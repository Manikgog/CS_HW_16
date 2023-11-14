using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_HW_16
{
    internal class TemporaryPass : IPass
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public TemporaryPass(DateTime startDate, DateTime endDate)
        {
            StartDate = startDate;
            EndDate = endDate;
        }

        public DateTime GetEndDate()
        {
            return EndDate;
        }

        public bool Validate()
        {
            if(DateTime.Now > StartDate && DateTime.Now < EndDate) 
            {
                return true;
            }
            return false;
        }

        public void PrintInfo()
        {
            Console.WriteLine("Временный пропуск. Дата начала действия: " + 
                                StartDate.ToString() + 
                                "; Дата окончания действия: " + 
                                EndDate.ToString() + ".");
        }
    }
}
