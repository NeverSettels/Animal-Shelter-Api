using System.ComponentModel.DataAnnotations;

namespace AnimalApi.Models
{
  public class Animal
  {
    public int AnimalId { get; set; }
    [Required]
    public string Name { get; set; }
    [Required]
    public string Species { get; set; }
    [Required]
    public string Gender { get; set; }
    [Required]
    public int Age { get; set; }
    public bool SpecialMedicalNeeds { get; set; }
    public string PicUrl { get; set; }
  }
}