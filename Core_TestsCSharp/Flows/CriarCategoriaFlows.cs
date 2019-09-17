using Core_TestsCSharp.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_TestsCSharp.Flows
{
    class CriarCategoriaFlows
    {
        public void CriarCategoriaDefault()
        {
            LoginFlows loginFlows = new LoginFlows();
            EditarProjetoPageObjects editarProjetoPageObjects = new EditarProjetoPageObjects();

            string categoria = "Categoria Projeto Base2";

            loginFlows.EfetuarLoginComUsuarioDefault();

            editarProjetoPageObjects.ClicarGerenciar();
            editarProjetoPageObjects.ClicarGerenciarProjetos();
            editarProjetoPageObjects.PreencherCategoriaProjeto(categoria);
            editarProjetoPageObjects.ClicarAdicionarCategoria();
        }


    }
}
