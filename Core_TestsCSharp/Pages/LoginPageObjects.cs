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
    class LoginPageObjects : PageBase
    {
        #region Mapping
        By TfBuscarU = By.Id("username");
        By BtEntrarU = By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='AVISO:'])[1]/preceding::input[1]");
        By TfBuscarP = By.Id("password");
        By BtEntrarP = By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Somente permitir que sua sessão seja utilizada a partir deste endereço IP.'])[1]/following::input[1]");
        By BtPerdeuSenha = By.LinkText("Perdeu a sua senha?");
        By TfEmail = By.Id("email-field");
        By BtEnviar = By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Entrar'])[1]/preceding::input[1]");
        By LtCriarTarefa = By.LinkText("Criar Tarefa");
        By TxtAlertaFalha = By.CssSelector("p");
        By LtMinhaVisao = By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Sair'])[1]/following::span[1]");

        #endregion

        #region Actions

        public void PreencherLogin(string login)
        {
            SendKeys(TfBuscarU, login);
        }

        public void ClicarEntrarLogin()
        {
            Click(BtEntrarU);
        }

        public void PreencherSenha(string senha)
        {
            SendKeys(TfBuscarP, senha);
        }

        public void ClicarEntrarSenha()
        {
            Click(BtEntrarP);
        }

        public bool validaMensagemErroLogin(string alertaErro)
        {
            try
            {
                Assert.AreEqual(GetText(TxtAlertaFalha), alertaErro);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public void ClicarEsquecerSenha()
        {
            Click(BtPerdeuSenha);
        }

        public void PreencherEmail(string email)
        {
            SendKeys(TfEmail, email);
        }

        public void ClicarEnviar()
        {
            Click(BtEnviar);
        }

        #endregion
    }
}
