using AventStack.ExtentReports;
using NUnit.Framework;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;
using PruebasSelenium.Paginas;
using PruebasSelenium.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PruebasSelenium.Pruebas
{
   

        [TestFixture]
        public class PruebaBusqueda
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
            public void RealizarBusqueda()
            {
                PgLogin pglogin = new PgLogin(Driver);
                pglogin.Logearse("eliezermejia161704@gmail.com", "Eliezer161704");
			    PagLobby pagLobby = pglogin.ClickLoginBoton();

			reporte.Log(Status.Info, "Prueba de Busqueda de un producto");
                pagLobby.BusquedaProducto("Carnes");
            HerramientaCaptura.TomarCaptura(Driver, "PruebaBusqueda", "capBusqueda");
            Thread.Sleep(1000);
            pagLobby.HacerBusqueda();
            HerramientaCaptura.TomarCaptura(Driver, "PruebaBusqueda", "capResultadoBusqueda");
            Thread.Sleep(1000);

            }

            [TearDown]
            public void TerminoPrueba()
            {
                HerramientaReportes.ObtenerReporte().Flush();
                Driver.Quit();
            }

        }
}

