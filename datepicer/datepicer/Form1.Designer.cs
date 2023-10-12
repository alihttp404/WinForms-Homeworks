namespace datepicer
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
            DateTimePicker = new DateTimePicker();
            SuspendLayout();
            // 
            // DateTimePicker
            // 
            DateTimePicker.Location = new Point(62, 60);
            DateTimePicker.Name = "DateTimePicker";
            DateTimePicker.Size = new Size(200, 23);
            DateTimePicker.TabIndex = 0;
            DateTimePicker.ValueChanged += DateTimePicker_ValueChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(DateTimePicker);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private DateTimePicker DateTimePicker;
    }
}