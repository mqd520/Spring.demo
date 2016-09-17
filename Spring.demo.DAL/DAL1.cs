using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spring.demo.IDAL;

namespace Spring.demo.DAL
{
    public class DAL1 : IDAL1
    {
        public void Fun1()
        {
            System.Diagnostics.Trace.WriteLine("DAL1.DAL1()");
        }
    }
}
