using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace APILibrary
{
    public class ForecastProvider
    {
        protected static HttpClientHandler clientHandler = new HttpClientHandler();
        protected Cache cache = new Cache();

        public ForecastProvider()
        {
            this.cache = new Cache();
        }
        public ForecastProvider(Cache cache)
        {
            this.cache = cache;
        }
        protected virtual JObject fetchFromWeb(ForecastRequest forecastRequest)
        {
            var request = (HttpRequestMessage)forecastRequest;
            var client = new HttpClient(clientHandler);
            using var response = client.SendAsync(request).Result;
            response.EnsureSuccessStatusCode();
            var body = response.Content.ReadAsStringAsync().Result;
            var json = JObject.Parse(body);
            cache.add(forecastRequest, json);
            return json;
        }
        protected virtual JObject getData(ForecastRequest forecastRequest)
        {
            return cache.get(forecastRequest) ?? fetchFromWeb(forecastRequest);
        }
        public virtual (WeatherCurrent, WeatherDetailed, IList<WeatherDetailed>) getForecast(ForecastRequest forecastRequest)
        {
            var json = getData(forecastRequest);
            Console.WriteLine(json);
            if(!json["success"].Value<bool>())
            {
                throw new Exception(json["error"].ToString());
            }
            if(forecastRequest.forecastType == ForecastType.Current)
            {
                return (JsonDecoder.getCurrent(json["response"]["ob"], forecastRequest.unitType == UnitType.Metric),null,null);
            }
            if (forecastRequest.forecastType == ForecastType.Today)
            {
                return (null, JsonDecoder.getWeatherDayDetailed(json["response"][0]["periods"][0], forecastRequest.unitType == UnitType.Metric), null);
            }
            if (forecastRequest.forecastType == ForecastType.Tomorrow)
            {
                return (null, JsonDecoder.getWeatherDayDetailed(json["response"][0]["periods"][1], forecastRequest.unitType == UnitType.Metric), null);
            }
            if (forecastRequest.forecastType == ForecastType.Weekly)
            {
                var list = new List<WeatherDetailed>();
                list.Add(JsonDecoder.getWeatherDayDetailed(json["response"][0]["periods"][0], forecastRequest.unitType == UnitType.Metric));
                list.Add(JsonDecoder.getWeatherDayDetailed(json["response"][0]["periods"][1], forecastRequest.unitType == UnitType.Metric));
                list.Add(JsonDecoder.getWeatherDayDetailed(json["response"][0]["periods"][2], forecastRequest.unitType == UnitType.Metric));
                list.Add(JsonDecoder.getWeatherDayDetailed(json["response"][0]["periods"][3], forecastRequest.unitType == UnitType.Metric));
                list.Add(JsonDecoder.getWeatherDayDetailed(json["response"][0]["periods"][4], forecastRequest.unitType == UnitType.Metric));
                list.Add(JsonDecoder.getWeatherDayDetailed(json["response"][0]["periods"][5], forecastRequest.unitType == UnitType.Metric));
                list.Add(JsonDecoder.getWeatherDayDetailed(json["response"][0]["periods"][6], forecastRequest.unitType == UnitType.Metric));
                return (null, null,list);
            }
            return (null, null, null);
        }
    }
}
