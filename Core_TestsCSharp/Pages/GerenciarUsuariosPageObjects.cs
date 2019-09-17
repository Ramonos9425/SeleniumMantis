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
    class GerenciarUsuariosPageObjects : PageBase
    {

        #region Mapping

        By BtGerenciar = By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Resumo'])[1]/following::a[1]");
        By BtGerenciarUsuarios = By.LinkText("Gerenciar Usuários");
        By BtCriarConta = By.LinkText("Criar nova conta");
        By TfNomeUsuario = By.Id("user-username");
        By TfNomeVerdadeiro = By.Id("user-realname");
        By TfEmail = By.Id("email-field");
        By BtCriarUsuario = By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Protegido'])[1]/following::input[2]");
        By BtRepresentarUsuario = By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Notificar o usuário dessa mudança'])[1]/following::input[9]");
        By BtNivelAcesso = By.Id("user-access-level");
        By TxtAlertaFalha = By.CssSelector("div.error-info");
        By LtUsuario = By.XPath("//div[@id='main-container']/div[2]/div[2]/div/div/div[4]/div[2]/div[2]/div/table/tbody/tr[2]/td/a");
        By BtCliqueProsseguir = By.LinkText("Clique aqui para prosseguir");
        By LtUser = By.XPath("(//a[contains(@href, '/mantis/account_page.php')])[2]");
        By BtApagarUsuario = By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Notificar o usuário dessa mudança'])[1]/following::input[6]");
        By BtApagarConta = By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='administrador'])[1]/following::input[5]");
        By TxUsuarioExistente = By.CssSelector("p.bold");
        By TfFiltroUsuario = By.Id("search");
        By BtAplicarFiltro = By.XPath("//input[@value='Aplicar Filtro']");
        By BtFiltroUsuarioCida = By.LinkText("Cida");
        By LtEditUsuario = By.LinkText("Barbara");
        By CbEditHabilitado = By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Habilitado'])[1]/following::span[1]");
        By BtAtualizarUsuario = By.XPath("//input[@value='Atualizar Usuário']");
        By CbMostrarDesativados = By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Ocultar Inativos'])[1]/following::span[1]");
        By BtFiltroUsuarioBarbara = By.LinkText("Barbara");
        By LtProjetoNaoAtribuido = By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Projetos Não-Atribuídos'])[1]/following::option[1]");
        By SlAdicionarPapelUsuarioProjeto = By.Id("add-user-project-access");
        By BtAdicionarUsuario = By.XPath("//input[@value='Adicionar Usuário']");
        By LtProjetosAtribuidos = By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Projetos Atribuídos'])[1]/following::td[1]");
        By BtRemoverProjetoAtribuido = By.XPath("//input[@value='Remover']");
        By BtConfirmarRemoverProjetoAtribuido = By.XPath("//input[@value='Remover Usuário']");

        #endregion

        #region Actions

        public bool CriarUsuarioRelator()
        {
            Click(BtGerenciar);
            Click(BtGerenciarUsuarios);
            Click(BtCriarConta);
            SendKeys(TfNomeUsuario,"Pedro");
            SendKeys(TfNomeVerdadeiro, "Pedro Lara");
            SendKeys(TfEmail, "pedrolara@hotmail.com");
            ComboBoxSelectByVisibleText(BtNivelAcesso, "relator");
            Click(BtCriarUsuario);

            Assert.IsTrue(ReturnIfElementIsDisplayed(BtRepresentarUsuario));
            return ReturnIfElementIsDisplayed(BtRepresentarUsuario);
        }

        public bool CriarUsuarioVisualizador()
        {
            Click(BtGerenciar);
            Click(BtGerenciarUsuarios);
            Click(BtCriarConta);
            SendKeys(TfNomeUsuario, "Claudia");
            SendKeys(TfNomeVerdadeiro, "Claudia Lara");
            SendKeys(TfEmail, "claudialara@hotmail.com");
            ComboBoxSelectByVisibleText(BtNivelAcesso, "visualizador");
            Click(BtCriarUsuario);

            Assert.IsTrue(ReturnIfElementIsDisplayed(BtRepresentarUsuario));
            return ReturnIfElementIsDisplayed(BtRepresentarUsuario);
        }

        public bool CriarUsuarioAtualizador()
        {
            Click(BtGerenciar);
            Click(BtGerenciarUsuarios);
            Click(BtCriarConta);
            SendKeys(TfNomeUsuario, "Cida");
            SendKeys(TfNomeVerdadeiro, "Cida Lara");
            SendKeys(TfEmail, "cidalara@hotmail.com");
            ComboBoxSelectByVisibleText(BtNivelAcesso, "atualizador");
            Click(BtCriarUsuario);

            Assert.IsTrue(ReturnIfElementIsDisplayed(BtRepresentarUsuario));
            return ReturnIfElementIsDisplayed(BtRepresentarUsuario);
        }

        public bool CriarUsuarioDesenvolvedor()
        {
            Click(BtGerenciar);
            Click(BtGerenciarUsuarios);
            Click(BtCriarConta);
            SendKeys(TfNomeUsuario, "Tuane");
            SendKeys(TfNomeVerdadeiro, "Tuane Lara");
            SendKeys(TfEmail, "tuanelara@hotmail.com");
            ComboBoxSelectByVisibleText(BtNivelAcesso, "desenvolvedor");
            Click(BtCriarUsuario);

            Assert.IsTrue(ReturnIfElementIsDisplayed(BtRepresentarUsuario));
            return ReturnIfElementIsDisplayed(BtRepresentarUsuario);
        }

        public bool CriarUsuarioGerente()
        {
            Click(BtGerenciar);
            Click(BtGerenciarUsuarios);
            Click(BtCriarConta);
            SendKeys(TfNomeUsuario, "Barbara");
            SendKeys(TfNomeVerdadeiro, "Barbara Lara");
            SendKeys(TfEmail, "barbaralara@hotmail.com");
            ComboBoxSelectByVisibleText(BtNivelAcesso, "gerente");
            Click(BtCriarUsuario);

            Assert.IsTrue(ReturnIfElementIsDisplayed(BtRepresentarUsuario));
            return ReturnIfElementIsDisplayed(BtRepresentarUsuario);
        }

        public bool CriarUsuarioAdministrador()
        {
            Click(BtGerenciar);
            Click(BtGerenciarUsuarios);
            Click(BtCriarConta);
            SendKeys(TfNomeUsuario, "Viviane");
            SendKeys(TfNomeVerdadeiro, "Viviane Lara");
            SendKeys(TfEmail, "vivianelara@hotmail.com");
            ComboBoxSelectByVisibleText(BtNivelAcesso, "administrador");
            Click(BtCriarUsuario);

            Assert.IsTrue(ReturnIfElementIsDisplayed(BtRepresentarUsuario));
            return ReturnIfElementIsDisplayed(BtRepresentarUsuario);
        }

        public bool CriarUsuarioAdministradorExistente()
        {
            Click(BtGerenciar);
            Click(BtGerenciarUsuarios);
            Click(BtCriarConta);
            SendKeys(TfNomeUsuario, "Viviane");
            ComboBoxSelectByVisibleText(BtNivelAcesso, "administrador");
            Click(BtCriarUsuario);

            Assert.IsTrue(ReturnIfElementIsDisplayed(TxtAlertaFalha));
            return ReturnIfElementIsDisplayed(TxtAlertaFalha);
        }

        public bool CriarUsuarioFalhaEmail()
        {
            Click(BtGerenciar);
            Click(BtGerenciarUsuarios);
            Click(BtCriarConta);
            SendKeys(TfNomeUsuario, "Luiza");
            SendKeys(TfNomeVerdadeiro, "Luiza Lara");
            SendKeys(TfEmail, "luizaaa");
            ComboBoxSelectByVisibleText(BtNivelAcesso, "administrador");
            Click(BtCriarUsuario);

            Assert.IsTrue(ReturnIfElementIsDisplayed(TxtAlertaFalha));
            return ReturnIfElementIsDisplayed(TxtAlertaFalha);
        }

        public bool RepresentarUsuario()
        {
            Click(BtGerenciar);
            Click(BtGerenciarUsuarios);
            Click(LtUsuario);
            Click(BtRepresentarUsuario);
            Click(BtCliqueProsseguir);

            Assert.IsTrue(ReturnIfElementIsDisplayed(LtUser));
            return ReturnIfElementIsDisplayed(LtUser);
        }

        public bool ApagarUsuario()//**Melhorar, como validar algo que nao existe mais ??????
        {
            Click(BtGerenciar);
            Click(BtGerenciarUsuarios);
            Click(LtUsuario);
            Click(BtApagarUsuario);
            Click(BtApagarConta);

            Assert.IsTrue(ReturnIfElementIsDisplayed(BtCriarConta));
            return ReturnIfElementIsDisplayed(BtCriarConta);
        }

        public bool FiltroUsuario()
        {
            Click(BtGerenciar);
            Click(BtGerenciarUsuarios);
            SendKeys(TfFiltroUsuario, "Cida");
            Click(BtAplicarFiltro);

            
            Assert.IsTrue(ReturnIfElementIsDisplayed(BtFiltroUsuarioCida));
            return ReturnIfElementIsDisplayed(BtFiltroUsuarioCida);
        }

        public void DesabilitarUsuario() //**Como validar ja que ele não aparece mais ???????
        {//Criar a Usuaria Barbara
            Click(BtGerenciar);
            Click(BtGerenciarUsuarios);
            Click(LtEditUsuario);
            Click(CbEditHabilitado);
            Click(BtAtualizarUsuario);

        }

        public bool FiltroUsuarioDesabilitado()
        {
            Click(BtGerenciar);
            Click(BtGerenciarUsuarios);
            Click(CbMostrarDesativados);
            SendKeys(TfFiltroUsuario, "Barbara");
            Click(BtAplicarFiltro);
            System.Threading.Thread.Sleep(3000);

            Assert.IsTrue(ReturnIfElementIsDisplayed(BtFiltroUsuarioBarbara));
            return ReturnIfElementIsDisplayed(BtFiltroUsuarioBarbara);
        }

        public bool AtribuirPorjetoUsuario(string projeto)
        {
            Click(BtGerenciar);
            Click(BtGerenciarUsuarios);
            Click(LtEditUsuario);
            Click(LtProjetoNaoAtribuido);
            ComboBoxSelectByVisibleText(SlAdicionarPapelUsuarioProjeto, "gerente");
            Click(BtAdicionarUsuario);

            try
            {
                Assert.AreEqual(GetText(LtProjetosAtribuidos), projeto);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool RemoverPorjetoUsuario(string projetoAtribuido)
        {
            Click(BtGerenciar);
            Click(BtGerenciarUsuarios);
            Click(LtEditUsuario);
            Click(BtRemoverProjetoAtribuido);
            Click(BtConfirmarRemoverProjetoAtribuido);

            try
            {
                Assert.AreEqual(GetText(LtProjetosAtribuidos), projetoAtribuido);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }


        #endregion
    }
}
