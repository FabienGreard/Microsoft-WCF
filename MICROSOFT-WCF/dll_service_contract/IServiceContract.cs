using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using dll_stg;

namespace dll_service_contract
{
    [ServiceContract]
    public interface IServiceContract
    {
        [OperationContract]
        STG m_service(STG msg);
    }
}
