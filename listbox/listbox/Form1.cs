using listbox.Models;

namespace listbox
{
    public partial class Form1 : Form
    {
        List<Car> cars = new List<Car>
        {
            new Car("Toyota", "Camry", new DateTime(2022, 1, 15)),
            new Car("Honda", "Civic", new DateTime(2021, 8, 20)),
            new Car("Ford", "Mustang", new DateTime(2022, 3, 5)),
            new Car("Chevrolet", "Silverado", new DateTime(2021, 12, 10)),
            new Car("Nissan", "Altima", new DateTime(2022, 6, 25)),
            new Car("BMW", "X5", new DateTime(2021, 11, 30)),
            new Car("Mercedes-Benz", "C-Class", new DateTime(2022, 4, 15)),
            new Car("Audi", "A4", new DateTime(2022, 2, 8)),
            new Car("Hyundai", "Elantra", new DateTime(2021, 10, 5)),
            new Car("Kia", "Sportage", new DateTime(2022, 7, 12)),
            new Car("Lexus", "RX 350", new DateTime(2022, 9, 18)),
            new Car("Mazda", "CX-5", new DateTime(2021, 7, 3)),
            new Car("Subaru", "Outback", new DateTime(2021, 5, 22)),
            new Car("Tesla", "Model 3", new DateTime(2022, 8, 7)),
            new Car("Volkswagen", "Golf", new DateTime(2021, 4, 1)),
            new Car("Jeep", "Wrangler", new DateTime(2021, 3, 12)),
            new Car("Ram", "1500", new DateTime(2022, 10, 28)),
            new Car("Chrysler", "300", new DateTime(2022, 6, 8)),
            new Car("GMC", "Sierra", new DateTime(2021, 2, 14)),
            new Car("Volvo", "XC60", new DateTime(2021, 9, 9))
        };

        public Form1()
        {
            InitializeComponent();

        }

        private void AddCarButton_Click(object sender, EventArgs e)
        {
            cars.Add(new Car(MakeTextBox.Text, ModelTextBox.Text, CarProductionDatePicker.Value));
            CarsListBox.DataSource = null;
            CarsListBox.DataSource = cars;
        }

        private void MakeTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void CarsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CarsListBox.DataSource = null;
            CarsListBox.DataSource = cars;
        }

        private void RightArrowButton_Click(object sender, EventArgs e)
        {
            CarsListBox2.DataSource = null;
            CarsListBox2.DataSource = CarsListBox.SelectedItems;

            for (int i = 0; i < cars.Count; i++) 
            {
                for (int j = 0; j < CarsListBox.SelectedItems.Count; j++)
                {
                    if (cars[i] == CarsListBox.SelectedItems[j]) { cars.Remove(cars[i]); }
                }
            }
            CarsListBox.DataSource = null;
            CarsListBox.DataSource = cars;
        }

        private void LeftArrowButton_Click(object sender, EventArgs e)
        {
            CarsListBox.DataSource = null;

            foreach (var item in CarsListBox2.SelectedItems)
                cars.Add(item as Car);

            var selectedCars = CarsListBox2.SelectedItems.Cast<Car>().ToList();
            var allCars = CarsListBox2.Items.Cast<Car>().ToList();

            for (int i = 0; i < selectedCars.Count; i++)
            {
                for (int j = 0; j < allCars.Count; j++)
                    if (selectedCars[i] == allCars[j]) allCars.Remove(selectedCars[i]);
            }

            CarsListBox.DataSource = null;
            CarsListBox.DataSource = cars;
        }
    }
}
