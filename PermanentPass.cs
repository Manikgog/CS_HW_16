using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_HW_16
{
    internal class PermanentPass : IPass
    {
        public bool Validate()
        {
            return true;
        }

        public void PrintInfo()
        {
            Console.WriteLine("Постоянный пропуск.");
        }

        public override string ToString()
        {
            return "permanent";
        }

        public DateTime GetEndDate()
        {
            return new DateTime();
        }
    }
}
