using System.ComponentModel.DataAnnotations;

namespace Abc.Data;

public class Currency
{
    public int Id { get; set; }

    [Required, StringLength(3)]
    public string Code { get; set; } = default!;   //EUR,USD

    [Required, StringLength(50)]
    public string Name { get; set; } = default!;   //Euro

    [StringLength(5)]
    public string? Symbol { get; set; } //// €,$
}