using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZWM.Classes
{
    class ContractClass
    {
        private int IdContract;
        private string ContractNumber;
        private string Kilometer;

        public int IdContractProperty
        {
            get { return IdContract; }
            set { IdContract = value; }
        }
        public string ContractNumberProperty
        {
            get { return ContractNumber; }
            set { ContractNumber = value; }
        }
        public string KilometerProperty
        {
            get { return Kilometer; }
            set { Kilometer = value; }
        }
       
    }
}
