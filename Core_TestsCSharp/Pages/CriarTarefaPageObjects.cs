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
        By BtSelectProjeto = By.XPath("//input[@value='Selecionar Projeto']");

        #endregion

        #region Actions

        public void ClicarSelecionarProjeto()
        {
            Click(BtSelectProjeto);
        }

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

        public string RetornaSeTarefaCriadaCampoResumo2()
        {
            string texto;
            texto = GetText(LtDescricao);
            return texto;
        }

        //public bool RetornaSeTarefaCriadaCampoDescricao(string descricao)
        //{
        //    try
        //    {
        //        Assert.AreEqual(GetText(LtDescricao), descricao);//Pega o campo vazio e compara
        //        return true;
        //    }
        //    catch (Exception e)
        //    {
        //        return false;
        //    }
        //}

        public string RetornaSeTarefaCriadaCampoDescricao2()
        {
            string texto;
            texto = GetText(LtDescricao);
            return texto;
        }

        

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
