namespace CalculatorApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            PlusButton = new Button();
            MinusButton = new Button();
            DivideButton = new Button();
            EqualButton = new Button();
            MultiplyButton = new Button();
            BackspaceButton = new Button();
            PowerButton = new Button();
            SquareRootButton = new Button();
            NegateSignButton = new Button();
            ZeroButton = new Button();
            OneButton = new Button();
            TwoButton = new Button();
            ThreeButton = new Button();
            FourButton = new Button();
            FiveButton = new Button();
            SixButton = new Button();
            SevenButton = new Button();
            EightButton = new Button();
            NineButton = new Button();
            DecimalDotButton = new Button();
            ClearButton = new Button();
            ResultTextBox = new TextBox();
            SuspendLayout();
            // 
            // PlusButton
            // 
            PlusButton.ForeColor = Color.FromArgb(52, 73, 94);
            PlusButton.Location = new Point(270, 250);
            PlusButton.Name = "PlusButton";
            PlusButton.Size = new Size(60, 50);
            PlusButton.TabIndex = 0;
            PlusButton.Text = "+";
            PlusButton.UseVisualStyleBackColor = true;
            PlusButton.Click += OnOperationClick;
            // 
            // MinusButton
            // 
            MinusButton.ForeColor = Color.FromArgb(52, 73, 94);
            MinusButton.Location = new Point(270, 198);
            MinusButton.Name = "MinusButton";
            MinusButton.Size = new Size(60, 50);
            MinusButton.TabIndex = 1;
            MinusButton.Text = "-";
            MinusButton.UseVisualStyleBackColor = true;
            MinusButton.Click += OnOperationClick;
            // 
            // DivideButton
            // 
            DivideButton.ForeColor = Color.FromArgb(52, 73, 94);
            DivideButton.Location = new Point(6, 198);
            DivideButton.Name = "DivideButton";
            DivideButton.Size = new Size(60, 50);
            DivideButton.TabIndex = 12;
            DivideButton.Text = "/";
            DivideButton.UseVisualStyleBackColor = true;
            DivideButton.Click += OnOperationClick;
            // 
            // EqualButton
            // 
            EqualButton.ForeColor = Color.FromArgb(231, 76, 60);
            EqualButton.Location = new Point(270, 306);
            EqualButton.Name = "EqualButton";
            EqualButton.Size = new Size(60, 50);
            EqualButton.TabIndex = 13;
            EqualButton.Text = "=";
            EqualButton.UseVisualStyleBackColor = true;
            EqualButton.Click += EqualButton_Click;
            // 
            // MultiplyButton
            // 
            MultiplyButton.ForeColor = Color.FromArgb(52, 73, 94);
            MultiplyButton.Location = new Point(270, 142);
            MultiplyButton.Name = "MultiplyButton";
            MultiplyButton.Size = new Size(60, 50);
            MultiplyButton.TabIndex = 14;
            MultiplyButton.Text = "x";
            MultiplyButton.UseVisualStyleBackColor = true;
            MultiplyButton.Click += OnOperationClick;
            // 
            // BackspaceButton
            // 
            BackspaceButton.ForeColor = Color.FromArgb(52, 73, 94);
            BackspaceButton.Location = new Point(204, 86);
            BackspaceButton.Name = "BackspaceButton";
            BackspaceButton.Size = new Size(126, 50);
            BackspaceButton.TabIndex = 15;
            BackspaceButton.Text = "⌫";
            BackspaceButton.UseVisualStyleBackColor = true;
            BackspaceButton.Click += BackspaceButton_Click;
            // 
            // PowerButton
            // 
            PowerButton.ForeColor = Color.FromArgb(52, 73, 94);
            PowerButton.Location = new Point(6, 306);
            PowerButton.Name = "PowerButton";
            PowerButton.Size = new Size(60, 50);
            PowerButton.TabIndex = 16;
            PowerButton.Text = "^";
            PowerButton.UseVisualStyleBackColor = true;
            PowerButton.Click += OnOperationClick;
            // 
            // SquareRootButton
            // 
            SquareRootButton.ForeColor = Color.FromArgb(52, 73, 94);
            SquareRootButton.Location = new Point(6, 250);
            SquareRootButton.Name = "SquareRootButton";
            SquareRootButton.Size = new Size(60, 50);
            SquareRootButton.TabIndex = 17;
            SquareRootButton.Text = "Sqrt";
            SquareRootButton.UseVisualStyleBackColor = true;
            SquareRootButton.Click += SquareRootButtonClick;
            // 
            // NegateSignButton
            // 
            NegateSignButton.ForeColor = Color.FromArgb(52, 73, 94);
            NegateSignButton.Location = new Point(72, 306);
            NegateSignButton.Name = "NegateSignButton";
            NegateSignButton.Size = new Size(60, 50);
            NegateSignButton.TabIndex = 18;
            NegateSignButton.Text = "+/-";
            NegateSignButton.UseVisualStyleBackColor = true;
            NegateSignButton.Click += NegateSignButton_Click;
            // 
            // ZeroButton
            // 
            ZeroButton.ForeColor = Color.FromArgb(52, 73, 94);
            ZeroButton.Location = new Point(138, 306);
            ZeroButton.Name = "ZeroButton";
            ZeroButton.Size = new Size(60, 50);
            ZeroButton.TabIndex = 19;
            ZeroButton.Text = "0";
            ZeroButton.UseVisualStyleBackColor = true;
            ZeroButton.Click += OnNumberClick;
            // 
            // OneButton
            // 
            OneButton.ForeColor = Color.FromArgb(52, 73, 94);
            OneButton.Location = new Point(72, 250);
            OneButton.Name = "OneButton";
            OneButton.Size = new Size(60, 50);
            OneButton.TabIndex = 20;
            OneButton.Text = "1";
            OneButton.UseVisualStyleBackColor = true;
            OneButton.Click += OnNumberClick;
            // 
            // TwoButton
            // 
            TwoButton.ForeColor = Color.FromArgb(52, 73, 94);
            TwoButton.Location = new Point(138, 250);
            TwoButton.Name = "TwoButton";
            TwoButton.Size = new Size(60, 50);
            TwoButton.TabIndex = 21;
            TwoButton.Text = "2";
            TwoButton.UseVisualStyleBackColor = true;
            TwoButton.Click += OnNumberClick;
            // 
            // ThreeButton
            // 
            ThreeButton.ForeColor = Color.FromArgb(52, 73, 94);
            ThreeButton.Location = new Point(204, 250);
            ThreeButton.Name = "ThreeButton";
            ThreeButton.Size = new Size(60, 50);
            ThreeButton.TabIndex = 22;
            ThreeButton.Text = "3";
            ThreeButton.UseVisualStyleBackColor = true;
            ThreeButton.Click += OnNumberClick;
            // 
            // FourButton
            // 
            FourButton.ForeColor = Color.FromArgb(52, 73, 94);
            FourButton.Location = new Point(72, 198);
            FourButton.Name = "FourButton";
            FourButton.Size = new Size(60, 50);
            FourButton.TabIndex = 23;
            FourButton.Text = "4";
            FourButton.UseVisualStyleBackColor = true;
            FourButton.Click += OnNumberClick;
            // 
            // FiveButton
            // 
            FiveButton.ForeColor = Color.FromArgb(52, 73, 94);
            FiveButton.Location = new Point(138, 198);
            FiveButton.Name = "FiveButton";
            FiveButton.Size = new Size(60, 50);
            FiveButton.TabIndex = 24;
            FiveButton.Text = "5";
            FiveButton.UseVisualStyleBackColor = true;
            FiveButton.Click += OnNumberClick;
            // 
            // SixButton
            // 
            SixButton.ForeColor = Color.FromArgb(52, 73, 94);
            SixButton.Location = new Point(204, 198);
            SixButton.Name = "SixButton";
            SixButton.Size = new Size(60, 50);
            SixButton.TabIndex = 25;
            SixButton.Text = "6";
            SixButton.UseVisualStyleBackColor = true;
            SixButton.Click += OnNumberClick;
            // 
            // SevenButton
            // 
            SevenButton.ForeColor = Color.FromArgb(52, 73, 94);
            SevenButton.Location = new Point(72, 142);
            SevenButton.Name = "SevenButton";
            SevenButton.Size = new Size(60, 50);
            SevenButton.TabIndex = 26;
            SevenButton.Text = "7";
            SevenButton.UseVisualStyleBackColor = true;
            SevenButton.Click += OnNumberClick;
            // 
            // EightButton
            // 
            EightButton.ForeColor = Color.FromArgb(52, 73, 94);
            EightButton.Location = new Point(140, 142);
            EightButton.Name = "EightButton";
            EightButton.Size = new Size(60, 50);
            EightButton.TabIndex = 27;
            EightButton.Text = "8";
            EightButton.UseVisualStyleBackColor = true;
            EightButton.Click += OnNumberClick;
            // 
            // NineButton
            // 
            NineButton.ForeColor = Color.FromArgb(52, 73, 94);
            NineButton.Location = new Point(204, 142);
            NineButton.Name = "NineButton";
            NineButton.Size = new Size(60, 50);
            NineButton.TabIndex = 28;
            NineButton.Text = "9";
            NineButton.UseVisualStyleBackColor = true;
            NineButton.Click += OnNumberClick;
            // 
            // DecimalDotButton
            // 
            DecimalDotButton.ForeColor = Color.FromArgb(52, 73, 94);
            DecimalDotButton.Location = new Point(204, 306);
            DecimalDotButton.Name = "DecimalDotButton";
            DecimalDotButton.Size = new Size(60, 50);
            DecimalDotButton.TabIndex = 29;
            DecimalDotButton.Text = ".";
            DecimalDotButton.UseVisualStyleBackColor = true;
            // 
            // ClearButton
            // 
            ClearButton.ForeColor = Color.FromArgb(52, 73, 94);
            ClearButton.Location = new Point(6, 142);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(60, 50);
            ClearButton.TabIndex = 30;
            ClearButton.Text = "C";
            ClearButton.UseVisualStyleBackColor = true;
            ClearButton.Click += ClearButton_Click;
            // 
            // ResultTextBox
            // 
            ResultTextBox.BackColor = Color.FromArgb(52, 73, 94);
            ResultTextBox.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            ResultTextBox.Location = new Point(12, 31);
            ResultTextBox.Multiline = true;
            ResultTextBox.Name = "ResultTextBox";
            ResultTextBox.ReadOnly = true;
            ResultTextBox.Size = new Size(319, 47);
            ResultTextBox.TabIndex = 36;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(149, 165, 166);
            ClientSize = new Size(343, 365);
            Controls.Add(ResultTextBox);
            Controls.Add(ClearButton);
            Controls.Add(DecimalDotButton);
            Controls.Add(NineButton);
            Controls.Add(EightButton);
            Controls.Add(SevenButton);
            Controls.Add(SixButton);
            Controls.Add(FiveButton);
            Controls.Add(FourButton);
            Controls.Add(ThreeButton);
            Controls.Add(TwoButton);
            Controls.Add(OneButton);
            Controls.Add(ZeroButton);
            Controls.Add(NegateSignButton);
            Controls.Add(SquareRootButton);
            Controls.Add(PowerButton);
            Controls.Add(BackspaceButton);
            Controls.Add(MultiplyButton);
            Controls.Add(EqualButton);
            Controls.Add(DivideButton);
            Controls.Add(MinusButton);
            Controls.Add(PlusButton);
            ForeColor = Color.FromArgb(44, 62, 80);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            Click += OnOperationClick;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button PlusButton;
        private Button MinusButton;
        private Button DivideButton;
        private Button EqualButton;
        private Button MultiplyButton;
        private Button BackspaceButton;
        private Button PowerButton;
        private Button SquareRootButton;
        private Button NegateSignButton;
        private Button ZeroButton;
        private Button OneButton;
        private Button TwoButton;
        private Button ThreeButton;
        private Button FourButton;
        private Button FiveButton;
        private Button SixButton;
        private Button SevenButton;
        private Button EightButton;
        private Button NineButton;
        private Button DecimalDotButton;
        private Button ClearButton;
        private TextBox ResultTextBox;
    }
}