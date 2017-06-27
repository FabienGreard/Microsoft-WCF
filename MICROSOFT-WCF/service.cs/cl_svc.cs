using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dll_service_contract;
using dll_stg;
using logique;

namespace service
{
    public class cl_svc : IServiceContract
    {
        STG msg;
        public STG m_service(STG msg)
        {
            if (checkToken(msg).statut_op)
            {
                cl_cam.resolveService(msg);
            }
            return this.msg;
        }

        public STG checkToken(STG msg)
        {
            return this.msg = cl_cam.checkPrivilege(msg);
        }
    }
}
