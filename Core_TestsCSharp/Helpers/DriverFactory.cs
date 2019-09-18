using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Configuration;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Opera;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Edge;

namespace Core_TestsCSharp.Helpers
{
    public class DriverFactory
    {
        public static IWebDriver INSTANCE { get; set; } = null;

        public static void CreateInstance()
        {

            //criado um appconfig com a configuração desejada
            string navegador = ConfigurationManager.AppSettings["NavegadorDefault"].ToString();
            string local = ConfigurationManager.AppSettings["Local"].ToString();
            string hubURL = ConfigurationManager.AppSettings["Hublink"].ToString();

            if (INSTANCE == null)
            {
                
                switch (local)
                {
                    case ("true"): //Execução Local
                        ChromeOptions chromeOptions = new ChromeOptions();
                        INSTANCE = new ChromeDriver(chromeOptions);
                        INSTANCE.Manage().Window.Maximize();
                        break;

                    case ("false"): //Execução Grid
                        switch (navegador)
                        {
                            case ("firefox"):
                                FirefoxOptions firefox = new FirefoxOptions();
                                INSTANCE = new RemoteWebDriver(new Uri(hubURL), firefox.ToCapabilities());
                                INSTANCE.Manage().Window.Maximize();
                                break;

                            case ("chrome"):
                                ChromeOptions chrome = new ChromeOptions();
                                INSTANCE = new RemoteWebDriver(new Uri(hubURL), chrome.ToCapabilities());
                                INSTANCE.Manage().Window.Maximize();
                                break;

                            case ("opera"):
                                OperaOptions opera = new OperaOptions(); 
                                opera.BinaryLocation = "@" + ConfigurationManager.AppSettings["PathOperaExe"].ToString();
                                INSTANCE = new RemoteWebDriver(new Uri(hubURL), opera.ToCapabilities());
                                INSTANCE.Manage().Window.Maximize();
                                break;

                            case ("edge"):
                                EdgeOptions edge = new EdgeOptions();
                                INSTANCE = new RemoteWebDriver(new Uri(hubURL), edge.ToCapabilities());
                                INSTANCE.Manage().Window.Maximize();
                                break;

                            default:
                                throw new NotImplementedException();
                        }
                        break;
                }

            }
        }

        public static void QuitInstace()
        {
            INSTANCE.Quit();
            INSTANCE = null;
        }
        
        public static string getPath()
        {
            String path = (Path.GetDirectoryName(Path.GetDirectoryName(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase))) + @"\Logs\Relatorios");
            //retirando lixo file:\
            path = path.Remove(0, 6);
            return path;
        }


    }
}
