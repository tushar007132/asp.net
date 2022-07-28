using Microsoft.AspNetCore.Mvc;
using Day3_Task1_.Models;
using Day3_Task1_.Repositries;
using Day3_Task1_.Filters;

namespace Day3_Task1_.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        IEmployeeRepo _employee;
        public EmployeeController(IEmployeeRepo employee, ILogger<HomeController> logger)
        {
            _employee = employee;
            _logger = logger;
        }

        public IActionResult Index()
        {
           
            return View();
        }

        [TypeFilter(typeof(MyExceptionFilter))]
        [HttpGet]
        public IActionResult Create()
        {
            _logger.LogInformation("Create Action is Processed.");
            return View();
        }
        [TypeFilter(typeof(MyExceptionFilter))]
        [HttpPost]
        public IActionResult Create(Employee obj)
        {
            _logger.LogInformation("Create Action is Processed.");
            _employee.AddEmployee(obj);
            return RedirectToAction("Index");
        }

        [TypeFilter(typeof(MyExceptionFilter))]
        public IActionResult Details(int id)
        {
            _logger.LogInformation("Details Action is Processed.");
            Employee obj = _employee.GetEmployeeById(id);
            return View(obj);
        }

        [TypeFilter(typeof(MyExceptionFilter))]
        [HttpGet]
        public IActionResult Edit(int id)
        {
            _logger.LogInformation("Edit Action is Processed.");
            Employee obj = _employee.GetEmployeeById(id);
            return View(obj);
        }

        [TypeFilter(typeof(MyExceptionFilter))]
        [HttpPost]
        public IActionResult Edit(Employee obj)
        {
            _logger.LogInformation("Edit Action is Processed.");
            _employee.UpdateEmployee(obj);
            return RedirectToAction("Index");
        }

        [TypeFilter(typeof(MyExceptionFilter))]
        [HttpGet]
        public IActionResult Delete(int id)
        {
            _logger.LogInformation("Delete Action is Processed.");
            Employee obj = _employee.GetEmployeeById(id);
            return View(obj);
        }

        [HttpPost]
        [TypeFilter(typeof(MyExceptionFilter))]
        
        public IActionResult DeleteConfirm(int id)
        {
            _logger.LogInformation("Delete confirm Action is Processed.");
            Employee obj = _employee.GetEmployeeById(id);
            _employee.DeleteEmployee(id);
            
            return RedirectToAction("Index");
        }

    }
}


