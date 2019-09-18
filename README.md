# Configuração Automação - Mantis
O seguinte projeto tem como objetivo praticar a automação em linguagem C#. O sistema a ser automatizado foi o Mantis Bug Tracker.

# Projeto Mantis
- Preparação do Ambiente

- 50 Casos de teste 

- Data Driven

- SeleniumGrid

# Ferramenas

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

