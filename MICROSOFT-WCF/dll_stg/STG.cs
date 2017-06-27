using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dll_stg
{
    public struct STG
    {
        public bool statut_op;
        public string info;
        public List<object> data;
        public string operationName;
        public string tokenApll;
        public string tokenUser;

        public STG(bool _statut_op, string _info, List<object> _data, string _operationName, string _tokenApll, string _tokenUser) : this()
        {
            this.statut_op = _statut_op;
            this.info = _info;
            this.data = _data;
            this.operationName = _operationName;
            this.tokenApll = _tokenApll;
            this.tokenUser = _tokenUser;
        }
    }
}
