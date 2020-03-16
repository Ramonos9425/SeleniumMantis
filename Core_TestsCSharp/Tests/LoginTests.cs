using Core_TestsCSharp.Bases;
using Core_TestsCSharp.Pages;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_TestsCSharp.Tests
{
    class LoginTests : TestBase
    {
        LoginPageObjects loginPageObjects = null;
        MinhaVisaoPageObjects minhaVisaoPageObjects = null;

        [Test]
        public void Login()
        {

            loginPageObjects = new LoginPageObjects();
            minhaVisaoPageObjects = new MinhaVisaoPageObjects();

            string usuario = "administrator";
            string senha = "admin";

            loginPageObjects.PreencherLogin(usuario);
            loginPageObjects.ClicarEntrarLogin();
            loginPageObjects.PreencherSenha(senha);
            loginPageObjects.ClicarEntrarSenha();

            Assert.IsTrue(minhaVisaoPageObjects.retornaSeBotaoEstaVisivel());
        }

        [Test]
        public void Login_Falha()
        {
            loginPageObjects = new LoginPageObjects();

            string usuario = "administrator";
            string senha = "12345654345";
            string mensagemEsperada = "Sua conta pode estar desativada ou bloqueada ou o nome de usuário e a senha que você digitou não estão corretos.";

            loginPageObjects.PreencherLogin(usuario);
            loginPageObjects.ClicarEntrarLogin();
            loginPageObjects.PreencherSenha(senha);
            loginPageObjects.ClicarEntrarSenha();

            Assert.IsTrue(loginPageObjects.validaMensagemErroLogin(mensagemEsperada));
        }

        [Test]
        public void Esquecer_Senha()
        {
            loginPageObjects = new LoginPageObjects();

            string usuario = "administrator";
            string email = "ramonos9425@gmail.com";
            string mensagemEsperada = "APPLICATION ERROR #1903";

            loginPageObjects.PreencherLogin(usuario);
            loginPageObjects.ClicarEntrarLogin();
            loginPageObjects.ClicarEsquecerSenha();
            loginPageObjects.PreencherEmail(email);
            loginPageObjects.ClicarEnviar();

            //Arrumar a Validacao porque esta dando erro na apos clicar no botao de Enviar
            Assert.IsTrue(loginPageObjects.validaMensagemEmail(mensagemEsperada));
         }

        [Test]
        public void Esquecer_Senha_Email_Invalido()
        {
            loginPageObjects = new LoginPageObjects();

            string usuario = "administrator";
            string email = "ramonos94";
            string mensagemEsperada = "APPLICATION ERROR #1200";

            loginPageObjects.PreencherLogin(usuario);
            loginPageObjects.ClicarEntrarLogin();
            loginPageObjects.ClicarEsquecerSenha();
            loginPageObjects.PreencherEmail(email);
            loginPageObjects.ClicarEnviar();

            //Arrumar a Validacao porque esta dando erro na apos clicar no botao de Enviar
            Assert.IsTrue(loginPageObjects.validaMensagemEmailInvalido(mensagemEsperada));
        }
    }
}
