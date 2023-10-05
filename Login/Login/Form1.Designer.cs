namespace Login
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
            label1 = new Label();
            UsernameTextBox = new TextBox();
            UsernameLabel = new Label();
            PasswordLabel = new Label();
            PasswordTextBox = new TextBox();
            LoginButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(24, 9);
            label1.Name = "label1";
            label1.Padding = new Padding(70, 0, 70, 0);
            label1.Size = new Size(262, 54);
            label1.TabIndex = 0;
            label1.Text = "Login";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // UsernameTextBox
            // 
            UsernameTextBox.Location = new Point(39, 112);
            UsernameTextBox.Name = "UsernameTextBox";
            UsernameTextBox.Size = new Size(212, 23);
            UsernameTextBox.TabIndex = 1;
            UsernameTextBox.TextChanged += UsernameTextBox_TextChanged;
            // 
            // UsernameLabel
            // 
            UsernameLabel.AutoSize = true;
            UsernameLabel.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            UsernameLabel.ForeColor = Color.LightSlateGray;
            UsernameLabel.Location = new Point(38, 97);
            UsernameLabel.Name = "UsernameLabel";
            UsernameLabel.Size = new Size(49, 12);
            UsernameLabel.TabIndex = 2;
            UsernameLabel.Text = "Username";
            // 
            // PasswordLabel
            // 
            PasswordLabel.AutoSize = true;
            PasswordLabel.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            PasswordLabel.ForeColor = Color.LightSlateGray;
            PasswordLabel.Location = new Point(39, 153);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(46, 12);
            PasswordLabel.TabIndex = 3;
            PasswordLabel.Text = "Password";
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Location = new Point(39, 168);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.PasswordChar = '*';
            PasswordTextBox.Size = new Size(212, 23);
            PasswordTextBox.TabIndex = 4;
            PasswordTextBox.TextChanged += PasswordTextBox_TextChanged;
            // 
            // LoginButton
            // 
            LoginButton.BackColor = SystemColors.Highlight;
            LoginButton.BackgroundImageLayout = ImageLayout.Stretch;
            LoginButton.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            LoginButton.ForeColor = SystemColors.Control;
            LoginButton.Location = new Point(101, 206);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(92, 38);
            LoginButton.TabIndex = 5;
            LoginButton.Text = "LOGIN";
            LoginButton.UseVisualStyleBackColor = false;
            LoginButton.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(298, 335);
            Controls.Add(LoginButton);
            Controls.Add(PasswordTextBox);
            Controls.Add(PasswordLabel);
            Controls.Add(UsernameLabel);
            Controls.Add(UsernameTextBox);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox UsernameTextBox;
        private Label UsernameLabel;
        private Label PasswordLabel;
        private TextBox PasswordTextBox;
        private Button LoginButton;
    }
}