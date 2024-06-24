using EF.CodeFirst.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EF.CodeFirst.Controllers;

[Route("/api/[controller]")]
[ApiController]
public class PatientController: ControllerBase
{
    private Apbd9Context dbContext;

    public PatientController(Apbd9Context dbContext)
    {
        this.dbContext = dbContext;
    }

    [HttpGet]
    public  async Task<IActionResult> Get()
    {
        var patients = await dbContext.Patients.ToListAsync();
        return Ok(patients);
    }

}