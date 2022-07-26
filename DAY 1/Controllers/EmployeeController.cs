using Microsoft.AspNetCore.Mvc;
using WebApp1.Models;

namespace WebApp1.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {

            List<Employee> Emps = new List<Employee>() {
                new Employee() { Empid=101,Ename="Tushar",Ejob="Dev",Esal=20000,Edeptno=200 },
                new Employee() { Empid=102,Ename="Munish",Ejob="Manager",Esal=23000,Edeptno=205 },
                new Employee() { Empid=103,Ename="Dinesh",Ejob="Manager",Esal=26000,Edeptno=200 },

            };

            return View(Emps);
        }

        public IActionResult Details(int id)
        {

            List<Employee> Emps = new List<Employee>() {
                new Employee(){ Empid=101,Ename="Tushar",Ejob="Dev",Esal=20000,Edeptno=200 },
                new Employee(){ Empid=101,Ename="Tushar",Ejob="Dev",Esal=20000,Edeptno=200 },
                new Employee(){ Empid=101,Ename="Tushar",Ejob="Dev",Esal=20000,Edeptno=200 }
            };


            Employee obj = Emps.SingleOrDefault(item => item.Empid == id);

            return View(obj);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Employee obj)
        {
            //return RedirectToAction("Index", HomeController);
            return RedirectToAction("Index");
            //return View();
        }


    }
}
