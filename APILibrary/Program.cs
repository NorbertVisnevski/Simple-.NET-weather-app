using System;

namespace APILibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            var provider = new ForecastProvider();
            var forecast = new ForecastRequest.ForecastRequestBuilder()
                .setCity("vilnius")
                .setCountry("lt")
                .setUnityType(UnitType.Imperial)
                .setForecastType(ForecastType.Weekly);
            Console.WriteLine(provider.getForecast(forecast.BuildRequest()).Item2);
            forecast = new ForecastRequest.ForecastRequestBuilder()
                .setCity("vilnius")
                .setCountry("lt")
                .setUnityType(UnitType.Imperial)
                .setForecastType(ForecastType.Today);
            Console.WriteLine(provider.getForecast(forecast.BuildRequest()).Item2);
            forecast = new ForecastRequest.ForecastRequestBuilder()
                .setCity("vilnius")
                .setCountry("lt")
                .setUnityType(UnitType.Metric)
                .setForecastType(ForecastType.Tomorrow);
            Console.WriteLine(provider.getForecast(forecast.BuildRequest()).Item2);
        }
    }
}
