using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dll_stg;
using System.Web.Script.Serialization;
using System.Net;

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
        struct jsonType
        {
            public string key;
            public string text;
            public string file;
        };


        public STG sendData(STG msg)
        {
            JavaScriptSerializer js = new JavaScriptSerializer();

            jsonType jsonObject;
            jsonObject.key = msg.data[0].ToString();
            jsonObject.text = msg.data[1].ToString();
            jsonObject.file = msg.data[2].ToString();

            string json = js.Serialize(jsonObject);

            Uri url = new Uri("http://192.168.30.10:11080/project_gen/messaging/messaging");
            Uri urlPierre = new Uri("http://192.168.30.15:11080/project_Gen/project/verif");

            using (var client = new WebClient())
            {
                client.Headers[HttpRequestHeader.ContentType] = "application/json";
                client.UploadStringAsync(url, "POST", json);
            }

            return msg;
        }
    }
}
