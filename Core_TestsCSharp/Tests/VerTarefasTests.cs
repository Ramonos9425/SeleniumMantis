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
    class VerTarefasTests : TestBase
    {

        [Test]
        public void AtribuirTarefa()
        {
            LoginFlows loginFlows = new LoginFlows();
            VerTarefasPageObjects verTarefasPageObjects = new VerTarefasPageObjects();
            CriarTarefaFlows criarTarefaFlows = new CriarTarefaFlows();
            CriarProjetoFlows criarProjetoFlows = new CriarProjetoFlows();
            EditarProjetoPageObjects editarProjetoPageObjects = new EditarProjetoPageObjects();
            CriarProjetoeTarefaDefaultFlows criarProjetoeTarefaDefaultFlows = new CriarProjetoeTarefaDefaultFlows();

            string atribuir = "administrator";

            loginFlows.EfetuarLoginComUsuarioDefault();
            //criarProjetoFlows.CriarProjetoDefault();
            // criarTarefaFlows.CriarTarefaDefault();
            criarProjetoeTarefaDefaultFlows.CriarProjetoeTarefaDefault();

           // verTarefasPageObjects.ClicarVerTarefas();
           // verTarefasPageObjects.ClicarAcessarTarefa();
            //verTarefasPageObjects.SelecionarAtribuir(atribuir);
            //verTarefasPageObjects.ClicarAtribuir();

            //Assert.IsTrue(verTarefasPageObjects.RetornaSeAtribuido(atribuir));
           // editarProjetoPageObjects.ExcluirProjeto();
            
        }

        [Test]
        public void AlterarStatusConfirmado()
        {
            LoginFlows loginFlows = new LoginFlows();
            VerTarefasPageObjects verTarefasPageObjects = new VerTarefasPageObjects();

            loginFlows.EfetuarLoginComUsuarioDefault();
            Assert.IsTrue(verTarefasPageObjects.AlterarStatusConfirmado("confirmado"));
        }

        [Test]
        public void AlterarStatusAdmitido()
        {
            LoginFlows loginFlows = new LoginFlows();
            VerTarefasPageObjects verTarefasPageObjects = new VerTarefasPageObjects();

            loginFlows.EfetuarLoginComUsuarioDefault();
            Assert.IsTrue(verTarefasPageObjects.AlterarStatusAdmitido("admitido"));
        }

        [Test]
        public void AlterarStatusRetorno()
        {
            LoginFlows loginFlows = new LoginFlows();
            VerTarefasPageObjects verTarefasPageObjects = new VerTarefasPageObjects();

            loginFlows.EfetuarLoginComUsuarioDefault();
            Assert.IsTrue(verTarefasPageObjects.AlterarStatusRetorno("retorno"));
        }

        [Test]
        public void AlterarStatusAtribuido()
        {
            LoginFlows loginFlows = new LoginFlows();
            VerTarefasPageObjects verTarefasPageObjects = new VerTarefasPageObjects();

            loginFlows.EfetuarLoginComUsuarioDefault();
            Assert.IsTrue(verTarefasPageObjects.AlterarStatusAtribuido("atribuído"));
        }

        [Test]
        public void AlterarStatusResolvido()
        {
            LoginFlows loginFlows = new LoginFlows();
            VerTarefasPageObjects verTarefasPageObjects = new VerTarefasPageObjects();

            loginFlows.EfetuarLoginComUsuarioDefault();
            Assert.IsTrue(verTarefasPageObjects.AlterarStatusResolvido("resolvido"));
        }

        [Test]
        public void AlterarStatusFechado()
        {
            LoginFlows loginFlows = new LoginFlows();
            VerTarefasPageObjects verTarefasPageObjects = new VerTarefasPageObjects();

            loginFlows.EfetuarLoginComUsuarioDefault();
            Assert.IsTrue(verTarefasPageObjects.AlterarStatusFechado("fechado"));
        }

        [Test]
        public void AplicarMarcadores()
        {
            LoginFlows loginFlows = new LoginFlows();
            VerTarefasPageObjects verTarefasPageObjects = new VerTarefasPageObjects();

            loginFlows.EfetuarLoginComUsuarioDefault();
            Assert.IsTrue(verTarefasPageObjects.AplicarMarcadores());

        }

        [Test]
        public void CriarClone()
        {
            LoginFlows loginFlows = new LoginFlows();
            VerTarefasPageObjects verTarefasPageObjects = new VerTarefasPageObjects();

            loginFlows.EfetuarLoginComUsuarioDefault();
            Assert.IsTrue(verTarefasPageObjects.CriarClone("Este botão não deveria aparecer na tela."));

        }

        [Test]
        public void FecharTarefa()
        {
            LoginFlows loginFlows = new LoginFlows();
            VerTarefasPageObjects verTarefasPageObjects = new VerTarefasPageObjects();

            loginFlows.EfetuarLoginComUsuarioDefault();
            Assert.IsTrue(verTarefasPageObjects.FecharTarefa("fechado"));
        }

        [Test]
        public void ReabrirTarefa()
        {
            LoginFlows loginFlows = new LoginFlows();
            VerTarefasPageObjects verTarefasPageObjects = new VerTarefasPageObjects();

            loginFlows.EfetuarLoginComUsuarioDefault();
            Assert.IsTrue(verTarefasPageObjects.ReabrirTarefa("retorno"));

        }

        [Test]
        public void ApagarTarefa()
        {
            LoginFlows loginFlows = new LoginFlows();
            VerTarefasPageObjects verTarefasPageObjects = new VerTarefasPageObjects();

            loginFlows.EfetuarLoginComUsuarioDefault();
            verTarefasPageObjects.ApagarTarefa();
        }
    }
}
