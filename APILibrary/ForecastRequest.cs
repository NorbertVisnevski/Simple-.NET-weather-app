using System;
using System.Net.Http;
using System.Text;

namespace APILibrary
{
    public enum ForecastType { Current, Today, Tomorrow, Weekly}
    public enum UnitType { Metric, Imperial}
    public class ForecastRequest
    {
        private static readonly string APIKey = "93180b7f8dmsh4dc746fc0c8c40ap1e51a7jsn5b99e028f513";
        public string region { get; init; }
        public UnitType unitType { get; init; }
        public ForecastType forecastType { get; init; }
        public DateTime timeStamp { get; init; }

        public static explicit operator HttpRequestMessage(ForecastRequest request)
        {
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
                    { "x-rapidapi-key", APIKey },
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

            public ForecastRequest buildRequest()
            {
                return new ForecastRequest
                {
                    region = city != null && country != null ? city.ToLower() + "," + country.ToUpper() : latitude.ToString() + "," + longitude.ToString(),
                    unitType = unitType,
                    forecastType = forecastType,
                    timeStamp = DateTime.UtcNow
                };
            }
        }
    }
}
