using GithubDemo.Controllers;
using Microsoft.Extensions.Logging;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject
{
    [TestClass]
    public class GithubDemoUnitTest
    {
        ILogger<WeatherForecastController> logger;
        [TestMethod]
        public void TestGetCity()
        {
            WeatherForecastController weatherForecastController= new WeatherForecastController(logger);
            var Output=weatherForecastController.GetCity();
            Assert.AreEqual("Thane", Output);

        }
    }
}