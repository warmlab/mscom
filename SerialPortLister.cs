using System;
using System.Collections;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mscom
{
    public enum DataFormat
    {
        ASCII,
        HEX
    }

    public enum BaudRate
    {
        BaudRate1200 = 1200,
        BaudRate2400 = 2400,
        BaudRate4800 = 4800,
        BaudRate9600 = 9600,
        BaudRate14400 = 14400,
        BaudRate19200 = 19200,
        BaudRate38400 = 38400,
        BaudRate57600 = 57600,
        BaudRate115200 = 115200,
        BaudRate230400 = 230400,
        BaudRate460800 = 460800,
        BaudRate921600 = 921600
    }

    public enum DataBits
    {
        FiveBits = 5,
        SixBits = 6,
        SevenBits = 7,
        EightBits = 8
    }

    public class SerialPortLister
    {
        private SerialPort _serialPort;

        public SerialPortLister()
        {
            _serialPort = new SerialPort();
        }

        // Function to list all available serial ports
        public string[] ListAvailablePorts()
        {
            // Get a list of serial port names
            string[] ports = SerialPort.GetPortNames();

            if (ports.Length > 0)
            {
                Console.WriteLine("Available Serial Ports:");
                foreach (string port in ports)
                {
                    Console.WriteLine($"- {port}");
                }
            }
            else
            {
                Console.WriteLine("No serial ports found.");
            }

            return ports;
        }

        // Open the selected port
        public int OpenSelectedPort(string port_name, int baud_rate, Parity parity, DataBits data_bits, StopBits stop_bits, Handshake handshake)
        {
            _serialPort.PortName = port_name;
            _serialPort.BaudRate = baud_rate;  // You can adjust the baud rate
            _serialPort.Parity = parity;
            _serialPort.DataBits = (int)data_bits;
            _serialPort.StopBits = StopBits.One;
            _serialPort.Handshake = Handshake.None;

            try
            {
                _serialPort.Open();
                Console.WriteLine($"{_serialPort.PortName} opened successfully.");
                return 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error opening port: {ex.Message}");
                return -1;
            }
        }

        // Send data from the send TextBox
        public int SendData(byte[] data)
        {
            if (_serialPort.IsOpen)
            {
                try
                {
                    _serialPort.Write(data, 0, data.Length);
                    return data.Length;
                }
                catch (Exception ex)
                {
                    Console.Error.WriteLine($"Error sending data: {ex.Message}");
                    return -2;
                }
            }
            else
            {
                Console.Error.WriteLine("Serial port is not open.");
                return -1;
            }
        }

        public int SendString(string message, DataFormat format)
        {
            if (_serialPort.IsOpen)
            {
                try
                {
                    if (format == DataFormat.HEX)
                    {
                        byte[] msg = HexString.ConvertHexStringToBytes(message);
                        _serialPort.Write(msg, 0, msg.Length);
                        Console.WriteLine($"Sent: {message}");

                        return msg.Length;
                    }
                    else
                    {
                        _serialPort.Write(message);
                        Console.WriteLine($"Sent: {message}");

                        return message.Length;
                    }
                }
                catch (Exception ex)
                {
                    Console.Error.WriteLine($"Error sending data: {ex.Message}");
                    return -2;
                }
            }
            else
            {
                Console.Error.WriteLine("Serial port is not open.");
                return -1;
            }
        }

        // Data received handler
        public string ReceiveData(DataFormat format, bool base64Decode)
        {
            try
            {
                string inData = _serialPort.ReadLine();
                if (base64Decode)
                {
                    byte[] bytes;
                    try
                    {
                        bytes = Convert.FromBase64String(inData);
                    }
                    catch (Exception ex)
                    {
                        Console.Error.WriteLine($"Error in format base64 string: {ex}");
                        bytes = System.Text.Encoding.ASCII.GetBytes(inData);
                    }

                    if (format == DataFormat.HEX)
                    {
                        return HexString.ConvertBytesToHexString(bytes);
                    }
                    else
                    {
                        return System.Text.Encoding.UTF8.GetString(bytes);
                    }
                }
                // Update the receive TextBox on the UI thread
                //_receiveTextBox.Invoke(new MethodInvoker(delegate
                //{
                //    _receiveTextBox.AppendText($"Received: {inData}\n");
                //}));

                if (format == DataFormat.HEX)
                {
                    return HexString.ConvertStringToHexString(inData);
                }
                else
                {
                    return inData;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error receiving data: {ex.Message}");

                return "";
            }
        }

        // Close the serial port when done
        public void ClosePort()
        {
            if (_serialPort.IsOpen)
            {
                _serialPort.Close();
                Console.WriteLine("Serial port closed.");
            }
        }

        public bool IsOpen()
        {
            return _serialPort.IsOpen;
        }
    }
}

