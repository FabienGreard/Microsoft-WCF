using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dll_stg;
using dll_data_contract;
using System.Web.Script.Serialization;

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
                msg = new cl_cm_decode().decode(msg);
            }
            else
            {
                msg.statut_op = false;
                msg.info = "error operationName";
            }

            return msg;
        }

        public static Json resolveServiceHttp(Json msg, string type)
        {
            if (type == "post")
            {
                Console.WriteLine("{ 'file': " + msg.file + ", 'key': " + msg.key + " ,'text': " + msg.text + ", 'pourcentage': " + msg.pourcentage + ", 'email': " + msg.email + "}");
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
