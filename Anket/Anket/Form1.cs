namespace Anket
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            bool gender;
            if (MaleRadioBtn.Checked) { gender = true; }
            else { gender = false; }

            AnketForm anket = new AnketForm();
            anket.Name = NameTxt.Text;
            anket.Surname = SurnameTxt.Text;
            anket.FatherName = FatherNameTxt.Text;
            anket.Country = CountryTxt.Text;
            anket.City = CityTxt.Text;
            anket.Phone = PhoneTxt.Text;
            anket.BirthDate = BirthDate.Value;

            CustomJson.Save<AnketForm>(anket, anket.Name);

            NameTxt.Text = "";
            SurnameTxt.Text = "";
            FatherNameTxt.Text = "";
            CountryTxt.Text = "";
            CityTxt.Text = "";
            PhoneTxt.Text = "";
            BirthDate.Value = DateTime.Now;
        }

        private void LoadBtn_Click(object sender, EventArgs e)
        {
            AnketForm anket = CustomJson.Load<AnketForm>(LoadNameTxt.Text ?? "NULL");
            NameTxt.Text = anket.Name;
            SurnameTxt.Text = anket.Surname;
            FatherNameTxt.Text = anket.FatherName;
            CountryTxt.Text = anket.Country;
            CityTxt.Text = anket.City;
            PhoneTxt.Text = anket.Phone;
            BirthDate.Value = anket.BirthDate;
        }
    }
}