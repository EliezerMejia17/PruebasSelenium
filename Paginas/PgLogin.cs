using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebasSelenium.Paginas
{
    public class PgLogin
    {
        protected IWebDriver Driver;

        protected By Input_Usuario = By.Id("email");
        protected By Input_Passwd = By.Id("pass");
        protected By BotonLogin = By.XPath("/html/body/div[2]/main/div[2]/div/section/div/div[3]/div/div/div/form/div/button");


        public PgLogin(IWebDriver driver)
        {
            Driver = driver;
        }

        public void Usuario(string user)
        {
            Driver.FindElement(Input_Usuario).SendKeys(user);
        }

        public void Password(string password)
        {
            Driver.FindElement(Input_Passwd).SendKeys(password);
        }

		public void Logearse(string user, string password)
		{
			Usuario(user);
			Password(password);
		}

		public PagLobby ClickLoginBoton()
        {
            Driver.FindElement(BotonLogin).Click();
			return new PagLobby(Driver);
		}

		

    }


}

