using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CURS
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmEnrolees());
        }
    }

    static class Helper
    {
        static public System.Data.DataTable tempAddSpec = null;
        static public System.Data.DataTable tempAddExam = null;
    }
}
