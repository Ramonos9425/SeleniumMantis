using Core_TestsCSharp.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_TestsCSharp.Flows
{
    class CriarPerfilFlows
    {
        public void CriarPerfilDefault()
        {
            LoginFlows loginFlows = new LoginFlows();
            GerenciarPerfisGlobaisPageObjects gerenciarPerfisGlobaisPageObjects = new GerenciarPerfisGlobaisPageObjects();

            string plataforma = "Plataform";
            string so = "Windows";
            string versao = "Versao1";

            loginFlows.EfetuarLoginComUsuarioDefault();

            gerenciarPerfisGlobaisPageObjects.ClicarGerenciar();
            gerenciarPerfisGlobaisPageObjects.ClicarGerenciarPerfisGlobais();
            gerenciarPerfisGlobaisPageObjects.PreencherCampoPlataforma(plataforma);
            gerenciarPerfisGlobaisPageObjects.PreencherCampoSistemaOperacional(so);
            gerenciarPerfisGlobaisPageObjects.PreencherVersao(versao);
            gerenciarPerfisGlobaisPageObjects.ClicarAdicionarPerfil();
        }

    }
}
