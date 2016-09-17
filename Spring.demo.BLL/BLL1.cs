using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spring.demo.IBLL;
using Spring.demo.IDAL;

namespace Spring.demo.BLL
{
    public class BLL1 : IBLL1
    {
        protected IDAL1 _dal1 { get; set; }

        public void Fun1()
        {
            System.Diagnostics.Debug.WriteLine("BLL1.Fun1()");
            if (_dal1 != null)
            {
                _dal1.Fun1();
            }
        }
    }
}
