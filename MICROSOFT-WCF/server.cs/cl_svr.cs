using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using dll_service_contract;

namespace server
{
    class cl_svr
    {
        static void Main(string[] args)
        {
            /*ServiceHost svch = new ServiceHost(typeof(IServiceContract),
                 new Uri("http://localhost/"));
            svch.AddServiceEndpoint(
               typeof(IServiceContract),
               new BasicHttpBinding(), "SERVICES");
            svch.Open();
            Console.WriteLine("Press <ENTER> to escape");
            Console.Read();*/

            ServiceHost svch = new ServiceHost(typeof(IServiceContract),
                 new Uri("net.tcp://localhost/"));
            svch.AddServiceEndpoint(
               typeof(IServiceContract),
               new NetTcpBinding(), "SERVICES");
            svch.Open();
            Console.WriteLine("Press <ENTER> to escape");
            Console.Read();
        }
    }
}
