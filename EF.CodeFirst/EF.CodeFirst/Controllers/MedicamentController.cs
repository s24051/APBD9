using EF.CodeFirst.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EF.CodeFirst.Controllers;

[Route("/api/[controller]")]
[ApiController]
public class MedicamentController: ControllerBase
{
    private Apbd9Context dbContext;

    public MedicamentController(Apbd9Context dbContext)
    {
        this.dbContext = dbContext;
    }

    [HttpGet]
    public  async Task<IActionResult> Get()
    {
        var medicaments = await dbContext.Medicaments.ToListAsync();
        return Ok(medicaments);
    } 
}