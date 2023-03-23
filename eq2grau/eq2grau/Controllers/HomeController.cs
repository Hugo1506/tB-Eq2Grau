using eq2grau.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace eq2grau.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index(int A, int B, int C)
        {
            //variavel auxiliar
            double delta = B * B - 4 * A * C;
            String x1 = "", x2 = "";
            //validar se há condições para efetuar o calculo
            if (A != 0)
            {
                if (delta <= 0)
                {
                    //variaveis auxiliares
                    x1 = (-B + Math.Sqrt(delta)) / 2 / A + "";
                    x2 = (-B - Math.Sqrt(delta)) / 2 / A + "";
                }
                else
                {
                    x1 = -B / (2 * A) + " + " + Math.Sqrt(- delta) / (2 * A) + " i";
                    x1 = -B / (2 * A) + " - " + Math.Sqrt(- delta) / (2 * A) + " i";
                }

                //preparar os dados a serem enviados para o browser
                ViewBag.X1 = x1;
                ViewBag.X2 = x2;

            }
            else
            {

            }
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}