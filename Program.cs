using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gartic
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Login login = new Login();

            Application.Run(login);
            if (login.DialogResult == DialogResult.OK)
            {
                Form1 Formm = new Form1();
               Formm.clientSocket = login.clientSocket;
                Formm.strName = login.strName;
                Formm.epServer = login.epServer;
                Formm.ShowDialog();
            }

        }
    }
}
