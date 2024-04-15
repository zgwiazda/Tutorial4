using Microsoft.AspNetCore.Mvc;
using Tutorial4.Database;
using Tutorial4.Models;

namespace Tutorial4.Controllers;


[ApiController]
[Route("/animals-controller")]
// [Route("[controller]")]
public class AnimalsController : ControllerBase
{
    

    [HttpGet]
    public IActionResult GetAnimals()
    {
        var animals = new MockDb().Animals;
        return Ok(animals);
    }
    
    [HttpGet("{id}")]
    public IActionResult GetAnimal(int id)
    {
        var animal = StaticData._animals.FirstOrDefault(a => a.Id == id);
        if (animal == null)
        {
            return NotFound($"Animal with id {id} was not found");
        }
        
        return Ok(animal);
    }
    
    [HttpPost]
    public IActionResult AddAnimal(Animal animal)
    {
        StaticData._animals.Add(animal);
        return Created("", null);
    }

    [HttpPut("{id}")]
    public IActionResult EditAnimal(int id, Animal animal)
    {
        var animalToEdit = StaticData._animals.FirstOrDefault(a => a.Id == id);
        if (animalToEdit == null)
        {
            return NotFound($"Animal with id {id} was not found");
        }

        StaticData._animals.Remove(animalToEdit);
        StaticData._animals.Add(animal);
        return NoContent();
    }

    [HttpDelete("{id}")]
    public IActionResult DeleteAnimal(int id)
    {
        var animalToDelete = StaticData._animals.FirstOrDefault(a => a.Id == id);
        if (animalToDelete == null)
        {
            return NotFound($"Animal with id {id} was not found");
        }

        StaticData._animals.Remove(animalToDelete);
        return NoContent();
    }
}