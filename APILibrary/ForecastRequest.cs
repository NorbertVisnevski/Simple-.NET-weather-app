using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace APILibrary
{
    public enum ForecastType { Current, Today, Tomorrow, Weekly}
    public enum UnitType { Metric, Imperial}
    public class ForecastRequest
    {
        public string region { get; init; }
        public UnitType unitType { get; init; }
        public ForecastType forecastType { get; init; }
        public DateTime timeStamp { get; private set; }

        public static explicit operator HttpRequestMessage(ForecastRequest request)
        {
            request.timeStamp = DateTime.UtcNow;

            StringBuilder sb = new StringBuilder();
            if (request.forecastType == ForecastType.Current)
            {
                sb.Append("https://aerisweather1.p.rapidapi.com/observations/");
                sb.Append(request.region);
            }
            else if (request.forecastType == ForecastType.Today || request.forecastType == ForecastType.Tomorrow || request.forecastType == ForecastType.Weekly)
            {
                sb.Append("https://aerisweather1.p.rapidapi.com/forecasts/");
                sb.Append(request.region);
                sb.Append("?plimit=7");
                sb.Append("&from=");
                sb.Append(DateTime.Now.ToString("yyyy-MM-dd"));
                sb.Append("&to=");
                sb.Append(DateTime.Now.AddDays(7).ToString("yyyy-MM-dd"));
            }

            return new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri(sb.ToString()),
                Headers =
                {
                    { "x-rapidapi-key", "76d856611fmsha35ddf8e5adef10p1d1297jsn381734c61c69" },
                    { "x-rapidapi-host", "aerisweather1.p.rapidapi.com" },
                },
            };

        }
        protected ForecastRequest() { }
        public class ForecastRequestBuilder
        {
            public double latitude { get; private set; } = 0.0;
            public double longitude { get; private set; } = 0.0;
            public string city { get; private set; } = null;
            public string country { get; private set; } = null;
            public UnitType unitType { get; private set; } = UnitType.Metric;
            public ForecastType forecastType { get; private set; } = ForecastType.Current;

            public ForecastRequestBuilder setCoordinates(double latitude, double longitude)
            {
                this.longitude = longitude;
                this.latitude = latitude;
                return this;
            }

            public ForecastRequestBuilder setCity(string city)
            {
                this.city = city;
                return this;
            }
            public ForecastRequestBuilder setCountry(string country)
            {
                this.country = country;
                return this;
            }

            public ForecastRequestBuilder setUnityType(UnitType type)
            {
                this.unitType = type;
                return this;
            }

            public ForecastRequestBuilder setForecastType(ForecastType type)
            {
                this.forecastType = type;
                return this;
            }

            public ForecastRequest BuildRequest()
            {
                if (city == null || country == null)
                    return null;
                return new ForecastRequest
                { 
                    region = city != null && country != null ? city + "," + country : latitude.ToString() + "," + longitude.ToString(),
                    unitType = unitType,
                    forecastType = forecastType
                };
            }
        }
    }
}
