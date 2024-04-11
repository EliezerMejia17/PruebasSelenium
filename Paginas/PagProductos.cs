using OpenQA.Selenium;
using PruebasSelenium.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PruebasSelenium.Paginas
{
  public class PagProductos
    {

       protected IWebDriver Driver;

        protected By ProductoBuscado = By.XPath("/html/body/div[2]/section/div[2]/div/div[2]/div/div/div/div[2]/ul/li[1]/div/div[1]/a[1]");
        protected By BotonDestacar = By.XPath("/html/body/div[2]/main/div[2]/div/section/div[1]/div[1]/div/a");

        protected By BotonListar = By.XPath("//*[@id=\"mode-list\"]");
        protected By SelectorFiltrar = By.XPath("//*[@id=\"element\"]/li[2]/div");
        protected By Seleccion = By.XPath("//*[@id=\"element\"]/li[2]/div/div[2]/div[1]");

		protected By BotonAgregarCarrito = By.Id("product-addtocart-button");
		protected By BotonCarrito = By.XPath("/html/body/div[2]/div[1]/nav/div[2]/div[2]/div[1]/div[2]/a");

        public PagProductos(IWebDriver driver)
        { 
            Driver = driver;
        }

        public void ListarProductos()
        {
            if (HerramientaWait.ElementoEstaPresente(Driver, ProductoBuscado,10))
            {
                Driver.FindElement(BotonListar).Click();
            }
			Driver.FindElement(BotonListar).Click();
		}

		public void DestacarProducto()
        {
			if (HerramientaWait.ElementoEstaPresente(Driver, BotonDestacar, 10))
			{
				Driver.FindElement(BotonDestacar).Click();
			}
		}

		public void seleccionarProducto()
		{
			if (HerramientaWait.ElementoEstaPresente(Driver, ProductoBuscado, 10))
			{
				Driver.FindElement(ProductoBuscado).Click();
			}
		}

		public void FiltrarProducto()
		{
			if (HerramientaWait.ElementoEstaPresente(Driver, SelectorFiltrar, 10))
			{
				Driver.FindElement(SelectorFiltrar).Click();
			}

			Driver.FindElement(Seleccion).Click();
		}

		public void AgregarCarrito()
		{
			if (HerramientaWait.ElementoEstaPresente(Driver, BotonAgregarCarrito, 10))
			{
				Driver.FindElement(BotonAgregarCarrito).Click();
			}
		}

		public void MostrarCarrito()
		{
			if (HerramientaWait.ElementoEstaPresente(Driver, BotonCarrito, 10))
			{
				Driver.FindElement(BotonCarrito).Click();
			}
		}

	}
}
