using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AdminPanel.Models
{
    public class User
    {
        /// <summary>
        /// User id
        /// </summary>
        /// 
        [Required]
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// User name
        /// </summary>
        /// 
        [Required]
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// User is approved
        /// </summary>
        /// 
        [Required]
        [JsonProperty("approved")]
        public bool Approved { get; set; }

        /// <summary>
        /// User date of register
        /// </summary>
        /// 
        [Required]
        [JsonProperty("register_date")]
        public string RegisterDate { get; set; }

        /// <summary>
        /// User email
        /// </summary>
        /// 
        [Required]
        [JsonProperty("email")]
        public string Email { get; set; }

        /// <summary>
        /// User phone
        /// </summary>
        /// 
        [Required]
        [JsonProperty("phone")]
        public string Phone { get; set; }
    }
}
