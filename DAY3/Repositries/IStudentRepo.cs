using Day3_Task1_.Models;

namespace Day3_Task1_.Repositries
{

        public interface IEmployeeRepo
        {
            List<Employee> GetAllEmployees();
            Employee GetEmployeeById(int id);
            void AddEmployee(Employee obj);
            void UpdateEmployee(Employee obj);
            void DeleteEmployee(int id);
        }
    }

