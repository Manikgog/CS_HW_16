using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_HW_16
{
    internal class PassSystem
    {
        List<Tuple<Employee, IPass>> registerList;

        public PassSystem()
        {
            registerList = new List<Tuple<Employee, IPass>>();
        }

        public void RegisterEmployee(Employee employee)
        {
            IPass pass = new PermanentPass();
            Tuple<Employee, IPass> regline = new Tuple<Employee, IPass>(employee, pass);
            registerList.Add(regline);
        }

        public void RegisterEmployee(Employee employee, DateTime dt_start_pass, DateTime dt_end_pass)
        {
            IPass pass = new TemporaryPass(dt_start_pass, dt_end_pass);
            Tuple<Employee, IPass> regline = new Tuple<Employee, IPass>(employee, pass);
            registerList.Add(regline);
        }

        public DateTime EnterDate()
        {
            Console.Write("Введите день: ");
            int day = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите месяц: ");
            int month = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите год: ");
            int year = Convert.ToInt32(Console.ReadLine());
            return new DateTime(year, month, day);
        }

        public void Print()
        {
            foreach(var item in registerList)
            {
                Console.WriteLine(item.Item1.ToString()); 
                item.Item2.PrintInfo();
                Console.WriteLine();
            }
        }

        public List<Employee> GetEmployeesWithPermanentPass()
        {
            List<Employee> employees = new List<Employee>();

            employees = registerList.Where(employee => employee.Item2.ToString().Equals("permanent")).Select(employee => employee.Item1).ToList();

            return employees;
        }

        public List<Employee> GetEmployeesWithTempNow()
        {
            List<Employee> employees = new List<Employee>();

            employees = registerList.Where(employee => employee.Item2.GetEndDate().Date == DateTime.Now.Date)
                                    .Select(employee => employee.Item1).ToList();

            return employees;
        }

        public bool AccessControl(Employee employee)
        {
            if(employee == null)
            {
                return false;
            }
            foreach(var item in registerList)
            {
                if(item.Item1.Equals(employee))
                {
                    if (item.Item2.Validate())
                    {
                        
                        Console.WriteLine(item.Item1.ToString() + ". Пропуск действителен.");
                        return true;
                    }
                    Console.WriteLine(item.Item1.ToString() + ". Пропуск просрочен.");
                }
            }
            return false;
        }

    }
}
