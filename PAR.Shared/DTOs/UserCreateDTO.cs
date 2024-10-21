using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAR.Shared.DTOs
{
    public class UserCreateDTO
    {
        public string? Username { get; set; }
        public string? Password { get; set; }
        public string? Mail { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? DisplayName { get; set; }
        public string? Department { get; set; }
    }
}
