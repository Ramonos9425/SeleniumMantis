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
    class CriarProjetoPageObjects : PageBase
    {
        #region Mapping

        By BtGerenciar = By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Resumo'])[1]/following::a[1]");
        By BtGerenciarProjetos = By.LinkText("Gerenciar Projetos");
        By BtCriarProjeto = By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Gerenciar Configuração'])[1]/following::button[1]");
        By TfNomeProjeto = By.Id("project-name");
        By TfDescricaoProjeto = By.Id("project-description");
        By BtAdicionarProjeto = By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='* requerido'])[1]/following::input[1]");
        By BtProsseguir = By.LinkText("Clique aqui para prosseguir");
        By LtProjetoCriado = By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Descrição'])[1]/following::a[1]");
        By TfAlertaFalhaProjeto = By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Estado'])[1]/following::td[1]");
        By LtProjetoRelease = By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Projeto Base2 Release'])[2]/following::td[1]");
        By SlEstadoProjeto = By.Id("project-status");
        By TfAlerta = By.CssSelector("div.error-info");
        By BtMinhaVisao = By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Minha Visão'])[1]/preceding::i[1]");
        By TxEstadoEstavel = By.XPath("//a[text()='Projeto Base2 Estavel']");
        By TxEstadoRelease = By.XPath("//a[text()='Projeto Base2 Release']");
        By TxEstadoObsoleto = By.XPath("//a[text()='Projeto Base2 Obsoleto']");

        #endregion

        #region Actions

        public void ClicarMinhaVisao()
        {
            Click(BtMinhaVisao);
        }

        public void ClicarGerenciar()
        {
            Click(BtGerenciar);
        }

        public void ClicarGerenciarProjetos()
        {
            Click(BtGerenciarProjetos);
        }

        public void ClicarCriarProjeto()
        {
            Click(BtCriarProjeto);
        }

        public void PreencherNomeProjeto(string nomeProjeto)
        {
            SendKeys(TfNomeProjeto, nomeProjeto);
        }

        public void PreencherDescricaoProjeto(string descricaoProjeto)
        {
            SendKeys(TfDescricaoProjeto, descricaoProjeto);
        }

        public void ClicarAdicionarProjeto()
        {
            Click(BtAdicionarProjeto);
        }

        public void ClicarProsseguir()
        {
            Click(BtProsseguir);
        }

        public void SelecionarEstadoProjeto(string estado)
        {
            ComboBoxSelectByVisibleText(SlEstadoProjeto, estado);
        }

        

        public bool retornaSeProjetoExiste()
        {
            return ReturnIfElementIsDisplayed(LtProjetoCriado);
        }

        //public bool retornaSeProjetoEstavelExiste(string estado) --- ERRADO
        //{
        //    try
        //    {
        //        Assert.AreEqual(GetText(TxEstadoEstavel), estado);
        //        return true;
        //    }
        //    catch (Exception e)
        //    {
        //        return false;
        //    }
        //}

        public string retornaSeProjetoEstavelExiste2()
        {
            string texto;
            texto = GetText(TxEstadoEstavel);
            return texto;
        }

        //public bool retornaSeProjetoReleaseExiste(string estado)
        //{
        //    try
        //    {
        //        Assert.AreEqual(GetText(TxEstadoRelease), estado);
        //        return true;
        //    }
        //    catch (Exception e)
        //    {
        //        return false;
        //    }
        //}

        public string retornaSeProjetoReleaseExiste2()
        {
            string texto;
            texto = GetText(TxEstadoRelease);
            return texto;
        }

        //public bool retornaSeProjetoObsoletoExiste(string estado)
        //{
        //    try
        //    {
        //        Assert.AreEqual(GetText(TxEstadoObsoleto), estado);
        //        return true;
        //    }
        //    catch (Exception e)
        //    {
        //        return false;
        //    }
        //}

        public string retornaSeProjetoObsoletoExiste2()
        {
            string texto;
            texto = GetText(TxEstadoObsoleto);
            return texto;
        }

        public bool retornaSeProjetoDuplicadoFalha()
        {
            return ReturnIfElementIsDisplayed(TfAlerta);
        }

        public bool retornaCampoFalha()
        {
            return ReturnIfElementIsDisplayed(TfNomeProjeto);
        }

        #endregion

    }
}
