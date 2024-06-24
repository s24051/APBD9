using EF.CodeFirst.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EF.CodeFirst.Controllers;

[Route("/api/[controller]")]
[ApiController]
public class DoctorController: ControllerBase
{
    private Apbd9Context dbContext;

    public DoctorController(Apbd9Context dbContext)
    {
        this.dbContext = dbContext;
    }

    [HttpGet]
    public  async Task<IActionResult> Get()
    {
        var doctors = await dbContext.Doctors.ToListAsync();
        return Ok(doctors);
    } 
}