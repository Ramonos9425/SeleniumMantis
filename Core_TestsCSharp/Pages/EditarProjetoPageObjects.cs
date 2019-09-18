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
    class EditarProjetoPageObjects : PageBase
    {
        #region Mapping
        By BtGerenciar = By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Resumo'])[1]/following::a[1]");
        By BtGerenciarProjetos = By.LinkText("Gerenciar Projetos");
        By LtProjetoCriado = By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Descrição'])[1]/following::a[1]");
        By SlEstado = By.Id("project-status");
        By TfDescricaoProjeto = By.Id("project-description");
        By BtAtualizarProjeto = By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='* requerido'])[1]/following::input[1]");
        By TxCategoria = By.XPath("//div[@id='categories']/div/div[2]/form/div/input[3]");
        By BtAdicionarCategoria = By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='MantisBT'])[2]/preceding::input[2]");
        By BtAlterarCategoria = By.XPath("//button[text()='Alterar']");
        By TxCategoriaAlterada = By.XPath("//td[text()='Categoria Projeto Base2-Parte1']");
        By BtCriarCategoria = By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Categoria Projeto Base2'])[1]/following::button[1]");
        By TxEditarCategoria = By.Id("proj-category-name");
        By BtAtualizarCategoria = By.XPath("//input[@value='Atualizar Categoria']");
        By BtProsseguir = By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Atribuído a'])[1]/following::input[1]");
        By BtAlterarCategoria2 = By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Categoria Projeto Base2-Parte1'])[1]/following::button[1]");
        By BtExcluirCategoria = By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Alterar'])[1]/following::button[1]");
        By BtConfirmarExclusaoCategoria = By.XPath("//input[@value='Apagar Categoria']");
        By BtExlcuirProjeto = By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='* requerido'])[1]/following::input[4]");
        By BtConfirmarExclusaoProjeto = By.XPath("//input[@value='Apagar Projeto']");
        By TfAlerta = By.CssSelector("p.bold");
        By TfAlertaPadrao = By.XPath("//div[@id='main-container']/div[2]/div[2]/div/div/div[2]/p");

        #endregion

        #region Actions

        public void ClicarGerenciar()
        {
            Click(BtGerenciar);
        }

        public void ClicarGerenciarProjetos()
        {
            Click(BtGerenciarProjetos);
        }

        public void ClicarProjetoCriado()
        {
            Click(LtProjetoCriado);
        }

        public void SelecionarEstadoProjeto(string estavel)
        {
            ComboBoxSelectByVisibleText(SlEstado, estavel);
        }

        public void PreencherDescricaoProjeto(string descricao)
        {
            SendKeys(TfDescricaoProjeto, "-Continuação");
        }

        public void ClicarAtualizarProjeto()
        {
            Click(BtAtualizarProjeto);
        }

        public bool RetornaSeProjetoEditado()
        {
           return ReturnIfElementIsDisplayed(LtProjetoCriado);
        }

        public void PreencherCategoriaProjeto(string categoria)
        {
            SendKeys(TxCategoria, categoria);
        }

        public bool RetornaSeCategoriaAlterada()
        {
            return ReturnIfElementIsDisplayed(TxCategoriaAlterada);
        }

        public bool RetornaSeCategoriaCriada()
        {
            return ReturnIfElementIsDisplayed(BtCriarCategoria);
        }

        public void ClicarAdicionarCategoria()
        {
            Click(BtAdicionarCategoria);
        }

        public bool RetornaSeCategoriaExiste()
        {
            return ReturnIfElementIsDisplayed(TfAlerta);
        }

        public void ClicarAlterarCategoria()
        {
            Click(BtAlterarCategoria);
        }

        public void PreencherEditarCategoria(string categoria)
        {
            SendKeys(TxEditarCategoria, categoria);
        }

        public void ClicarAtualizarCategoria()
        {
            Click(BtAtualizarCategoria);
        }

        public void ConfirmarExcluirCategoria()
        {
            Click(BtConfirmarExclusaoCategoria);
        }

        public void ExcluirCategoria()
        {
            Click(BtExcluirCategoria);
            
        }

        public void ExcluirProjeto()
        {
            Click(BtExlcuirProjeto);
        }

        public void ConfirmarExcluirProjeto()
        {
            Click(BtConfirmarExclusaoProjeto);
        }

        #endregion
    }
}
