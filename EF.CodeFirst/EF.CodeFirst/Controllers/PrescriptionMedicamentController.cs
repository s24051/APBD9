using EF.CodeFirst.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EF.CodeFirst.Controllers;

[Route("/api/[controller]")]
[ApiController]
public class PrescriptionMedicamentController: ControllerBase
{
    private Apbd9Context dbContext;

    public PrescriptionMedicamentController(Apbd9Context dbContext)
    {
        this.dbContext = dbContext;
    }

    [HttpGet]
    public  async Task<IActionResult> Get()
    {
        var prescriptionMedicaments = await dbContext.PrescriptionMedicaments.ToListAsync();
        return Ok(prescriptionMedicaments);
    } 
}