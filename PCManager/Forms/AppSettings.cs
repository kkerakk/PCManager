using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PCManager.Forms
{
    public static class AppSettings
    {
        /// <summary>
        /// Properties that check if something was clicked in active form
        /// </summary>
        public static bool AppStatusModified { get; set; } = false;
        public  static string DefaultLanguage { get; set; }

    }

}
