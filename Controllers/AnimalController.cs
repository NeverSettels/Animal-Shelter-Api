using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PagedList;
using System;
using AnimalApi.Models;

namespace AnimalApi.Controller
{
  [Route("api/[controller]")]
  [ApiController]
  public class AnimalController : ControllerBase
  {
    private AnimalApiContext _db;

    public AnimalController(AnimalApiContext db)
    {
      _db =db;
    }

   [HttpGet]
    public ActionResult<IEnumerable<Animal>> Get(string name, string species, string gender, int? age, bool hasSpecialMedicalNeeds)
    {
      var query = _db.Animals.AsQueryable();
      if(name != null)
      {
        query = query.Where(entry => entry.Name == name);
      }
       if(species != null)
      {
        query = query.Where(entry => entry.Species == species);
      }
       if(gender != null)
      {
        query = query.Where(entry => entry.Gender == gender);
      }
       if(hasSpecialMedicalNeeds)
      {
        query = query.Where(entry => entry.SpecialMedicalNeeds == true);
      }
      return query.ToList();
    }

    [HttpGet("page={page}")]
    public ActionResult<IEnumerable<Animal>> Get(int? page)
    {
       if(page == null)
      {
        page= 1;
      }
      int pageSize = 3;
      int pageNumber = (page ?? 1);
     return  _db.Animals.ToPagedList(pageNumber, pageSize).ToList();

    }
    [HttpGet("{id}")]
    public ActionResult<Animal> Get(int id)
    {
      return _db.Animals.FirstOrDefault(entry => entry.AnimalId == id);
    }

    [HttpGet("random")]
    public ActionResult<Animal> Get()
    {
       int maxId = _db.Animals.Count();
      Random rnd = new Random();
      int randId= rnd.Next(1, maxId+1);
      return _db.Animals.FirstOrDefault(entry => entry.AnimalId == randId);
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
      animal.AnimalId = id;
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