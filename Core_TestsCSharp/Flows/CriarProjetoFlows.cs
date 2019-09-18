using Core_TestsCSharp.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Core_TestsCSharp.Flows
{
    class CriarProjetoFlows
    {

        CriarProjetoPageObjects criarProjetoPageObjects = new CriarProjetoPageObjects();

        public void CriarProjetoDefault()
        {

            string nomeProjeto = "Projeto Base2";
            string descricaoProjeto = "Projeto Base2";

            criarProjetoPageObjects.ClicarGerenciar();
            criarProjetoPageObjects.ClicarGerenciarProjetos();
            criarProjetoPageObjects.ClicarCriarProjeto();
            criarProjetoPageObjects.PreencherNomeProjeto(nomeProjeto);
            criarProjetoPageObjects.PreencherDescricaoProjeto(descricaoProjeto);
            criarProjetoPageObjects.ClicarAdicionarProjeto();           
        }

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
        }

    }
}
