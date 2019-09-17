using Core_TestsCSharp.Helpers;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_TestsCSharp.Bases
{
    public class TestBase
    {
        [SetUp]
        public void Setup()
        {
            ExtentReportHelpers.AddTest(); //Ciar o Report com os dados do teste
            DriverFactory.CreateInstance();
            DriverFactory.INSTANCE.Navigate().GoToUrl(ConfigurationManager.AppSettings["URL"].ToString());
        }


        [TearDown]
        public void TearDown()
        {
            ExtentReportHelpers.AddTestResult();
            DriverFactory.QuitInstace();
        }

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            ExtentReportHelpers.CreateReport();
        }

        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            ExtentReportHelpers.GenerateReport();
        }

    }
}
