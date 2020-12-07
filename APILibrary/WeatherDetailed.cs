using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APILibrary
{
    public class WeatherDetailed
    {
        public float temperatureAverage { get; init; }
        public float temperatureMin { get; init; }
        public float temperatureMax { get; init; }
        public float temperatureFeelsLike { get; init; }
        public float temperatureFeelsLikeAverage { get; init; }
        public float temperatureFeelsLikeMin { get; init; }
        public float temperatureFeelsLikeMax { get; init; }
        public float humidity { get; init; }
        public float humidityMin { get; init; }
        public float humidityMax { get; init; }
        public float preasure { get; init; }
        public float windSpeed { get; init; }
        public float windSpeedMin { get; init; }
        public float windSpeedMax { get; init; }
        public string windDirection { get; init; }
        public float visibility { get; init; }
        public string weather { get; init; }
        public string weatherPrimary { get; init; }
        public string icon { get; init; }
    }
}
