using System.ComponentModel.DataAnnotations.Schema;
using System.Configuration;

namespace RazorPagesMovie.Models;

public class Movie
{
    public int Id { get; set; }


    [StringLength(60, MinimumLength = 3)]
    [Required]
    public string? Title { get; set; } = string.Empty;


    [DataType(DataType.Date)]
    [Display(Name = "Release Date")]
    [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
    public DateTime ReleaseDate { get; set; }


    [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
    [Required]
    [StringLength(30)]
    public string? Genre { get; set; } = string.Empty;
    
    
    [Range(1, 100)]
    [DataType(DataType.Currency)]
    [Column(TypeName = "decimal(18, 2)")]
    public decimal Price { get; set; }
    
    
    [RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$")]
    [StringLength(5)]
    [Required]
    public string Rating { get; set; } = string.Empty;
}