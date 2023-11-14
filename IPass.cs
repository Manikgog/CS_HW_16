using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_HW_16
{
    internal interface IPass
    {
        bool Validate();
        void PrintInfo();

        DateTime GetEndDate();

    }
}
