using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APILibrary
{
    public class Cache : ICacheContainer<ForecastRequest, JObject>
    {
        private readonly int MAX_SIZE = 10;
        private Queue<KeyValuePair<ForecastRequest, JObject>> cache = new Queue<KeyValuePair<ForecastRequest, JObject>>();

        public int Size { get=>cache.Count; }
        protected virtual int compareForecasts(ForecastRequest r1, ForecastRequest r2)
        {
            if (r1.region.Equals(r2.region) && (r1.timeStamp.Date - r2.timeStamp).TotalMinutes >= 60)
            {
                if (r1.forecastType == r2.forecastType)
                    return 1;
                else if ((r1.forecastType == ForecastType.Today || r1.forecastType == ForecastType.Tomorrow || r1.forecastType == ForecastType.Weekly)
                    &&
                    (r2.forecastType == ForecastType.Today || r2.forecastType == ForecastType.Tomorrow || r2.forecastType == ForecastType.Weekly))
                    return 1;
                else
                    return -1;
            }
            else if (r1.region.Equals(r2.region) && (r1.timeStamp.Date - r2.timeStamp).TotalMinutes < 60)
            {
                if (r1.forecastType == r2.forecastType)
                    return 0;
                else if ((r1.forecastType == ForecastType.Today || r1.forecastType == ForecastType.Tomorrow || r1.forecastType == ForecastType.Weekly)
                    &&
                    (r2.forecastType == ForecastType.Today || r2.forecastType == ForecastType.Tomorrow || r2.forecastType == ForecastType.Weekly))
                    return 0;
                else
                    return -1;
            }
            else return -1;
        }

        public JObject get(ForecastRequest key)
        {
            foreach (var element in cache)
            {
                if (compareForecasts(key, element.Key) == 0)
                {
                    return element.Value;
                }
            }
            return null;
        }

        public void add(ForecastRequest key, JObject value)
        {
            cache.Enqueue(new KeyValuePair<ForecastRequest, JObject>(key, value));
            if (cache.Count > MAX_SIZE)
                cache.Dequeue();
        }
    }
}
