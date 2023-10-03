namespace WinForms_Lesson_1
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
            BakuBtn = new Button();
            PicOfCurrCity = new PictureBox();
            LondonBtn = new Button();
            TimeTextbox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)PicOfCurrCity).BeginInit();
            SuspendLayout();
            // 
            // BakuBtn
            // 
            BakuBtn.AccessibleName = "";
            BakuBtn.Location = new Point(81, 11);
            BakuBtn.Name = "BakuBtn";
            BakuBtn.Size = new Size(64, 25);
            BakuBtn.TabIndex = 0;
            BakuBtn.Tag = "";
            BakuBtn.Text = "Baku";
            BakuBtn.UseVisualStyleBackColor = true;
            BakuBtn.Click += button1_Click;
            // 
            // PicOfCurrCity
            // 
            PicOfCurrCity.Location = new Point(12, 60);
            PicOfCurrCity.Name = "PicOfCurrCity";
            PicOfCurrCity.Size = new Size(760, 378);
            PicOfCurrCity.SizeMode = PictureBoxSizeMode.StretchImage;
            PicOfCurrCity.TabIndex = 1;
            PicOfCurrCity.TabStop = false;
            PicOfCurrCity.Click += pictureBox1_Click;
            // 
            // LondonBtn
            // 
            LondonBtn.Location = new Point(0, 12);
            LondonBtn.Name = "LondonBtn";
            LondonBtn.Size = new Size(75, 23);
            LondonBtn.TabIndex = 2;
            LondonBtn.Text = "London";
            LondonBtn.UseVisualStyleBackColor = true;
            LondonBtn.Click += button2_Click;
            // 
            // TimeTextbox
            // 
            TimeTextbox.Location = new Point(244, 29);
            TimeTextbox.Name = "TimeTextbox";
            TimeTextbox.Size = new Size(288, 23);
            TimeTextbox.TabIndex = 3;
            TimeTextbox.TextChanged += textBox1_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(TimeTextbox);
            Controls.Add(LondonBtn);
            Controls.Add(PicOfCurrCity);
            Controls.Add(BakuBtn);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)PicOfCurrCity).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BakuBtn;
        private PictureBox PicOfCurrCity;
        private Button LondonBtn;
        private TextBox TimeTextbox;
    }
}