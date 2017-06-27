using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data
{
    class cl_cmp_session
    {
        public string selectALLByToken(string token)
        {
            return "SELECT * FROM Session WHERE token = '" + token + "'";
        }

        public string selectALLByEmail(string email)
        {
            return "SELECT * FROM Session WHERE email = '" + email + "'";
        }

        public string createSession(string token, DateTime token_exp, string email, DateTime date)
        {
            return "INSERT INTO Session(token, token_exp, email, date) VALUES('" + token + "', '" + token_exp + "', '" + email + "', '" + date + "')";
        }

        public string deleteSessionByToken(string token)
        {
            return "DELETE FROM Session WHERE token = '" + token + "'";
        }

        public string deleteSessionByEmail(string email)
        {
            return "DELETE FROM Session WHERE email = '" + email + "'";
        }
    }
}
