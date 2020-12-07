using APILibrary;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.TestClasses
{
    public class TestForecastProvider : ForecastProvider
    {
        public int counter = 0;
        public TestForecastProvider()
        {
        }
        public TestForecastProvider(Cache cache) : base(cache)
        {
        }

        protected override JObject fetchFromWeb(ForecastRequest forecastRequest)
        {
            fetchFromWebDummy();
            return base.fetchFromWeb(forecastRequest);
        }
        public virtual void fetchFromWebDummy() 
        {
            counter++;
        }
    }
}
