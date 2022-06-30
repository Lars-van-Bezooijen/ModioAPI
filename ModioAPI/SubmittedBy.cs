using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ModioAPI
{
    internal class SubmittedBy
    {
        [JsonProperty("username")]
        public string Username { get; set; }
        [JsonProperty("avatar")]
        public Avatar Profile { get; set; }
        [JsonProperty("profile_url")]
        public string ProfileUrl { get; set; }
    }
}
