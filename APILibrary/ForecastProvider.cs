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
        private static readonly HttpClientHandler clientHandler = new HttpClientHandler();

        private static WeatherCurrent getCurrent(JToken json, bool metric)
        {
            if (metric)
            {
                return new WeatherCurrent
                {
                    temperature = json["tempC"].Value<float>(),
                    temperatureFeelsLike = json["feelslikeC"].Value<float>(),
                    humidity = json["humidity"].Value<float>(),
                    preasure = json["pressureMB"].Value<float>(),
                    windSpeed = json["windSpeedKPH"].Value<float>(),
                    visibility = json["visibilityKM"].Value<float>(),
                    windDirection = json["windDir"].ToString(),
                    weather = json["weather"].ToString(),
                    weatherShort = json["weatherShort"].ToString(),
                    weatherPrimary = json["weatherPrimary"].ToString(),
                    icon = json["icon"].ToString()
                };
            }
            else
            {
                return new WeatherCurrent
                {
                    temperature = json["tempF"].Value<float>(),
                    temperatureFeelsLike = json["feelslikeF"].Value<float>(),
                    humidity = json["humidity"].Value<float>(),
                    preasure = json["pressureIN"].Value<float>(),
                    windSpeed = json["windSpeedMPH"].Value<float>(),
                    visibility = json["visibilityMI"].Value<float>(),
                    windDirection = json["windDir"].Value<string>(),
                    weather = json["weather"].ToString(),
                    weatherShort = json["weatherShort"].ToString(),
                    weatherPrimary = json["weatherPrimary"].ToString(),
                    icon = json["icon"].ToString()
                };
            }
        }
        private static WeatherDetailed getWeatherDayDetailed(JToken json, bool metric)
        {
            if (metric)
            {
                return new WeatherDetailed
                {
                    temperatureMin = json["minTempC"].Value<float>(),
                    temperatureMax = json["maxTempC"].Value<float>(),
                    temperatureAverage = json["avgTempC"].Value<float>(),
                    temperatureFeelsLike = json["feelslikeC"].Value<float>(),
                    temperatureFeelsLikeMin = json["minFeelslikeC"].Value<float>(),
                    temperatureFeelsLikeMax = json["maxFeelslikeC"].Value<float>(),
                    temperatureFeelsLikeAverage = json["avgFeelslikeC"].Value<float>(),
                    humidity = json["humidity"].Value<float>(),
                    humidityMin = json["minHumidity"].Value<float>(),
                    humidityMax = json["maxHumidity"].Value<float>(),
                    preasure = json["pressureMB"].Value<float>(),
                    windSpeed = json["windSpeedKPH"].Value<float>(),
                    windSpeedMin = json["windSpeedMinKPH"].Value<float>(),
                    windSpeedMax = json["windSpeedMaxKPH"].Value<float>(),
                    visibility = json["visibilityKM"].Value<float>(),
                    windDirection = json["windDir"].ToString(),
                    weather = json["weather"].ToString(),
                    weatherPrimary = json["weatherPrimary"].ToString(),
                    icon = json["icon"].ToString()
                };
            }
            else
            {
                return new WeatherDetailed
                {
                    temperatureMin = json["minTempF"].Value<float>(),
                    temperatureMax = json["maxTempF"].Value<float>(),
                    temperatureAverage = json["avgTempF"].Value<float>(),
                    temperatureFeelsLike = json["feelslikeF"].Value<float>(),
                    temperatureFeelsLikeMin = json["minFeelslikeF"].Value<float>(),
                    temperatureFeelsLikeMax = json["maxFeelslikeF"].Value<float>(),
                    temperatureFeelsLikeAverage = json["avgFeelslikeF"].Value<float>(),
                    humidity = json["humidity"].Value<float>(),
                    humidityMin = json["minHumidity"].Value<float>(),
                    humidityMax = json["maxHumidity"].Value<float>(),
                    preasure = json["pressureIN"].Value<float>(),
                    windSpeed = json["windSpeedMPH"].Value<float>(),
                    windSpeedMin = json["windSpeedMinMPH"].Value<float>(),
                    windSpeedMax = json["windSpeedMaxMPH"].Value<float>(),
                    visibility = json["visibilityMI"].Value<float>(),
                    windDirection = json["windDir"].ToString(),
                    weather = json["weather"].ToString(),
                    weatherPrimary = json["weatherPrimary"].ToString(),
                    icon = json["icon"].ToString()
                };
            }
        }
        public (WeatherCurrent, WeatherDetailed, IList<WeatherDetailed>) getForecast(ForecastRequest forecastRequest)
        { 
            var client = new HttpClient(clientHandler);
            var request = (HttpRequestMessage)forecastRequest;

            using var response = client.SendAsync(request).Result;
            response.EnsureSuccessStatusCode();
            var body = response.Content.ReadAsStringAsync().Result;
            var json = JObject.Parse(body);
            //Console.WriteLine(json);
            if(!json["success"].Value<bool>())
            {
                throw new Exception(json["error"].ToString());
            }
            if(forecastRequest.forecastType == ForecastType.Current)
            {
                return (getCurrent(json["response"]["ob"], forecastRequest.unitType == UnitType.Metric),null,null);
            }
            if (forecastRequest.forecastType == ForecastType.Today)
            {
                return (null, getWeatherDayDetailed(json["response"][0]["periods"][0], forecastRequest.unitType == UnitType.Metric), null);
            }
            if (forecastRequest.forecastType == ForecastType.Tomorrow)
            {
                return (null, getWeatherDayDetailed(json["response"][0]["periods"][1], forecastRequest.unitType == UnitType.Metric), null);
            }
            if (forecastRequest.forecastType == ForecastType.Weekly)
            {
                var list = new List<WeatherDetailed>();
                list.Add(getWeatherDayDetailed(json["response"][0]["periods"][0], forecastRequest.unitType == UnitType.Metric));
                list.Add(getWeatherDayDetailed(json["response"][0]["periods"][1], forecastRequest.unitType == UnitType.Metric));
                list.Add(getWeatherDayDetailed(json["response"][0]["periods"][2], forecastRequest.unitType == UnitType.Metric));
                list.Add(getWeatherDayDetailed(json["response"][0]["periods"][3], forecastRequest.unitType == UnitType.Metric));
                list.Add(getWeatherDayDetailed(json["response"][0]["periods"][4], forecastRequest.unitType == UnitType.Metric));
                list.Add(getWeatherDayDetailed(json["response"][0]["periods"][5], forecastRequest.unitType == UnitType.Metric));
                list.Add(getWeatherDayDetailed(json["response"][0]["periods"][6], forecastRequest.unitType == UnitType.Metric));
                return (null, null,list);
            }
            return (null, null, null);
        }
    }
}
