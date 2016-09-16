using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spring.demo.IBLL;

namespace Spring.demo.BLL
{
    public class BLL1 : IBLL1
    {
        public void test1()
        {
            System.Diagnostics.Debug.WriteLine("BLL1.test1()");
        }
    }
}
