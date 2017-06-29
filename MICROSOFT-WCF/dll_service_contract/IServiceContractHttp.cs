using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using dll_stg;
using System.ServiceModel.Web;
using dll_data_contract;

namespace dll_service_contract
{
    [ServiceContract]
    public interface IServiceContractHttp
    {
        [OperationContract]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, UriTemplate = "/soluce/")]
        Json postSoluce(Json msg);
    }
}
