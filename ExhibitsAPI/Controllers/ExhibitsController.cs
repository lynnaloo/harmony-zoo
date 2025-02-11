// ExhibitsAPI/Controllers/ExhibitsController.cs
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

[ApiController]
[Route("api/[controller]")]
public class ExhibitsController : ControllerBase
{
    private static readonly List<Exhibit> Exhibits = new List<Exhibit>
    {
        new Exhibit { Id = 1, Name = "Lion Exhibit", Description = "Home of the lions", Location = "Zone A" },
        new Exhibit { Id = 2, Name = "Penguin Exhibit", Description = "Home of the penguins", Location = "Zone B" }
    };

    [HttpGet]
    public ActionResult<IEnumerable<Exhibit>> GetExhibits()
    {
        return Ok(Exhibits);
    }

    [HttpGet("{id}")]
    public ActionResult<Exhibit> GetExhibit(int id)
    {
        var exhibit = Exhibits.Find(e => e.Id == id);
        if (exhibit == null)
        {
            return NotFound();
        }
        return Ok(exhibit);
    }
}