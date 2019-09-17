using Core_TestsCSharp.Bases;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_TestsCSharp.Pages
{
    class MinhaVisaoPageObjects : PageBase
    {
        #region Mapping

        By LtMinhaVisao = By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Sair'])[1]/following::span[1]");

        #endregion

        #region Actions

        public bool retornaSeBotaoEstaVisivel()
        {
            return ReturnIfElementIsDisplayed(LtMinhaVisao);
        }

        #endregion


    }
}
