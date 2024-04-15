using Microsoft.AspNetCore.Mvc;
using Tutorial4.Database;
using Tutorial4.Models;

namespace Tutorial4.Controllers;

[ApiController]
[Route("/appointements-controllers")]
public class AppointementsControllers : ControllerBase
{
    [HttpGet]
    public IActionResult GetAllAppointements()
    {
        var appointements = new MockDb().Appointements;
        return Ok(appointements);
    }
    
    [HttpGet("{id}")]
    public IActionResult GetAppointements(int id)
    {
        var appointements = new MockDb().Appointements.Where(a => a.AnimalId == id);
        return Ok(appointements);
    }
    
    [HttpPost]
    public IActionResult AddAppointement(Appointement appointement)
    {
        StaticData._Appointements.Add(appointement);
        return Created("", null);
    }
}