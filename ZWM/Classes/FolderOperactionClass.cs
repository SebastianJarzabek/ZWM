using System;
using System.IO;
using System.IO.Compression;

namespace ZWM.Classes
{
    class FolderOperactionClass
    {
        #region Zwm_Instance_variables
        private string baseFolderName = "ZWM-pliki";
        private string zipFolder = "ZWM-pliki.zip";
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

        public void IfBaseFolderDontExistExtractIt()
        {
            ZipFile.ExtractToDirectory(Path.Combine(CurrentDirectory, zipFolder), desktopPatch);
        }
        #endregion
    }
}

