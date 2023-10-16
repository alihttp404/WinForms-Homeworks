namespace Anket
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
            groupBox1 = new GroupBox();
            FemaleRadioBtn = new RadioButton();
            MaleRadioBtn = new RadioButton();
            BirthDate = new DateTimePicker();
            PhoneTxt = new TextBox();
            CityTxt = new TextBox();
            CountryTxt = new TextBox();
            FatherNameTxt = new TextBox();
            SurnameTxt = new TextBox();
            NameTxt = new TextBox();
            GenderLabel = new Label();
            BirthDateLabel = new Label();
            PhoneLabel = new Label();
            CityLabel = new Label();
            CountryLabel = new Label();
            FatherNameLabel = new Label();
            SurnameLabel = new Label();
            NameLabel = new Label();
            LoadNameTxt = new TextBox();
            LoadBtn = new Button();
            SaveBtn = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(FemaleRadioBtn);
            groupBox1.Controls.Add(MaleRadioBtn);
            groupBox1.Controls.Add(BirthDate);
            groupBox1.Controls.Add(PhoneTxt);
            groupBox1.Controls.Add(CityTxt);
            groupBox1.Controls.Add(CountryTxt);
            groupBox1.Controls.Add(FatherNameTxt);
            groupBox1.Controls.Add(SurnameTxt);
            groupBox1.Controls.Add(NameTxt);
            groupBox1.Controls.Add(GenderLabel);
            groupBox1.Controls.Add(BirthDateLabel);
            groupBox1.Controls.Add(PhoneLabel);
            groupBox1.Controls.Add(CityLabel);
            groupBox1.Controls.Add(CountryLabel);
            groupBox1.Controls.Add(FatherNameLabel);
            groupBox1.Controls.Add(SurnameLabel);
            groupBox1.Controls.Add(NameLabel);
            groupBox1.Location = new Point(12, 45);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(360, 379);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Anket";
            // 
            // FemaleRadioBtn
            // 
            FemaleRadioBtn.AutoSize = true;
            FemaleRadioBtn.Location = new Point(254, 321);
            FemaleRadioBtn.Name = "FemaleRadioBtn";
            FemaleRadioBtn.Size = new Size(78, 24);
            FemaleRadioBtn.TabIndex = 15;
            FemaleRadioBtn.TabStop = true;
            FemaleRadioBtn.Text = "Female";
            FemaleRadioBtn.UseVisualStyleBackColor = true;
            // 
            // MaleRadioBtn
            // 
            MaleRadioBtn.AutoSize = true;
            MaleRadioBtn.Location = new Point(161, 320);
            MaleRadioBtn.Name = "MaleRadioBtn";
            MaleRadioBtn.Size = new Size(63, 24);
            MaleRadioBtn.TabIndex = 14;
            MaleRadioBtn.TabStop = true;
            MaleRadioBtn.Text = "Male";
            MaleRadioBtn.UseVisualStyleBackColor = true;
            // 
            // BirthDate
            // 
            BirthDate.Format = DateTimePickerFormat.Short;
            BirthDate.Location = new Point(161, 278);
            BirthDate.Name = "BirthDate";
            BirthDate.Size = new Size(167, 27);
            BirthDate.TabIndex = 13;
            // 
            // PhoneTxt
            // 
            PhoneTxt.Location = new Point(161, 228);
            PhoneTxt.Name = "PhoneTxt";
            PhoneTxt.Size = new Size(167, 27);
            PhoneTxt.TabIndex = 12;
            // 
            // CityTxt
            // 
            CityTxt.Location = new Point(161, 195);
            CityTxt.Name = "CityTxt";
            CityTxt.Size = new Size(167, 27);
            CityTxt.TabIndex = 11;
            // 
            // CountryTxt
            // 
            CountryTxt.Location = new Point(161, 162);
            CountryTxt.Name = "CountryTxt";
            CountryTxt.Size = new Size(167, 27);
            CountryTxt.TabIndex = 10;
            // 
            // FatherNameTxt
            // 
            FatherNameTxt.Location = new Point(161, 108);
            FatherNameTxt.Name = "FatherNameTxt";
            FatherNameTxt.Size = new Size(167, 27);
            FatherNameTxt.TabIndex = 9;
            // 
            // SurnameTxt
            // 
            SurnameTxt.Location = new Point(161, 75);
            SurnameTxt.Name = "SurnameTxt";
            SurnameTxt.Size = new Size(167, 27);
            SurnameTxt.TabIndex = 8;
            // 
            // NameTxt
            // 
            NameTxt.Location = new Point(161, 42);
            NameTxt.Name = "NameTxt";
            NameTxt.Size = new Size(167, 27);
            NameTxt.TabIndex = 4;
            // 
            // GenderLabel
            // 
            GenderLabel.AutoSize = true;
            GenderLabel.Location = new Point(26, 320);
            GenderLabel.Name = "GenderLabel";
            GenderLabel.Size = new Size(57, 20);
            GenderLabel.TabIndex = 7;
            GenderLabel.Text = "Gender";
            // 
            // BirthDateLabel
            // 
            BirthDateLabel.AutoSize = true;
            BirthDateLabel.Location = new Point(25, 283);
            BirthDateLabel.Name = "BirthDateLabel";
            BirthDateLabel.Size = new Size(76, 20);
            BirthDateLabel.TabIndex = 6;
            BirthDateLabel.Text = "Birth Date";
            // 
            // PhoneLabel
            // 
            PhoneLabel.AutoSize = true;
            PhoneLabel.Location = new Point(26, 231);
            PhoneLabel.Name = "PhoneLabel";
            PhoneLabel.Size = new Size(50, 20);
            PhoneLabel.TabIndex = 5;
            PhoneLabel.Text = "Phone";
            // 
            // CityLabel
            // 
            CityLabel.AutoSize = true;
            CityLabel.Location = new Point(25, 198);
            CityLabel.Name = "CityLabel";
            CityLabel.Size = new Size(34, 20);
            CityLabel.TabIndex = 4;
            CityLabel.Text = "City";
            // 
            // CountryLabel
            // 
            CountryLabel.AutoSize = true;
            CountryLabel.Location = new Point(25, 165);
            CountryLabel.Name = "CountryLabel";
            CountryLabel.Size = new Size(60, 20);
            CountryLabel.TabIndex = 3;
            CountryLabel.Text = "Country";
            // 
            // FatherNameLabel
            // 
            FatherNameLabel.AutoSize = true;
            FatherNameLabel.Location = new Point(25, 111);
            FatherNameLabel.Name = "FatherNameLabel";
            FatherNameLabel.Size = new Size(99, 20);
            FatherNameLabel.TabIndex = 2;
            FatherNameLabel.Text = "Father's name";
            // 
            // SurnameLabel
            // 
            SurnameLabel.AutoSize = true;
            SurnameLabel.Location = new Point(26, 78);
            SurnameLabel.Name = "SurnameLabel";
            SurnameLabel.Size = new Size(67, 20);
            SurnameLabel.TabIndex = 1;
            SurnameLabel.Text = "Surname";
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Location = new Point(26, 45);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(49, 20);
            NameLabel.TabIndex = 0;
            NameLabel.Text = "Name";
            // 
            // LoadNameTxt
            // 
            LoadNameTxt.Location = new Point(85, 13);
            LoadNameTxt.Name = "LoadNameTxt";
            LoadNameTxt.Size = new Size(167, 27);
            LoadNameTxt.TabIndex = 1;
            // 
            // LoadBtn
            // 
            LoadBtn.Location = new Point(278, 11);
            LoadBtn.Name = "LoadBtn";
            LoadBtn.Size = new Size(94, 29);
            LoadBtn.TabIndex = 2;
            LoadBtn.Text = "Load";
            LoadBtn.UseVisualStyleBackColor = true;
            LoadBtn.Click += LoadBtn_Click;
            // 
            // SaveBtn
            // 
            SaveBtn.Location = new Point(37, 430);
            SaveBtn.Name = "SaveBtn";
            SaveBtn.Size = new Size(315, 29);
            SaveBtn.TabIndex = 3;
            SaveBtn.Text = "Save";
            SaveBtn.UseVisualStyleBackColor = true;
            SaveBtn.Click += SaveBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 468);
            Controls.Add(SaveBtn);
            Controls.Add(LoadBtn);
            Controls.Add(LoadNameTxt);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox LoadNameTxt;
        private Button LoadBtn;
        private Label GenderLabel;
        private Label BirthDateLabel;
        private Label PhoneLabel;
        private Label CityLabel;
        private Label CountryLabel;
        private Label FatherNameLabel;
        private Label SurnameLabel;
        private Label NameLabel;
        private Button SaveBtn;
        private TextBox PhoneTxt;
        private TextBox CityTxt;
        private TextBox CountryTxt;
        private TextBox FatherNameTxt;
        private TextBox SurnameTxt;
        private TextBox NameTxt;
        private DateTimePicker BirthDate;
        private RadioButton FemaleRadioBtn;
        private RadioButton MaleRadioBtn;
    }
}