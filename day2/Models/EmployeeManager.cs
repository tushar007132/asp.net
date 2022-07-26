using WebApplicationEmp.Controllers;

namespace WebApplicationEmp.Models
{
    public class EmployeeManager

    {
        List<Employee> emps = new List<Employee>();

        public EmployeeManager()
        {
            emps = new List<Employee>() {
                new Employee(){ Empid = 1022, Ename = "Tushar", Ejob = "Developer",Esal=23450, Edeptno = 54 },
                new Employee(){ Empid = 10243, Ename = "Pritam", Ejob = "Manager",Esal=20450, Edeptno = 50 }

            };
        }

        public List<Employee> GetAllEmps()
        {
            return emps;
        }

        public Employee GetEmployeeById(int id)
        {
            return emps.Find(item=>item.Empid == id);
        }

        public void AddEmployee(Employee obj)
        {
            emps.Add(obj);
        }

        public void DeleteEmployee(int id)
        {
            Employee obj = emps.Find(item => item.Empid == id);
            emps.Remove(obj);
        }

        public void UpdateEmployee(Employee updateobj)
        {
            Employee obj = emps.Find(item => item.Empid == updateobj.Empid);
            emps.Remove(obj);
            emps.Add(updateobj);
        }
    }
}
