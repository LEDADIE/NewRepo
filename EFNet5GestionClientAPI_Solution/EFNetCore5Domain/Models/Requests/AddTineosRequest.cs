using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFNetCore5Domain.Models.Requests
{
    public class AddTineosRequest
    {
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string JobFunction { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string Mail { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public DateTime StartDate { get; set; }
    }
}