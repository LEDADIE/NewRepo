using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore;

namespace EFNetCore5AccessDataLibrairy.EntityModels
{
    public class Address
    {
        [Required]
        [MaxLength(200)]
        public string City { get; set; }

        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime CreateDate { get; set; }

        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        [Timestamp]
        public byte[] RowVersion { get; set; }

        [Required]
        [MaxLength(200)]
        public string State { get; set; }

        [Required]
        [MaxLength(200)]
        public string StreetAdress { get; set; }

        //[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime UpdateDate { get; set; }

        [Required]
        [MaxLength(200)]
        [Column(TypeName = "varchar(200)")]
        public string ZipCode { get; set; }
    }
}