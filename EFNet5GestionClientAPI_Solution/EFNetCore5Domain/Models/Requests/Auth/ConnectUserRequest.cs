using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFNetCore5Domain.Models.Requests.Auth
{
    public class ConnectUserRequest
    {
        [Required]
        public string Mail { get; set; }

        [Required]
        public string Password { get; set; }
    }
}