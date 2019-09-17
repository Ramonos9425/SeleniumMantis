using Core_TestsCSharp.Bases;
using Core_TestsCSharp.Flows;
using Core_TestsCSharp.Pages;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_TestsCSharp.Tests
{
    class GerenciarPerfisGlobaisTests : TestBase
    {
        [Test]
        public void AdicionarPerfil()
        {//***Queria pegar a mensagem dentro do combobox para validar
            LoginFlows loginFlows = new LoginFlows();
            GerenciarPerfisGlobaisPageObjects gerenciarPerfisGlobaisPageObjects = new GerenciarPerfisGlobaisPageObjects();

            string plataforma = "Plataform";
            string so = "Windows";
            string versao = "Versao1";

            loginFlows.EfetuarLoginComUsuarioDefault();

            gerenciarPerfisGlobaisPageObjects.ClicarGerenciar();
            gerenciarPerfisGlobaisPageObjects.ClicarGerenciarPerfisGlobais();
            gerenciarPerfisGlobaisPageObjects.PreencherCampoPlataforma(plataforma);
            gerenciarPerfisGlobaisPageObjects.PreencherCampoSistemaOperacional(so);
            gerenciarPerfisGlobaisPageObjects.PreencherVersao(versao);
            gerenciarPerfisGlobaisPageObjects.RetornaSeEnviarExiste();

        }

        [Test]
        public void PerfilFalhaPlataforma()
        {
            LoginFlows loginFlows = new LoginFlows();
            GerenciarPerfisGlobaisPageObjects gerenciarPerfisGlobaisPageObjects = new GerenciarPerfisGlobaisPageObjects();

            string plataforma = "";
            string so = "Windows";
            string versao = "Versao1";

            loginFlows.EfetuarLoginComUsuarioDefault();

            gerenciarPerfisGlobaisPageObjects.ClicarGerenciar();
            gerenciarPerfisGlobaisPageObjects.ClicarGerenciarPerfisGlobais();
            gerenciarPerfisGlobaisPageObjects.PreencherCampoSistemaOperacional(so);
            gerenciarPerfisGlobaisPageObjects.PreencherVersao(versao);
            gerenciarPerfisGlobaisPageObjects.ClicarAdicionarPerfil();

            Assert.IsTrue(gerenciarPerfisGlobaisPageObjects.RetornaTextoPlataforma(plataforma));
        }

        [Test]
        public void PerfilFalhaSO()
        {
            LoginFlows loginFlows = new LoginFlows();
            GerenciarPerfisGlobaisPageObjects gerenciarPerfisGlobaisPageObjects = new GerenciarPerfisGlobaisPageObjects();

            string so = "";
            string plataforma = "Plataform";
            string versao = "Versao1";

            loginFlows.EfetuarLoginComUsuarioDefault();

            gerenciarPerfisGlobaisPageObjects.ClicarGerenciar();
            gerenciarPerfisGlobaisPageObjects.ClicarGerenciarPerfisGlobais();
            gerenciarPerfisGlobaisPageObjects.PreencherCampoPlataforma(plataforma);
            gerenciarPerfisGlobaisPageObjects.PreencherVersao(versao);
            gerenciarPerfisGlobaisPageObjects.ClicarAdicionarPerfil();

            Assert.IsTrue(gerenciarPerfisGlobaisPageObjects.RetornaTextoSO(so));
        }

        [Test]
        public void PerfilFalhaVersaoSO()
        {
            LoginFlows loginFlows = new LoginFlows();
            GerenciarPerfisGlobaisPageObjects gerenciarPerfisGlobaisPageObjects = new GerenciarPerfisGlobaisPageObjects();

            string versaoSO = "";
            string plataforma = "Plataform";
            string so = "Windows";

            loginFlows.EfetuarLoginComUsuarioDefault();

            gerenciarPerfisGlobaisPageObjects.ClicarGerenciar();
            gerenciarPerfisGlobaisPageObjects.ClicarGerenciarPerfisGlobais();
            gerenciarPerfisGlobaisPageObjects.PreencherCampoPlataforma(plataforma);
            gerenciarPerfisGlobaisPageObjects.PreencherCampoSistemaOperacional(so);
            gerenciarPerfisGlobaisPageObjects.ClicarAdicionarPerfil();

            Assert.IsTrue(gerenciarPerfisGlobaisPageObjects.RetornaTextoVersoSistemaOperacional(versaoSO)); //Queria Pegar o Texto da Caixa para validar ???????
        }

        [Test]
        public void EditarPerfil()//**Arrumar o retorno
        {
            LoginFlows loginFlows = new LoginFlows();
            GerenciarPerfisGlobaisPageObjects gerenciarPerfisGlobaisPageObjects = new GerenciarPerfisGlobaisPageObjects();

            string perfil = "Plataform Windows Versao1";
            string plataforma = "-Edit";

            loginFlows.EfetuarLoginComUsuarioDefault();

            // Assert.IsTrue(gerenciarPerfisGlobaisPageObjects.PerfilFalhaVersaoSO("")); //****Queria Pegar o Texto da Caixa para validar ???????
            gerenciarPerfisGlobaisPageObjects.ClicarGerenciar();
            gerenciarPerfisGlobaisPageObjects.ClicarGerenciarPerfisGlobais();
            gerenciarPerfisGlobaisPageObjects.SelecionarPerfil(perfil);
            gerenciarPerfisGlobaisPageObjects.ClicarEnviar();
            gerenciarPerfisGlobaisPageObjects.PreencherCampoPlataforma(plataforma);
            gerenciarPerfisGlobaisPageObjects.ClicarAtualizarPerfil();

            Assert.IsTrue(gerenciarPerfisGlobaisPageObjects.RetornaSeEnviarExiste());

        }

        [Test]
        public void ApagarPerfil() //***Como Validar algo que nao existe mais ???????????
        {
            LoginFlows loginFlows = new LoginFlows();
            GerenciarPerfisGlobaisPageObjects gerenciarPerfisGlobaisPageObjects = new GerenciarPerfisGlobaisPageObjects();

            loginFlows.EfetuarLoginComUsuarioDefault();

            gerenciarPerfisGlobaisPageObjects.ClicarGerenciar();
            gerenciarPerfisGlobaisPageObjects.ClicarGerenciarPerfisGlobais();
            gerenciarPerfisGlobaisPageObjects.ClicarApagarPerfil();
            //gerenciarPerfisGlobaisPageObjects.SelecionarPerfil();
            gerenciarPerfisGlobaisPageObjects.ClicarEnviar();

            gerenciarPerfisGlobaisPageObjects.ApagarPerfil(); 
        }
    }
}
