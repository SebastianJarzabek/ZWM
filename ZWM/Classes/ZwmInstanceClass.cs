using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZWM.Classes
{
    class ZwmInstanceClass
    {
        #region Zwm_Instance_variables

        private int orderId;
        private string name;
        private string surname;
        private string contractNumber;
        private string kilometer;
        private string materialName;
        private string materialType;
        private string nameOfTheMaterialUnit;
        private int quantity;
        private DateTime plannedDateOfReceipt;
        private string attention;
        private DateTime dateOfReceipt;
        private string[,] tab;

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
        public string materialNameProperty
        {
            get { return materialName; }
            set { materialName = value; }
        }
        public string materialTypeProperty
        {
            get { return materialType; }
            set { materialType = value; }
        }
        public string nameOfTheMaterialUnitProperty
        {
            get { return nameOfTheMaterialUnit; }
            set { nameOfTheMaterialUnit = value; }
        }
        public int quantityProperty
        {
            get { return quantity; }
            set { quantity = value; }
        }
        public DateTime plannedDateOfReceiptProperty
        {
            get { return plannedDateOfReceipt; }
            set { plannedDateOfReceipt = value; }
        }
        public string attentionProperty
        {
            get { return attention; }
            set { attention = value; }
        }
        public DateTime dateOfReceiptProperty
        {
            get { return dateOfReceipt; }
            set { dateOfReceipt = value; }
        }
        public string[,] tabProperty
        {
            get { return tab; }
            set { tab = value; }
        }

        #endregion

        #region constructor
        public ZwmInstanceClass()
        {

        }

        public ZwmInstanceClass(int orderIdProperty, string nameProperty, string surnameProperty, string contractNumberProperty, string kilometerProperty, string materialNameProperty, string materialTypeProperty, string nameOfTheMaterialUnitProperty, int quantityProperty, DateTime plannedDateOfReceiptProperty, string attentionProperty, DateTime dateOfReceiptProperty, string[,] tab)
        {
            this.orderIdProperty = orderIdProperty;
            this.nameProperty = nameProperty;
            this.surnameProperty = surnameProperty;
            this.contractNumberProperty = contractNumberProperty;
            this.kilometerProperty = kilometerProperty;
            this.materialNameProperty = materialTypeProperty;
            this.materialTypeProperty = materialTypeProperty;
            this.nameOfTheMaterialUnitProperty = nameOfTheMaterialUnitProperty;
            this.quantityProperty = quantityProperty;
            this.plannedDateOfReceiptProperty = plannedDateOfReceiptProperty;
            this.attentionProperty = attentionProperty;
            this.dateOfReceiptProperty = dateOfReceiptProperty;
            this.tab = tab;
        }

        #endregion constructor




    }
}

