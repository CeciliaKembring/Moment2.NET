using System.ComponentModel.DataAnnotations;

namespace Moment2NET.Models;

public class DataModel
{
[Required(ErrorMessage = "Ange namn på utflyktsmålet")]
[Display(Name ="Namn:")]
public string? Name { get; set; }
[Required(ErrorMessage = "Ange adress till utflyktsmålet")]
[Display(Name ="Adress:")]
public string? Address { get; set; }

 [Display(Name ="Kategori:")]
public string? Category { get; set; }


[Display(Name = "Har du besökt platsen tidigare?:")]
 public bool Visited{ get; set; }


}