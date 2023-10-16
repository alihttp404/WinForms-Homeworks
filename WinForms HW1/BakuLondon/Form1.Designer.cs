namespace BakuLondon
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
            LondonBtn = new Button();
            TimeTextBox = new TextBox();
            CityPic = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)CityPic).BeginInit();
            SuspendLayout();
            // 
            // BakuBtn
            // 
            BakuBtn.Location = new Point(70, 61);
            BakuBtn.Name = "BakuBtn";
            BakuBtn.Size = new Size(94, 29);
            BakuBtn.TabIndex = 0;
            BakuBtn.Text = "Baku";
            BakuBtn.UseVisualStyleBackColor = true;
            BakuBtn.Click += BakuBtn_Click;
            // 
            // LondonBtn
            // 
            LondonBtn.Location = new Point(607, 61);
            LondonBtn.Name = "LondonBtn";
            LondonBtn.Size = new Size(94, 29);
            LondonBtn.TabIndex = 1;
            LondonBtn.Text = "London";
            LondonBtn.UseVisualStyleBackColor = true;
            LondonBtn.Click += LondonBtn_Click;
            // 
            // TimeTextBox
            // 
            TimeTextBox.Location = new Point(247, 61);
            TimeTextBox.Name = "TimeTextBox";
            TimeTextBox.Size = new Size(253, 27);
            TimeTextBox.TabIndex = 2;
            // 
            // CityPic
            // 
            CityPic.Image = Properties.Resources.baku;
            CityPic.Location = new Point(127, 117);
            CityPic.Name = "CityPic";
            CityPic.Size = new Size(514, 297);
            CityPic.SizeMode = PictureBoxSizeMode.Zoom;
            CityPic.TabIndex = 3;
            CityPic.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(CityPic);
            Controls.Add(TimeTextBox);
            Controls.Add(LondonBtn);
            Controls.Add(BakuBtn);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)CityPic).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BakuBtn;
        private Button LondonBtn;
        private TextBox TimeTextBox;
        private PictureBox CityPic;
    }
}