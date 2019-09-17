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
    class GerenciarPerfisGlobaisPageObjects : PageBase
    {

        #region Mapping

        By BtGerenciar = By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Resumo'])[1]/following::a[1]");
        By BtGerenciarPerfisGlobais = By.LinkText("Gerenciar Perfís Globais");
        By TxPlataforma = By.Id("platform");
        By TxSO = By.Id("os");
        By TxVersao = By.Id("os-version");
        By BtAdicionarPerfil = By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='* requerido'])[1]/following::input[1]");
        By SlSelectPerfil = By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Selecionar Perfil'])[1]/following::select[1]");
        By CbEditarPerfil = By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Editar perfil'])[1]/following::span[1]");
        By BtEnviar = By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Selecionar Perfil'])[1]/following::input[1]");
        By BtAtualizarPerfil = By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='* requerido'])[1]/following::input[1]");
        By BtApagarPeril = By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Apagar Perfil'])[1]/following::span[1]");
        By TxEditPlataform = By.Name("platform");


        #endregion


        #region Actions

        public void ClicarGerenciar()
        {
            Click(BtGerenciar);
        }

        public void ClicarGerenciarPerfisGlobais()
        {
            Click(BtGerenciarPerfisGlobais);
        }

        public void PreencherCampoPlataforma(string plataforma)
        {
            SendKeys(TxPlataforma, plataforma);
        }

        public void PreencherCampoSistemaOperacional(string so)
        {
            SendKeys(TxSO, so);
        }

        public void PreencherVersao(string versao)
        {
            SendKeys(TxVersao, versao);
        }

        public void ClicarAdicionarPerfil()
        {
            Click(BtAdicionarPerfil);
        }

        public bool RetornaSeEnviarExiste()
        {
            return ReturnIfElementIsDisplayed(BtEnviar);//**Aq nao esta legal
            /*
            try
            {
                Assert.AreEqual(GetText(SlSelectPerfil), perfil);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }*/
        }

        public bool RetornaTextoPlataforma(string plataforma)
        {
            try
            {
                Assert.AreEqual(GetText(TxPlataforma), plataforma);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool RetornaTextoSO(string so)
        {
            try
            {
                Assert.AreEqual(GetText(TxSO), so);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool RetornaTextoVersoSistemaOperacional(string VersaoSO)
        {
            try
            {
                Assert.AreEqual(GetText(TxVersao), VersaoSO);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public void SelecionarPerfil(string perfil)
        {
            ComboBoxSelectByVisibleText(SlSelectPerfil, perfil);
        }

        public void ClicarEnviar()
        {
            Click(BtEnviar);
        }

        public void PreencherEditarPlataforma()
        {
            SendKeys(TxEditPlataform, "-Edit");
        }

        public void ClicarAtualizarPerfil()
        {
            Click(BtAtualizarPerfil);
        }

        public void ClicarApagarPerfil()
        {
            Click(BtApagarPeril);
        }

        public bool EditarPerfil(string perfil)
        {
            Click(BtGerenciar);
            Click(BtGerenciarPerfisGlobais);
            Click(CbEditarPerfil);
            ComboBoxSelectByVisibleText(SlSelectPerfil, "Plataform Windows Versao1");
            Click(BtEnviar);
            SendKeys(TxEditPlataform, "-Edit");
            Click(BtAtualizarPerfil);

            Assert.IsTrue(ReturnIfElementIsDisplayed(BtEnviar));
            return ReturnIfElementIsDisplayed(BtEnviar);
            /*
            try
            {
                Assert.AreEqual(GetText(TxPlataforma), perfil);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
            */
        }

        public void ApagarPerfil()
        {
            Click(BtGerenciar);
            Click(BtGerenciarPerfisGlobais);
            Click(BtApagarPeril);
            ComboBoxSelectByVisibleText(SlSelectPerfil, "Plataform Windows Versao1");
            Click(BtEnviar);

        }


        #endregion

    }
}
