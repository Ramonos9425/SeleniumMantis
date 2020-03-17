using Core_TestsCSharp.Pages;
using Core_TestsCSharp.Bases;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core_TestsCSharp.Helpers;
using Core_TestsCSharp.Flows;

namespace Core_TestsCSharp.Tests
{
    class CriarProjetoTests : TestBase
    {
        [Test]
        public void CriarProjetoDesenvolvimento()
        {
            LoginFlows loginFlows = new LoginFlows();
            CriarProjetoPageObjects criarProjetoPageObjects = new CriarProjetoPageObjects();

            string nomeProjeto = "Projeto Base2 Desenvolvimento";
            string descricaoProjeto = "Projeto Base2 Parte Desenvolvimento";

            loginFlows.EfetuarLoginComUsuarioDefault();

            criarProjetoPageObjects.ClicarGerenciar();
            criarProjetoPageObjects.ClicarGerenciarProjetos();
            criarProjetoPageObjects.ClicarCriarProjeto();
            criarProjetoPageObjects.PreencherNomeProjeto(nomeProjeto);
            criarProjetoPageObjects.PreencherDescricaoProjeto(descricaoProjeto);
            criarProjetoPageObjects.ClicarAdicionarProjeto();

            Assert.IsTrue(criarProjetoPageObjects.retornaSeProjetoExiste());
        }

        [Test]
        public void CriarProjetoRelease()
        {
            LoginFlows loginFlows = new LoginFlows();
            CriarProjetoPageObjects criarProjetoPageObjects = new CriarProjetoPageObjects();

            string nomeProjeto = "Projeto Base2 Release";
            string descricaoProjeto = "Projeto Base2 Parte Release";
            string mensagemEsperada = "Projeto Base2 Release";
            string estadoProjeto = "release";

            loginFlows.EfetuarLoginComUsuarioDefault();

            criarProjetoPageObjects.ClicarGerenciar();
            criarProjetoPageObjects.ClicarGerenciarProjetos();
            criarProjetoPageObjects.ClicarCriarProjeto();
            criarProjetoPageObjects.PreencherNomeProjeto(nomeProjeto);
            criarProjetoPageObjects.SelecionarEstadoProjeto(estadoProjeto);
            criarProjetoPageObjects.PreencherDescricaoProjeto(descricaoProjeto);
            criarProjetoPageObjects.ClicarAdicionarProjeto();

            //Assert.IsTrue(criarProjetoPageObjects.retornaSeProjetoReleaseExiste("Projeto Base2 Release"));
            Assert.AreEqual(mensagemEsperada, criarProjetoPageObjects.retornaSeProjetoReleaseExiste2());
        }

        [Test]
        public void CriarProjetoEstavel()
        {
            LoginFlows loginFlows = new LoginFlows();
            CriarProjetoPageObjects criarProjetoPageObjects = new CriarProjetoPageObjects();

            string nomeProjeto = "Projeto Base2 Estavel";
            string descricaoProjeto = "Projeto Base2 Parte Estavel";
            string mensagemEsperada = "Projeto Base2 Estavel";
            string estadoProjeto = "estável";

            loginFlows.EfetuarLoginComUsuarioDefault();

            criarProjetoPageObjects.ClicarGerenciar();
            criarProjetoPageObjects.ClicarGerenciarProjetos();
            criarProjetoPageObjects.ClicarCriarProjeto();
            criarProjetoPageObjects.PreencherNomeProjeto(nomeProjeto);
            criarProjetoPageObjects.SelecionarEstadoProjeto(estadoProjeto);
            criarProjetoPageObjects.PreencherDescricaoProjeto(descricaoProjeto);
            criarProjetoPageObjects.ClicarAdicionarProjeto();

            //Assert.IsTrue(criarProjetoPageObjects.retornaSeProjetoEstavelExiste("Projeto Base2 Estavel"));
            Assert.AreEqual(mensagemEsperada, criarProjetoPageObjects.retornaSeProjetoEstavelExiste2());
        }

        [Test]
        public void CriarProjetoObsoleto()
        {
            LoginFlows loginFlows = new LoginFlows();
            CriarProjetoPageObjects criarProjetoPageObjects = new CriarProjetoPageObjects();

            string nomeProjeto = "Projeto Base2 Obsoleto";
            string descricaoProjeto = "Projeto Base2 Parte Obsoleto";
            string mensagemEsperada = "Projeto Base2 Obsoleto";
            string estadoProjeto = "obsoleto";

            loginFlows.EfetuarLoginComUsuarioDefault();

            criarProjetoPageObjects.ClicarGerenciar();
            criarProjetoPageObjects.ClicarGerenciarProjetos();
            criarProjetoPageObjects.ClicarCriarProjeto();
            criarProjetoPageObjects.PreencherNomeProjeto(nomeProjeto);
            criarProjetoPageObjects.SelecionarEstadoProjeto(estadoProjeto);
            criarProjetoPageObjects.PreencherDescricaoProjeto(descricaoProjeto);
            criarProjetoPageObjects.ClicarAdicionarProjeto();

            //Assert.IsTrue(criarProjetoPageObjects.retornaSeProjetoObsoletoExiste());
            Assert.AreEqual(mensagemEsperada, criarProjetoPageObjects.retornaSeProjetoObsoletoExiste2());
        }

        [Test]
        public void CriarProjetoObsoletoExistente()
        {
            LoginFlows loginFlows = new LoginFlows();
            CriarProjetoPageObjects criarProjetoPageObjects = new CriarProjetoPageObjects();

            string nomeProjeto = "Projeto Base2 Obsoleto";
            string estadoProjeto = "obsoleto";

            loginFlows.EfetuarLoginComUsuarioDefault();

            criarProjetoPageObjects.ClicarGerenciar();
            criarProjetoPageObjects.ClicarGerenciarProjetos();
            criarProjetoPageObjects.ClicarCriarProjeto();
            criarProjetoPageObjects.PreencherNomeProjeto(nomeProjeto);
            criarProjetoPageObjects.SelecionarEstadoProjeto(estadoProjeto);
            criarProjetoPageObjects.ClicarAdicionarProjeto();

            Assert.IsTrue(criarProjetoPageObjects.retornaSeProjetoDuplicadoFalha());
        }

        [Test]
        public void CriarProjetoFalha() //Sem o Campo Nome que e obrigatorio
        {
            LoginFlows loginFlows = new LoginFlows();
            CriarProjetoPageObjects criarProjetoPageObjects = new CriarProjetoPageObjects();

            string descricaoProjeto = "Projeto Base2 Parte Falha";

            loginFlows.EfetuarLoginComUsuarioDefault();

            criarProjetoPageObjects.ClicarGerenciar();
            criarProjetoPageObjects.ClicarGerenciarProjetos();
            criarProjetoPageObjects.ClicarCriarProjeto();
            criarProjetoPageObjects.PreencherDescricaoProjeto(descricaoProjeto);
            criarProjetoPageObjects.ClicarAdicionarProjeto();

            Assert.IsTrue(criarProjetoPageObjects.retornaCampoFalha());
        }

    }
}
