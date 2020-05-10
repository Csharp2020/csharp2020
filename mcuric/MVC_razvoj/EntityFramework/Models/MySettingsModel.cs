using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace EntityFramework.Models
{
    [DataContract]
    public class MySettingsModel
    {
        [DataMember]
        public string WebApiBaseUrl { get; set; }
    }
}
