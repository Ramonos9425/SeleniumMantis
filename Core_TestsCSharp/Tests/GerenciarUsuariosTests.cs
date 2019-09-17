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
    class GerenciarUsuariosTests : TestBase
    {

        [Test]
        public void CriarUsuarioRelator()
        {
            LoginFlows loginFlows = new LoginFlows();
            GerenciarUsuariosPageObjects gerenciarUsuariosPageObjects = new GerenciarUsuariosPageObjects();

            loginFlows.EfetuarLoginComUsuarioDefault();
            Assert.IsTrue(gerenciarUsuariosPageObjects.CriarUsuarioRelator());
        }

        [Test]
        public void CriarUsuarioVisualizador()
        {
            LoginFlows loginFlows = new LoginFlows();
            GerenciarUsuariosPageObjects gerenciarUsuariosPageObjects = new GerenciarUsuariosPageObjects();

            loginFlows.EfetuarLoginComUsuarioDefault();
            Assert.IsTrue(gerenciarUsuariosPageObjects.CriarUsuarioVisualizador());
        }

        [Test]
        public void CriarUsuarioAtualizador()
        {
            LoginFlows loginFlows = new LoginFlows();
            GerenciarUsuariosPageObjects gerenciarUsuariosPageObjects = new GerenciarUsuariosPageObjects();

            loginFlows.EfetuarLoginComUsuarioDefault();
            Assert.IsTrue(gerenciarUsuariosPageObjects.CriarUsuarioAtualizador());
        }

        [Test]
        public void CriarUsuarioDesenvolvedor()
        {
            LoginFlows loginFlows = new LoginFlows();
            GerenciarUsuariosPageObjects gerenciarUsuariosPageObjects = new GerenciarUsuariosPageObjects();

            loginFlows.EfetuarLoginComUsuarioDefault();
            Assert.IsTrue(gerenciarUsuariosPageObjects.CriarUsuarioDesenvolvedor());
        }

        [Test]
        public void CriarUsuarioGerente()
        {
            LoginFlows loginFlows = new LoginFlows();
            GerenciarUsuariosPageObjects gerenciarUsuariosPageObjects = new GerenciarUsuariosPageObjects();

            loginFlows.EfetuarLoginComUsuarioDefault();
            Assert.IsTrue(gerenciarUsuariosPageObjects.CriarUsuarioGerente());
        }

        [Test]
        public void CriarUsuarioAdministrador()
        {
            LoginFlows loginFlows = new LoginFlows();
            GerenciarUsuariosPageObjects gerenciarUsuariosPageObjects = new GerenciarUsuariosPageObjects();

            loginFlows.EfetuarLoginComUsuarioDefault();
            Assert.IsTrue(gerenciarUsuariosPageObjects.CriarUsuarioAdministrador());
        }

        [Test]
        public void CriarUsuarioAdministradorExistente()
        {
            LoginFlows loginFlows = new LoginFlows();
            GerenciarUsuariosPageObjects gerenciarUsuariosPageObjects = new GerenciarUsuariosPageObjects();

            loginFlows.EfetuarLoginComUsuarioDefault();
            Assert.IsTrue(gerenciarUsuariosPageObjects.CriarUsuarioAdministradorExistente());
        }

        [Test]
        public void CriarUsuarioFalhaEmail()
        {
            LoginFlows loginFlows = new LoginFlows();
            GerenciarUsuariosPageObjects gerenciarUsuariosPageObjects = new GerenciarUsuariosPageObjects();

            loginFlows.EfetuarLoginComUsuarioDefault();
            Assert.IsTrue(gerenciarUsuariosPageObjects.CriarUsuarioFalhaEmail());
        }

        [Test]
        public void RepresentarUsuario() //Deu ruim, ter que debugar dps
        {
            LoginFlows loginFlows = new LoginFlows();
            GerenciarUsuariosPageObjects gerenciarUsuariosPageObjects = new GerenciarUsuariosPageObjects();

            loginFlows.EfetuarLoginComUsuarioDefault();
            Assert.IsTrue(gerenciarUsuariosPageObjects.RepresentarUsuario());
        }

        [Test]
        public void ApagarUsuario() //Deu ruim, ter que debugar dps
        {
            LoginFlows loginFlows = new LoginFlows();
            GerenciarUsuariosPageObjects gerenciarUsuariosPageObjects = new GerenciarUsuariosPageObjects();

            loginFlows.EfetuarLoginComUsuarioDefault();
            Assert.IsTrue(gerenciarUsuariosPageObjects.ApagarUsuario());
        }

        [Test]
        public void FiltroUsuario() //Deu ruim, ter que debugar dps
        {
            LoginFlows loginFlows = new LoginFlows();
            GerenciarUsuariosPageObjects gerenciarUsuariosPageObjects = new GerenciarUsuariosPageObjects();

            loginFlows.EfetuarLoginComUsuarioDefault();
            Assert.IsTrue(gerenciarUsuariosPageObjects.FiltroUsuario());
        }

        [Test]
        public void DesabilitarUsuario() //Deu ruim, ter que debugar dps
        {
            LoginFlows loginFlows = new LoginFlows();
            GerenciarUsuariosPageObjects gerenciarUsuariosPageObjects = new GerenciarUsuariosPageObjects();

            loginFlows.EfetuarLoginComUsuarioDefault();
            gerenciarUsuariosPageObjects.DesabilitarUsuario();
        }

        [Test]
        public void FiltroUsuarioDesabilitado() 
        {
            LoginFlows loginFlows = new LoginFlows();
            GerenciarUsuariosPageObjects gerenciarUsuariosPageObjects = new GerenciarUsuariosPageObjects();

            loginFlows.EfetuarLoginComUsuarioDefault();
            Assert.IsTrue(gerenciarUsuariosPageObjects.FiltroUsuarioDesabilitado());
        }

        [Test]
        public void AtribuirPorjetoUsuario() 
        {
            LoginFlows loginFlows = new LoginFlows();
            GerenciarUsuariosPageObjects gerenciarUsuariosPageObjects = new GerenciarUsuariosPageObjects();

            loginFlows.EfetuarLoginComUsuarioDefault();
            Assert.IsTrue(gerenciarUsuariosPageObjects.AtribuirPorjetoUsuario("Projeto Base2 Desenvolvimento [gerente] (público)"));
        }

        [Test]
        public void RemoverPorjetoUsuario()
        {
            LoginFlows loginFlows = new LoginFlows();
            GerenciarUsuariosPageObjects gerenciarUsuariosPageObjects = new GerenciarUsuariosPageObjects();

            loginFlows.EfetuarLoginComUsuarioDefault();
            Assert.IsTrue(gerenciarUsuariosPageObjects.RemoverPorjetoUsuario(""));
        }
        

    }
}
