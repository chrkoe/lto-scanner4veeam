using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Backup_Scanner
{
    static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        /// 
        private static void initiateConfigFile()
        {
            try
            {
                Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + Path.DirectorySeparatorChar + "Backup-Scanner");
                System.Console.WriteLine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + Path.DirectorySeparatorChar + "Backup-Scanner");
                if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + Path.DirectorySeparatorChar + "Backup-Scanner" + Path.DirectorySeparatorChar + "Settings.config"))
                {
                    if (File.Exists(Directory.GetCurrentDirectory() + Path.DirectorySeparatorChar + "Settings.config"))
                        File.Copy(Directory.GetCurrentDirectory() + Path.DirectorySeparatorChar + "Settings.config", Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + Path.DirectorySeparatorChar + "Backup-Scanner" + Path.DirectorySeparatorChar + "Settings.config");
                    else
                        File.Create(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + Path.DirectorySeparatorChar + "Backup-Scanner" + Path.DirectorySeparatorChar + "Settings.config");
                }
            } catch (Exception e)
            {
                System.Console.WriteLine(e.Message);
            }
        }
        [STAThread]
        static void Main()
        {
            initiateConfigFile();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new DefaultWindow());
        }
    }
}
