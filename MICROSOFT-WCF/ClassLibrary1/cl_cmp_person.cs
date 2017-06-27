using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dara
{
    class cl_cmp_person
    {
        public string connectPerson(string email, string password)
        {
            return "SELECT * FROM Person WHERE email = '" + email + "' AND password = '" + password + "'";
        }

        public string createPerson(string email, string password)
        {
            return "INSERT INTO Person(email, password) VALUES('" + email + "', '" + password + "')";
        }

        public string deletePerson(string email)
        {
            return "DELETE FROM Person WHERE email = '" + email + "'";
        }
    }
}
