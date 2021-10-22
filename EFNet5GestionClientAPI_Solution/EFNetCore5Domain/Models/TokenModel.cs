using System.ComponentModel.DataAnnotations;

namespace EFNetCore5Domain.Models
{
    public class TokenModel
    {
        public string Mail { get; set; }

        public string Token { get; set; }
    }
}