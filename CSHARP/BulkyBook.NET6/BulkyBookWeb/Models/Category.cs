using System;
using System.ComponentModel.DataAnnotations;

namespace BulkyBookWeb.Models;

public class Category
{
    [Key]
    public int CategoryId { get; set; }

    public DateTime CreatedDateTime { get; set; } = DateTime.Now;
    public int Displayorder { get; set; }

    [Required]
    public string Name { get; set; }
}