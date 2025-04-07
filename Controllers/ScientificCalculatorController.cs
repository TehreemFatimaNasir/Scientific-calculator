using Microsoft.AspNetCore.Mvc;

namespace scientific_calculator.Controllers
{
    public class ScientificCalculatorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(double num1, double num2, string operation)
        {
            double result = 0;

            if (operation == "Add")
            {
                result = num1 + num2;
            }
            else if (operation == "Subtract")
            {
                result = num1 - num2;
            }
            else if (operation == "Multiply")
            {
                result = num1 * num2;
            }
            else if (operation == "Divide")
            {
                if (num2 != 0)
                {
                    result = num1 / num2;
                }
            }
            else if (operation == "SquareRoot")
            {
                result = Math.Sqrt(num1);
            }
            else if (operation == "Sin")
            {
                result = Math.Sin(num1 / 180);
            }
            else if (operation == "Cos")
            {
                result = Math.Cos(num1 / 180);
            }
            else if (operation == "Tan")
            {
                result = Math.Tan(num1 / 180);
            }

            ViewBag.Result = result; 
            return View();
        }

    }
}