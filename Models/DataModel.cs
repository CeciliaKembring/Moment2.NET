using System.ComponentModel.DataAnnotations;

namespace Moment2NET.Models;

public class DataModel
{
[Required]
[Display(Name ="Namn:")]
public string? Name { get; set; }
[Required]
[Display(Name ="Adress:")]
public string? Address { get; set; }
[Display(Name ="Kilometer:")]
public int? Kilometers { get; set; }
}