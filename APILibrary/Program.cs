using System;

namespace APILibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            var forecast = new ForecastRequest.ForecastRequestBuilder()
                .setCity("vilnius")
                .setCountry("lt")
                .setUnityType(UnitType.Imperial)
                .setForecastType(ForecastType.Weekly);
            Console.WriteLine(new ForecastProvider().getForecast(forecast.BuildRequest()).Item2);
        }
    }
}
