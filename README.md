# Configuração Automação - Mantis
O seguinte projeto tem como objetivo praticar a automação em linguagem C#. O sistema a ser automatizado foi o Mantis Bug Tracker.

# Projeto Mantis
- Preparação do Ambiente

- 50 Casos de teste 

- Data Driven

- SeleniumGrid

# Ferramentas

- Visual Studio Professional 2019 (Instalar UnitTestAdaptor, Nunit e Selenium)
- ChromeDriver
- FirefoxDriver (gecko)
- OperaDriver
- Selenium Server
- NUnit Test Adapter 
	```Tools -> Extensions And Updates -> Online -> Search for "Nunit Test Adapter" -> Click on "NUnit Test Adapter" in results list -> Click on Download button ```
- Xampp para startar o Apache e o MySql para uso do Mantis
	Baixar o Xampp em (https://www.apachefriends.org/pt_br/download.html)
	Baixar o Mantis em (https://www.mantisbt.org/download.php) - Versão utilizada foi a 2.22.0 e copiar para a pasta htdocs dentro do diretório do Mantis. Dúvidas de instalação no link (https://www.youtube.com/watch?v=eCA5K7Zx804&t=87s)

# Classes Criadas

| Classe | Função |
| ------ | ------ |
| Tests | Classe que herda valores da TestBase e executa as suites de testes |
| PageObjects | Classe que herda da PageBase responsável pelo mapeamento dos elementos da tela e seus métodos|
| DataDriven | Classe responsável por implementar o DDT |
| Flows | Agrupa métodos em comuns |
| DriverFactory | Responsável por qual navegador sera realizado a automação e Selenium Grid |
| PageBase | Responsável pela por conter funções relacionadas às ações da página (click, selecionar combobox) |

# Page Objects
Padrão de Projeto onde temos manipulação de Objetos através de Elementos da Tabela mapeados como IWebElement, classes genéricas e métodos genéricos.
![alt text](https://i.imgur.com/Y6Lxiuc.png)

# Data Driven Testing
O Data-driven é uma estrutura de automação de testes que armazena dados de teste em uma tabela ou no formato de planilha distribuída.
O endereço da tabela deve ser mudado

# Configuração Selenium Grid
O Selenium-Grid permite que você execute seus testes em diferentes máquinas em diferentes navegadores em paralelo. Ou seja, executando vários testes ao mesmo tempo em diferentes máquinas executando diferentes navegadores e sistemas operacionais. 

Baixar o arquivo do selenium server
```sh
https://www.seleniumhq.org/download/
```
Colocar o Jar em C: e abrir o CMD na pasta (Shift+Botão Direito)

Executar o comando via CMD
```sh
 java -jar seleniumserver.jar -role hub
 ```
Caso a porta esteja ocupada use:
```sh
 java -jar seleniumserver.jar -port 4445 -role hub
```
Acessar o servidor via navegador e verificar se o HUB está conectado
```sh
Link http://localhost:4444/grid/console
```

- Cadastro de nó

```sh
java -jar seleniumserver.jar -role webdriver -hub https://IPHUB:PORTA/grid/register
```

Configurando o Selenium GRID - HUB com arquivo JSON (O arquivo deve estar na pasta que irá executar o comando)
```sh
java -jar "seleniumserver.jar" -port 4444 -role hub -hubConfig HubConfig.json
```
Conteúdo Arquivo HUBConfig.JSON
```sh
{
	  "port": 4444,
	  "newSessionWaitTimeout": -1,
	  "servlets" : [],
	  "withoutServlets": [],
	  "custom": {},
	  "capabilityMatcher": "org.openqa.grid.internal.utils.DefaultCapabilityMatcher",
	  "registryClass": "org.openqa.grid.internal.DefaultGridRegistry",
	  "throwOnCapabilityNotPresent": true,
	  "cleanUpCycle": 5000,
	  "role": "hub",
	  "debug": false,
	  "browserTimeout": 0,
	  "timeout": 1800
}
```
Configurando o Selenium GRID - Nó com arquivo JSON (O arquivo deve estar na pasta que irá executar o comando)
```sh
java -Dwebdriver.chrome.driver="chromedriver.exe" -Dwebdriver.ie.driver="IEDriverServer.exe" -Dwebdriver.opera.driver="operadriver.exe" -Dwebdriver.gecko.driver="geckodriver.exe" -jar seleniumserver.jar -role node -nodeConfig NodeDefaultConfig.json 
```
Conteúdo Arquivo NodeDeafultConfig.JSON (JUNIT 3 acima)
```sh
{
  "capabilities":
  [
    {
      "browserName": "firefox",
      "marionette": true,
      "maxInstances": 5,
      "seleniumProtocol": "WebDriver"
    },
     {
      "browserName": "internet explorer",
      "marionette": true,
      "maxInstances": 5,
      "seleniumProtocol": "WebDriver"
    },
    {
      "browserName": "chrome",
      "maxInstances": 5,
      "seleniumProtocol": "WebDriver"
    }
  ],
  "proxy": "org.openqa.grid.selenium.proxy.DefaultRemoteProxy",
  "maxSession": 5,
  "port": -1,
  "register": true,
  "registerCycle": 5000,
  "hub": "http://localhost:4444",
  "nodeStatusCheckTimeout": 5000,
  "nodePolling": 5000,
  "role": "node",
  "unregisterIfStillDownAfter": 60000,
  "downPollingLimit": 2,
  "debug": false,
  "servlets" : [],
  "withoutServlets": [],
  "custom": {},
  "browserTimeout": 0,
  "timeout": 1800
}
```
É altamente sugerido a criação de .bat para inicialização do Nó e do HUB.

CONTEUDO_NO.BAT
```sh
cd C:\chromedriver 
java -Dwebdriver.chrome.driver="chromedriver.exe" -Dwebdriver.ie.driver="IEDriverServer.exe" -Dwebdriver.opera.driver="operadriver.exe" -Dwebdriver.gecko.driver="geckodriver.exe" -jar seleniumserver.jar -role node -nodeConfig NodeDefaultConfig.json 
```
CONTEUDO_HUB.BAT
```sh
cd C:\chromedriver 
java -jar seleniumserver.jar -role hub -hubConfig HubConfig.json
```
# Configuração do WebDriver com o RemoteWebDriver 
Configurar via AppConfig a key responsável pelo NavegadorDefault e IpHub.
```
[SetUp]
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
```
Agradecimentos: [Saymon Oliveira e Saymon Oliveira]
