using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZWM.Classes
{
    class ZWMFormClass
    {
        private int IdZWM;
        private UserClass NameAndSurname;
        private ContractClass contract;
        private DateTime plannedDateOfReceipt;
        private List<MaterialClass> materials;
        private string AttentionToZWMForm;

        public int IdZWMProperty
        {
            get { return IdZWM; }
            set { IdZWM = value; }
        }
        public UserClass NameAndSurnameProperty
        {
            get { return NameAndSurname; }
            set { NameAndSurname = value; }
        }
        public ContractClass contractProperty
        {
            get { return contract; }
            set { contract = value; }
        }
        public DateTime plannedDateOfReceiptProperty
        {
            get { return plannedDateOfReceipt; }
            set { plannedDateOfReceipt = value; }
        }
        public List<MaterialClass> materialsProperty
        {
            get { return materials; }
            set { List<MaterialClass> materials = value; }
        }
        public string AttentionToZWMFormProperty
        {
            get { return AttentionToZWMForm; }
            set { AttentionToZWMForm = value; }
        }
    }
}
