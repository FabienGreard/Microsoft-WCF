using System;
using System.ServiceModel;
using System.ServiceModel.Web;
using dll_service_contract;
using service;
using System.ServiceModel.Description;

namespace server
{
    class cl_svr
    {
        static void Main(string[] args)
        {
            WebServiceHost webHost = new WebServiceHost(typeof(cl_svc_http), new Uri("http://localhost:8088/"));
            ServiceEndpoint ep = webHost.AddServiceEndpoint(typeof(IServiceContractHttp), new WebHttpBinding(), "HTTP");
            webHost.Open();

            ServiceHost svch = new ServiceHost(typeof(cl_svc), new Uri("net.tcp://localhost/"));
            svch.AddServiceEndpoint(typeof(IServiceContract), new NetTcpBinding(), "SERVICES");
            svch.Open();

            Console.WriteLine("Press <ENTER> to escape");
            Console.Read();
        }
    }
}
