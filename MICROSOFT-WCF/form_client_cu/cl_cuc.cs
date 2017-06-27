using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ServiceModel;
using dll_service_contract;

namespace form_client_cu
{
    static class cl_cuc
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        /// 
 
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1(init_tcpBinding()));
            
        }
        //init tcpBinding
        public static IServiceContract init_tcpBinding()
        {
            EndpointAddress epAdd = new EndpointAddress("net.tcp://localhost/SERVICES");
            IServiceContract proxy = ChannelFactory<IServiceContract>.CreateChannel(new NetTcpBinding(), epAdd);

            return proxy;
        }
    }
}
