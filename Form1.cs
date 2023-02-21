using System.Linq;
using System.Windows.Forms;

namespace WeatherApp {
    public partial class WeatherForm : Form {
        private WeatherDatabase _weather;

        public WeatherForm() {
            InitializeComponent();

            _weather = new WeatherDatabase();
            _weather.Initialize();

            WeatherDataGrid.DataSource = _weather.Weathers;

            measureUnitsBox.Items.Add(MeasureUnits.Celsius.ToString());
            measureUnitsBox.Items.Add(MeasureUnits.Fahrenheit.ToString());
            measureUnitsBox.Items.Add(MeasureUnits.Kelvin.ToString());
        }

        private void searchBox_TextChanged(object sender, System.EventArgs e) {
            if (string.IsNullOrEmpty(searchBox.Text)) {
                WeatherDataGrid.DataSource = _weather.Weathers;
                return;
            }
            WeatherDataGrid.DataSource = _weather.Weathers
                .Where(w => w.CityName.ToLower().Contains(searchBox.Text.ToLower()))
                .ToList();
        }

        private void WeatherForm_Load(object sender, System.EventArgs e) {

        }

        private void measureUnitsBox_SelectedChanged(object sender, System.EventArgs e) {
            if (measureUnitsBox.SelectedItem != null) {
                var selected = measureUnitsBox.SelectedItem as string;
                WeatherDataGrid.DataSource = _weather.Weathers
                    .Where(w => w.MeasureUnit.ToString() == selected)
                    .ToList();
                return;
            }
            WeatherDataGrid.DataSource = _weather.Weathers;
        }

        private void resetButton_Click(object sender, System.EventArgs e) {
            WeatherDataGrid.DataSource = _weather.Weathers;
            searchBox.Text = string.Empty;
            measureUnitsBox.Text = string.Empty;
        }

        private void onlyPositive_Click(object sender, System.EventArgs e) {
            WeatherDataGrid.DataSource = _weather.Weathers.Where(w => w.Temperature > 0).ToList();
        }

        private void sortButton_Click(object sender, System.EventArgs e) {
            WeatherDataGrid.DataSource = _weather.Weathers.OrderBy(w => w.Temperature).ToList();
        }
    }
}