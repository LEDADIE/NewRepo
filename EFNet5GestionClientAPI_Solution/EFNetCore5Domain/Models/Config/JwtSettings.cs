using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFNetCore5Domain.Models.Config
{
    public class JwtSettings
    {
        public int ExpirationInMinutes { get; set; }
        public string Issuer { get; set; }
        public string Secret { get; set; }
    }
}