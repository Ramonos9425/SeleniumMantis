using Core_TestsCSharp.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_TestsCSharp.Flows
{
    class LoginFlows
    {
        LoginPageObjects loginPageObjects = new LoginPageObjects();

        public void EfetuarLogin(string usuario, string senha)
        {
            loginPageObjects.PreencherLogin(usuario);
            loginPageObjects.ClicarEntrarLogin();
            loginPageObjects.PreencherSenha(senha);
            loginPageObjects.ClicarEntrarSenha();
        }

        public void EfetuarLoginComUsuarioDefault()
        {
            loginPageObjects.PreencherLogin("administrator");
            loginPageObjects.ClicarEntrarLogin();
            loginPageObjects.PreencherSenha("admin");
            loginPageObjects.ClicarEntrarSenha();
        }
    }
}
