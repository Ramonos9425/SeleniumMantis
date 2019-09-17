using Core_TestsCSharp.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Core_TestsCSharp.Flows
{
    class CriarProjetoeTarefaDefaultFlows
    {
        CriarProjetoPageObjects criarProjetoPageObjects = new CriarProjetoPageObjects();
        CriarTarefaPageObjects criarTarefaPageObjects = new CriarTarefaPageObjects();

        public void CriarProjetoeTarefaDefault()
        {
            string nomeProjeto = "Projeto Base2";
            string descricaoProjeto = "Projeto Base2 Parte";

            criarProjetoPageObjects.ClicarGerenciar();
            criarProjetoPageObjects.ClicarGerenciarProjetos();
            criarProjetoPageObjects.ClicarCriarProjeto();
            criarProjetoPageObjects.PreencherNomeProjeto(nomeProjeto);
            criarProjetoPageObjects.PreencherDescricaoProjeto(descricaoProjeto);
            criarProjetoPageObjects.ClicarAdicionarProjeto();

            criarTarefaPageObjects.ClicarCriarTarefa();
           // criarTarefaPageObjects.SelecionarCategoria("[Todos os Projetos] General");
           // criarTarefaPageObjects.PreencherResumo("Botão de scroll indevido");
           // criarTarefaPageObjects.PreencherDescricao("Este botão não deveria aparecer na tela.");
          //  criarTarefaPageObjects.ClicarCriarNovaTarefa();

        }

    }
}
