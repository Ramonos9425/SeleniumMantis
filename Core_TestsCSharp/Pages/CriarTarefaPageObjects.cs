using Core_TestsCSharp.Bases;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_TestsCSharp.Pages
{
    class CriarTarefaPageObjects : PageBase
    {

        #region Mapping

        By BtCriarTarefas = By.XPath("//span[text()=' Criar Tarefa ']");
        By TfResumo = By.Id("summary");
        By TfDescricao = By.Id("description");
        By BtCriarNovaTarefa = By.XPath("//input[@value='Criar Nova Tarefa']");
        By LtDescricao = By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Descrição'])[1]/following::td[1]");
        By StGravidade = By.Id("severity");
        By StPrioridade = By.Id("priority");
        By StAtribuir = By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='>>'])[1]/following::select[1]");
        By StSelecionarProjeto = By.Id("select-project-id");
        By BtSelecionarProjeto = By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Tornar Padrão'])[1]/following::input[2]");
        By StCategoria = By.Id("category_id");
        
        #endregion

        #region Actions

        public void ClicarCriarTarefa()
        {
            Click(BtCriarTarefas);
        }

        public void SelecionarCategoria(string categoria)
        {
            ComboBoxSelectByVisibleText(StCategoria, categoria);
        }

        public void PreencherResumo(string resumo)
        {
            SendKeys(TfResumo, resumo);
        }

        public void PreencherDescricao(string descricao)
        {
            SendKeys(TfDescricao, descricao);
        }

        public void ClicarCriarNovaTarefa()
        {
            Click(BtCriarNovaTarefa);
        }

        public bool RetornaSeTarefaCriadaCampoResumo(string resumo)
        {
            try
            {
                Assert.AreEqual(GetText(LtDescricao), resumo);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool RetornaSeTarefaCriadaCampoDescricao(string descricao)
        {
            try
            {
                Assert.AreEqual(GetText(LtDescricao), descricao);//Pega o campo vazio e compara
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool CriarTarefa( string resumo)
        {
            Click(BtCriarTarefas);
            System.Threading.Thread.Sleep(3000);
            Click(BtSelecionarProjeto);
            System.Threading.Thread.Sleep(3000);
            ComboBoxSelectByVisibleText(StCategoria, "[Todos os Projetos] General");
            SendKeys(TfResumo, "Botão de scroll indevido");
            SendKeys(TfDescricao, "Este botão não deveria aparecer na tela.");
            Click(BtCriarNovaTarefa);

            try
            {
                Assert.AreEqual(GetText(LtDescricao), resumo);
                return true;
            }
            catch(Exception e)
            {
                return false;
            }

        }

        public bool CriarTarefaFalhaCampoResumo(string resumo)
        {
            Click(BtCriarTarefas);
            System.Threading.Thread.Sleep(3500);
            ComboBoxSelectByVisibleText(StSelecionarProjeto, "Projeto Base2 Desenvolvimento");
            Click(BtSelecionarProjeto);
            SendKeys(TfDescricao, "Este botão não deveria aparecer na tela.");
            Click(BtCriarNovaTarefa);

            try
            {
                Assert.AreEqual(GetText(TfResumo), resumo);//Pega o campo vazio e compara
                return true;
            }
            catch (Exception e)
            {
                return false;
            }

        }

        public bool CriarTarefaFalhaCampoDescricao(string descricao)
        {
            Click(BtCriarTarefas);
            ComboBoxSelectByVisibleText(StSelecionarProjeto, "Projeto Base2 Desenvolvimento");
            Click(BtSelecionarProjeto);
            SendKeys(TfResumo, "Botão de scroll indevido");
            Click(BtCriarNovaTarefa);

            try
            {
                Assert.AreEqual(GetText(LtDescricao), descricao);//Pega o campo vazio e compara
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }


        /* public bool CriarTarefaFalhaCampoCategoria(string resumo)
         {
             Click(BtCriarTarefas);
             //System.Threading.Thread.Sleep(3500);
             Click(BtSelecionarProjeto);
             SendKeys(TfResumo, "Botão de scroll indevido");
             SendKeys(TfDescricao, "Este botão não deveria aparecer na tela.");
             Click(BtCriarNovaTarefa);
             // Click(BtVerTarefas);

             try
             {
                 Assert.AreEqual(GetText(LtDescricao), resumo);
                 return true;
             }
             catch (Exception e)
             {
                 return false;
             }

         }*/

        public void CriarTarefaDataDriven(string categoria, string frequencia, string gravidade, string prioridade, string resumo, string descricao)
         {
             Click(BtCriarTarefas);
             Click(BtSelecionarProjeto);
             ComboBoxSelectByVisibleText(StSelecionarProjeto, "Projeto Base2 Desenvolvimento");
             //System.Threading.Thread.Sleep(3500);
             // ComboBoxSelectByVisibleText(StCategoria, listaExcel[1].Arguments[]);

             //ComboBoxSelectByVisibleText(StCategoria, categoria);
             ComboBoxSelectByVisibleText(StGravidade, gravidade);

         }


        #endregion

    }
}
