using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Spring.demo.IBLL;

namespace Spring.demo.UI
{
    public partial class Form1 : Form
    {
        protected IBLL1 _BLL1 { get; set; }
        protected string _BLL2 { get; set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (_BLL1 != null)
            {
                Console.WriteLine("_BLL1: test1()");
            }
            if (!string.IsNullOrEmpty(_BLL2))
            {
                Console.WriteLine("_BLL2");
            }
        }
    }
}
