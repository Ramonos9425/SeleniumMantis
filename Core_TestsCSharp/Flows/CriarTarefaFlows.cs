using Core_TestsCSharp.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_TestsCSharp.Flows
{
    class CriarTarefaFlows
    {
        CriarTarefaPageObjects criarTarefaPageObjects = new CriarTarefaPageObjects();

        public void CriarTarefaDefault()
        {
            criarTarefaPageObjects.ClicarCriarNovaTarefa();
            criarTarefaPageObjects.SelecionarCategoria("[Todos os Projetos] General");
            criarTarefaPageObjects.PreencherResumo("Botão de scroll indevido");
            criarTarefaPageObjects.PreencherDescricao("Este botão não deveria aparecer na tela.");
            criarTarefaPageObjects.ClicarCriarNovaTarefa();

            Assert.IsTrue(criarTarefaPageObjects.RetornaSeTarefaCriadaCampoResumo("Botão de scroll indevido"));
        }


    }
}
