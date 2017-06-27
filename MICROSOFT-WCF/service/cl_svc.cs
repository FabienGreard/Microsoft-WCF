using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dll_service_contract;
using dll_stg;

namespace service
{
    public class cl_svc : IServiceContract
    {
        public STG m_service(STG msg)
        {
            return msg;
        }
    }
}
