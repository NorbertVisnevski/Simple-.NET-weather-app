using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APILibrary
{
    class JsonDecoder
    {
        public static WeatherCurrent getCurrent(JToken json, bool metric)
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
        public static WeatherDetailed getWeatherDayDetailed(JToken json, bool metric)
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
    }
}
