using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mscom
{
	public partial class Base64Form : Form
	{
		public Base64Form()
		{
			InitializeComponent();
		}

		private void exchangeButton_Click(object sender, EventArgs e)
		{
			string tmp = sourceTextBox.Text;
			sourceTextBox.Text = targetTextBox.Text;
			targetTextBox.Text = tmp;
		}

		private void convertButton_Click(object sender, EventArgs e)
		{
			string text = sourceTextBox.Text;
			if (!string.IsNullOrEmpty(text))
			{
				if (toBase64RadioButton.Checked)
				{
					if (hexCheckBox.Checked)
					{
						byte[] bytes = HexString.ConvertHexStringToBytes(text);
						targetTextBox.Text = Convert.ToBase64String(bytes);
					}
					else
					{
						// convert utf8 to base64
						byte[] bytes = Encoding.UTF8.GetBytes(text);
						targetTextBox.Text = Convert.ToBase64String(bytes);
					}
				}
				else
				{
					try
					{
						byte[] bytes = Convert.FromBase64String(text);
						if (hexCheckBox.Checked)
						{
							targetTextBox.Text = BitConverter.ToString(bytes).Replace('-', ' ');
						}
						else
						{
							targetTextBox.Text = Encoding.UTF8.GetString(bytes);
						}
					}
					catch (FormatException ex)
					{
						Console.Error.WriteLine($"The source string is not in Base64 Format: {ex}");
						MessageBox.Show("The source string is not in Base64 Format", "Error in Converting", MessageBoxButtons.OK, MessageBoxIcon.Error);
						targetTextBox.Text = "";
					}
				}
			}
		}
	}
}
