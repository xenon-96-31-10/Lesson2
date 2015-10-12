﻿using System.Windows.Forms;

namespace Lesson2
{
	public partial class CarRent : Form
	{
        FileDatabase fileDatabase = new FileDatabase(@"FileDatabase");
        CarService carservice;
        Rent[] rentcars = new Rent[] {};
		public CarRent()
		{
			InitializeComponent();
            dateTimePicker2.MinDate = dateTimePicker1.Value;
            
		}
        
        private void CarRent_Load(object sender, System.EventArgs e)
        {

            var cars = new Car[]
                {
                    new Car("БМВ", "Машина бизнес-класса"),
                    new Car("Мерседес", "Машина люкс-класса"),
                    new Car("Жигули", "Машина обычного класса"),
                    new Car("Мазератти", "Машина спорт-класса")
                };
            
            if (!System.IO.File.Exists(@"FileDatabase\Car.fdb"))
            {
               
                fileDatabase.SaveToDatabase<Car>(cars);
            }
            CarList.Items.Clear();
            CarList.Items.AddRange(cars);
        }

        private void CarList_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            var selectedCar = CarList.SelectedItem as Car;
            CarDescription.Text = selectedCar.description;
        }

        private void CarDescription_TextChanged(object sender, System.EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, System.EventArgs e)
        {
            dateTimePicker2.MinDate = dateTimePicker1.Value;

            Car[] availableCars = carservice.AVailableCars(dateTimePicker1.Value, dateTimePicker2.Value, rentcars);
            CarList.Items.Clear();
            CarList.Items.AddRange(availableCars);
        }

        private void dateTimePicker2_ValueChanged(object sender, System.EventArgs e)
        {
            Car[] availableCars = carservice.AVailableCars(dateTimePicker1.Value, dateTimePicker2.Value, rentcars);
            CarList.Items.Clear();
            CarList.Items.AddRange(availableCars);
        }

        private void MakeAnOrderButton_Click(object sender, System.EventArgs e)
        {
            var selectedCar = CarList.SelectedItem as Car;
            carservice.MakeRent(selectedCar, dateTimePicker1.Value, dateTimePicker2.Value, rentcars);
        }
	}
}
