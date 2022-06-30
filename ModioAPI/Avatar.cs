using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ModioAPI
{
    internal class Avatar
    {
        [JsonProperty("thumb_50x50")]
        public string Photo50 { get; set; }
        [JsonProperty("thumb_100x100")]
        public string Photo100 { get; set; }
    }
}
