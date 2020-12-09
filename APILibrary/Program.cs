using System;

namespace APILibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            ForecastProvider.APIKey = "76d856611fmsha35ddf8e5adef10p1d1297jsn381734c61c69";
            var provider = new ForecastProvider();
            var forecast = new ForecastRequest.ForecastRequestBuilder()
                .setCity("vilnius")
                .setCountry("lt")
                .setUnityType(UnitType.Imperial)
                .setForecastType(ForecastType.Weekly);
            Console.WriteLine(provider.getForecast(forecast.buildRequest()).Item2);
            forecast = new ForecastRequest.ForecastRequestBuilder()
                .setCity("vilnius")
                .setCountry("lt")
                .setUnityType(UnitType.Imperial)
                .setForecastType(ForecastType.Today);
            Console.WriteLine(provider.getForecast(forecast.buildRequest()).Item2);
            forecast = new ForecastRequest.ForecastRequestBuilder()
                .setCity("vilnius")
                .setCountry("lt")
                .setUnityType(UnitType.Metric)
                .setForecastType(ForecastType.Tomorrow);
            Console.WriteLine(provider.getForecast(forecast.buildRequest()).Item2);
        }
    }
}
