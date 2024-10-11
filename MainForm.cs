using System;
using System.Data;
using System.IO.Ports;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace mscom
{
    public partial class MainForm : Form
    {
        private SerialPortLister _serialListener = new SerialPortLister();
        private Thread _receiveThread;
        private bool _continueReceiving;
        private ulong _receive_count;
        private ulong _sent_count;
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // initialize menr
            MenuInitialize();
            // initialize port list
            PortListInitialize();

            // initialize baud rate list
            EnumValuesInitialize(baudRateComboBox, typeof(BaudRate));
            baudRateComboBox.SelectedIndex = 8; 

            // initialize data bits list
            EnumValuesInitialize(dataBitsComboBox, typeof(DataBits), 1);

            // initialize parity list
            EnumNamesInitialize(parityComboBox, typeof(Parity));

            // initiaize stop bits list
            EnumNamesInitialize(stopBitsComboBox, typeof(StopBits));

            // initiaize stop bits list
            EnumNamesInitialize(handshakeComboBox, typeof(Handshake));

            //portPictureBox.Image = Image.FromFile(@"asserts\unplug.svg");
            string basePath = System.IO.Path.GetDirectoryName(Assembly.GetExecutingAssembly().GetName().CodeBase);
            Console.WriteLine(basePath);
        }

        private void MenuInitialize()
        {
            this.Menu = new MainMenu();
            MenuItem item = new MenuItem("File");
            this.Menu.MenuItems.Add(item);
            //item.MenuItems.Add("Save", new EventHandler(Save_Click));
            //item.MenuItems.Add("Open", new EventHandler(Open_Click));
            item = new MenuItem("Edit");
            this.Menu.MenuItems.Add(item);
            //item.MenuItems.Add("Copy", new EventHandler(Copy_Click));
            //item.MenuItems.Add("Paste", new EventHandler(Paste_Click));
        }

        private void PortListInitialize()
        {
            string[] ports = _serialListener.ListAvailablePorts();
            portComboBox.Items.Clear(); // clear previous ports
            if (ports.Length > 0)
            {
                foreach (string port in ports)
                {
                    portComboBox.Items.Add(port);
                }
                portComboBox.SelectedIndex = 0; // Select the first available port by default
            }
            else
            {
                MessageBox.Show("No serial ports found.");
            }
        }

        private void EnumValuesInitialize(ComboBox box, Type enumType, int order_by = 0)
        {
            box.Items.Clear();
            if (order_by == 0)
            {
                box.DataSource = Enum.GetValues(enumType).Cast<object>()
                                 .Select(b => ((int)b).ToString())  // Get the integer values as strings
                                 .ToList(); ;
            }
            else
            {

                box.DataSource = Enum.GetValues(enumType).Cast<object>()
                                 .Select(b => ((int)b).ToString())  // Get the integer values as strings
                                 .OrderByDescending(x => x)
                                 .ToList();
            }
        }

        private void EnumNamesInitialize(ComboBox box, Type enumType)
        {
            box.Items.Clear();
            box.DataSource = Enum.GetValues(enumType); // Get the integer values as strings
        }

        private void portButton_Click(object sender, EventArgs e)
        {
            if (!_serialListener.IsOpen())
            {
                int baud_rate = Int32.Parse(baudRateComboBox.SelectedValue.ToString());
                //BaudRate br = (BaudRate)Enum.Parse(typeof(BaudRate), baudRateComboBox.SelectedValue.ToString());
                int result = _serialListener.OpenSelectedPort(portComboBox.SelectedItem.ToString(),
                                                  baud_rate,
                                                  (Parity)Enum.Parse(typeof(Parity), parityComboBox.SelectedValue.ToString()),
                                                  (DataBits)Enum.Parse(typeof(DataBits), dataBitsComboBox.SelectedValue.ToString()),
                                                  (StopBits)Enum.Parse(typeof(StopBits), stopBitsComboBox.SelectedValue.ToString()),
                                                  (Handshake)Enum.Parse(typeof(Handshake), handshakeComboBox.SelectedValue.ToString())
                                                  );

                if (result == 0 && _serialListener.IsOpen())
                {
                    portPictureBox.Image = Properties.Resources.circle_green;
                    portButton.Text = "Close";
                    portStatusLabel.Text = $"{portComboBox.SelectedItem.ToString()} OPENED";
                    portStatuspictureBox.Image = Properties.Resources.circle_green;

                    _continueReceiving = true;
                    _receive_count = 0;
                    _sent_count = 0;
                    _receiveThread = new Thread(ReceivingData);
                    _receiveThread.IsBackground = true; // Make sure the thread terminates when the app closes
                    _receiveThread.Start();
                } else
                {
                    MessageBox.Show($"Cannot open {portComboBox.SelectedItem.ToString()}", "Error in Opening COM", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                _serialListener.ClosePort();
                portPictureBox.Image = Properties.Resources.circle_red;
                portButton.Text = "Open";
                portStatusLabel.Text = $"{portComboBox.SelectedItem.ToString()} CLOSED";
                portStatuspictureBox.Image = Properties.Resources.circle_red;
                _continueReceiving = false;
                _receiveThread?.Join();  // Ensure the thread finishes properly
            }
        }

        private void ReceivingData()
        {
            DataFormat format;
            while (_continueReceiving)
            {
                try
                {
                    if (_serialListener.IsOpen())
                    {
                        if (showHexCheckbox.Checked)
                            format = DataFormat.HEX;
                        else
                            format = DataFormat.ASCII;
                        // Read data from the serial port
                        string data = _serialListener.ReceiveData(format, base64CheckBox.Checked);
                        //Console.WriteLine($"Received data: {data}");
                        displayData(data);
                    }
                }
                catch (TimeoutException)
                {
                    // Handle the timeout exception if you want, or just ignore it
                }

                Thread.Sleep(500); // TODO
            }
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            int rc;
            string message = SendTextBox.Text.Trim();
            string suffix;
            if (suffixComboBox.SelectedItem != null) {
                suffix = suffixComboBox.SelectedItem.ToString().Replace(@"\r", "\r").Replace(@"\n", "\n");
            } else
            {
                suffix = "";
            }

            byte[] data;

            if (sendHexCheckBox.Checked)
            {
                message = message + " " + HexString.ConvertStringToHexString(suffix);
                data = HexString.ConvertHexStringToBytes(message);
            }
            else
            {
                message = message + suffix;
                data = Encoding.ASCII.GetBytes(message);
            }

            rc = _serialListener.SendData(data);
            if (rc > 0)
            {
                _sent_count += (ulong)rc;
                sentTextBox.Text = $"{_sent_count}";
                if (displaySentCheckBox.Checked)
                {
                    if (showHexCheckbox.Checked)
                        displayData(HexString.ConvertBytesToHexString(data));
                    else
                        displayData(message);
                }
            }
        }

        private void displayData(string data)
        {
            if (!string.IsNullOrEmpty(data))
            {
                // Invoke the UI thread to update the TextBox
                displayTextBox.Invoke(new Action(() =>
                {
                    if (timeStampCheckBox.Checked)
                        displayTextBox.AppendText($"[{DateTime.Now.ToString("HH:mm:ss.fff", System.Globalization.DateTimeFormatInfo.InvariantInfo)}] ");
                    displayTextBox.AppendText(data.TrimEnd('\r', '\n'));
                    displayTextBox.AppendText("\r\n");
                    _receive_count += (ulong)data.Length;
                    receiveTextBox.Text = $"{_receive_count}";

                    if (displayTextBox.Lines.Count() > 1000) // TODO need to config by user
                    {
                        string[] lines = displayTextBox.Lines;
                        displayTextBox.Lines = lines.Skip(lines.Length - 1000).ToArray();
                        displayTextBox.Select(displayTextBox.Text.Length, 0);
                        displayTextBox.ScrollToCaret();
                    }
                }));
            }
        }

        private void clearDisplayButton_Click(object sender, EventArgs e)
        {
            displayTextBox.Clear();
        }
    }
}

