using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BulkyBookWeb.Models;

public class Category
{
    [Key]
    public int CategoryId { get; set; }

    public DateTime CreatedDateTime { get; set; } = DateTime.Now;

    [DisplayName("Display order")]
    [Range(1, 100, ErrorMessage = "Display order mus be between 1 and 100 only !!")]
    public int Displayorder { get; set; }

    [Required]
    public string Name { get; set; }
}