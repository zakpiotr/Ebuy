using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ebuy.Model
{
    public class Car : Product
    {
        public decimal EngineCapacity { get; set; } 
        public int SeatNumber { get; set; }
    }
}
