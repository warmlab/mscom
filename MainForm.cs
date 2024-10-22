using System;
using System.Data;
using System.IO;
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
		private Thread _sendThread;
		private bool _continueReceiving;
		private ulong _receiveByteCount;
		private ulong _sentByteCount;
		private string _suffix;
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
			MenuItem item = new MenuItem("&Port");
			this.Menu.MenuItems.Add(item);
			item.MenuItems.Add("Reload", new EventHandler(PortListReload));
			item.MenuItems.Add("E&xit", new EventHandler(ExitProgram));
			item = new MenuItem("&Tools");
			this.Menu.MenuItems.Add(item);
			item.MenuItems.Add("H&EX Converter", new EventHandler(OpenHexForm));
			item.MenuItems.Add("&Base64 Converter", new EventHandler(OpenBase64Form));
			item = new MenuItem("&About");
			this.Menu.MenuItems.Add(item);
			item.MenuItems.Add("About", new EventHandler(OpenAboutForm));
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
					_receiveByteCount = 0;
					_sentByteCount = 0;

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

				//Thread.Sleep(500); // TODO
			}
		}

		private void sendButton_Click(object sender, EventArgs e)
		{
			//string suffix;
			if (suffixComboBox.SelectedItem != null) {
				_suffix = suffixComboBox.SelectedItem.ToString().Replace(@"\r", "\r").Replace(@"\n", "\n");
			} else
			{
				_suffix = "";
			}
			_sendThread = new Thread(SendingData);
			_sendThread.IsBackground = true;
			_sendThread.Start();
		}

		private void SendingData() {
			int loopCount = -1;
			int interval = 1000;

			if (!string.IsNullOrEmpty(intervalTextBox.Text))
			{
				if (!Int32.TryParse(intervalTextBox.Text, out interval))
					interval = 1000;
				if (interval < 0) interval = 1000;
			}

			if (!string.IsNullOrEmpty(countTextBox.Text))
			{
				if (!Int32.TryParse(countTextBox.Text, out loopCount))
					loopCount = -1;
			}


			Console.WriteLine($"interval: {interval}, count; {loopCount}");

			if (loopCheckBox.Checked)
			{
				// start a new thread to send data
			}
			int sendCount = 0;
			do
			{
				string message = sendTextBox.Text;
				if (sendData(message, _suffix) < 0) break;
				else Thread.Sleep(interval);
				// send the content of the sendTextBox
				if (!string.IsNullOrEmpty(fileTextBox.Text))
				{
					try
					{
						FileStream fs = File.Open(fileTextBox.Text, FileMode.Open);
						using (StreamReader sr = new StreamReader(fs))
						{
							while (!string.IsNullOrEmpty(message = sr.ReadLine()))
							{
								if (sendData(message, _suffix) < 0)
								{
									loopCount = 0;
									break;
								}
								Thread.Sleep(interval);
							}
						}
					}
					catch (Exception ex)
					{
						Console.Error.WriteLine($"Error in File $[{fileTextBox.Text}], ${ex}");
					}
				}

				sendCount++;
				Thread.Sleep(interval);
			} while (loopCheckBox.Checked && (loopCount < 0 || sendCount < loopCount));
		}

		private int sendData(string message, string suffix) {
			int rc;

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
				_sentByteCount += (ulong)rc;
				Control.CheckForIllegalCrossThreadCalls = false; // TODO
				sentTextBox.Text = $"{_sentByteCount}";
				if (displaySentCheckBox.Checked)
				{
					if (showHexCheckbox.Checked)
						displayData(HexString.ConvertBytesToHexString(data));
					else
						displayData(message);
				}
			}
			else if (rc == -1)
			{
				//Console.WriteLine("Serial Port wasn't Opened");
				MessageBox.Show("Serial Port wasn't Opened", "Error in Sending Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			return rc;
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
					_receiveByteCount += (ulong)data.Length;
					receiveTextBox.Text = $"{_receiveByteCount}";

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

		private void saveButton_Click(object sender, EventArgs e)
		{
			// open a save file dialog
			SaveFileDialog sfd = new SaveFileDialog();
			//sfd.Filter = "Text File|*.txt";
			sfd.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
			sfd.FilterIndex = 1;
			sfd.Title = "Save Output As a File";
			sfd.FileName = "mscom_output";
			sfd.RestoreDirectory = true;
			if (sfd.ShowDialog() == DialogResult.OK)
			{
				fileTextBox.Text = sfd.FileName;
			}

			if (!string.IsNullOrEmpty(sfd.FileName))
			{
				// Saves the Image via a FileStream created by the OpenFile method.
				FileStream fs = (FileStream)sfd.OpenFile();
				using (StreamWriter sw = new StreamWriter(fs))
				{
					foreach (string line in displayTextBox.Lines)
					{
						sw.WriteLine(line);
					}
				}

				fs.Close();
			}
		}

		private void fileButton_Click(object sender, EventArgs e)
		{
			OpenFileDialog ofd = new OpenFileDialog();
			ofd.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
			ofd.FilterIndex = 2;
			ofd.Title = "Select A file to Send";
			ofd.RestoreDirectory = true;
			if (ofd.ShowDialog() == DialogResult.OK && !string.IsNullOrEmpty(ofd.FileName))
			{
				fileTextBox.Text = ofd.FileName;
			}
		}

		private void statusResetButton_Click(object sender, EventArgs e)
		{
			sentTextBox.Text = "0";
			receiveTextBox.Text = "0";
		}

		private void OpenHexForm(object sender, EventArgs e)
		{
			HexForm form = new HexForm();
			form.ShowDialog();
		}

		private void OpenBase64Form(object sender, EventArgs e)
		{
			Base64Form form = new Base64Form();
			form.ShowDialog();
		}

		private void OpenAboutForm(object sender, EventArgs e)
		{
			AboutMeForm form = new AboutMeForm();
			form.ShowDialog();
		}

		private void PortListReload(object sender, EventArgs e)
		{
			if (_serialListener.IsOpen())
			{
				MessageBox.Show($"Please Close the Opening serial port FIRST!!", "Need to Close Port", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}

			PortListInitialize();
		}

		private void ExitProgram(object sender, EventArgs e)
		{
			_continueReceiving = false;
			loopCheckBox.Checked = false;
			if (_receiveThread != null)
				_receiveThread.Join();
			if (_sendThread != null)
				_sendThread.Join();

			this.Close();
		}
	}
}

