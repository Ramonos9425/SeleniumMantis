using Core_TestsCSharp.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_TestsCSharp.Flows
{
    class CriarUsuarioFlows
    {
        public void CriarUsuarioDefault()
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
        }

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
        }

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
        }

    }
}
