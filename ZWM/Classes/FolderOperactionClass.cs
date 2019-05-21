using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZWM.Classes
{
    class FolderOperactionClass
    {
        #region Zwm_Instance_variables
        private string desktopPatch = @"Environment.GetFolderPath(Environment.SpecialFolder.Desktop)";
        private string baseFolderName = "ZWM-pliki";
        private string CurrentDirectory = @"Environment.CurrentDirectory";

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
            string[] files = System.IO.Directory.GetFiles(Path.Combine(CurrentDirectory, baseFolderName));

            // Copy the files and overwrite destination files if they already exist.
            foreach (string s in files)
            {
                // Use static Path methods to extract only the file name from the path.
                baseFolderName = System.IO.Path.GetFileName(s);
                desktopPatch = System.IO.Path.Combine(desktopPatch, baseFolderName);
                System.IO.File.Copy(s, desktopPatch, true);
            }

        }





        #endregion

    }
}
