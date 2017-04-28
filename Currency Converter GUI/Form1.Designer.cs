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
            this.myCurrencyBox = new System.Windows.Forms.ComboBox();
            this.convertCurrencyBox = new System.Windows.Forms.ComboBox();
            this.myCurrencyLabel = new System.Windows.Forms.Label();
            this.convertCurrencyLabel = new System.Windows.Forms.Label();
            this.myAmountText = new System.Windows.Forms.TextBox();
            this.convertAmountText = new System.Windows.Forms.TextBox();
            this.myAmountLabel = new System.Windows.Forms.Label();
            this.convertAmountLabel = new System.Windows.Forms.Label();
            this.equalsButton = new System.Windows.Forms.Button();
            this.repeatConversionGroup = new System.Windows.Forms.GroupBox();
            this.noButton = new System.Windows.Forms.RadioButton();
            this.yesButton = new System.Windows.Forms.RadioButton();
            this.myAmountCode = new System.Windows.Forms.Label();
            this.convertAmountCode = new System.Windows.Forms.Label();
            this.repeatConversionGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // myCurrencyBox
            // 
            this.myCurrencyBox.FormattingEnabled = true;
            this.myCurrencyBox.Location = new System.Drawing.Point(45, 91);
            this.myCurrencyBox.Name = "myCurrencyBox";
            this.myCurrencyBox.Size = new System.Drawing.Size(244, 33);
            this.myCurrencyBox.TabIndex = 0;
            this.myCurrencyBox.SelectedIndexChanged += new System.EventHandler(this.myCurrencyBox_SelectedIndexChanged);
            // 
            // convertCurrencyBox
            // 
            this.convertCurrencyBox.FormattingEnabled = true;
            this.convertCurrencyBox.Location = new System.Drawing.Point(578, 91);
            this.convertCurrencyBox.Name = "convertCurrencyBox";
            this.convertCurrencyBox.Size = new System.Drawing.Size(244, 33);
            this.convertCurrencyBox.TabIndex = 1;
            this.convertCurrencyBox.SelectedIndexChanged += new System.EventHandler(this.convertCurrencyBox_SelectedIndexChanged);
            // 
            // myCurrencyLabel
            // 
            this.myCurrencyLabel.AutoSize = true;
            this.myCurrencyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myCurrencyLabel.Location = new System.Drawing.Point(45, 60);
            this.myCurrencyLabel.Name = "myCurrencyLabel";
            this.myCurrencyLabel.Size = new System.Drawing.Size(178, 25);
            this.myCurrencyLabel.TabIndex = 2;
            this.myCurrencyLabel.Text = "Currency I have";
            // 
            // convertCurrencyLabel
            // 
            this.convertCurrencyLabel.AutoSize = true;
            this.convertCurrencyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.convertCurrencyLabel.Location = new System.Drawing.Point(578, 60);
            this.convertCurrencyLabel.Name = "convertCurrencyLabel";
            this.convertCurrencyLabel.Size = new System.Drawing.Size(176, 25);
            this.convertCurrencyLabel.TabIndex = 3;
            this.convertCurrencyLabel.Text = "Currency I want";
            // 
            // myAmountText
            // 
            this.myAmountText.Location = new System.Drawing.Point(88, 307);
            this.myAmountText.Name = "myAmountText";
            this.myAmountText.Size = new System.Drawing.Size(178, 31);
            this.myAmountText.TabIndex = 4;
            this.myAmountText.TextChanged += new System.EventHandler(this.myAmountText_TextChanged);
            // 
            // convertAmountText
            // 
            this.convertAmountText.Location = new System.Drawing.Point(619, 307);
            this.convertAmountText.Name = "convertAmountText";
            this.convertAmountText.Size = new System.Drawing.Size(178, 31);
            this.convertAmountText.TabIndex = 5;
            // 
            // myAmountLabel
            // 
            this.myAmountLabel.AutoSize = true;
            this.myAmountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myAmountLabel.Location = new System.Drawing.Point(85, 279);
            this.myAmountLabel.Name = "myAmountLabel";
            this.myAmountLabel.Size = new System.Drawing.Size(162, 25);
            this.myAmountLabel.TabIndex = 6;
            this.myAmountLabel.Text = "Amount I have";
            // 
            // convertAmountLabel
            // 
            this.convertAmountLabel.AutoSize = true;
            this.convertAmountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.convertAmountLabel.Location = new System.Drawing.Point(616, 278);
            this.convertAmountLabel.Name = "convertAmountLabel";
            this.convertAmountLabel.Size = new System.Drawing.Size(160, 25);
            this.convertAmountLabel.TabIndex = 7;
            this.convertAmountLabel.Text = "Amount I want";
            // 
            // equalsButton
            // 
            this.equalsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equalsButton.Location = new System.Drawing.Point(335, 282);
            this.equalsButton.Name = "equalsButton";
            this.equalsButton.Size = new System.Drawing.Size(169, 85);
            this.equalsButton.TabIndex = 8;
            this.equalsButton.Text = "Equals";
            this.equalsButton.UseVisualStyleBackColor = true;
            this.equalsButton.Click += new System.EventHandler(this.equalsButton_Click);
            // 
            // repeatConversionGroup
            // 
            this.repeatConversionGroup.Controls.Add(this.noButton);
            this.repeatConversionGroup.Controls.Add(this.yesButton);
            this.repeatConversionGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.repeatConversionGroup.Location = new System.Drawing.Point(282, 433);
            this.repeatConversionGroup.Name = "repeatConversionGroup";
            this.repeatConversionGroup.Size = new System.Drawing.Size(283, 161);
            this.repeatConversionGroup.TabIndex = 9;
            this.repeatConversionGroup.TabStop = false;
            this.repeatConversionGroup.Text = "Another Conversion?";
            // 
            // noButton
            // 
            this.noButton.AutoSize = true;
            this.noButton.Location = new System.Drawing.Point(20, 102);
            this.noButton.Name = "noButton";
            this.noButton.Size = new System.Drawing.Size(72, 29);
            this.noButton.TabIndex = 1;
            this.noButton.TabStop = true;
            this.noButton.Text = "No";
            this.noButton.UseVisualStyleBackColor = true;
            this.noButton.CheckedChanged += new System.EventHandler(this.repeatConversion_CheckedChanged);
            // 
            // yesButton
            // 
            this.yesButton.AutoSize = true;
            this.yesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yesButton.Location = new System.Drawing.Point(20, 52);
            this.yesButton.Name = "yesButton";
            this.yesButton.Size = new System.Drawing.Size(84, 29);
            this.yesButton.TabIndex = 0;
            this.yesButton.TabStop = true;
            this.yesButton.Text = "Yes";
            this.yesButton.UseVisualStyleBackColor = true;
            this.yesButton.CheckedChanged += new System.EventHandler(this.repeatConversion_CheckedChanged);
            // 
            // myAmountCode
            // 
            this.myAmountCode.AutoSize = true;
            this.myAmountCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myAmountCode.Location = new System.Drawing.Point(20, 313);
            this.myAmountCode.Name = "myAmountCode";
            this.myAmountCode.Size = new System.Drawing.Size(59, 25);
            this.myAmountCode.TabIndex = 10;
            this.myAmountCode.Text = "AUD";
            // 
            // convertAmountCode
            // 
            this.convertAmountCode.AutoSize = true;
            this.convertAmountCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.convertAmountCode.Location = new System.Drawing.Point(551, 312);
            this.convertAmountCode.Name = "convertAmountCode";
            this.convertAmountCode.Size = new System.Drawing.Size(59, 25);
            this.convertAmountCode.TabIndex = 11;
            this.convertAmountCode.Text = "AUD";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 638);
            this.Controls.Add(this.convertAmountCode);
            this.Controls.Add(this.myAmountCode);
            this.Controls.Add(this.repeatConversionGroup);
            this.Controls.Add(this.equalsButton);
            this.Controls.Add(this.convertAmountLabel);
            this.Controls.Add(this.myAmountLabel);
            this.Controls.Add(this.convertAmountText);
            this.Controls.Add(this.myAmountText);
            this.Controls.Add(this.convertCurrencyLabel);
            this.Controls.Add(this.myCurrencyLabel);
            this.Controls.Add(this.convertCurrencyBox);
            this.Controls.Add(this.myCurrencyBox);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Currency Converter";
            this.repeatConversionGroup.ResumeLayout(false);
            this.repeatConversionGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox myCurrencyBox;
        private System.Windows.Forms.ComboBox convertCurrencyBox;
        private System.Windows.Forms.Label myCurrencyLabel;
        private System.Windows.Forms.Label convertCurrencyLabel;
        private System.Windows.Forms.TextBox myAmountText;
        private System.Windows.Forms.TextBox convertAmountText;
        private System.Windows.Forms.Label myAmountLabel;
        private System.Windows.Forms.Label convertAmountLabel;
        private System.Windows.Forms.Button equalsButton;
        private System.Windows.Forms.GroupBox repeatConversionGroup;
        private System.Windows.Forms.RadioButton noButton;
        private System.Windows.Forms.RadioButton yesButton;
        private System.Windows.Forms.Label myAmountCode;
        private System.Windows.Forms.Label convertAmountCode;
    }
}

