﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;

namespace Core_TestsCSharp.Helpers
{
    public class ExtentReportHelpers
    {
        public static ExtentReports EXTENT_REPORT = null;
        public static ExtentTest TEST;
        static string reportPath = DriverFactory.getPath();
        static string fileName = ConfigurationManager.AppSettings["ReportName"].ToString() + "_" + DateTime.Now.ToString("dd-MM-yyyy_HH-mm") + ".html";

        public static void CreateReport()
        {
            if (EXTENT_REPORT == null)
            {
                var htmlReporter = new ExtentHtmlReporter(reportPath + fileName);
                EXTENT_REPORT = new ExtentReports();
                EXTENT_REPORT.AttachReporter(htmlReporter);
                htmlReporter.Configuration().ChartVisibilityOnOpen = false;
            }
        }

        public static void AddTest()
        {
            string testName = TestContext.CurrentContext.Test.MethodName;
            

            TEST = EXTENT_REPORT.CreateTest(testName);
        }

        public static void AddTestInfo(int methodLevel, string text)
        {
            TEST.Log(Status.Info, text);
        }

        public static MediaEntityModelProvider GetScreenShotMedia()
        {
            string screenshotPath = GetScreenshot(reportPath);

            return MediaEntityBuilder.CreateScreenCaptureFromPath(screenshotPath).Build();
        }

        public static void AddTestResult()
        {
            var status = TestContext.CurrentContext.Result.Outcome.Status;
            var message = string.IsNullOrEmpty(TestContext.CurrentContext.Result.Message) ? "" : string.Format("{0}", TestContext.CurrentContext.Result.Message);
            var stacktrace = string.IsNullOrEmpty(TestContext.CurrentContext.Result.StackTrace) ? "" : string.Format("{0}", TestContext.CurrentContext.Result.StackTrace);

            switch (status)
            {
                case TestStatus.Failed:
                    TEST.Log(Status.Fail, "Test Result: " + Status.Fail + "<pre>" + "Message: " + message + "</pre>" + "<pre>" + "Stack Trace: " + stacktrace + "</pre>", GetScreenShotMedia());
                    break;
                case TestStatus.Inconclusive:
                    TEST.Log(Status.Warning, "Test Result: " + Status.Warning + "<pre>" + "Message: " + message + "</pre>" + "<pre>" + "Stack Trace: " + stacktrace + "</pre>", GetScreenShotMedia());
                    break;
                case TestStatus.Skipped:
                    TEST.Log(Status.Skip, "Test Result: " + Status.Skip + "<pre>" + "Message: " + message + "</pre>" + "<pre>" + "Stack Trace: " + stacktrace + "</pre>", GetScreenShotMedia());
                    break;
                default:
                    TEST.Log(Status.Pass, "Test Result: " + Status.Pass);
                    break;
            }
        }

        public static void GenerateReport()
        {
            EXTENT_REPORT.Flush();
        }

        public static string GetScreenshot(string path)
        {
            string testName = TestContext.CurrentContext.Test.MethodName;
            string date = DateTime.Now.ToString().Replace("/", "_").Replace(":", "_").Replace(" ", "-");

            Screenshot screenShot = ((ITakesScreenshot)DriverFactory.INSTANCE).GetScreenshot();
            string filePathAndName = path + "/" + testName + "_" + date + ".png";
            screenShot.SaveAsFile(filePathAndName, ScreenshotImageFormat.Png);

            return filePathAndName;
        }
    }
}
