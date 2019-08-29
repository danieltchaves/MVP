using MVP.BusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unity;

namespace MVP
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            IUnityContainer unity = new UnityContainer()
                                    .RegisterType<ICadastroClienteView, Form1>()
                                    .RegisterType<ICliente, Cliente>();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1(new Cliente()));
            //Application.Run((Form1)unity);
        }
    }
}
