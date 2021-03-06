﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZWM.Classes
{
    class FilleOperationClass
    {
        #region Zwm_Instance_variables
        private string fileZWMToAddPatch = @"";
        private string archivesFolderPatch = @"Environment.GetFolderPath(Environment.SpecialFolder.Desktop)";
        private string zwmfolderPatch = @"ZWM-pliki\Archiwum\ZWM";
        private string wzFolderPatch = @"ZWM-pliki\Archiwum\WZ";
        private string CurrentDirectory = @"Environment.CurrentDirectory";
        private int orderId;
        private string name;
        private string surname;
        private string contractNumber;
        private string kilometer;
        private DateTime plannedDateOfReceipt;

        private string newZWMFileName;
        private string newWZFileName;
        private string newfilename;
        #endregion Zwm_Instance_variables

        #region Zwm_Instance_variables_Property

        public int orderIdProperty
        {
            get { return orderId; }
            set { orderId = value; }
        }
        public string nameProperty
        {
            get { return name; }
            set { name = value; }
        }
        public string surnameProperty
        {
            get { return surname; }
            set { surname = value; }
        }
        public string contractNumberProperty
        {
            get { return contractNumber; }
            set { contractNumber = value; }
        }
        public string kilometerProperty
        {
            get { return kilometer; }
            set { kilometer = value; }
        }
        public DateTime plannedDateOfReceiptProperty
        {
            get { return plannedDateOfReceipt; }
            set { plannedDateOfReceipt = value; }
        }

        public string newZWMFileNameProperty
        {
            get { return newZWMFileName; }
            set { newZWMFileName = value; }
        }


        public string newWZFileNameProperty
        {
            get { return newWZFileName; }
            set { newWZFileName = value; }
        }
        #endregion

        #region constructor

        public FilleOperationClass(int orderId, string contractNumber, string kilometer, DateTime plannedDateOfReceipt)
        {
            this.orderId=orderId;
            this.contractNumber=contractNumber;
            this.kilometer=kilometer;
            this.plannedDateOfReceipt=plannedDateOfReceipt;
    }

        #endregion constructor

        #region methods

        public string Filename(string documentType, int orderId, string contractNumber, string kilometer, DateTime plannedDateOfReceipt)
        {
            StringBuilder StringBuildernewfilename = new StringBuilder();
            StringBuildernewfilename.Append(documentType).Append(orderId).Append(contractNumber).Append(kilometer).Append(Convert.ToString(plannedDateOfReceipt));

            return Convert.ToString(StringBuildernewfilename);
        }

        public void CopyAndRenameZWMFile()
        {
            string documentType = "ZWM";
            //orderId dostaje pustą wartość - brak bazy
            System.IO.File.Copy(fileZWMToAddPatch, Path.Combine(archivesFolderPatch, zwmfolderPatch, Filename(documentType, orderId, contractNumber, kilometer, plannedDateOfReceipt)), true);
        }

        public string CreateWZFile()
        {
            string documentType = "WZ";

            System.IO.File.Copy(fileZWMToAddPatch, Path.Combine(archivesFolderPatch, zwmfolderPatch, Filename(documentType, orderId, contractNumber, kilometer, plannedDateOfReceipt)), true);
            return newWZFileName;
        }//Nie skonczone brak pliku do zapisu, jedynie nadaje nazwe





        #endregion

    }
}
