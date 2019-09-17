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
    class GerenciarMarcadoresPageObjects : PageBase
    {
        #region Mapping

        By BtGerenciar = By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Resumo'])[1]/following::a[1]");
        By BtGerenciarMarcador = By.LinkText("Gerenciar Marcadores");
        By TxNomeMarcador = By.Id("tag-name");
        By TxDescricaoMarcador = By.Id("tag-description");
        By BtCriarMarcador = By.Name("config_set");
        By LtProjetoCriado = By.LinkText("ProjetoB2");
        By BtAtualizarMarcador = By.XPath("//input[@value='Atualizar Marcador']");
        By TlDescricaoMarcador = By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Descrição do marcador'])[1]/following::td[1]");
        By BtApagarMarcador = By.XPath("//input[@value='Apagar Marcador']");

        #endregion

        #region Actions

        public void ClicarGerenciar()
        {
            Click(BtGerenciar);
        }

        public void ClicarGerrenciarMarcador()
        {
            Click(BtGerenciarMarcador);
        }

        public void PreencherNomeMarcador(string nomeMarcador)
        {
            SendKeys(TxNomeMarcador, nomeMarcador);
        }

        public void PreencherDescricaoMarcador(string descricaoMarcador)
        {
            SendKeys(TxDescricaoMarcador, descricaoMarcador);
        }

        public void ClicarCriarMarcador()
        {
            Click(BtCriarMarcador);
        }

        public bool RetornaSeProjetoCriado()
        {
            return ReturnIfElementIsDisplayed(LtProjetoCriado);
        }

        public bool RetornaSeCampoNomeFalha(string nome)
        {
            try
            {
                Assert.AreEqual(GetText(TxNomeMarcador), nome);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public void ClicarProjetoCriado()
        {
            Click(LtProjetoCriado);
        }

        public void ClicarAtualizarMarcador()
        {
            Click(BtAtualizarMarcador);
        }

        public bool RetornaCampoDescricaoMarcadorEditado(string descricao)
        {
            try
            {
                Assert.AreEqual(GetText(TlDescricaoMarcador), descricao);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public void ClicarApagarMarcador()
        {
            Click(BtApagarMarcador);
        }

        public bool CriarMarcador() //**Queria fazer um try catch 
        {
            Click(BtGerenciar);
            Click(BtGerenciarMarcador);
            SendKeys(TxNomeMarcador, "ProjetoB2");
            SendKeys(TxDescricaoMarcador, "Marcador para Projeto");
            Click(BtCriarMarcador);

            Assert.IsTrue(ReturnIfElementIsDisplayed(LtProjetoCriado));
            return ReturnIfElementIsDisplayed(LtProjetoCriado);
        }


        public bool EditarMarcador(string descricao)  
        {
            Click(BtGerenciar);
            Click(BtGerenciarMarcador);
            Click(LtProjetoCriado);
            Click(BtAtualizarMarcador);
            SendKeys(TxDescricaoMarcador, "-Edit");
            Click(BtAtualizarMarcador);

            try
            {
                Assert.AreEqual(GetText(TlDescricaoMarcador), descricao);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public void ApagarMarcador() //**Como validar algo que ja foi excluido
        {
            Click(BtGerenciar);
            Click(BtGerenciarMarcador);
            Click(LtProjetoCriado);
            Click(BtApagarMarcador);
         
        }

        #endregion


    }
}
