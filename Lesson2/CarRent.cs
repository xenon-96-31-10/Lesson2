using System.Windows.Forms;

namespace Lesson2
{
	public partial class CarRent : Form
	{
        
		public CarRent()
		{
			InitializeComponent();
            
		}
        
        private void CarRent_Load(object sender, System.EventArgs e)
        {

            FileDatabase fileDatabase = new FileDatabase(@"FileDatabase");
            var cars = new Car[] { };
            if (System.IO.File.Exists(@"FileDatabase\Car.fdb"))
            {
                cars = fileDatabase.GetFromDatabase<Car>(); // вот тут и возникает проблема, когда создан файл Car.fdb( Как ее решить?
            }
            else
            {
                cars = new Car[]
            {
                new Car("БМВ", "Машина бизнес-класса"),
                new Car("Мерседес", "Машина люкс-класса"),
                new Car("Жигули", "Машина обычного класса"),
                new Car("Мазератти", "Машина спорт-класса")
            };
                fileDatabase.SaveToDatabase<Car>(cars);

            }
            CarList.Items.AddRange(cars);
        }

        private void CarList_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            var selectedCar = CarList.SelectedItem as Car;
            CarDescription.Text = selectedCar.getDescription;
        }

        private void CarDescription_TextChanged(object sender, System.EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, System.EventArgs e)
        {
            dateTimePicker2.MinDate = dateTimePicker1.Value;            
        }
	}
}
