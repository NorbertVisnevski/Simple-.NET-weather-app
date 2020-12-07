using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using MaterialThemeCore.MaterialControls;
using APILibrary;

namespace CsharpProject
{
    public static class AdvancedWeatherNodeGenerator
    {
        public static Control generateNode(DateTime date, WeatherDetailed data)
        {
            var dateLabel = new MaterialLabel();
            dateLabel.Text = (date.ToString("yyyy-MM-dd"));
            dateLabel.Location = new Point(15, 25);
            var weaterLabel = new MaterialLabel();
            weaterLabel.Text = data.weatherPrimary;
            weaterLabel.Location = new Point(15, 55);
            var groupBox = new GroupBox();
            groupBox.Controls.Add(dateLabel);
            groupBox.Controls.Add(weaterLabel);
            var list = new MaterialListView();
            groupBox.Width = 410;
            groupBox.Height = 420;
            groupBox.BackColor = Color.Transparent;
            list.Location = new Point(5, 85);
            list.Width = 400;
            list.Height = 328;
            list.View = View.Details;
            list.Enabled = false;
            list.Anchor = AnchorStyles.Left;
            list.Columns.Add("Condition", 100, HorizontalAlignment.Left);
            list.Columns.Add("Average", 100, HorizontalAlignment.Left);
            list.Columns.Add("Minimal", 100, HorizontalAlignment.Left);
            list.Columns.Add("Maximal", 100, HorizontalAlignment.Left);
            ListViewItem item = list.Items.Add("Temperature");
            item.SubItems.Add(data.temperatureAverage.ToString());
            item.SubItems.Add(data.temperatureFeelsLikeMin.ToString());
            item.SubItems.Add(data.temperatureMax.ToString());
            item = list.Items.Add("Feels like");
            item.SubItems.Add(data.temperatureFeelsLikeAverage.ToString());
            item.SubItems.Add(data.temperatureFeelsLikeMin.ToString());
            item.SubItems.Add(data.temperatureFeelsLikeMax.ToString());
            item = list.Items.Add("Humidity");
            item.SubItems.Add(data.humidity.ToString());
            item.SubItems.Add(data.humidityMin.ToString());
            item.SubItems.Add(data.humidityMax.ToString());
            item = list.Items.Add("Preasure");
            item.SubItems.Add(data.preasure.ToString());
            item.SubItems.Add("-");
            item.SubItems.Add("-");
            item = list.Items.Add("Wind speed");
            item.SubItems.Add(data.windSpeed.ToString());
            item.SubItems.Add(data.windSpeedMin.ToString());
            item.SubItems.Add(data.windSpeedMax.ToString());
            item = list.Items.Add("Wind direction");
            item.SubItems.Add(data.windDirection);
            item.SubItems.Add("-");
            item.SubItems.Add("-");
            item = list.Items.Add("Visibility");
            item.SubItems.Add(data.visibility.ToString());
            item.SubItems.Add("-");
            item.SubItems.Add("-");
            groupBox.Controls.Add(list);
            return groupBox;
        }
    }
}
