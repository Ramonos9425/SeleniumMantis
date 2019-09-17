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
    class LogoutPageObjects : PageBase
    {
        #region Mapping

        By BtLogout = By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='teste'])[1]/following::a[1]");
        By BtSair = By.LinkText("Sair");
        By BtEntrar = By.XPath("//input[@value='Entrar']");

        #endregion

        #region Actions

        public bool Logout()
        {
            Click(BtLogout);
            Click(BtSair);

            Assert.IsTrue(ReturnIfElementIsDisplayed(BtEntrar));
            return ReturnIfElementIsDisplayed(BtEntrar);
        }

        #endregion

    }
}
