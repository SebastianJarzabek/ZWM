using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZWM.Classes
{
    class DbClass
    {
        private const string conectionStringToBaseZwm = "Data Source=SEBASTIAN;Initial Catalog = ZWM; Integrated Security = True";

        public string conectionStringToBaseZwmProperty
        {
            get { return conectionStringToBaseZwm; }
        }

        public DbClass()
        {

        }

    }
}
