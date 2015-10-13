using System.Windows.Forms;
using System.Collections.Generic;

namespace Lesson2
{
	public partial class CarRent : Form
	{
        FileDatabase fileDatabase = new FileDatabase(@"FileDatabase");
        List<Car> cars = new List<Car>();
        List<Rent> rentcars = new List<Rent>();
        
        
		public CarRent()
		{
			InitializeComponent();
            dateTimePicker2.MinDate = dateTimePicker1.Value;
            
		}
        
        private void CarRent_Load(object sender, System.EventArgs e)
        {
            cars.Add(new Car("БМВ", "Машина бизнес-класса"));
            cars.Add(new Car("Мерседес", "Машина люкс-класса"));
            cars.Add(new Car("Мерседес", "Машина люкс-класса"));
            cars.Add(new Car("Мазератти", "Машина спорт-класса"));
            

            if (!System.IO.File.Exists(@"FileDatabase\Car.fdb"))
            {
               
                fileDatabase.SaveToDatabase<Car>(cars.ToArray());
            }
            CarList.DataSource = null;
            CarList.DataSource = cars;
        }

        private void CarList_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            
            var selectedCar = CarList.SelectedItem as Car;
            if(selectedCar != null)
            {
                CarDescription.Text = selectedCar.description;
            }
            
        }

        private void CarDescription_TextChanged(object sender, System.EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, System.EventArgs e)
        {
            dateTimePicker2.MinDate = dateTimePicker1.Value;
            CarService carservice = new CarService(cars, rentcars);
            CarList.DataSource = null;
            CarList.DataSource = carservice.AVailableCars(dateTimePicker1.Value, dateTimePicker2.Value);
            
        }

        private void dateTimePicker2_ValueChanged(object sender, System.EventArgs e)
        {
            CarList.DataSource = null;
            CarService carservice = new CarService(cars, rentcars);
            CarList.DataSource = carservice.AVailableCars(dateTimePicker1.Value, dateTimePicker2.Value);
        }

        private void MakeAnOrderButton_Click(object sender, System.EventArgs e)
        {
            var selectedCar = CarList.SelectedItem as Car;
            CarService carservice = new CarService(cars, rentcars);
            carservice.MakeRent(selectedCar, dateTimePicker1.Value, dateTimePicker2.Value);
        }
	}
}
