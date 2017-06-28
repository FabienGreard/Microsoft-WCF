using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using data;
using dll_stg;
using System.Data;

namespace logique
{
    public class cl_cm_auth
    {
        cl_cad oCad;
        cl_cmp_person oCmpPerson;
        cl_cmp_session oCmpSession;
        public cl_cm_auth()
        {
            this.oCad = new cl_cad();
            this.oCmpPerson = new cl_cmp_person();
            this.oCmpSession = new cl_cmp_session();
        }

        public STG auth(STG msg)
        {
            Console.WriteLine("Demande de service 'auth'");
            System.Data.DataSet oDS = new DataSet();

            string email = "";
            do
            {
                oDS = oCad.getRows(this.oCmpPerson.connectPerson(msg.data[0].ToString(), msg.data[1].ToString()), "Person");

                foreach (DataRow pRow in oDS.Tables["Person"].Rows)
                {
                    try
                    {
                        email = pRow["email"].ToString();

                    }
                    catch
                    {

                    }

                }

                if (email == "")
                {
                    oCad.ActionRows(this.oCmpPerson.createPerson(msg.data[0].ToString(), msg.data[1].ToString()));
                    Console.WriteLine("Utilisateur introuvable, création de l'utilisateur.");
                }
            } while (email == "");

            Console.WriteLine("connected");

            msg.info = "13, user connected";
            msg.statut_op = true;
            msg.tokenUser = cl_cm_session.createSession(msg, this.oCmpSession, this.oCad);

            return msg;
        }
    }
}
