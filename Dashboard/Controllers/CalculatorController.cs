using Dashboard.Models;
using Microsoft.AspNetCore.Mvc;

namespace Dashboard.Controllers
{
    public class CalculatorController : Controller
    {
        public IActionResult Index()
        {
            return View(new CalculatorModel());
        }

        [HttpPost]
        public IActionResult Calculate(CalculatorModel model, string operation)
        {
            // Perform calculations based on the selected operation (+, -, *, /).
            switch (operation)
            {
                case "+":
                    model.Result = model.Number1 + model.Number2;
                    break;
                case "-":
                    model.Result = model.Number1 - model.Number2;
                    break;
                case "*":
                    model.Result = model.Number1 * model.Number2;
                    break;
                case "/":
                    model.Result = model.Number1 / model.Number2;
                    break;
                case "%":
                    model.Result = model.Number1 / model.Number2;
                    break;
            }

            return View("Index", model);
        }

    }
}
