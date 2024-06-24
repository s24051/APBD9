using System.ComponentModel.DataAnnotations;

namespace EF.CodeFirst.Models;

public class Doctor
{
    public Doctor()
    {
        Prescriptions = new HashSet<Prescription>();
    }
    public int IdDoctor { get; set; }
    public String FirstName { get; set; }
    public String LastName { get; set; }
    public String Email { get; set; }
    public ICollection<Prescription> Prescriptions { get; set; }
}