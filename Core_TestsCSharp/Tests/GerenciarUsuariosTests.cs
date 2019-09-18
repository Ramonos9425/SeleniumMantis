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

            string nome = "Pedro";
            string nomeVerdadeiro = "Pedro Lara";
            string email = "pedrolara@hotmail.com";
            string nivelAcesso = "relator";

            loginFlows.EfetuarLoginComUsuarioDefault();

            gerenciarUsuariosPageObjects.ClicarGerenciar();
            gerenciarUsuariosPageObjects.ClicarGerenciarUsuarios();
            gerenciarUsuariosPageObjects.ClicarCriarConta();
            gerenciarUsuariosPageObjects.PreencherNomeUsuario(nome);
            gerenciarUsuariosPageObjects.PreencherNomeVerdadeiro(nomeVerdadeiro);
            gerenciarUsuariosPageObjects.PreencherEmail(email);
            gerenciarUsuariosPageObjects.SelecionarNivelAcesso(nivelAcesso);
            gerenciarUsuariosPageObjects.ClicarCriarUsuario();

            Assert.IsTrue(gerenciarUsuariosPageObjects.RetornaRepresentarUsuario());
        }

        [Test]
        public void CriarUsuarioVisualizador()
        {
            LoginFlows loginFlows = new LoginFlows();
            GerenciarUsuariosPageObjects gerenciarUsuariosPageObjects = new GerenciarUsuariosPageObjects();

            string nome = "Claudia";
            string nomeVerdadeiro = "Claudia Lara";
            string email = "claudialara@hotmail.com";
            string nivelAcesso = "visualizador";

            loginFlows.EfetuarLoginComUsuarioDefault();

            gerenciarUsuariosPageObjects.ClicarGerenciar();
            gerenciarUsuariosPageObjects.ClicarGerenciarUsuarios();
            gerenciarUsuariosPageObjects.ClicarCriarConta();
            gerenciarUsuariosPageObjects.PreencherNomeUsuario(nome);
            gerenciarUsuariosPageObjects.PreencherNomeVerdadeiro(nomeVerdadeiro);
            gerenciarUsuariosPageObjects.PreencherEmail(email);
            gerenciarUsuariosPageObjects.SelecionarNivelAcesso(nivelAcesso);
            gerenciarUsuariosPageObjects.ClicarCriarUsuario();

            Assert.IsTrue(gerenciarUsuariosPageObjects.RetornaRepresentarUsuario());
        }

        [Test]
        public void CriarUsuarioAtualizador()
        {
            LoginFlows loginFlows = new LoginFlows();
            GerenciarUsuariosPageObjects gerenciarUsuariosPageObjects = new GerenciarUsuariosPageObjects();

            string nome = "Cida";
            string nomeVerdadeiro = "Cida Lara";
            string email = "cidalara@hotmail.com";
            string nivelAcesso = "atualizador";

            loginFlows.EfetuarLoginComUsuarioDefault();

            gerenciarUsuariosPageObjects.ClicarGerenciar();
            gerenciarUsuariosPageObjects.ClicarGerenciarUsuarios();
            gerenciarUsuariosPageObjects.ClicarCriarConta();
            gerenciarUsuariosPageObjects.PreencherNomeUsuario(nome);
            gerenciarUsuariosPageObjects.PreencherNomeVerdadeiro(nomeVerdadeiro);
            gerenciarUsuariosPageObjects.PreencherEmail(email);
            gerenciarUsuariosPageObjects.SelecionarNivelAcesso(nivelAcesso);
            gerenciarUsuariosPageObjects.ClicarCriarUsuario();

            Assert.IsTrue(gerenciarUsuariosPageObjects.RetornaRepresentarUsuario());
        }

        [Test]
        public void CriarUsuarioDesenvolvedor()
        {
            LoginFlows loginFlows = new LoginFlows();
            GerenciarUsuariosPageObjects gerenciarUsuariosPageObjects = new GerenciarUsuariosPageObjects();

            string nome = "Tuane";
            string nomeVerdadeiro = "Tuane Lara";
            string email = "tuanelara@hotmail.com";
            string nivelAcesso = "desenvolvedor";

            loginFlows.EfetuarLoginComUsuarioDefault();

            gerenciarUsuariosPageObjects.ClicarGerenciar();
            gerenciarUsuariosPageObjects.ClicarGerenciarUsuarios();
            gerenciarUsuariosPageObjects.ClicarCriarConta();
            gerenciarUsuariosPageObjects.PreencherNomeUsuario(nome);
            gerenciarUsuariosPageObjects.PreencherNomeVerdadeiro(nomeVerdadeiro);
            gerenciarUsuariosPageObjects.PreencherEmail(email);
            gerenciarUsuariosPageObjects.SelecionarNivelAcesso(nivelAcesso);
            gerenciarUsuariosPageObjects.ClicarCriarUsuario();

            Assert.IsTrue(gerenciarUsuariosPageObjects.RetornaRepresentarUsuario());
        }

        [Test]
        public void CriarUsuarioGerente()
        {
            LoginFlows loginFlows = new LoginFlows();
            GerenciarUsuariosPageObjects gerenciarUsuariosPageObjects = new GerenciarUsuariosPageObjects();

            string nome = "Barbara";
            string nomeVerdadeiro = "Barbara Lara";
            string email = "barbaralara@hotmail.com";
            string nivelAcesso = "gerente";

            loginFlows.EfetuarLoginComUsuarioDefault();

            gerenciarUsuariosPageObjects.ClicarGerenciar();
            gerenciarUsuariosPageObjects.ClicarGerenciarUsuarios();
            gerenciarUsuariosPageObjects.ClicarCriarConta();
            gerenciarUsuariosPageObjects.PreencherNomeUsuario(nome);
            gerenciarUsuariosPageObjects.PreencherNomeVerdadeiro(nomeVerdadeiro);
            gerenciarUsuariosPageObjects.PreencherEmail(email);
            gerenciarUsuariosPageObjects.SelecionarNivelAcesso(nivelAcesso);
            gerenciarUsuariosPageObjects.ClicarCriarUsuario();

            Assert.IsTrue(gerenciarUsuariosPageObjects.RetornaRepresentarUsuario());
        }

        [Test]
        public void CriarUsuarioAdministrador()
        {
            LoginFlows loginFlows = new LoginFlows();
            GerenciarUsuariosPageObjects gerenciarUsuariosPageObjects = new GerenciarUsuariosPageObjects();

            string nome = "Viviane";
            string nomeVerdadeiro = "Viviane Lara";
            string email = "Viviane@hotmail.com";
            string nivelAcesso = "administrador";

            loginFlows.EfetuarLoginComUsuarioDefault();

            gerenciarUsuariosPageObjects.ClicarGerenciar();
            gerenciarUsuariosPageObjects.ClicarGerenciarUsuarios();
            gerenciarUsuariosPageObjects.ClicarCriarConta();
            gerenciarUsuariosPageObjects.PreencherNomeUsuario(nome);
            gerenciarUsuariosPageObjects.PreencherNomeVerdadeiro(nomeVerdadeiro);
            gerenciarUsuariosPageObjects.PreencherEmail(email);
            gerenciarUsuariosPageObjects.SelecionarNivelAcesso(nivelAcesso);
            gerenciarUsuariosPageObjects.ClicarCriarUsuario();

            Assert.IsTrue(gerenciarUsuariosPageObjects.RetornaRepresentarUsuario());
        }

        [Test]
        public void CriarUsuarioAdministradorExistente()
        {
            LoginFlows loginFlows = new LoginFlows();
            GerenciarUsuariosPageObjects gerenciarUsuariosPageObjects = new GerenciarUsuariosPageObjects();
            CriarUsuarioFlows criarUsuarioFlows = new CriarUsuarioFlows();

            string nome = "Viviane";
            string nivelAcesso = "administrador";

            loginFlows.EfetuarLoginComUsuarioDefault();
            criarUsuarioFlows.CriarUsuarioDefault();

            gerenciarUsuariosPageObjects.ClicarGerenciar();
            gerenciarUsuariosPageObjects.ClicarGerenciarUsuarios();
            gerenciarUsuariosPageObjects.ClicarCriarConta();
            gerenciarUsuariosPageObjects.PreencherNomeUsuario(nome);
            gerenciarUsuariosPageObjects.SelecionarNivelAcesso(nivelAcesso);
            gerenciarUsuariosPageObjects.ClicarCriarUsuario();

            Assert.IsTrue(gerenciarUsuariosPageObjects.RetornaAlertaFalha());
        }

        [Test]
        public void CriarUsuarioFalhaEmail()
        {
            LoginFlows loginFlows = new LoginFlows();
            GerenciarUsuariosPageObjects gerenciarUsuariosPageObjects = new GerenciarUsuariosPageObjects();

            string nome = "Luiza";
            string nomeVerdadeiro = "Luiza Lara";
            string email = "luizaaa";
            string nivelAcesso = "administrador";

            loginFlows.EfetuarLoginComUsuarioDefault();

            gerenciarUsuariosPageObjects.ClicarGerenciar();
            gerenciarUsuariosPageObjects.ClicarGerenciarUsuarios();
            gerenciarUsuariosPageObjects.ClicarCriarConta();
            gerenciarUsuariosPageObjects.PreencherNomeUsuario(nome);
            gerenciarUsuariosPageObjects.PreencherNomeVerdadeiro(nomeVerdadeiro);
            gerenciarUsuariosPageObjects.PreencherEmail(email);
            gerenciarUsuariosPageObjects.SelecionarNivelAcesso(nivelAcesso);
            gerenciarUsuariosPageObjects.ClicarCriarUsuario();

            Assert.IsTrue(gerenciarUsuariosPageObjects.RetornaAlertaFalha());
        }

        [Test]
        public void RepresentarUsuario() 
        {
            LoginFlows loginFlows = new LoginFlows();
            GerenciarUsuariosPageObjects gerenciarUsuariosPageObjects = new GerenciarUsuariosPageObjects();
            CriarUsuarioFlows criarUsuarioFlows = new CriarUsuarioFlows();

            loginFlows.EfetuarLoginComUsuarioDefault();
            criarUsuarioFlows.CriarUsuarioDefault();

            gerenciarUsuariosPageObjects.ClicarGerenciar();
            gerenciarUsuariosPageObjects.ClicarGerenciarUsuarios();
            gerenciarUsuariosPageObjects.ClicarUsuario();
            gerenciarUsuariosPageObjects.ClicarRepresentarUsuario();
            gerenciarUsuariosPageObjects.ClicarProsseguir();

            Assert.IsTrue(gerenciarUsuariosPageObjects.RetornaUsuarioRepresentado());
        }

        [Test]
        public void ApagarUsuario() 
        {
            LoginFlows loginFlows = new LoginFlows();
            GerenciarUsuariosPageObjects gerenciarUsuariosPageObjects = new GerenciarUsuariosPageObjects();
            CriarUsuarioFlows criarUsuarioFlows = new CriarUsuarioFlows();

            loginFlows.EfetuarLoginComUsuarioDefault();
            criarUsuarioFlows.CriarUsuarioDefault();

            gerenciarUsuariosPageObjects.ClicarGerenciar();
            gerenciarUsuariosPageObjects.ClicarGerenciarUsuarios();
            gerenciarUsuariosPageObjects.ClicarUsuario();
            gerenciarUsuariosPageObjects.ClicarApagarUsuario();
            gerenciarUsuariosPageObjects.ClicarApagarConta();

            Assert.IsTrue(gerenciarUsuariosPageObjects.RetornaCriarConta());
        }

        [Test]
        public void FiltroUsuario() 
        {
            LoginFlows loginFlows = new LoginFlows();
            GerenciarUsuariosPageObjects gerenciarUsuariosPageObjects = new GerenciarUsuariosPageObjects();
            CriarUsuarioFlows criarUsuarioFlows = new CriarUsuarioFlows();

            string filtroUsuario = "Cida";

            loginFlows.EfetuarLoginComUsuarioDefault();
            criarUsuarioFlows.CriarUsuarioAtualizador();

            gerenciarUsuariosPageObjects.ClicarGerenciar();
            gerenciarUsuariosPageObjects.ClicarGerenciarUsuarios();
            gerenciarUsuariosPageObjects.PreencherFiltroUsuario(filtroUsuario);
            gerenciarUsuariosPageObjects.ClicarAplicarFiltro();

            Assert.IsTrue(gerenciarUsuariosPageObjects.RetornaFiltroUsuarioCida());
        }

        [Test]
        public void FiltroUsuarioDesabilitado() 
        {
            LoginFlows loginFlows = new LoginFlows();
            GerenciarUsuariosPageObjects gerenciarUsuariosPageObjects = new GerenciarUsuariosPageObjects();
            CriarUsuarioFlows criarUsuarioFlows = new CriarUsuarioFlows();

            string usuario = "Barbara";

            loginFlows.EfetuarLoginComUsuarioDefault();
            criarUsuarioFlows.CriarUsuarioGerente();

            gerenciarUsuariosPageObjects.ClicarGerenciar();
            gerenciarUsuariosPageObjects.ClicarGerenciarUsuarios();
            gerenciarUsuariosPageObjects.SelecionarMostrarDesativados();
            gerenciarUsuariosPageObjects.PreencherFiltroUsuario(usuario);
            gerenciarUsuariosPageObjects.ClicarAplicarFiltro();

            Assert.IsTrue(gerenciarUsuariosPageObjects.RetornaFiltroUsuarioBarbara());
        }

        [Test]
        public void AtribuirPorjetoUsuario() 
        {
            LoginFlows loginFlows = new LoginFlows();
            GerenciarUsuariosPageObjects gerenciarUsuariosPageObjects = new GerenciarUsuariosPageObjects();
            CriarProjetoFlows criarProjetoFlows = new CriarProjetoFlows();
            CriarUsuarioFlows criarUsuarioFlows = new CriarUsuarioFlows();

            string papel = "gerente";
            string projeto = "Projeto Base2 Desenvolvimento[gerente](público)";

            loginFlows.EfetuarLoginComUsuarioDefault();
            criarProjetoFlows.CriarProjetoDesenvolvimento();
            criarUsuarioFlows.CriarUsuarioDefault();

            gerenciarUsuariosPageObjects.ClicarGerenciar();
            gerenciarUsuariosPageObjects.ClicarGerenciarUsuarios();
            gerenciarUsuariosPageObjects.ClicarEditarUsuario();
            gerenciarUsuariosPageObjects.ClicarProjetoNaoAtribuido();
            gerenciarUsuariosPageObjects.SelecionarAdicionarPapelUsuario(papel);
            gerenciarUsuariosPageObjects.ClicarAdicionarUsuario();

            Assert.IsTrue(gerenciarUsuariosPageObjects.RetornaProjetosAtribuidos(projeto));
        }

        [Test]
        public void RemoverPorjetoUsuario()
        {
            LoginFlows loginFlows = new LoginFlows();
            GerenciarUsuariosPageObjects gerenciarUsuariosPageObjects = new GerenciarUsuariosPageObjects();
            CriarProjetoFlows criarProjetoFlows = new CriarProjetoFlows();
            CriarUsuarioFlows criarUsuarioFlows = new CriarUsuarioFlows();

            string projeto = "";

            loginFlows.EfetuarLoginComUsuarioDefault();
            criarProjetoFlows.CriarProjetoDefault();
            criarUsuarioFlows.CriarUsuarioDefault();

            gerenciarUsuariosPageObjects.ClicarGerenciar();
            gerenciarUsuariosPageObjects.ClicarGerenciarUsuarios();
            gerenciarUsuariosPageObjects.ClicarEditarUsuario();
            gerenciarUsuariosPageObjects.ClicarRemoverProjetoAtribuido();
            gerenciarUsuariosPageObjects.ClicarConfirmarRemoverProjetoAtribuido();

            Assert.IsTrue(gerenciarUsuariosPageObjects.RetornaProjetosAtribuidos(projeto));
        }
        

    }
}
