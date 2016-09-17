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

namespace Spring.demo.Winform
{
    public partial class Form1 : Form
    {
        protected string _string { get; set; }
        protected IBLL1 _bll1 { get; set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(_string))
            {
                System.Diagnostics.Debug.WriteLine(_string);
            }
            if (_bll1 != null)
            {
                _bll1.Fun1();
            }
        }
    }
}
