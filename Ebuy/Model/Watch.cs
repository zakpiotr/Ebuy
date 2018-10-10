using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ebuy.Model
{
    public class Watch : Product
    {
        public BeltType BeltType { get; set; }

        public int Weight { get; set; }
        public int Lenght { get; set; }

    }
}
