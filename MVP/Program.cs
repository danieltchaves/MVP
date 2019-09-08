using MVP.Repository;
using MVP.Commands;
using System;
using System.Windows.Forms;

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
            //IUnityContainer unity = new UnityContainer()
            //                        .RegisterType<ICadastroClienteView, Form1>()
            //                        .RegisterType<IClienteRepository, ClienteRepository>();
            //Application.Run((Form1)unity);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1(new ClienteCommandHandler(new ClienteRepository())));
        }
    }
}
