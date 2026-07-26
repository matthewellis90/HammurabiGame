using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hammurabi
{
    class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>

    
        static void Main()
        {
            World world = new World();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
