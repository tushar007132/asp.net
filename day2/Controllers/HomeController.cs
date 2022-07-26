using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplicationEmp.Models;

namespace WebApplicationEmp.Controllers
{
    public class EmployeeController : Controller
    {

        EmployeeManager context = new EmployeeManager();
        public IActionResult Index()
        {
            List<Employee> emps = context.GetAllEmps();
            return View(emps);
        }

        [HttpGet]
        public IActionResult Create()
        {

            return View();
        }

        [HttpPost]
        public IActionResult Create(Employee obj)
        {
            if (ModelState.IsValid == true)
            {
                // Save the data
                context.AddEmployee(obj);
                return RedirectToAction("Index");

            }
            else
            {

                ViewBag.RequestType = Request.Method;
                ViewBag.ErrorMessage = "Invalid data";
                return View();
            }
        }

        public IActionResult Details(int id)
        {
            Employee obj = context.GetEmployeeById(id);
            return View(obj);
        }


        [HttpGet]
        public IActionResult Edit(int id)
        {
            Employee obj = context.GetEmployeeById(id);
            return View(obj);
        }

        [HttpPost]
        public IActionResult Edit(Employee obj)
        {
            if (ModelState.IsValid == true)
            {
                // Save the data
                context.UpdateEmployee(obj);
                return RedirectToAction("Index");

            }
            else
            {

                ViewBag.RequestType = Request.Method;
                ViewBag.ErrorMessage = "Invalid data";
                return View();
            }
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            Employee obj = context.GetEmployeeById(id);
            return View(obj);
        }

        [HttpPost]
        [ActionName("Delete")]
        public IActionResult DeleteConfirm(int id)
        {
            context.DeleteEmployee(id);
            return RedirectToAction("Index");


            // List<Product> products = context.GetAllDets();
            // return View("Index", products);
        }


    }
}