using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AdminPanel.Models.Requests
{
    public class UserRequest
    {
        /// <summary>
        /// User id
        /// </summary>
        /// 
        [Required]
        [JsonProperty("password")]
        public string Password { get; set; }

        [Required]
        [JsonProperty("user")]
        public List<User> User { get; set; }

    }
}
