using APILibrary;
using Moq;
using NUnit.Framework;
using System;
using Tests.TestClasses;

namespace Tests
{
    public class CacheTests
    {
        Cache cache;
        TestForecastProvider provider;
        [SetUp]
        public void Setup()
        {
            provider = new TestForecastProvider(cache = new Cache());
        }

        [Test]
        public void webCacheTest1()
        {
            var request = new ForecastRequest.ForecastRequestBuilder()
                .setCity("vilnius")
                .setCountry("lt")
                .setUnityType(UnitType.Imperial)
                .setForecastType(ForecastType.Weekly)
                .buildRequest();
            provider.getForecast(request);
            provider.getForecast(request);
            Assert.AreEqual(provider.counter, 1);
        }
        [Test]
        public void webCacheTest2()
        {
            var request = new ForecastRequest.ForecastRequestBuilder()
                .setCity("vilnius")
                .setCountry("lt")
                .setUnityType(UnitType.Imperial)
                .setForecastType(ForecastType.Weekly)
                .buildRequest();
            provider.getForecast(request);
            request = new ForecastRequest.ForecastRequestBuilder()
                .setCity("vilnius")
                .setCountry("lt")
                .setUnityType(UnitType.Metric)
                .setForecastType(ForecastType.Weekly)
                .buildRequest();
            provider.getForecast(request);
            Assert.AreEqual(provider.counter, 1);
        }
        [Test]
        public void webCacheTest3()
        {
            var request = new ForecastRequest.ForecastRequestBuilder()
                .setCity("vilnius")
                .setCountry("lt")
                .setUnityType(UnitType.Imperial)
                .setForecastType(ForecastType.Weekly)
                .buildRequest();
            provider.getForecast(request);
            request = new ForecastRequest.ForecastRequestBuilder()
                .setCity("vilnius")
                .setCountry("lt")
                .setUnityType(UnitType.Metric)
                .setForecastType(ForecastType.Today)
                .buildRequest();
            provider.getForecast(request);
            Assert.AreEqual(provider.counter, 1);
        }
        [Test]
        public void webCacheTest4()
        {
            var request = new ForecastRequest.ForecastRequestBuilder()
                .setCity("vilnius")
                .setCountry("lt")
                .setUnityType(UnitType.Imperial)
                .setForecastType(ForecastType.Weekly)
                .buildRequest();
            provider.getForecast(request);
            request = new ForecastRequest.ForecastRequestBuilder()
                .setCity("vilnius")
                .setCountry("lt")
                .setUnityType(UnitType.Metric)
                .setForecastType(ForecastType.Current)
                .buildRequest();
            provider.getForecast(request);
            Assert.AreEqual(provider.counter, 2);
        }
        [Test]
        public void webCacheTest5()
        {
            var request = new ForecastRequest.ForecastRequestBuilder()
                .setCity("vilnius")
                .setCountry("lt")
                .setUnityType(UnitType.Imperial)
                .setForecastType(ForecastType.Weekly)
                .buildRequest();
            provider.getForecast(request);
            request = new ForecastRequest.ForecastRequestBuilder()
                .setCity("vilnius")
                .setCountry("lt")
                .setUnityType(UnitType.Metric)
                .setForecastType(ForecastType.Today)
                .buildRequest();
            provider.getForecast(request);
            request = new ForecastRequest.ForecastRequestBuilder()
                .setCity("warsaw")
                .setCountry("pl")
                .setUnityType(UnitType.Metric)
                .setForecastType(ForecastType.Today)
                .buildRequest();
            provider.getForecast(request);
            Assert.AreEqual(provider.counter, 2);
        }
        [Test]
        public void localCacheTest1()
        {
            var request = new ForecastRequest.ForecastRequestBuilder()
                .setCity("Berlin")
                .setCountry("de")
                .setUnityType(UnitType.Imperial)
                .setForecastType(ForecastType.Weekly)
                .buildRequest();
            cache.add(request, new Newtonsoft.Json.Linq.JObject());
            request = new ForecastRequest.ForecastRequestBuilder()
                .setCity("Berlin")
                .setCountry("de")
                .setUnityType(UnitType.Imperial)
                .setForecastType(ForecastType.Tomorrow)
                .buildRequest();
            cache.add(request, new Newtonsoft.Json.Linq.JObject());
            request = new ForecastRequest.ForecastRequestBuilder()
                .setCity("vilnius")
                .setCountry("lt")
                .setUnityType(UnitType.Metric)
                .setForecastType(ForecastType.Current)
                .buildRequest();
            cache.add(request, new Newtonsoft.Json.Linq.JObject());
            request = new ForecastRequest.ForecastRequestBuilder()
                .setCity("vilnius")
                .setCountry("lt")
                .setUnityType(UnitType.Metric)
                .setForecastType(ForecastType.Today)
                .buildRequest();
            cache.add(request, new Newtonsoft.Json.Linq.JObject());
            request = new ForecastRequest.ForecastRequestBuilder()
                .setCity("Berlin")
                .setCountry("de")
                .setUnityType(UnitType.Metric)
                .setForecastType(ForecastType.Weekly)
                .buildRequest();
            try
            {
                provider.getForecast(request);
            }
            catch (Exception) { }
            Assert.AreEqual(provider.counter, 0);
        }
        [Test]
        public void localCacheTest2()
        {
            var request = new ForecastRequest.ForecastRequestBuilder()
                .setCity("Berlin")
                .setCountry("de")
                .setUnityType(UnitType.Imperial)
                .setForecastType(ForecastType.Tomorrow)
                .buildRequest();
            cache.add(request, new Newtonsoft.Json.Linq.JObject());
            request = new ForecastRequest.ForecastRequestBuilder()
                .setCity("Berlin")
                .setCountry("de")
                .setUnityType(UnitType.Metric)
                .setForecastType(ForecastType.Current)
                .buildRequest();
            try
            {
                provider.getForecast(request);
            }
            catch (Exception) { }
            Assert.AreEqual(provider.counter, 1);
        }
        [Test]
        public void localCacheTest3()
        {
            var request = new ForecastRequest.ForecastRequestBuilder()
                .setCity("Berlin")
                .setCountry("de")
                .setUnityType(UnitType.Imperial)
                .setForecastType(ForecastType.Tomorrow)
                .buildRequest();
            cache.add(request, new Newtonsoft.Json.Linq.JObject());
            request = new ForecastRequest.ForecastRequestBuilder()
                .setCity("Berlin")
                .setCountry("de")
                .setUnityType(UnitType.Metric)
                .setForecastType(ForecastType.Today)
                .buildRequest();
            try
            {
                provider.getForecast(request);
            }
            catch (Exception) { }
            Assert.AreEqual(provider.counter, 0);
        }
        [Test]
        public void localCacheTes4()
        {
            var request = new ForecastRequest.ForecastRequestBuilder().buildRequest();
            cache.add(request, null);
            cache.add(request, null);
            cache.add(request, null);
            cache.add(request, null);
            cache.add(request, null);
            cache.add(request, null);
            cache.add(request, null);
            cache.add(request, null);
            cache.add(request, null);
            cache.add(request, null);
            cache.add(request, null);
            cache.add(request, null);
            cache.add(request, null);
            cache.add(request, null);
            cache.add(request, null);
            Assert.AreEqual(cache.Size, 10);
        }
    }
}