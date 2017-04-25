namespace Currency_Converter_GUI {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.MyCurrencyBox = new System.Windows.Forms.ComboBox();
            this.ConvertCurrencyBox = new System.Windows.Forms.ComboBox();
            this.MyCurrencyLabel = new System.Windows.Forms.Label();
            this.ConvertCurrencyLabel = new System.Windows.Forms.Label();
            this.MyAmountText = new System.Windows.Forms.TextBox();
            this.ConvertAmountText = new System.Windows.Forms.TextBox();
            this.MyAmountLabel = new System.Windows.Forms.Label();
            this.ConvertAmountLabel = new System.Windows.Forms.Label();
            this.EqualsButton = new System.Windows.Forms.Button();
            this.RepeatConversionGroup = new System.Windows.Forms.GroupBox();
            this.NoButton = new System.Windows.Forms.RadioButton();
            this.YesButton = new System.Windows.Forms.RadioButton();
            this.MyAmountCode = new System.Windows.Forms.Label();
            this.ConvertAmountCode = new System.Windows.Forms.Label();
            this.RepeatConversionGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // MyCurrencyBox
            // 
            this.MyCurrencyBox.FormattingEnabled = true;
            this.MyCurrencyBox.Location = new System.Drawing.Point(45, 91);
            this.MyCurrencyBox.Name = "MyCurrencyBox";
            this.MyCurrencyBox.Size = new System.Drawing.Size(244, 33);
            this.MyCurrencyBox.TabIndex = 0;
            this.MyCurrencyBox.SelectedIndexChanged += new System.EventHandler(this.MyCurrencyBox_SelectedIndexChanged);
            // 
            // ConvertCurrencyBox
            // 
            this.ConvertCurrencyBox.FormattingEnabled = true;
            this.ConvertCurrencyBox.Location = new System.Drawing.Point(578, 91);
            this.ConvertCurrencyBox.Name = "ConvertCurrencyBox";
            this.ConvertCurrencyBox.Size = new System.Drawing.Size(244, 33);
            this.ConvertCurrencyBox.TabIndex = 1;
            this.ConvertCurrencyBox.SelectedIndexChanged += new System.EventHandler(this.ConvertCurrencyBox_SelectedIndexChanged);
            // 
            // MyCurrencyLabel
            // 
            this.MyCurrencyLabel.AutoSize = true;
            this.MyCurrencyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MyCurrencyLabel.Location = new System.Drawing.Point(45, 60);
            this.MyCurrencyLabel.Name = "MyCurrencyLabel";
            this.MyCurrencyLabel.Size = new System.Drawing.Size(178, 25);
            this.MyCurrencyLabel.TabIndex = 2;
            this.MyCurrencyLabel.Text = "Currency I have";
            // 
            // ConvertCurrencyLabel
            // 
            this.ConvertCurrencyLabel.AutoSize = true;
            this.ConvertCurrencyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConvertCurrencyLabel.Location = new System.Drawing.Point(578, 60);
            this.ConvertCurrencyLabel.Name = "ConvertCurrencyLabel";
            this.ConvertCurrencyLabel.Size = new System.Drawing.Size(176, 25);
            this.ConvertCurrencyLabel.TabIndex = 3;
            this.ConvertCurrencyLabel.Text = "Currency I want";
            // 
            // MyAmountText
            // 
            this.MyAmountText.Location = new System.Drawing.Point(88, 307);
            this.MyAmountText.Name = "MyAmountText";
            this.MyAmountText.Size = new System.Drawing.Size(178, 31);
            this.MyAmountText.TabIndex = 4;
            this.MyAmountText.TextChanged += new System.EventHandler(this.MyAmountText_TextChanged);
            // 
            // ConvertAmountText
            // 
            this.ConvertAmountText.Location = new System.Drawing.Point(619, 307);
            this.ConvertAmountText.Name = "ConvertAmountText";
            this.ConvertAmountText.Size = new System.Drawing.Size(178, 31);
            this.ConvertAmountText.TabIndex = 5;
            // 
            // MyAmountLabel
            // 
            this.MyAmountLabel.AutoSize = true;
            this.MyAmountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MyAmountLabel.Location = new System.Drawing.Point(85, 279);
            this.MyAmountLabel.Name = "MyAmountLabel";
            this.MyAmountLabel.Size = new System.Drawing.Size(162, 25);
            this.MyAmountLabel.TabIndex = 6;
            this.MyAmountLabel.Text = "Amount I have";
            // 
            // ConvertAmountLabel
            // 
            this.ConvertAmountLabel.AutoSize = true;
            this.ConvertAmountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConvertAmountLabel.Location = new System.Drawing.Point(616, 278);
            this.ConvertAmountLabel.Name = "ConvertAmountLabel";
            this.ConvertAmountLabel.Size = new System.Drawing.Size(160, 25);
            this.ConvertAmountLabel.TabIndex = 7;
            this.ConvertAmountLabel.Text = "Amount I want";
            // 
            // EqualsButton
            // 
            this.EqualsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EqualsButton.Location = new System.Drawing.Point(335, 282);
            this.EqualsButton.Name = "EqualsButton";
            this.EqualsButton.Size = new System.Drawing.Size(169, 85);
            this.EqualsButton.TabIndex = 8;
            this.EqualsButton.Text = "Equals";
            this.EqualsButton.UseVisualStyleBackColor = true;
            this.EqualsButton.Click += new System.EventHandler(this.EqualsButton_Click);
            // 
            // RepeatConversionGroup
            // 
            this.RepeatConversionGroup.Controls.Add(this.NoButton);
            this.RepeatConversionGroup.Controls.Add(this.YesButton);
            this.RepeatConversionGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RepeatConversionGroup.Location = new System.Drawing.Point(282, 433);
            this.RepeatConversionGroup.Name = "RepeatConversionGroup";
            this.RepeatConversionGroup.Size = new System.Drawing.Size(283, 161);
            this.RepeatConversionGroup.TabIndex = 9;
            this.RepeatConversionGroup.TabStop = false;
            this.RepeatConversionGroup.Text = "Another Conversion?";
            // 
            // NoButton
            // 
            this.NoButton.AutoSize = true;
            this.NoButton.Location = new System.Drawing.Point(20, 102);
            this.NoButton.Name = "NoButton";
            this.NoButton.Size = new System.Drawing.Size(72, 29);
            this.NoButton.TabIndex = 1;
            this.NoButton.TabStop = true;
            this.NoButton.Text = "No";
            this.NoButton.UseVisualStyleBackColor = true;
            this.NoButton.CheckedChanged += new System.EventHandler(this.RepeatConversion_CheckedChanged);
            // 
            // YesButton
            // 
            this.YesButton.AutoSize = true;
            this.YesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YesButton.Location = new System.Drawing.Point(20, 52);
            this.YesButton.Name = "YesButton";
            this.YesButton.Size = new System.Drawing.Size(84, 29);
            this.YesButton.TabIndex = 0;
            this.YesButton.TabStop = true;
            this.YesButton.Text = "Yes";
            this.YesButton.UseVisualStyleBackColor = true;
            this.YesButton.CheckedChanged += new System.EventHandler(this.RepeatConversion_CheckedChanged);
            // 
            // MyAmountCode
            // 
            this.MyAmountCode.AutoSize = true;
            this.MyAmountCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MyAmountCode.Location = new System.Drawing.Point(20, 313);
            this.MyAmountCode.Name = "MyAmountCode";
            this.MyAmountCode.Size = new System.Drawing.Size(59, 25);
            this.MyAmountCode.TabIndex = 10;
            this.MyAmountCode.Text = "AUD";
            // 
            // ConvertAmountCode
            // 
            this.ConvertAmountCode.AutoSize = true;
            this.ConvertAmountCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConvertAmountCode.Location = new System.Drawing.Point(551, 312);
            this.ConvertAmountCode.Name = "ConvertAmountCode";
            this.ConvertAmountCode.Size = new System.Drawing.Size(59, 25);
            this.ConvertAmountCode.TabIndex = 11;
            this.ConvertAmountCode.Text = "AUD";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 638);
            this.Controls.Add(this.ConvertAmountCode);
            this.Controls.Add(this.MyAmountCode);
            this.Controls.Add(this.RepeatConversionGroup);
            this.Controls.Add(this.EqualsButton);
            this.Controls.Add(this.ConvertAmountLabel);
            this.Controls.Add(this.MyAmountLabel);
            this.Controls.Add(this.ConvertAmountText);
            this.Controls.Add(this.MyAmountText);
            this.Controls.Add(this.ConvertCurrencyLabel);
            this.Controls.Add(this.MyCurrencyLabel);
            this.Controls.Add(this.ConvertCurrencyBox);
            this.Controls.Add(this.MyCurrencyBox);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Currency Converter";
            this.RepeatConversionGroup.ResumeLayout(false);
            this.RepeatConversionGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox MyCurrencyBox;
        private System.Windows.Forms.ComboBox ConvertCurrencyBox;
        private System.Windows.Forms.Label MyCurrencyLabel;
        private System.Windows.Forms.Label ConvertCurrencyLabel;
        private System.Windows.Forms.TextBox MyAmountText;
        private System.Windows.Forms.TextBox ConvertAmountText;
        private System.Windows.Forms.Label MyAmountLabel;
        private System.Windows.Forms.Label ConvertAmountLabel;
        private System.Windows.Forms.Button EqualsButton;
        private System.Windows.Forms.GroupBox RepeatConversionGroup;
        private System.Windows.Forms.RadioButton NoButton;
        private System.Windows.Forms.RadioButton YesButton;
        private System.Windows.Forms.Label MyAmountCode;
        private System.Windows.Forms.Label ConvertAmountCode;
    }
}

