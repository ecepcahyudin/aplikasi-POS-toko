using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace TokoApp.Shared.Models
{
    public class UserModel
    {
        public string IdPegawai { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Token { get; set; }

        [JsonIgnore]
        public string Password { get; set; }
    }
}
