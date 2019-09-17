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
        public void CriarProjetoDesenvolvimento()//Deveria ser com Try Catch ?????????????
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

            loginFlows.EfetuarLoginComUsuarioDefault();

            criarProjetoPageObjects.ClicarGerenciar();
            criarProjetoPageObjects.ClicarGerenciarProjetos();
            criarProjetoPageObjects.ClicarCriarProjeto();
            criarProjetoPageObjects.PreencherNomeProjeto(nomeProjeto);
            criarProjetoPageObjects.SelecionarEstadoProjeto("release");
            criarProjetoPageObjects.PreencherDescricaoProjeto(descricaoProjeto);
            criarProjetoPageObjects.ClicarAdicionarProjeto();

            Assert.IsTrue(criarProjetoPageObjects.retornaSeProjetoExiste());
        }

        [Test]
        public void CriarProjetoEstavel()
        {
            LoginFlows loginFlows = new LoginFlows();
            CriarProjetoPageObjects criarProjetoPageObjects = new CriarProjetoPageObjects();

            string nomeProjeto = "Projeto Base2 Estavel";
            string descricaoProjeto = "Projeto Base2 Parte Estavel";

            loginFlows.EfetuarLoginComUsuarioDefault();

            criarProjetoPageObjects.ClicarGerenciar();
            criarProjetoPageObjects.ClicarGerenciarProjetos();
            criarProjetoPageObjects.ClicarCriarProjeto();
            criarProjetoPageObjects.PreencherNomeProjeto(nomeProjeto);
            criarProjetoPageObjects.SelecionarEstadoProjeto("estável");
            criarProjetoPageObjects.PreencherDescricaoProjeto(descricaoProjeto);
            criarProjetoPageObjects.ClicarAdicionarProjeto();

            Assert.IsTrue(criarProjetoPageObjects.retornaSeProjetoExiste());
        }

        [Test]
        public void CriarProjetoObsoleto()
        {
            LoginFlows loginFlows = new LoginFlows();
            CriarProjetoPageObjects criarProjetoPageObjects = new CriarProjetoPageObjects();

            string nomeProjeto = "Projeto Base2 Obsoleto";
            string descricaoProjeto = "Projeto Base2 Parte Obsoleto";

            loginFlows.EfetuarLoginComUsuarioDefault();

            criarProjetoPageObjects.ClicarGerenciar();
            criarProjetoPageObjects.ClicarGerenciarProjetos();
            criarProjetoPageObjects.ClicarCriarProjeto();
            criarProjetoPageObjects.PreencherNomeProjeto(nomeProjeto);
            criarProjetoPageObjects.SelecionarEstadoProjeto("obsoleto");
            criarProjetoPageObjects.PreencherDescricaoProjeto(descricaoProjeto);
            criarProjetoPageObjects.ClicarAdicionarProjeto();

            Assert.IsTrue(criarProjetoPageObjects.retornaSeProjetoExiste());
        }

        [Test]
        public void CriarProjetoObsoletoExistente()//***Validar a mensagem - Já foi
        {
            LoginFlows loginFlows = new LoginFlows();
            CriarProjetoPageObjects criarProjetoPageObjects = new CriarProjetoPageObjects();

            string nomeProjeto = "Projeto Base2 Obsoleto";

            loginFlows.EfetuarLoginComUsuarioDefault();

            criarProjetoPageObjects.ClicarGerenciar();
            criarProjetoPageObjects.ClicarGerenciarProjetos();
            criarProjetoPageObjects.ClicarCriarProjeto();
            criarProjetoPageObjects.PreencherNomeProjeto(nomeProjeto);
            criarProjetoPageObjects.SelecionarEstadoProjeto("obsoleto");
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

            // Assert.IsTrue(criarProjetoPageObjects.CriarProjetoFalha("Preencha este campo"));// Problema para pegar o texto ??????????????
            Assert.IsTrue(criarProjetoPageObjects.retornaCampoFalha());
        }

    }
}
