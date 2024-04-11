using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AventStack.ExtentReports.Reporter;
using AventStack.ExtentReports;

namespace PruebasSelenium.Tools
{
    public class HerramientaReportes
    {
        private static ExtentReports reporte;
        private static ExtentSparkReporter ReporteHTML;
        public static ExtentReports ObtenerReporte()
        {
            if (reporte == null)
            {
                string Ruta = @"C:\Users\Eliezer\Documents\PruebasSelenium\Reports\Reporte.html";
                ReporteHTML = new ExtentSparkReporter(Ruta);
                reporte = new ExtentReports();
                reporte.AttachReporter(ReporteHTML);
            }
            return reporte;
        }

    }
}
