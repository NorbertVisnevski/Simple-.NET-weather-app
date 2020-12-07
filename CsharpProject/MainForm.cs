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
            Settings.load();
            if(Settings.unitType==UnitType.Metric)
            {
                metricMaterialRadioButton.Select();
            }
            else
            {
                ImperialMaterialRadioButton.Select();
            }
            string[] loc = Settings.defaultLocation.Split(',');
            settingsCityTextField.Text = loc[0];
            settingsCountryCodeTextField.Text = loc[1];
            

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

        }

        private void searchButton_Click(object sender, EventArgs e)
        {

        }

        private void applySettingsButton_Click(object sender, EventArgs e)
        {
            Settings.unitType = metricMaterialRadioButton.Checked ? UnitType.Metric : UnitType.Imperial;
            Settings.defaultLocation = settingsCityTextField.Text + "," + settingsCountryCodeTextField.Text;
            Settings.save();
            materialTabControl1.SelectedIndex = 0;
        }
    }
}
