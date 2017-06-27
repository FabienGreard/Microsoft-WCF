using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using service;
using dll_service_contract;

namespace server
{
    class cl_svr
    {
        static void Main(string[] args)
        {
            ServiceHost svch = new ServiceHost(typeof(cl_svc),
                 new Uri("http://ebarbolini/ServerWCF"));
            svch.AddServiceEndpoint(
               typeof(IServiceContract),
               new BasicHttpBinding(), "SERVICES");
            svch.Open();
            Console.WriteLine("Press <ENTER> to escape");
            Console.Read();
        }
    }
}
