namespace mscom
{
	partial class HexForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HexForm));
            this.sourceTextBox = new System.Windows.Forms.TextBox();
            this.targetTextBox = new System.Windows.Forms.TextBox();
            this.convertButton = new System.Windows.Forms.Button();
            this.ToHexRadioButton = new System.Windows.Forms.RadioButton();
            this.fromHexRadioButton = new System.Windows.Forms.RadioButton();
            this.exchangeButton = new System.Windows.Forms.Button();
            this.radioGroupPanel = new System.Windows.Forms.Panel();
            this.radioGroupPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // sourceTextBox
            // 
            this.sourceTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sourceTextBox.Font = new System.Drawing.Font("Consolas", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sourceTextBox.Location = new System.Drawing.Point(12, 67);
            this.sourceTextBox.Multiline = true;
            this.sourceTextBox.Name = "sourceTextBox";
            this.sourceTextBox.Size = new System.Drawing.Size(1154, 324);
            this.sourceTextBox.TabIndex = 0;
            // 
            // targetTextBox
            // 
            this.targetTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.targetTextBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.targetTextBox.Font = new System.Drawing.Font("Consolas", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.targetTextBox.Location = new System.Drawing.Point(12, 408);
            this.targetTextBox.Multiline = true;
            this.targetTextBox.Name = "targetTextBox";
            this.targetTextBox.ReadOnly = true;
            this.targetTextBox.Size = new System.Drawing.Size(1154, 324);
            this.targetTextBox.TabIndex = 3;
            // 
            // convertButton
            // 
            this.convertButton.Location = new System.Drawing.Point(999, 12);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(167, 42);
            this.convertButton.TabIndex = 4;
            this.convertButton.Text = "Convert";
            this.convertButton.UseVisualStyleBackColor = true;
            this.convertButton.Click += new System.EventHandler(this.convertButton_Click);
            // 
            // ToHexRadioButton
            // 
            this.ToHexRadioButton.AutoSize = true;
            this.ToHexRadioButton.Checked = true;
            this.ToHexRadioButton.Location = new System.Drawing.Point(3, 10);
            this.ToHexRadioButton.Name = "ToHexRadioButton";
            this.ToHexRadioButton.Size = new System.Drawing.Size(87, 22);
            this.ToHexRadioButton.TabIndex = 5;
            this.ToHexRadioButton.TabStop = true;
            this.ToHexRadioButton.Text = "To Hex";
            this.ToHexRadioButton.UseVisualStyleBackColor = true;
            // 
            // fromHexRadioButton
            // 
            this.fromHexRadioButton.AutoSize = true;
            this.fromHexRadioButton.Location = new System.Drawing.Point(127, 10);
            this.fromHexRadioButton.Name = "fromHexRadioButton";
            this.fromHexRadioButton.Size = new System.Drawing.Size(105, 22);
            this.fromHexRadioButton.TabIndex = 6;
            this.fromHexRadioButton.Text = "From Hex";
            this.fromHexRadioButton.UseVisualStyleBackColor = true;
            // 
            // exchangeButton
            // 
            this.exchangeButton.Location = new System.Drawing.Point(826, 12);
            this.exchangeButton.Name = "exchangeButton";
            this.exchangeButton.Size = new System.Drawing.Size(167, 42);
            this.exchangeButton.TabIndex = 7;
            this.exchangeButton.Text = "Switch";
            this.exchangeButton.UseVisualStyleBackColor = true;
            this.exchangeButton.Click += new System.EventHandler(this.exchangeButton_Click);
            // 
            // radioGroupPanel
            // 
            this.radioGroupPanel.Controls.Add(this.fromHexRadioButton);
            this.radioGroupPanel.Controls.Add(this.ToHexRadioButton);
            this.radioGroupPanel.Location = new System.Drawing.Point(522, 12);
            this.radioGroupPanel.Name = "radioGroupPanel";
            this.radioGroupPanel.Size = new System.Drawing.Size(284, 42);
            this.radioGroupPanel.TabIndex = 9;
            // 
            // HexForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 744);
            this.Controls.Add(this.radioGroupPanel);
            this.Controls.Add(this.exchangeButton);
            this.Controls.Add(this.convertButton);
            this.Controls.Add(this.targetTextBox);
            this.Controls.Add(this.sourceTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HexForm";
            this.Text = "Hexadecimal Tool";
            this.radioGroupPanel.ResumeLayout(false);
            this.radioGroupPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox sourceTextBox;
		private System.Windows.Forms.TextBox targetTextBox;
		private System.Windows.Forms.Button convertButton;
		private System.Windows.Forms.RadioButton ToHexRadioButton;
		private System.Windows.Forms.RadioButton fromHexRadioButton;
		private System.Windows.Forms.Button exchangeButton;
		private System.Windows.Forms.Panel radioGroupPanel;
	}
}
