namespace ТелекомНеваСвязь
{
    partial class Autorization
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Autorization));
            CompanyTitle = new Label();
            pictureBox1 = new PictureBox();
            NumberTextBox = new TextBox();
            NumberLabel = new Label();
            PasswordLabel = new Label();
            PasswordTextBox = new TextBox();
            CodeLabel = new Label();
            CodeTextBox = new TextBox();
            ButtonStop = new Button();
            ButtonIn = new Button();
            ButtonNewCode = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // CompanyTitle
            // 
            CompanyTitle.AutoSize = true;
            CompanyTitle.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            CompanyTitle.Location = new Point(30, 30);
            CompanyTitle.Name = "CompanyTitle";
            CompanyTitle.Size = new Size(336, 46);
            CompanyTitle.TabIndex = 0;
            CompanyTitle.Text = "Телеком Нева Связь";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(615, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(185, 153);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // NumberTextBox
            // 
            NumberTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            NumberTextBox.Location = new Point(341, 194);
            NumberTextBox.Name = "NumberTextBox";
            NumberTextBox.Size = new Size(244, 34);
            NumberTextBox.TabIndex = 2;
            // 
            // NumberLabel
            // 
            NumberLabel.AutoSize = true;
            NumberLabel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            NumberLabel.Location = new Point(237, 194);
            NumberLabel.Name = "NumberLabel";
            NumberLabel.Size = new Size(89, 32);
            NumberLabel.TabIndex = 3;
            NumberLabel.Text = "Номер";
            // 
            // PasswordLabel
            // 
            PasswordLabel.AutoSize = true;
            PasswordLabel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            PasswordLabel.Location = new Point(237, 249);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(96, 32);
            PasswordLabel.TabIndex = 4;
            PasswordLabel.Text = "Пароль";
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Enabled = false;
            PasswordTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            PasswordTextBox.Location = new Point(341, 249);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.Size = new Size(244, 34);
            PasswordTextBox.TabIndex = 5;
            // 
            // CodeLabel
            // 
            CodeLabel.AutoSize = true;
            CodeLabel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            CodeLabel.Location = new Point(237, 303);
            CodeLabel.Name = "CodeLabel";
            CodeLabel.Size = new Size(55, 32);
            CodeLabel.TabIndex = 6;
            CodeLabel.Text = "Код";
            // 
            // CodeTextBox
            // 
            CodeTextBox.Enabled = false;
            CodeTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            CodeTextBox.Location = new Point(341, 303);
            CodeTextBox.Name = "CodeTextBox";
            CodeTextBox.Size = new Size(189, 34);
            CodeTextBox.TabIndex = 7;
            // 
            // ButtonStop
            // 
            ButtonStop.BackColor = Color.DarkGray;
            ButtonStop.Location = new Point(341, 381);
            ButtonStop.Name = "ButtonStop";
            ButtonStop.Size = new Size(97, 41);
            ButtonStop.TabIndex = 8;
            ButtonStop.Text = "Отмена";
            ButtonStop.UseVisualStyleBackColor = false;
            ButtonStop.Click += ButtonStop_Click;
            // 
            // ButtonIn
            // 
            ButtonIn.BackColor = Color.DarkGray;
            ButtonIn.BackgroundImageLayout = ImageLayout.None;
            ButtonIn.Enabled = false;
            ButtonIn.Location = new Point(488, 381);
            ButtonIn.Name = "ButtonIn";
            ButtonIn.Size = new Size(97, 41);
            ButtonIn.TabIndex = 9;
            ButtonIn.Text = "Вход";
            ButtonIn.UseVisualStyleBackColor = false;
            ButtonIn.Click += ButtonIn_Click;
            // 
            // ButtonNewCode
            // 
            ButtonNewCode.BackgroundImage = (Image)resources.GetObject("ButtonNewCode.BackgroundImage");
            ButtonNewCode.BackgroundImageLayout = ImageLayout.Stretch;
            ButtonNewCode.Enabled = false;
            ButtonNewCode.Location = new Point(547, 303);
            ButtonNewCode.Name = "ButtonNewCode";
            ButtonNewCode.Size = new Size(38, 38);
            ButtonNewCode.TabIndex = 10;
            ButtonNewCode.UseVisualStyleBackColor = true;
            ButtonNewCode.Click += ButtonNewCode_Click;
            // 
            // Autorization
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(ButtonNewCode);
            Controls.Add(ButtonIn);
            Controls.Add(ButtonStop);
            Controls.Add(CodeTextBox);
            Controls.Add(CodeLabel);
            Controls.Add(PasswordTextBox);
            Controls.Add(PasswordLabel);
            Controls.Add(NumberLabel);
            Controls.Add(NumberTextBox);
            Controls.Add(pictureBox1);
            Controls.Add(CompanyTitle);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Autorization";
            Text = "Авторизация";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label CompanyTitle;
        private PictureBox pictureBox1;
        private TextBox NumberTextBox;
        private Label NumberLabel;
        private Label PasswordLabel;
        private TextBox PasswordTextBox;
        private Label CodeLabel;
        private TextBox CodeTextBox;
        private Button ButtonStop;
        private Button ButtonIn;
        private Button ButtonNewCode;
    }
}