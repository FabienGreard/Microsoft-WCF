using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using data;
using dll_stg;

namespace logique
{
    public class cl_cm_auth
    {
        cl_cad oCad;
        cl_cmp_person oCmpPerson;
        public cl_cm_auth()
        {
            this.oCad = new cl_cad();
            this.oCmpPerson = new cl_cmp_person();
        }

        public void auth(STG msg)
        {
            Console.WriteLine(msg);
            /*if(!string.IsNullOrEmpty(msg.data[0]) && !string.IsNullOrEmpty(msg.data[0]))
                this.oCad.ActionRows(this.oCmpPerson.connectPerson(msg.data[0]));*/

        }
    }
}
