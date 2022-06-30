using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ModioAPI
{
    internal class Mod
    {
        [JsonProperty("submitted_by")]
        public SubmittedBy Submit { get; set; }
    }
}
