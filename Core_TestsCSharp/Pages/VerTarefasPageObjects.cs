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
        By BtApagar = By.XPath("//input[@value='Apagar']");
        By BtApagarTarefas = By.XPath("//input[@value='Apagar Tarefas']");
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

        public bool RetornaSeAtribuido(string atribuir)
        {
            try
            {
                Assert.AreEqual(GetText(TtAtribuir), atribuir);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool AtribuirTarefa(string atribuir)
        {
            Click(BtVerTarefas);
            Click(LtTarefa);
            ComboBoxSelectByVisibleText(StAtribuir, "administrator");
            Click(BtAtribuir);

            try
            {
                Assert.AreEqual(GetText(TtAtribuir), atribuir);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }

        }

        public bool AlterarStatusConfirmado(string status)
        {
            Click(BtVerTarefas);
            System.Threading.Thread.Sleep(3500);
            Click(LtTarefa);
            System.Threading.Thread.Sleep(3500);
            ComboBoxSelectByVisibleText(SlAlterarStatus, "confirmado");
            Click(BtAlterarStatus);
            //System.Threading.Thread.Sleep(3500);
            Click(BtConfirmarTarefa);

            try
            {
                Assert.AreEqual(GetText(TfEstado), status);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }

        }

        public bool AlterarStatusAdmitido(string status)
        {
            Click(BtVerTarefas);
            Click(LtTarefa);
            ComboBoxSelectByVisibleText(SlAlterarStatus, "admitido");
            Click(BtAlterarStatus);
            Click(BtAdmitirTarefa);
            try
            {
                Assert.AreEqual(GetText(TfEstado), status);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }

        }

        public bool AlterarStatusRetorno(string status)
        {
            Click(BtVerTarefas);
            Click(LtTarefa);
            ComboBoxSelectByVisibleText(SlAlterarStatus, "retorno");
            Click(BtAlterarStatus);
            Click(BtSolicitaRetornoTarefa);
            try
            {
                Assert.AreEqual(GetText(TfEstado), status);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }

        }

        public bool AlterarStatusAtribuido(string status)
        {
            Click(BtVerTarefas);
            Click(LtTarefa);
            ComboBoxSelectByVisibleText(SlAlterarStatus, "atribuído");
            Click(BtAlterarStatus);
            Click(BtAtribuirTarefa);
            try
            {
                Assert.AreEqual(GetText(TfEstado), status);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }

        }

        public bool AlterarStatusResolvido(string status)
        {
            Click(BtVerTarefas);
            Click(LtTarefa);
            ComboBoxSelectByVisibleText(SlAlterarStatus, "resolvido");
            Click(BtAlterarStatus);
            Click(BtResolverTarefa);
            try
            {
                Assert.AreEqual(GetText(TfEstado), status);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }

        }

        public bool AlterarStatusFechado(string status)
        {
            Click(BtVerTarefas);
            Click(LtTarefa);
            ComboBoxSelectByVisibleText(SlAlterarStatus, "fechado");
            Click(BtAlterarStatus);
            Click(BtFecharTarefa);
            try
            {
                Assert.AreEqual(GetText(TfEstado), status);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }

        }

        public bool AplicarMarcadores()
        {
            Click(BtVerTarefas);
            Click(LtTarefa);
            SendKeys(TtAplicarMarcadores, "PB2");
            //System.Threading.Thread.Sleep(3500);
            Click(BtAplicarMarcador);

            Assert.IsTrue(ReturnIfElementIsDisplayed(BtMarcador));
            return ReturnIfElementIsDisplayed(BtMarcador);
            
        }

        public bool CriarClone(string descricao)
        {
            Click(BtVerTarefas);
            Click(LtTarefa);
            Click(BtCriarClone);
            Click(BtCriarNovaTarefa);

            try
            {
                Assert.AreEqual(GetText(TtDescricao), descricao);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool FecharTarefa(string estado)
        {
            Click(BtVerTarefas);
            Click(LtTarefa);
            Click(BtFechar);
            Click(BtFecharTarefa);

            try
            {
                Assert.AreEqual(GetText(TfEstado), estado);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool ReabrirTarefa(string estado) //Deveria Fechar a Tarefa aqui ou chamar o metodo que faz isso
        {

            Click(BtVerTarefas);
            Click(LtTarefa);
            Click(BtFechar);
            Click(BtFecharTarefa);
            Click(BtReabrirTarefa);
            Click(BtSolicitaRetorno);

            try
            {
                Assert.AreEqual(GetText(TfEstado), estado);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public void ApagarTarefa() // Como validar algo que apagou ????????
        {
            Click(BtVerTarefas);
            Click(LtTarefa);
            Click(BtApagar);
            Click(BtApagarTarefas);

        }

        #endregion
    }
}
