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
    class GerenciarMarcadoresTests : TestBase
    {
        [Test]
        public void CriarMarcadores()
        {
            LoginFlows loginFlows = new LoginFlows();
            GerenciarMarcadoresPageObjects gerenciarMarcadoresPageObjects = new GerenciarMarcadoresPageObjects();

            string nomeMarcador = "ProjetoB2";
            string descricaoMarcador = "Marcador para Projeto";

            loginFlows.EfetuarLoginComUsuarioDefault();

            gerenciarMarcadoresPageObjects.ClicarGerenciar();
            gerenciarMarcadoresPageObjects.ClicarGerrenciarMarcador();
            gerenciarMarcadoresPageObjects.PreencherNomeMarcador(nomeMarcador);
            gerenciarMarcadoresPageObjects.PreencherDescricaoMarcador(descricaoMarcador);
            gerenciarMarcadoresPageObjects.CriarMarcador();

            Assert.IsTrue(gerenciarMarcadoresPageObjects.RetornaSeProjetoCriado());

        }

        [Test]
        public void CriarMarcadorFalhaCampoNome()
        {
            LoginFlows loginFlows = new LoginFlows();
            GerenciarMarcadoresPageObjects gerenciarMarcadoresPageObjects = new GerenciarMarcadoresPageObjects();

            string descricaoMarcador = "Marcador para Projeto Falha";
            string nome = "";

            loginFlows.EfetuarLoginComUsuarioDefault();

            gerenciarMarcadoresPageObjects.ClicarGerenciar();
            gerenciarMarcadoresPageObjects.ClicarGerrenciarMarcador();
            gerenciarMarcadoresPageObjects.PreencherDescricaoMarcador(descricaoMarcador);
            gerenciarMarcadoresPageObjects.CriarMarcador();

            Assert.IsTrue(gerenciarMarcadoresPageObjects.RetornaSeCampoNomeFalha(nome));

        }

        [Test]
        public void EditarMarcador()
        {
            LoginFlows loginFlows = new LoginFlows();
            GerenciarMarcadoresPageObjects gerenciarMarcadoresPageObjects = new GerenciarMarcadoresPageObjects();

            string descricao = "-Edit";
            string descricaoMarcador = "Marcador para Projeto-Edit";

            loginFlows.EfetuarLoginComUsuarioDefault();

            gerenciarMarcadoresPageObjects.ClicarGerenciar();
            gerenciarMarcadoresPageObjects.ClicarGerrenciarMarcador();
            gerenciarMarcadoresPageObjects.ClicarProjetoCriado();
            gerenciarMarcadoresPageObjects.ClicarAtualizarMarcador();
            gerenciarMarcadoresPageObjects.PreencherDescricaoMarcador(descricao);


            Assert.IsTrue(gerenciarMarcadoresPageObjects.RetornaCampoDescricaoMarcadorEditado(descricaoMarcador));

        }
        

        [Test]
        public void ApagarMarcador() 
        {
            LoginFlows loginFlows = new LoginFlows();
            GerenciarMarcadoresPageObjects gerenciarMarcadoresPageObjects = new GerenciarMarcadoresPageObjects();

            loginFlows.EfetuarLoginComUsuarioDefault();

            gerenciarMarcadoresPageObjects.ClicarGerenciar();
            gerenciarMarcadoresPageObjects.ClicarGerrenciarMarcador();
            gerenciarMarcadoresPageObjects.ClicarProjetoCriado();
            gerenciarMarcadoresPageObjects.ClicarApagarMarcador();

            //Falta Validar

        }
    }
}
