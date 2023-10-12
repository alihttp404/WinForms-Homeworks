namespace datepicer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void DateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            MessageBox.Show(DateTimePicker.Value.Year.ToString());
            MessageBox.Show(DateTimePicker.Value.Month.ToString());
            MessageBox.Show(DateTimePicker.Value.Day.ToString());
        }
    }
}