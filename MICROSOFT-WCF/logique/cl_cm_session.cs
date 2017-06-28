using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dll_stg;
using data;
using System.Data;

namespace logique
{
    class cl_cm_session
    {
        public static string createSession(STG msg, cl_cmp_session oCmpSession, cl_cad oCad)
        {
            byte[] time = BitConverter.GetBytes(DateTime.UtcNow.ToBinary());
            byte[] key = Guid.NewGuid().ToByteArray();
            string token = Convert.ToBase64String(time.Concat(key).ToArray());

            if (!checkSession(msg, oCmpSession, oCad))
            {
                oCad.ActionRows(oCmpSession.createSession(token, DateTime.UtcNow.AddHours(24), msg.data[0].ToString(), DateTime.UtcNow));
            }
            else
            {
                Console.WriteLine("Session already exist");
            }
            
            Console.WriteLine("Session started");
            return token;
        }

        public static bool checkSession(STG msg, cl_cmp_session oCmpSession, cl_cad oCad)
        {
            Console.WriteLine("Checking de la session");
            System.Data.DataSet oDS = new DataSet();

            string email = "";

                oDS = oCad.getRows(oCmpSession.selectALLByEmail(msg.data[0].ToString()), "Session");

                foreach (DataRow pRow in oDS.Tables["Session"].Rows)
                {
                    try
                    {
                        email = pRow["email"].ToString();

                    }
                    catch
                    {

                    }

                }

            return (email == "") ? false : true;
        }
    }
}
