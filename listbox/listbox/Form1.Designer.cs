namespace listbox
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
            CarsListBox = new ListBox();
            MakeTextBox = new TextBox();
            ModelTextBox = new TextBox();
            AddCarButton = new Button();
            CarProductionDatePicker = new DateTimePicker();
            RightArrowButton = new Button();
            LeftArrowButton = new Button();
            CarsListBox2 = new ListBox();
            SuspendLayout();
            // 
            // CarsListBox
            // 
            CarsListBox.FormattingEnabled = true;
            CarsListBox.ItemHeight = 15;
            CarsListBox.Location = new Point(12, 12);
            CarsListBox.Name = "CarsListBox";
            CarsListBox.SelectionMode = SelectionMode.MultiSimple;
            CarsListBox.Size = new Size(289, 319);
            CarsListBox.TabIndex = 0;
            CarsListBox.SelectedIndexChanged += CarsListBox_SelectedIndexChanged;
            // 
            // MakeTextBox
            // 
            MakeTextBox.Location = new Point(12, 347);
            MakeTextBox.Name = "MakeTextBox";
            MakeTextBox.Size = new Size(216, 23);
            MakeTextBox.TabIndex = 1;
            MakeTextBox.TextChanged += MakeTextBox_TextChanged;
            // 
            // ModelTextBox
            // 
            ModelTextBox.Location = new Point(11, 376);
            ModelTextBox.Name = "ModelTextBox";
            ModelTextBox.Size = new Size(288, 23);
            ModelTextBox.TabIndex = 2;
            // 
            // AddCarButton
            // 
            AddCarButton.Location = new Point(234, 347);
            AddCarButton.Name = "AddCarButton";
            AddCarButton.Size = new Size(65, 23);
            AddCarButton.TabIndex = 3;
            AddCarButton.Text = "Add";
            AddCarButton.UseVisualStyleBackColor = true;
            AddCarButton.Click += AddCarButton_Click;
            // 
            // CarProductionDatePicker
            // 
            CarProductionDatePicker.Location = new Point(12, 405);
            CarProductionDatePicker.Name = "CarProductionDatePicker";
            CarProductionDatePicker.Size = new Size(288, 23);
            CarProductionDatePicker.TabIndex = 4;
            // 
            // RightArrowButton
            // 
            RightArrowButton.BackgroundImage = (Image)resources.GetObject("RightArrowButton.BackgroundImage");
            RightArrowButton.BackgroundImageLayout = ImageLayout.Zoom;
            RightArrowButton.Location = new Point(351, 112);
            RightArrowButton.Name = "RightArrowButton";
            RightArrowButton.Size = new Size(96, 44);
            RightArrowButton.TabIndex = 5;
            RightArrowButton.UseVisualStyleBackColor = true;
            RightArrowButton.Click += RightArrowButton_Click;
            // 
            // LeftArrowButton
            // 
            LeftArrowButton.BackgroundImage = (Image)resources.GetObject("LeftArrowButton.BackgroundImage");
            LeftArrowButton.BackgroundImageLayout = ImageLayout.Zoom;
            LeftArrowButton.Location = new Point(351, 194);
            LeftArrowButton.Name = "LeftArrowButton";
            LeftArrowButton.Size = new Size(96, 34);
            LeftArrowButton.TabIndex = 6;
            LeftArrowButton.UseVisualStyleBackColor = true;
            LeftArrowButton.Click += LeftArrowButton_Click;
            // 
            // CarsListBox2
            // 
            CarsListBox2.FormattingEnabled = true;
            CarsListBox2.ItemHeight = 15;
            CarsListBox2.Location = new Point(499, 12);
            CarsListBox2.Name = "CarsListBox2";
            CarsListBox2.SelectionMode = SelectionMode.MultiSimple;
            CarsListBox2.Size = new Size(289, 319);
            CarsListBox2.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(CarsListBox2);
            Controls.Add(LeftArrowButton);
            Controls.Add(RightArrowButton);
            Controls.Add(CarProductionDatePicker);
            Controls.Add(AddCarButton);
            Controls.Add(ModelTextBox);
            Controls.Add(MakeTextBox);
            Controls.Add(CarsListBox);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox CarsListBox;
        private TextBox MakeTextBox;
        private TextBox ModelTextBox;
        private Button AddCarButton;
        private DateTimePicker CarProductionDatePicker;
        private Button RightArrowButton;
        private Button LeftArrowButton;
        private ListBox CarsListBox2;
    }
}