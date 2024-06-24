using EF.CodeFirst.Context;
using EF.CodeFirst.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;

namespace EF.CodeFirst.Controllers;
using Microsoft.AspNetCore.Mvc;

[Route("/api/[controller]")]
[ApiController]
public class PrescriptionController: ControllerBase
{
    private Apbd9Context dbContext;

    public PrescriptionController(Apbd9Context dbContext)
    {
        this.dbContext = dbContext;
    }

    [HttpGet]
    public async Task<IActionResult> Get()
    {
        var prescriptions = await dbContext.Prescriptions.ToListAsync();
        return Ok(prescriptions);
    }
    
    [HttpPost]
    public async Task<IActionResult> PostPrescription([FromBody]PrescriptionPostModel body)
    {
        
        try
        {
            //  Jeśli lek podany na recepcie nie istnieje, zwracamy błąd.
            var meds = await dbContext.Medicaments
                .Where(med => body.Medicaments
                    .Where(testm => testm.IdMedicament == med.IdMedicament)
                    .First() != null)
                .ToListAsync();

            // Recepta może obejmować maksymalnie 10 leków. W innym wypadku zwracamy błąd
            if (meds.Count > 10)
            {
               return BadRequest("The prescription cannot have more than 10 meds");
            }

            //  Musimy sprawdzić czy DueData>=Date
            if (body.DueDate > body.Date)
            {
                return BadRequest("The due date cannot be older than the date!!");
            }
            
            
            // Jeśli pacjent przekazany w żądaniu nie istnieje, wstawiamy nowego pacjenta do tabeli Pacjent
            var patient = await dbContext.Patients
                .Where(p => p.IdPatient == body.Patient.IdPatient)
                .SingleOrDefaultAsync();
            if (patient == null)
            {
                patient = new Patient
                {
                    FirstName = body.Patient.FirstName,
                    LastName = body.Patient.LastName,
                    BirthDate = body.Patient.BirthDate
                };
                dbContext.Patients.Add(patient);
            }

            await dbContext.SaveChangesAsync();
            
        }
        catch (InvalidOperationException err)
        {
            Console.WriteLine(err.ToString());
            NotFound();
        }
        


        
        return Ok();
    }
}