using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.Runtime.Serialization;

namespace dll_data_contract
{
    [DataContract]
    public class Json
    {
        [DataMember]
        public String file { get; set; }

        [DataMember]
        public String key { get; set; }

        [DataMember]
        public String text { get; set; } 

        [DataMember]
        public float pourcentage { get; set; }  

        [DataMember]
        public string email { get; set; }
    }
}
