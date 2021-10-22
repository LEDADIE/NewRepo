using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace EFNetCore5AccessDataLibrairy.EntityModels
{
    public class Client
    {
        public List<Address> Addresses { get; set; } = new List<Address>();

        public int Age { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime CreateDate { get; set; }

        public List<Email> EmailAddresses { get; set; } = new List<Email>();

        [MaxLength(405)]
        public string FullName { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(200)]
        public string Nom { get; set; }

        [MaxLength(200)]
        public string Prenoms { get; set; }

        [Timestamp]
        public byte[] RowVersion { get; set; }

        [MaxLength(50)]
        public string Sexe { get; set; }

        [MaxLength(50)]
        [Column(TypeName = "varchar(50)")]
        [Required]
        public string Telephone { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime UpdateDate { get; set; }
    }
}