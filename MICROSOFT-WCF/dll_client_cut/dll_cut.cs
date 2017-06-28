using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dll_stg;

namespace dll_client_cut
{
    public class dll_cut
    {
        //Verifie les données Avant/Après server

        public STG checkData(STG msg)
        {
            if (msg.data[0].GetType() == typeof(object[]))
            {
                msg.statut_op = true;
            }
            else
            {
                msg.statut_op = false;
            }

            return msg;
        }
    }
}
