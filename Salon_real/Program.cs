using System;
using System.Collections.Generic;
using System.Linq;
using DMSoft;
using System.Windows.Forms;

namespace Salon_real
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            SkinCrafter.Init();
            SkinCrafter skinobj = new SkinCrafter();
            skinobj.InitDecoration(true);
            skinobj.SkinFile = @"C:\Program Files\SkinCrafter3\SkinCrafterDemo\Skins\Zondar.skf";
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Principal());
            skinobj.ApplySkin();
            skinobj.DeInitDecoration();
            SkinCrafter.Terminate();
        }
    }
}
