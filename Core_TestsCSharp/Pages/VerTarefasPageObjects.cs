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
    class VerTarefasPageObjects : PageBase
    {
        #region Mapping

        By StAtribuir = By.Name("handler_id");
        By BtAtribuir = By.XPath("//input[@value='Atribuir a:']");
        By TtAtribuir = By.CssSelector("td.bug-assigned-to");
        By BtVerTarefas = By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Ver Tarefas'])[1]/preceding::i[1]");
        By LtTarefa = By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Resumo'])[3]/following::a[2]");
        By SlAlterarStatus = By.Name("new_status");
        By BtAlterarStatus = By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='>>'])[1]/following::input[9]");
        By BtConfirmarTarefa = By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='* requerido'])[1]/following::input[1]");
        By TfEstado = By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Estado'])[1]/following::td[1]");
        By TtAplicarMarcadores = By.Id("tag_string");
        By BtAplicarMarcador = By.XPath("(.//*[normalize-space(text()) and normalize-space(.)=concat('(Separar por ', \"'\", ',', \"'\", ')')])[1]/following::input[4]");
        By BtMarcador = By.LinkText("PB2");
        By BtCriarClone = By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='>>'])[1]/following::input[21]");
        By BtCriarNovaTarefa = By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='* requerido'])[1]/following::input[1]");
        By TtDescricao = By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Descrição'])[1]/following::td[1]");
        By BtFechar = By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='>>'])[1]/following::input[26]");
        By BtFecharTarefa = By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='* requerido'])[1]/following::input[1]");
        By BtReabrirTarefa = By.XPath("//input[@value='Reabrir']");
        By BtSolicitaRetorno = By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='* requerido'])[1]/following::input[1]");
        By BtAdmitirTarefa = By.XPath("//input[@value='Admitir Tarefa']");
        By BtSolicitaRetornoTarefa = By.XPath("//input[@value='Solicitar Retorno']");
        By BtAtribuirTarefa = By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='* requerido'])[1]/following::input[1]");
        By BtResolverTarefa = By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='* requerido'])[1]/following::input[1]");

        #endregion

        #region Actions
        
        public void ClicarVerTarefas()
        {
            Click(BtVerTarefas);
        }

        public void ClicarAcessarTarefa()
        {
            Click(LtTarefa);
        }

        public void SelecionarAtribuir(string atribuir)
        {
            ComboBoxSelectByVisibleText(StAtribuir, atribuir);
        }

        public void ClicarAtribuir()
        {
            Click(BtAtribuir);
        }

        //public bool RetornaSeAtribuido(string atribuir)
        //{
        //    try
        //    {
        //        Assert.AreEqual(GetText(TtAtribuir), atribuir);
        //        return true;
        //    }
        //    catch (Exception e)
        //    {
        //        return false;
        //    }
        //}

        public string RetornaSeAtribuido2()
        {
            string texto;
            texto = GetText(TtAtribuir);
            return texto;
        }

        public void SelecionarAlterarStatus(string status)
        {
            ComboBoxSelectByVisibleText(SlAlterarStatus, status);
        }

        public void ClicarAlterarStatus()
        {
            Click(BtAlterarStatus);
        }

        public void ClicarConfirmarTarefa()
        {
            Click(BtConfirmarTarefa);
        }

        //public bool RetornaEstadoStatus(string status)
        //{
        //    try
        //    {
        //        Assert.AreEqual(GetText(TfEstado), status);
        //        return true;
        //    }
        //    catch (Exception e)
        //    {
        //        return false;
        //    }
        //}

        public string RetornaEstadoStatus2()
        {
            string texto;
            texto = GetText(TfEstado);
            return texto;
        }

        public void ClicarAdmitirTarefa()
        {
            Click(BtAdmitirTarefa);
        }

        public void ClicarSolicitaRetornoTarefa()
        {
            Click(BtSolicitaRetornoTarefa);
        }

        public void ClicarAtribuirTarefa()
        {
            Click(BtAtribuirTarefa);
        }

        public void ClicarResolverTarefa()
        {
            Click(BtResolverTarefa);
        }

        public void ClicarFecharTarefa()
        {
            Click(BtFecharTarefa);
        }

        public void SelecionarAplicarMarcadores(string marcador)
        {
            SendKeys(TtAplicarMarcadores, marcador);
        }

        public void ClicarAplicarMarcador()
        {
            Click(BtAplicarMarcador);
        }

        public bool RetornaMarcador()
        {
            //Assert.IsTrue(ReturnIfElementIsDisplayed(BtMarcador));
            return ReturnIfElementIsDisplayed(BtMarcador);
        }

        public void ClicarCriarClone()
        {
            Click(BtCriarClone);
        }

        public void ClicarCriarNovaTarefa()
        {
            Click(BtCriarNovaTarefa);
        }

        //public bool RetornaDescricao(string descricao)
        //{
        //    try
        //    {
        //        Assert.AreEqual(GetText(TtDescricao), descricao);
        //        return true;
        //    }
        //    catch (Exception e)
        //    {
        //        return false;
        //    }
        //}

        public string RetornaDescricao2()
        {
            string texto;
            texto = GetText(TtDescricao);
            return texto;
        }

        public void ClicarFechar()
        {
            Click(BtFechar);
        }

        public void ClicarReabrirTarefa()
        {
            Click(BtReabrirTarefa);
        }

        public void ClicarSolicitaRetorno()
        {
            Click(BtSolicitaRetorno);
        }

        #endregion
    }
}
