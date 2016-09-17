using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Spring.Context;
using Spring.Context.Support;

namespace Spring.demo.Winform
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(CreateForm<Form1>());
        }

        public static T CreateForm<T>()
        {
            T form = default(T);
            Type t = typeof(T);
            IApplicationContext context = ContextRegistry.GetContext();
            form = (T)context.GetObject(t.FullName);
            return form;
        }
    }
}
