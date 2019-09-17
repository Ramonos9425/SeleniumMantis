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
    class LogoutTests : TestBase
    {
        [Test]
        public void Logout()
        {
            LogoutPageObjects logoutPageObjects = new LogoutPageObjects();
            LoginFlows loginFlows = new LoginFlows();

            loginFlows.EfetuarLoginComUsuarioDefault();
            Assert.IsTrue(logoutPageObjects.Logout());
        }


    }
}
