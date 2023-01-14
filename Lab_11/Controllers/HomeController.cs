using Lab_11.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Lab_11.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger) =>
        _logger = logger;
    public IActionResult Index() =>
        View();
    public IActionResult PassUsingModel()
    {
        ResModel model = GetNewModel();

        return View(model);
    }
    public IActionResult PassUsingViewData()
    {
        ViewData["data"] = GetNewModel();

        return View();
    }
    public IActionResult PassUsingViewBag()
    {
        ViewBag.data = GetNewModel();

        return View();
    }
    public IActionResult PassUsingService() =>
        View();
    public ResModel GetNewModel()
    {
        Random rand = new Random(DateTime.Now.Second);
        int first = rand.Next(0, 10), second = rand.Next(0, 10);

        return new ResModel {
            firstNum = first,
            secondNum = second,
            sumResult = first + second,
            subResult = first - second,
            mulResult = first * second,
            divResult = (second == 0) ? -1 : first / second
        };
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error() =>
        View(new ErrorViewModel {
            RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier
        });
}
