using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace EFNetCore5AccessDataLibrairy.EntityModels
{
    public class User
    {
        public List<Client> ClientsUser { get; set; } = new List<Client>();

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime CreateDate { get; set; }

        [Display(Name = "Adresse email")]
        [Required(ErrorMessage = "L'adresse email est requis")]
        [EmailAddress(ErrorMessage = "Adresse email invalid")]
        public string Email { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        public bool IsAdmin { get; set; }

        [MaxLength(500)]
        [Column(TypeName = "varchar(500)")]
        public string JobFunction { get; set; }

        [MinLength(6)]
        [MaxLength(1024)]
        [Display(Name = "Mot de passe")]
        [Required(ErrorMessage = "Le mot de passe est requis")]
        [Column(TypeName = "varchar(1024)")]
        public string Password { get; set; }

        public string Picture { get; set; } = @"/Medias/upload/Patrice.jpg";

        [MaxLength(50)]
        [Column(TypeName = "varchar(50)")]
        [Display(Name = "Pseudo")]
        [Required(ErrorMessage = "Le Pseudo est requis")]
        public string Pseudo { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime UpdateDate { get; set; }
    }
}