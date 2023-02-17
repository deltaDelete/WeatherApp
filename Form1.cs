using System.Linq;
using System.Windows.Forms;

namespace WeatherApp
{
    public partial class WeatherForm : Form
    {
        private WeatherDatabase _weather;

        public WeatherForm()
        {
            InitializeComponent();

            _weather = new WeatherDatabase();
            _weather.Initialize();

            WeatherDataGrid.DataSource = _weather.Weathers.ToList();

            measureUnitsBox.Items.Add(MeasureUnits.Celsius.ToString());
            measureUnitsBox.Items.Add(MeasureUnits.Fahrenheit.ToString());
            measureUnitsBox.Items.Add(MeasureUnits.Kelvin.ToString());
        }

        private void searchBox_TextChanged(object sender, System.EventArgs e) {
            if (string.IsNullOrEmpty(searchBox.Text)) {
                WeatherDataGrid.DataSource = _weather.Weathers.ToList();
                return;
            }
            WeatherDataGrid.DataSource = _weather.Weathers
                .Where(w => w.CityName.ToLower().Contains(searchBox.Text.ToLower()))
                .ToList();
        }

        private void WeatherForm_Load(object sender, System.EventArgs e) {

        }
    }
}