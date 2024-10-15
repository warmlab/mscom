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
	public partial class HexForm : Form
	{
		public HexForm()
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
			if (ToHexRadioButton.Checked)
			{
				// convert ascii to hexadecimal code
				string text = HexString.ConvertStringToHexString(sourceTextBox.Text);
				targetTextBox.Text = text;
			}
			else
			{
				byte[] bytes = HexString.ConvertHexStringToBytes(sourceTextBox.Text);
				targetTextBox.Text = Encoding.UTF8.GetString(bytes);
			}
		}
	}
}
