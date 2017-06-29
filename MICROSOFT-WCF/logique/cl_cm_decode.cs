using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dll_stg;

namespace logique
{
    public class cl_cm_decode
    {
        private static char[] Match =
         {
            'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j',
            'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't',
            'u', 'v', 'w', 'x', 'y', 'z'
         };
        public cl_cm_decode()
        {
        }

        private string deXor(string text, string key)
        {
            byte[] result = new byte[text.Length];
            Parallel.For(0, text.Length, c =>
            {
                result[c] = (byte)((uint)text[c] ^ (uint)key[c % key.Length]);
            });
            return Encoding.GetEncoding(1252).GetString(result);
        }

        public char findAlpha(char value)
        {
            char rslt = 'a';

            for (int i = 0; i < Match.Length -1; i++)
            {
                if (value.Equals(Match[i]))
                {
                    rslt = Match[i + 1];
                }
            }
            return rslt;
        }

        public STG sendMsg(string text, string key, STG msg)
        {
            using (System.IO.StreamWriter file = new System.IO.StreamWriter("./" + msg.data[2] + "Decrypt.txt", true))
            {
                file.WriteLine(deXor(text, key));
                file.WriteLine(key);
                file.WriteLine(msg.data[0].ToString());
                file.WriteLine("________________________________________________________________________________________________________________");

                //Console.WriteLine("key: " + key);
                //Console.WriteLine("content: " + deXor(text, key));
                //Console.WriteLine("fileName: " + msg.data[2]);

                msg.data[0] = key; // key
                msg.data[1] = deXor(text, key);  // content
                msg.data[2] = msg.data[2]; // file

                return msg;
            }
        }

        public STG decode(STG msg)
        {
            Console.WriteLine("Demande de service 'decode'");

            string text = System.IO.File.ReadAllText(".\\" + msg.data[2]);

            char[] key = //fjuiop
{
                'f',
                'j',
                'u',
                'i',
                'o',
                'a'
            };

            

            if (!string.IsNullOrEmpty(msg.data[0].ToString()))
            { 
               key = msg.data[0].ToString().ToCharArray();
            }

            int start = 5;

            for (int i = start; i < 6; i++)
            {
                do
                {
                    key[i] = findAlpha(key[i]);
                    if (new string(key).Equals("fjuioz"))
                    {
                        msg.info = "13, decoded";
                    }
                    return sendMsg(text, new string(key), msg);
                } while (!key[i].Equals("z"));
            }

            msg.info = "13, decode";

            return sendMsg(text, new string(key), msg);
        }
    }
}
