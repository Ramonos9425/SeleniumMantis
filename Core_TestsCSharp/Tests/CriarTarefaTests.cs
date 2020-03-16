using Core_TestsCSharp.Bases;
using Core_TestsCSharp.Flows;
using Core_TestsCSharp.Helpers;
using Core_TestsCSharp.Pages;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_TestsCSharp.Tests
{
    class CriarTarefaTests : TestBase
    {
        [Test]
        public void CriarTarefa() //Ficar esperto que quando cria um projeto pela primeira vez e vai criar uma Tarefa ele aparece outra tela antes
        {
            
            CriarProjetoFlows criarProjetoFlows = new CriarProjetoFlows();
            LoginFlows loginFlows = new LoginFlows();
            CriarTarefaPageObjects criarTarefaPageObjects = new CriarTarefaPageObjects();
            EditarProjetoTests editarProjetoTests = new EditarProjetoTests();

            string categoria = "[Todos os Projetos] General";
            string resumo = "Botão de scroll indevido";
            string descricao = "Este botão não deveria aparecer na tela.";


            loginFlows.EfetuarLoginComUsuarioDefault();
            criarProjetoFlows.CriarProjetoDefault();

            criarTarefaPageObjects.ClicarCriarTarefa();
            criarTarefaPageObjects.ClicarSelecionarProjeto();
            criarTarefaPageObjects.SelecionarCategoria(categoria);
            criarTarefaPageObjects.PreencherResumo(resumo);
            criarTarefaPageObjects.PreencherDescricao(descricao);
            criarTarefaPageObjects.ClicarCriarNovaTarefa();

            //Assert.IsTrue(criarTarefaPageObjects.RetornaSeTarefaCriadaCampoDescricao(descricao));
            Assert.AreEqual(descricao, criarTarefaPageObjects.RetornaSeTarefaCriadaCampoDescricao2());
        }

        [Test]
        public void CriarTarefaFalhaCampoResumo()
        {
            CriarProjetoFlows criarProjetoFlows = new CriarProjetoFlows();
            LoginFlows loginFlows = new LoginFlows();
            CriarTarefaPageObjects criarTarefaPageObjects = new CriarTarefaPageObjects();

            string descricao = "Este botão não deveria aparecer na tela.";
            string resumo = "";

            loginFlows.EfetuarLoginComUsuarioDefault();
            criarProjetoFlows.CriarProjetoDefault();

            criarTarefaPageObjects.ClicarCriarTarefa();
           criarTarefaPageObjects.ClicarSelecionarProjeto();
            criarTarefaPageObjects.PreencherDescricao(descricao);
            criarTarefaPageObjects.ClicarCriarNovaTarefa();

            //Assert.IsTrue(criarTarefaPageObjects.RetornaSeTarefaCriadaCampoResumo(resumo));
            Assert.AreEqual(resumo, criarTarefaPageObjects.RetornaSeTarefaCriadaCampoResumo2());
        }

        [Test]
        public void CriarTarefaFalhaCampoDescricao()
        {
            CriarProjetoFlows criarProjetoFlows = new CriarProjetoFlows();
            LoginFlows loginFlows = new LoginFlows();
            CriarTarefaPageObjects criarTarefaPageObjects = new CriarTarefaPageObjects();

            string resumo = "Botão de scroll indevido";
            string descricao = "";

            loginFlows.EfetuarLoginComUsuarioDefault();
            criarProjetoFlows.CriarProjetoDefault();

            criarTarefaPageObjects.ClicarCriarTarefa();
           criarTarefaPageObjects.ClicarSelecionarProjeto();
            criarTarefaPageObjects.PreencherResumo(resumo);
            criarTarefaPageObjects.ClicarCriarNovaTarefa();

            //Assert.IsTrue(criarTarefaPageObjects.RetornaSeTarefaCriadaCampoDescricao(descricao));
            Assert.AreEqual(descricao, criarTarefaPageObjects.RetornaSeTarefaCriadaCampoDescricao2());
        }

        [TestCaseSource("InsercaoIssues")]
        public void Issue_Data_Driven(string categoria, string frequencia, string gravidade, string prioridade, string resumo, string descricao)
        {
            LoginFlows loginFlows = new LoginFlows();
            CriarTarefaPageObjects criarTarefaPageObjects = new CriarTarefaPageObjects();


            loginFlows.EfetuarLoginComUsuarioDefault();
            criarTarefaPageObjects.CriarTarefaDataDriven(categoria, frequencia, gravidade, prioridade, resumo, descricao);

        }

        public static List<TestCaseData> InsercaoIssues
        {

            get
            {
                DataDriven datadriven = new DataDriven();
                var testCases = datadriven.DataDrivenImplement();
                return testCases;
            }
        }


    }
}
