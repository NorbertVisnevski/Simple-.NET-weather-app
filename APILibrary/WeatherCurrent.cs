using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APILibrary
{
    public class WeatherCurrent
    {
        public float temperature { get; init; }
        public float temperatureFeelsLike { get; init; }
        public float humidity { get; init; }
        public float preasure { get; init; }
        public float windSpeed { get; init; }
        public string windDirection { get; init; }
        public float visibility { get; init; }
        public string weather { get; init; }
        public string weatherShort { get; init; }
        public string weatherPrimary { get; init; }
        public string icon { get; init; }
    }
}
