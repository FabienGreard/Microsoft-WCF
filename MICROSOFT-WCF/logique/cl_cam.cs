using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dll_stg;

namespace logique
{
    public class cl_cam
    {
        public static STG resolveService(STG msg)
        {

            if (msg.operationName == "auth")
            {
                msg = new cl_cm_auth().auth(msg);
            }
            else if (msg.operationName == "decode")
            {

            }
            else
            {

            }

            return msg;
        }

        public static STG checkPrivilege(STG msg)
        {
            if (msg.tokenApll != "GEN_WCF")
            {
                msg.statut_op = false;
                msg.info = "error tokenApll";
            }
            else
            {
                msg.statut_op = true;
                msg.info = "13, ok";
            }

            return msg;
        }

    }
}
