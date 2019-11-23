using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MonikaFoksLab1Zadanie
{
   

    static class Program
    {
        /// Gra "ZombieShooter" napisana jako zadanie domowe na pierwsze laboratoria KN Kredek.
        /// Autor: Monika Foks
        
        [STAThread]
        //główna funkcja main allikacji inicjująca jej start
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            MainWindow mainWindow = new MainWindow();
            Application.Run(mainWindow);
        }
    }
}
