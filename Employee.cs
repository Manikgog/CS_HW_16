using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_HW_16
{
    internal class Employee
    {
        public int EmployeeId { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Position { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }

        public Employee() { }

        public Employee(int employeeId, string lastName, string firstName, 
                        string position, string login, string password)
        {
            EmployeeId=employeeId;
            LastName=lastName;
            FirstName=firstName;
            Position=position;
            Login=login;
            Password=password;
        }

        public override string ToString()
        {
            return "ID: " + EmployeeId + "; Фамилия: " + LastName + "; Имя: " + FirstName + 
                    "; Должность: " + Position + "; Login: " + Login + "; Password: " + Password;
        }
    }
}
