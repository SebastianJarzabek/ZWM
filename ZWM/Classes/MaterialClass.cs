using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZWM.Classes
{
    class MaterialClass
    {
        
        private int IdMAterial;
        private string MaterialName;
        private string TypeOfMaterial;
        private string UnitOfMaterial;
        private string Quantity;

        public int IdMAterialProperty
        {
            get { return IdMAterial; }
            set { IdMAterial = value; }
        }
        public string MaterialNameProperty
        {
            get { return MaterialName; }
            set { MaterialName = value; }
        }
        public string TypeOfMaterialProperty
        {
            get { return TypeOfMaterial; }
            set { TypeOfMaterial = value; }
        }
        public string UnitOfMaterialProperty
        {
            get { return UnitOfMaterial; }
            set { UnitOfMaterial = value; }
        }
        public string QuantityProperty
        {
            get { return Quantity; }
            set { Quantity = value; }
        }


    }
}
