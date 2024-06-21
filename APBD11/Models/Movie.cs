using System.ComponentModel.DataAnnotations;

namespace APBD11.Models;

public class Movie
{
    public int Id { get; set; }
    [MaxLength(255)]
    [Required]
    public string Name { get; set; } = "";
    [Required]
    public DateOnly Date { get; set; }

    public Movie[] Movies { get; set; }
}