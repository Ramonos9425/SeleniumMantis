using Core_TestsCSharp.Bases;
using Core_TestsCSharp.Flows;
using Core_TestsCSharp.Pages;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_TestsCSharp.Tests
{
    class EditarProjetoTests : TestBase
    {
        [Test]
        public void EditarProjeto()
        {
            LoginFlows loginFlows = new LoginFlows();
            CriarProjetoFlows criarProjetoFlows = new CriarProjetoFlows();
            EditarProjetoPageObjects editarProjetoPageObjects = new EditarProjetoPageObjects();

            string estado = "estável";
            string descricao = "-Continuação";

            loginFlows.EfetuarLoginComUsuarioDefault();
            criarProjetoFlows.CriarProjetoDefault();

            editarProjetoPageObjects.ClicarGerenciar();
            editarProjetoPageObjects.ClicarGerenciarProjetos();
            editarProjetoPageObjects.ClicarProjetoCriado();
            editarProjetoPageObjects.SelecionarEstadoProjeto(estado);
            editarProjetoPageObjects.PreencherDescricaoProjeto(descricao);
            editarProjetoPageObjects.ClicarAtualizarProjeto();

            Assert.IsTrue(editarProjetoPageObjects.RetornaSeProjetoEditado());
        }

        [Test]
        public void CriarCategoria()//Não precisa de um projeto criado
        {
            LoginFlows loginFlows = new LoginFlows();
            EditarProjetoPageObjects editarProjetoPageObjects = new EditarProjetoPageObjects();

            string categoria = "Categoria Projeto Base2";

            loginFlows.EfetuarLoginComUsuarioDefault();

            editarProjetoPageObjects.ClicarGerenciar();
            editarProjetoPageObjects.ClicarGerenciarProjetos();
            editarProjetoPageObjects.PreencherCategoriaProjeto(categoria);
            editarProjetoPageObjects.ClicarAdicionarCategoria();

            Assert.IsTrue(editarProjetoPageObjects.RetornaSeCategoriaCriada());
        }

        [Test]
        public void CriarCategoriaExistente()
        {
            LoginFlows loginFlows = new LoginFlows();
            EditarProjetoPageObjects editarProjetoPageObjects = new EditarProjetoPageObjects();
            CriarCategoriaFlows criarCategoriaFlows = new CriarCategoriaFlows();

            string categoria = "Categoria Projeto Base2";

            loginFlows.EfetuarLoginComUsuarioDefault();

            editarProjetoPageObjects.ClicarGerenciar();
            editarProjetoPageObjects.ClicarGerenciarProjetos();
            editarProjetoPageObjects.PreencherCategoriaProjeto(categoria);
            editarProjetoPageObjects.ClicarAdicionarCategoria();

            Assert.IsTrue(editarProjetoPageObjects.RetornaSeCategoriaExiste());
        }

        [Test]
        public void EditarCategoria()
        {
            LoginFlows loginFlows = new LoginFlows();
            EditarProjetoPageObjects editarProjetoPageObjects = new EditarProjetoPageObjects();

            string categoria = "-Parte1";

            loginFlows.EfetuarLoginComUsuarioDefault();

            editarProjetoPageObjects.ClicarGerenciar();
            editarProjetoPageObjects.ClicarGerenciarProjetos();
            editarProjetoPageObjects.ClicarAlterarCategoria();
            editarProjetoPageObjects.PreencherCategoriaProjeto(categoria);
            editarProjetoPageObjects.ClicarAtualizarCategoria();

            Assert.IsTrue(editarProjetoPageObjects.RetornaSeCategoriaAlterada());
          
        }

     }
}
