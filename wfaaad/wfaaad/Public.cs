using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfaaad
{
    class Public
   { 
        private int idPublic;
        private string TypePublic;

        public Public(int idPublic, string TypePublic)
        {
            this.idPublic = idPublic; 
            this.TypePublic = TypePublic;

        }

        public int id
        {
            get
            {
                // accesseur en lecture : getter
                return this.idPublic;
            }

        }
        public string Type
        {
            get
            {
                // accesseur en lecture : getter
                return this.TypePublic;
            }
            set
            {
                // accesseur en écriture : setter
                this.TypePublic = value;
            }
        }
    }
}
