using System.ComponentModel.DataAnnotations;

namespace Abc.Data;

public class Country
{ 
    public int Id { get; set; }
    [Required, StringLength(100)]
    public string Name { get; set; } = default!; //Estonia
    [Required, StringLength(2)]
    public string IsoCode { get; set; } = default!; //EE
    [StringLength(100)]
    public string? Capital { get; set; } //Tallinn
}