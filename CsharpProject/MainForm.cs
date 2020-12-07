using APILibrary;
using MaterialThemeCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CsharpProject
{
    public partial class MainForm : MaterialThemeCore.MaterialControls.MaterialThemeForm
    {
        public MainForm()
        {
            InitializeComponent();
            var materialTheme = MaterialTheme.Instance;
            materialTheme.AddFormToManage(this);
            materialTheme.Theme = MaterialTheme.Themes.DARK;
            materialTheme.MaterialColor = new MaterialColor(Primary.Grey800, Primary.Grey900, Primary.Grey900, Accent.LightBlue100, TextShade.WHITE);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
            Store.load();
            if(Store.unitType==UnitType.Metric){
                metricMaterialRadioButton.Select();
            }
            else{
                ImperialMaterialRadioButton.Select();
            }
            settingsCityTextField.Text = Store.defaultCity;
            settingsCountryCodeTextField.Text = Store.defaultCountry;
            loadCurrent(Store.defaultCity, Store.defaultCountry);


            //var forecast1 = new ForecastRequest.ForecastRequestBuilder()
            //   .setCity("vilnius")
            //   .setCountry("lt")
            //   .setUnityType(UnitType.Metric)
            //   .setForecastType(ForecastType.Weekly)
            //   .BuildRequest();
            //var list = new ForecastProvider().getForecast(forecast1).Item3;
            //int i = 0;
            //foreach(var element in list)
            //{
            //    flowWeekForecastPanel.Controls.Add(AdvancedWeatherNodeGenerator.generateNode(DateTime.Now.AddDays(i++), element));
            //}
            //return;
            //var forecast = new ForecastRequest.ForecastRequestBuilder()
            //   .setCity("vilnius")
            //   .setCountry("lt")
            //   .setUnityType(UnitType.Metric)
            //   .setForecastType(ForecastType.Current)
            //   .BuildRequest();
            //try
            //{
            //    var result = new ForecastProvider().getForecast(forecast).Item1;

            //    regionLabel.Text = forecast.region.FirstCharToUpper();

            //    weatherConditionLabel.Text = result.weatherShort.FirstCharToUpper();

            //    currentWeatherListView.Items[0].SubItems[1].Text = result.temperature.ToString();
            //    currentWeatherListView.Items[1].SubItems[1].Text = result.temperatureFeelsLike.ToString();
            //    currentWeatherListView.Items[2].SubItems[1].Text = result.humidity.ToString();
            //    currentWeatherListView.Items[3].SubItems[1].Text = result.preasure.ToString();
            //    currentWeatherListView.Items[4].SubItems[1].Text = result.windSpeed.ToString();
            //    currentWeatherListView.Items[5].SubItems[1].Text = result.windDirection;
            //    currentWeatherListView.Items[6].SubItems[1].Text = result.visibility.ToString();
            //    CurrentWeatherGroupBox.Visible = true;
            //    errorLabel.Visible = false;
            //}
            //catch (Exception)
            //{
            //    CurrentWeatherGroupBox.Visible = false;
            //    errorLabel.Visible = true;
            //}
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            materialTabSelector1.Left  = (this.ClientSize.Width - materialTabSelector1.Width) / 2;
            materialTabControl1.Left = (this.ClientSize.Width - materialTabControl1.Width) / 2;
        }

        private void materialTabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(materialTabControl1.SelectedIndex == 1)
            {
                loadWeekly();
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            loadCurrent(searchCityTextField.Text, searchCountryCodeTextField.Text);
        }

        private void applySettingsButton_Click(object sender, EventArgs e)
        {
            Store.unitType = metricMaterialRadioButton.Checked ? UnitType.Metric : UnitType.Imperial;
            Store.defaultCity = settingsCityTextField.Text;
            Store.defaultCountry = settingsCountryCodeTextField.Text;
            Store.save();
            loadCurrent(Store.defaultCity, Store.defaultCountry);
            materialTabControl1.SelectedIndex = 0;
        }
        private void loadWeekly()
        {
            var forecast = new ForecastRequest.ForecastRequestBuilder()
               .setCity(Store.currentCity)
               .setCountry(Store.currentCountry)
               .setUnityType(Store.unitType)
                .setForecastType(ForecastType.Weekly)
                .BuildRequest();
            try
            {
                var list = new ForecastProvider().getForecast(forecast).Item3;
                flowWeekForecastPanel.Controls.Clear();
                int i = 0;
                foreach (var element in list)
                {
                    flowWeekForecastPanel.Controls.Add(AdvancedWeatherNodeGenerator.generateNode(DateTime.Now.AddDays(i++), element));
                }
            }
            catch (Exception) { }
        }
        private void loadCurrent(string city, string country)
        {
            searchCityTextField.Text = Store.currentCity = city;
            searchCountryCodeTextField.Text = Store.currentCountry = country;

            var forecast = new ForecastRequest.ForecastRequestBuilder()
                        .setCity(city)
                        .setCountry(country)
                        .setUnityType(Store.unitType)
                        .setForecastType(ForecastType.Current)
                        .BuildRequest();
            try
            {
                var result = new ForecastProvider().getForecast(forecast).Item1;

                regionLabel.Text = forecast.region.FirstCharToUpper();

                weatherConditionLabel.Text = result.weatherShort.FirstCharToUpper();

                currentWeatherListView.Items[0].SubItems[1].Text = result.temperature.ToString();
                currentWeatherListView.Items[1].SubItems[1].Text = result.temperatureFeelsLike.ToString();
                currentWeatherListView.Items[2].SubItems[1].Text = result.humidity.ToString();
                currentWeatherListView.Items[3].SubItems[1].Text = result.preasure.ToString();
                currentWeatherListView.Items[4].SubItems[1].Text = result.windSpeed.ToString();
                currentWeatherListView.Items[5].SubItems[1].Text = result.windDirection;
                currentWeatherListView.Items[6].SubItems[1].Text = result.visibility.ToString();
                CurrentWeatherGroupBox.Visible = true;
                errorLabel.Visible = false;
            }
            catch (Exception)
            {
                CurrentWeatherGroupBox.Visible = false;
                errorLabel.Visible = true;
            }
        }

        private void btnMoscow_Click(object sender, EventArgs e)
        {
            loadCurrent("Moscow", "RUS");
        }

        private void btnStockholm_Click(object sender, EventArgs e)
        {
            loadCurrent("Stockholm", "SE");
        }

        private void btwVilnius_Click(object sender, EventArgs e)
        {
            loadCurrent("Vilnius", "LT");
        }

        private void btnKiev_Click(object sender, EventArgs e)
        {
            loadCurrent("Kiev", "UA");
        }

        private void btnBerlin_Click(object sender, EventArgs e)
        {
            loadCurrent("Berlin", "DE");
        }

        private void btnVienna_Click(object sender, EventArgs e)
        {
            loadCurrent("Vienna", "AT");
        }

        private void btnBucharest_Click(object sender, EventArgs e)
        {
            loadCurrent("Bucharest", "ROM");
        }

        private void btnLondom_Click(object sender, EventArgs e)
        {
            loadCurrent("London", "UK");
        }

        private void btnParis_Click(object sender, EventArgs e)
        {
            loadCurrent("Paris", "FR");
        }

        private void btnRome_Click(object sender, EventArgs e)
        {
            loadCurrent("Rome", "IT");
        }

        private void btnAthens_Click(object sender, EventArgs e)
        {
            loadCurrent("Athens", "GR");
        }

        private void btnMadrid_Click(object sender, EventArgs e)
        {
            loadCurrent("Madrid", "ESP");
        }
    }
}
