﻿using OpenQA.Selenium;

namespace PatternsInAutomation.Tests.Advanced.PageObjectv20.Base
{
    public abstract class BaseElementMap
    {
        protected IWebDriver driver;

        public BaseElementMap(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void SwitchToDefault()
        {
            this.driver.SwitchTo().DefaultContent();
        }
    }
}
