using System.ComponentModel.DataAnnotations;

namespace AnimalApi.Models
{
  public class Animal
  {
    public int AnimalId { get; set; }
    public string Name { get; set; }
    public string Species { get; set; }
    public string Gender { get; set; }
    public int Age { get; set; }
    public bool SpecialMedicalNeeds { get; set; }
    public string PicUrl { get; set; }
  }
}