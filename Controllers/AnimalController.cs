using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Animal.Models;

namespace Animal-Api.Controller
{
  [Route("api/[controller]")]
  [ApiController]
  public class AnimalController : ControllerBase
  {
    private AnimalContext _db;

    public AnimalController(AnimalContext db)
    {
      _db =db;
    }
   [HttpGet]
    public ActionResult<IEnumerable<Doggo>> Get()
    {
      var query = _db.Doggos.AsQueryable();
      return query.ToList();
    }
    [HttpGet("{id}")]
    public ActionResult<Animal> Get(int id)
    {
      return _db.Animals.FirstOrDefault(entry => entry.AnimalId == id);
    }

     [HttpPost]
    public void Post([FromBody] Animal animal)
    {
      _db.Animals.Add(animal);
      _db.SaveChanges();
    }

    [HttpPut("{id}")]
    public void Put(int id, [FromBody] Animal animal)

    {
      doggo.AnimalId = id;
      _db.Entry(animal).State = EntityState.Modified;
      _db.SaveChanges();
    }

    [HttpDelete("{id}")]
    public void Delete(int id)

    {
      var animlaToDelete = _db.Animals.FirstOrDefault(entry => entry.AnimalId == id);
      _db.Animals.Remove(animlaToDelete);
      _db.SaveChanges();
    }
  }
}