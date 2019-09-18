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

            string atribuir = "administrator";

            loginFlows.EfetuarLoginComUsuarioDefault();

            criarProjetoFlows.CriarProjetoDefault();
            criarTarefaFlows.CriarTarefaDefault();

            verTarefasPageObjects.ClicarVerTarefas();
            verTarefasPageObjects.ClicarAcessarTarefa();
            verTarefasPageObjects.SelecionarAtribuir(atribuir);
            verTarefasPageObjects.ClicarAtribuir();

            Assert.IsTrue(verTarefasPageObjects.RetornaSeAtribuido(atribuir));         
        }

        [Test]
        public void AlterarStatusConfirmado()
        {
            LoginFlows loginFlows = new LoginFlows();
            VerTarefasPageObjects verTarefasPageObjects = new VerTarefasPageObjects();

            string status = "confirmado";

            loginFlows.EfetuarLoginComUsuarioDefault();

            verTarefasPageObjects.ClicarVerTarefas();
            verTarefasPageObjects.ClicarAcessarTarefa();
            verTarefasPageObjects.SelecionarAlterarStatus(status);
            verTarefasPageObjects.ClicarAlterarStatus();
            verTarefasPageObjects.ClicarConfirmarTarefa();

            Assert.IsTrue(verTarefasPageObjects.RetornaEstadoStatus(status));
        }

        [Test]
        public void AlterarStatusAdmitido()
        {
            LoginFlows loginFlows = new LoginFlows();
            VerTarefasPageObjects verTarefasPageObjects = new VerTarefasPageObjects();

            string status = "admitido";

            loginFlows.EfetuarLoginComUsuarioDefault(); 

            verTarefasPageObjects.ClicarVerTarefas();
            verTarefasPageObjects.ClicarAcessarTarefa();
            verTarefasPageObjects.SelecionarAlterarStatus(status);
            verTarefasPageObjects.ClicarAlterarStatus();
            verTarefasPageObjects.ClicarAdmitirTarefa();

            Assert.IsTrue(verTarefasPageObjects.RetornaEstadoStatus(status));
        }

        [Test]
        public void AlterarStatusRetorno()
        {
            LoginFlows loginFlows = new LoginFlows();
            VerTarefasPageObjects verTarefasPageObjects = new VerTarefasPageObjects();

            string status = "retorno";

            loginFlows.EfetuarLoginComUsuarioDefault();

            verTarefasPageObjects.ClicarVerTarefas();
            verTarefasPageObjects.ClicarAcessarTarefa();
            verTarefasPageObjects.SelecionarAlterarStatus(status);
            verTarefasPageObjects.ClicarAlterarStatus();
            verTarefasPageObjects.ClicarSolicitaRetornoTarefa();

            Assert.IsTrue(verTarefasPageObjects.RetornaEstadoStatus(status));
        }

        [Test]
        public void AlterarStatusAtribuido()
        {
            LoginFlows loginFlows = new LoginFlows();
            VerTarefasPageObjects verTarefasPageObjects = new VerTarefasPageObjects();

            string status = "atribuído";

            loginFlows.EfetuarLoginComUsuarioDefault();

            verTarefasPageObjects.ClicarVerTarefas();
            verTarefasPageObjects.ClicarAcessarTarefa();
            verTarefasPageObjects.SelecionarAlterarStatus(status);
            verTarefasPageObjects.ClicarAlterarStatus();
            verTarefasPageObjects.ClicarAtribuirTarefa();

            Assert.IsTrue(verTarefasPageObjects.RetornaEstadoStatus(status));
        }

        [Test]
        public void AlterarStatusResolvido()
        {
            LoginFlows loginFlows = new LoginFlows();
            VerTarefasPageObjects verTarefasPageObjects = new VerTarefasPageObjects();

            string status = "resolvido";

            loginFlows.EfetuarLoginComUsuarioDefault();

            verTarefasPageObjects.ClicarVerTarefas();
            verTarefasPageObjects.ClicarAcessarTarefa();
            verTarefasPageObjects.SelecionarAlterarStatus(status);
            verTarefasPageObjects.ClicarAlterarStatus();
            verTarefasPageObjects.ClicarResolverTarefa();

            Assert.IsTrue(verTarefasPageObjects.RetornaEstadoStatus(status));
        }

        [Test]
        public void AlterarStatusFechado()
        {
            LoginFlows loginFlows = new LoginFlows();
            VerTarefasPageObjects verTarefasPageObjects = new VerTarefasPageObjects();

            string status = "fechado";

            loginFlows.EfetuarLoginComUsuarioDefault();

            verTarefasPageObjects.ClicarVerTarefas();
            verTarefasPageObjects.ClicarAcessarTarefa();
            verTarefasPageObjects.SelecionarAlterarStatus(status);
            verTarefasPageObjects.ClicarAlterarStatus();
            verTarefasPageObjects.ClicarFecharTarefa();

            Assert.IsTrue(verTarefasPageObjects.RetornaEstadoStatus(status));
        }

        [Test]
        public void AplicarMarcadores()
        {
            LoginFlows loginFlows = new LoginFlows();
            VerTarefasPageObjects verTarefasPageObjects = new VerTarefasPageObjects();

            string marcador = "PB2";

            loginFlows.EfetuarLoginComUsuarioDefault();

            verTarefasPageObjects.ClicarVerTarefas();
            verTarefasPageObjects.ClicarAcessarTarefa();
            verTarefasPageObjects.SelecionarAplicarMarcadores(marcador);
            verTarefasPageObjects.ClicarAplicarMarcador();

            Assert.IsTrue(verTarefasPageObjects.RetornaMarcador());

        }

        [Test]
        public void CriarClone()
        {
            LoginFlows loginFlows = new LoginFlows();
            VerTarefasPageObjects verTarefasPageObjects = new VerTarefasPageObjects();

            string descricao = "Este botão não deveria aparecer na tela.";

            loginFlows.EfetuarLoginComUsuarioDefault();

            verTarefasPageObjects.ClicarVerTarefas();
            verTarefasPageObjects.ClicarAcessarTarefa();
            verTarefasPageObjects.ClicarCriarClone();
            verTarefasPageObjects.ClicarCriarNovaTarefa();


            Assert.IsTrue(verTarefasPageObjects.RetornaDescricao(descricao));

        }

        [Test]
        public void FecharTarefa()
        {
            LoginFlows loginFlows = new LoginFlows();
            VerTarefasPageObjects verTarefasPageObjects = new VerTarefasPageObjects();

            string estado = "fechado";

            loginFlows.EfetuarLoginComUsuarioDefault();

            verTarefasPageObjects.ClicarVerTarefas();
            verTarefasPageObjects.ClicarAcessarTarefa();
            verTarefasPageObjects.ClicarFechar();
            verTarefasPageObjects.ClicarFecharTarefa();

            Assert.IsTrue(verTarefasPageObjects.RetornaEstadoStatus(estado));
        }

        [Test]
        public void ReabrirTarefa()
        {
            LoginFlows loginFlows = new LoginFlows();
            VerTarefasPageObjects verTarefasPageObjects = new VerTarefasPageObjects();

            string estado = "retorno";

            loginFlows.EfetuarLoginComUsuarioDefault();

            verTarefasPageObjects.ClicarVerTarefas();
            verTarefasPageObjects.ClicarAcessarTarefa();
            verTarefasPageObjects.ClicarFechar();
            verTarefasPageObjects.ClicarFecharTarefa();
            verTarefasPageObjects.ClicarReabrirTarefa();
            verTarefasPageObjects.ClicarSolicitaRetorno();

            Assert.IsTrue(verTarefasPageObjects.RetornaEstadoStatus(estado));
        }

    }
}
