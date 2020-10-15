using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IssueStackOverflow
{
    interface interfaceISportCar
    {
        bool Accelerate();
        string Brand { get; }
        int Speed { get; }
        int MaxSpeed { get; }
        string Status { get; }
        

    }
}
