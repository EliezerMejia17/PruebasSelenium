using NUnit.Framework.Legacy;
using NUnit.Framework;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;
using PruebasSelenium.Paginas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using AventStack.ExtentReports.Model;
using AventStack.ExtentReports;
using PruebasSelenium.Tools;

namespace PruebasSelenium.Pruebas
{
    [TestFixture]
    public class PruebaLogin
    {
        protected IWebDriver Driver;
        protected ExtentTest reporte;


        [SetUp]
        public void InicioPrueba()
        {
            Driver = new FirefoxDriver();
            Driver.Navigate().GoToUrl("https://jumbo.com.do/customer/account/login");
            Driver.Manage().Window.Maximize();
            reporte = HerramientaReportes.ObtenerReporte().CreateTest(TestContext.CurrentContext.Test.Name);

        }

        [Test]
        public void LoginCorrecto()
        {

            reporte.Log(Status.Info, "Prueba de login");
            PgLogin pglogin = new PgLogin(Driver);
            HerramientaCaptura.TomarCaptura(Driver, "PruebaLogin", "capLogin");
			pglogin.Logearse("eliezermejia161704@gmail.com", "Eliezer161704");
			HerramientaCaptura.TomarCaptura(Driver, "PruebaLogin", "capCredenciales");
			PagLobby pagLobby = pglogin.ClickLoginBoton();
			HerramientaCaptura.TomarCaptura(Driver, "PruebaLogin", "capCredencialesCorrectas");
			Thread.Sleep(2000);

            

        }

        [TearDown]
        public void TerminoPrueba()
        {
            HerramientaReportes.ObtenerReporte().Flush();
            Driver.Quit();
        }

    }

 }
