using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dll_service_contract;
using dll_stg;
using logique;
using dll_data_contract;

namespace service
{
    public class cl_svc_http : IServiceContractHttp
    {
        public Json postSoluce(Json msg)
        {
            msg = cl_cam.resolveServiceHttp(msg, "post");
            return msg;
        }
    }
}
