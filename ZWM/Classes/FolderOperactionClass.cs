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
        private string desktopPatch = @"Environment.SpecialFolder.Desktop";
        private string baseFolderName = "ZWM-pliki";
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
            CopyFolder(CurrentDirectory, desktopPatch);
            #endregion
        }
        static public void CopyFolder(string sourceFolder, string destFolder)
        {
            if (!Directory.Exists(baseFolderName))
                Directory.CreateDirectory(destFolder);
            string[] files = Directory.GetFiles(sourceFolder);
            foreach (string file in files)
            {
                string name = Path.GetFileName(file);
                string dest = Path.Combine(destFolder, name);
                File.Copy(file, dest);
            }
            string[] folders = Directory.GetDirectories(sourceFolder);
            foreach (string folder in folders)
            {
                string name = Path.GetFileName(folder);
                string dest = Path.Combine(destFolder, name);
                CopyFolder(folder, dest);
            }
        }
    }
}
