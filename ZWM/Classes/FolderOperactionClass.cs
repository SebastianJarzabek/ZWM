using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace ZWM.Classes
{
    class FolderOperactionClass
    {
        #region Zwm_Instance_variables
        private string baseFolderName = "ZWM-pliki";
        private string desktopPatch = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        
        private string CurrentDirectory = Directory.GetCurrentDirectory();
        #endregion Zwm_Instance_variables
        #region Zwm_Instance_variables_Property

        #endregion
        #region constructor

        public FolderOperactionClass()
        {

        }
        #endregion constructor

        #region methods
        public bool IsBaseFolderZWMExist()
        {
            if (File.Exists(Path.Combine(desktopPatch, baseFolderName)))
                return true;
            return false;
        }

        public void IfBaseFolderDontExistCopyIt()
        {
            //Przeniesie plik, a nie skopiuje -----Do poprawki
            Directory.Move(Path.Combine(CurrentDirectory, baseFolderName), Path.Combine(desktopPatch, baseFolderName));
            
        }
        #endregion
    }
}

