using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_MVVM_EF6_MSSQL.Models
{
    public class EmployeeService
    {
        private static List<Employee> objEmployeesList;

        public EmployeeService()
        {
            objEmployeesList = new List<Employee>()
            {
                new Employee { Id=101, Name="Mayur", Age=32}
            };
        }

        public List<Employee> GetAll()
        {
            return objEmployeesList;
        }

        public bool Add(Employee ObjNewEmolyeeList)
        {
            if (ObjNewEmolyeeList.Age < 21 || ObjNewEmolyeeList.Age > 50)
                throw new ArgumentException("Invaild age limit for Employee");

            objEmployeesList.Add(ObjNewEmolyeeList);
            return true;
        }

        public bool Update(Employee ObjEmployeeUpdate)
        {
            bool IsUpdated = false;
            for (int index = 0; index < objEmployeesList.Count; index++) 
            {
                if (objEmployeesList[index].Id == ObjEmployeeUpdate.Id) 
                {
                    objEmployeesList[index].Name = ObjEmployeeUpdate.Name;
                    objEmployeesList[index].Age = ObjEmployeeUpdate.Age;
                    IsUpdated = true;
                    break;
                }
            }
            return IsUpdated;
        }

        public bool Delete(int id)
        {
            bool IsDeleted = false;
            for (int index = 0; index < objEmployeesList.Count; index++)
            {
                if (objEmployeesList[index].Id == id) 
                {
                    objEmployeesList.RemoveAt(index);
                    IsDeleted = true;
                    break;
                }
            }
            return IsDeleted;
        }

        public Employee Search(int id)
        {
            return objEmployeesList.FirstOrDefault(e => e.Id == id);
        }

        ////Improvement
        //private static List<Employee> objEmployeesList;

        //public EmployeeService()
        //{
        //    objEmployeesList = new List<Employee>
        //{
        //    new Employee { Id = 101, Name = "Mayur", Age = 32 }
        //};
        //}

        //public IEnumerable<Employee> GetAll()
        //{
        //    return objEmployeesList.AsReadOnly();
        //}

        //public bool Add(Employee newEmployee)
        //{
        //    ValidateAge(newEmployee.Age);

        //    objEmployeesList.Add(newEmployee);
        //    return true;
        //}

        //public bool Update(Employee updatedEmployee)
        //{
        //    var employeeToUpdate = objEmployeesList.FirstOrDefault(e => e.Id == updatedEmployee.Id);

        //    if (employeeToUpdate != null)
        //    {
        //        employeeToUpdate.Name = updatedEmployee.Name;
        //        employeeToUpdate.Age = updatedEmployee.Age;
        //        return true;
        //    }

        //    return false;
        //}

        //public bool Delete(int id)
        //{
        //    var employeeToDelete = objEmployeesList.FirstOrDefault(e => e.Id == id);

        //    if (employeeToDelete != null)
        //    {
        //        objEmployeesList.Remove(employeeToDelete);
        //        return true;
        //    }

        //    return false;
        //}

        //public Employee Search(int id)
        //{
        //    return objEmployeesList.FirstOrDefault(e => e.Id == id);
        //}

        //private void ValidateAge(int age)
        //{
        //    if (age < 21 || age > 50)
        //    {
        //        throw new ArgumentException("Invalid age limit for Employee. Age must be between 21 and 50.");
        //    }
        //}


    }
}
