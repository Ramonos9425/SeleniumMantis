using Core_TestsCSharp.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_TestsCSharp.Flows
{
    class CriarMarcadorFlows
    {
        public void CriarMarcadorDefault()
        {    
            LoginFlows loginFlows = new LoginFlows();
            GerenciarMarcadoresPageObjects gerenciarMarcadoresPageObjects = new GerenciarMarcadoresPageObjects();

            string nomeMarcador = "ProjetoB2";
            string descricaoMarcador = "Marcador para Projeto";

            loginFlows.EfetuarLoginComUsuarioDefault();

            gerenciarMarcadoresPageObjects.ClicarGerenciar();
            gerenciarMarcadoresPageObjects.ClicarGerrenciarMarcador();
            gerenciarMarcadoresPageObjects.PreencherNomeMarcador(nomeMarcador);
            gerenciarMarcadoresPageObjects.PreencherDescricaoMarcador(descricaoMarcador);
            gerenciarMarcadoresPageObjects.CriarMarcador();
        }
    }
}
