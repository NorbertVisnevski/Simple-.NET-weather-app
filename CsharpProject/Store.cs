using APILibrary;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpProject
{
    public static class Store
    {
        public static UnitType unitType = UnitType.Metric;
        public static string defaultCity = "Tataouine";
        public static string defaultCountry = "TUN";
        public static string currentCity;
        public static string currentCountry;
        public static ForecastProvider provider = new ForecastProvider();
        public static void save()
        {
            try
            {
                string[] lines = { unitType.ToString(), defaultCity , defaultCountry };
                using (StreamWriter writetext = new StreamWriter("config.ini"))
                {
                    writetext.WriteLine(lines[0]);
                    writetext.WriteLine(lines[1]);
                    writetext.WriteLine(lines[2]);
                }
            }
            catch (Exception) { }

        }
        public static void load()
        {
            try
            {
                using (StreamReader readtext = new StreamReader("config.ini"))
                {
                    unitType = readtext.ReadLine().Equals("Metric") ? UnitType.Metric : UnitType.Imperial;
                    defaultCity = readtext.ReadLine();
                    defaultCountry = readtext.ReadLine();
                }
            }
            catch (Exception) { }
        }
    }
}
