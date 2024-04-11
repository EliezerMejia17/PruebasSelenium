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
    public class PruebaCarrito
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
        public void AgregarProducto_Carrito()
        {
            PgLogin pglogin = new PgLogin(Driver);
            pglogin.Logearse("eliezermejia161704@gmail.com", "Eliezer161704");
            PagLobby pagLobby = pglogin.ClickLoginBoton();
			pagLobby.BusquedaProducto("jamon");
            pagLobby.HacerBusqueda();

            PagProductos pagproductos = pagLobby.SeleccionarPaginaProduct();
            reporte.Log(Status.Info, "Seleccionando Producto");
            pagproductos.seleccionarProducto();
            Thread.Sleep(5000);
            reporte.Log(Status.Info, "Agregando el producto al Carrito");
            pagproductos.AgregarCarrito();
            Thread.Sleep(1000);
            HerramientaCaptura.TomarCaptura(Driver, "PruebaCarrito", "capAgredandoProducto");


            reporte.Log(Status.Info, "Mostrando el carrito");
            pagproductos.MostrarCarrito();
            Thread.Sleep(2000);
            HerramientaCaptura.TomarCaptura(Driver, "PruebaCarrito", "capCarritoMostrado");


        }

        [TearDown]
        public void TerminoPrueba()
        {
            HerramientaReportes.ObtenerReporte().Flush();
            Driver.Quit();
        }

    }
}

