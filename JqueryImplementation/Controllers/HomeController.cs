namespace JqueryImplementation.Controllers
{
    using System.Diagnostics;
    using JqueryImplementation.Models;
    using Microsoft.AspNetCore.Mvc;

    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            this._logger = logger;
        }

        public IActionResult Index()
        {
            return this.View();
        }

        public IActionResult Privacy()
        {
            return this.View();
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee { Id = 1, Name = "Raja", State = "Andra", city = "Atp", Salary = 32341 },
                new Employee { Id = 2, Name = "Sekhar", State = "Telangana", city = "Hyd", Salary = 35563},
            };

            return this.View(employees);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return this.View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? this.HttpContext.TraceIdentifier });
        }
    }
}
