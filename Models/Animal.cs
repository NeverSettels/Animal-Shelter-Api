using System.ComponentModel.DataAnnotations;

namespace Animal-Api.Models
{
  public class Animal
  {
    public int AnimalId;
    public string Name;
    public string Species;
    public string Gender;
    public string Age;
    public bool SpecialMedicalNeeds;
    public string PicUrl;
  }
}