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

        public void ClicarGerenciar()
        {
            Click(BtGerenciar);
        }

        public void ClicarGerenciarUsuarios()
        {
            Click(BtGerenciarUsuarios);
        }

        public void ClicarCriarConta()
        {
            Click(BtCriarConta);
        }

        public void PreencherNomeUsuario(string nome)
        {
            SendKeys(TfNomeUsuario, nome);
        }

        public void PreencherNomeVerdadeiro(string nomeVerdadeiro)
        {
            SendKeys(TfNomeVerdadeiro, nomeVerdadeiro);
        }

        public void PreencherEmail(string email)
        {
            SendKeys(TfEmail, email);
        }

        public void SelecionarNivelAcesso(string nivelAcesso)
        {
            ComboBoxSelectByVisibleText(BtNivelAcesso, nivelAcesso);
        }

        public void ClicarCriarUsuario()
        {
            Click(BtCriarUsuario);
        }

        public bool RetornaRepresentarUsuario()
        {
            Assert.IsTrue(ReturnIfElementIsDisplayed(BtRepresentarUsuario));
            return ReturnIfElementIsDisplayed(BtRepresentarUsuario);
        }

        public bool RetornaAlertaFalha()
        {
            Assert.IsTrue(ReturnIfElementIsDisplayed(TxtAlertaFalha));
            return ReturnIfElementIsDisplayed(TxtAlertaFalha);
        }

        public void ClicarRepresentarUsuario()
        {
            Click(BtRepresentarUsuario);
        }

        public void ClicarProsseguir()
        {
            Click(BtCliqueProsseguir);
        }

        public bool RetornaUsuarioRepresentado()
        {
            Assert.IsTrue(ReturnIfElementIsDisplayed(LtUser));
            return ReturnIfElementIsDisplayed(LtUser);
        }
        public void ClicarUsuario()
        {
            Click(LtUsuario);
        }

        public bool RetornaCriarConta()
        {
            Assert.IsTrue(ReturnIfElementIsDisplayed(BtCriarConta));
            return ReturnIfElementIsDisplayed(BtCriarConta);
        }

        public void ClicarApagarUsuario()
        {
            Click(BtApagarUsuario);
        }

        public void ClicarApagarConta()
        {
            Click(BtApagarConta);
        }

        public void PreencherFiltroUsuario(string filtroUsuario)
        {
            SendKeys(TfFiltroUsuario, filtroUsuario);
        }

        public void ClicarAplicarFiltro()
        {
            Click(BtAplicarFiltro);
        }

        public bool RetornaFiltroUsuarioCida()
        {
            Assert.IsTrue(ReturnIfElementIsDisplayed(BtFiltroUsuarioCida));
            return ReturnIfElementIsDisplayed(BtFiltroUsuarioCida);
        }

        public bool RetornaFiltroUsuarioBarbara()
        {
            Assert.IsTrue(ReturnIfElementIsDisplayed(BtFiltroUsuarioBarbara));
            return ReturnIfElementIsDisplayed(BtFiltroUsuarioBarbara);
        }

        public void SelecionarMostrarDesativados()
        {
            Click(CbMostrarDesativados);
        }

        public void ClicarEditarUsuario()
        {
            Click(LtEditUsuario);
        }

        public void ClicarProjetoNaoAtribuido()
        {
            Click(LtProjetoNaoAtribuido);
        }

        public void SelecionarAdicionarPapelUsuario(string papel)
        {
            ComboBoxSelectByVisibleText(SlAdicionarPapelUsuarioProjeto, papel);
        }

        public void ClicarAdicionarUsuario()
        {
            Click(BtAdicionarUsuario);
        }

        public bool RetornaProjetosAtribuidos(string projeto)
        {
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

        public void ClicarRemoverProjetoAtribuido()
        {
            Click(BtRemoverProjetoAtribuido);
        }

        public void ClicarConfirmarRemoverProjetoAtribuido()
        {
            Click(BtConfirmarRemoverProjetoAtribuido);
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
