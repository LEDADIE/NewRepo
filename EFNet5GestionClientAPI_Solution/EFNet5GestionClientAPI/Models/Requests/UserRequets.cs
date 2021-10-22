using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EFNet5GestionClientAPI.Models.DTO.Requests
{
    public class UserRequets
    {
        [Required]
        public string Email { get; set; }

        public Guid Id { get; set; }

        public string JobFunction { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public string Pseudo { get; set; }
    }
}