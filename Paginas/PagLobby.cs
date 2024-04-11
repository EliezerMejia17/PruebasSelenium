using OpenQA.Selenium;
using PruebasSelenium.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruebasSelenium.Paginas
{
    public class PagLobby
    {

        protected IWebDriver Driver;



    
        protected By BotonPerfil = By.XPath("/html/body/app-root/app-home-initial/div[2]/div/div/div/div/div/div/div/div/div[2]/div/div[2]/div[1]");

        protected By BarraBuscador = By.Id("search");

        protected By ProductoBuscado = By.Id("//*[@id=\"maincontent\"]/div[2]/div/div[2]/div/div/div/div[2]/ul/li[1]/div/div[1]");
   


       public PagLobby(IWebDriver driver)
        {
          Driver = driver;

        }


        public void BusquedaProducto(string producto)
        {
            Driver.FindElement(BarraBuscador).SendKeys(producto);
        }

        public void HacerBusqueda()
        {
            Driver.FindElement(BarraBuscador).SendKeys(OpenQA.Selenium.Keys.Enter); ;
    
        }



        public PagProductos SeleccionarPaginaProduct()
        {
            return new PagProductos(Driver);
        }


    }
 }

