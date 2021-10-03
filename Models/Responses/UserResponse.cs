using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminPanel.Models.Responses
{
    public class UserResponse
    {
        /// <summary>
        /// Users
        /// </summary>
        public List<User> User { get; set; }

        /// <summary>
        /// Response Status
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }
    }
}
