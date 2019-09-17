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
                ChromeOptions chromeOptions = new ChromeOptions();
                FirefoxOptions firefoxOptions = new FirefoxOptions();
                OperaOptions operaOptions = new OperaOptions();
                InternetExplorerOptions internetExplorerOptions = new InternetExplorerOptions();
                
                //chromeOptions.AddArguments("headless");
               // chromeOptions.AddArgument("start-maximized"); // open Browser in maximized mode
               // chromeOptions.AddArgument("disable-infobars"); // disabling infobars
               // chromeOptions.AddArgument("--disable-extensions"); // disabling extensions
                //chromeOptions.AddArgument("--disable-gpu"); // applicable to windows os only
                //chromeOptions.AddArgument("--disable-dev-shm-usage"); // overcome limited resource problems
                //chromeOptions.AddArgument("--no-sandbox"); // Bypass OS security model
                //INSTANCE = new ChromeDriver(chromeOptions); //usar este para chrome dentro do projeto
                                                            // INSTANCE.Manage().Window.Maximize();

                switch (local)
                {
                    case ("true"): //Execução Local
                        INSTANCE = new ChromeDriver(chromeOptions);
                        INSTANCE.Manage().Window.Maximize();
                        break;

                    case ("false"): //Execução Grid
                        switch (navegador)
                        {
                            case ("firefox"):
                                FirefoxOptions firefox = new FirefoxOptions();
                                INSTANCE = new RemoteWebDriver(new Uri(hubURL), firefoxOptions.ToCapabilities());
                                INSTANCE.Manage().Window.Maximize();
                                break;

                            case ("chrome"):
                                ChromeOptions chrome = new ChromeOptions();
                                INSTANCE = new RemoteWebDriver(new Uri(hubURL), chrome.ToCapabilities());
                                INSTANCE.Manage().Window.Maximize();
                                break;

                            case ("opera"):
                                OperaOptions opera = new OperaOptions();
                                opera.BinaryLocation = "@" + ConfigurationManager.AppSettings["PatchOperaExe"].ToString();
                                INSTANCE = new RemoteWebDriver(new Uri(hubURL), opera.ToCapabilities());
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
