using System.ComponentModel.DataAnnotations;

namespace EF.CodeFirst.Models;

public class Medicament
{
    public Medicament()
    {
        PrescriptionMedicaments = new HashSet<PrescriptionMedicament>();
    }
    public int IdMedicament { get; set; }
    public String Name { get; set; }
    public String Description { get; set; }
    public String Type { get; set; }
    public ICollection<PrescriptionMedicament> PrescriptionMedicaments { get; set; }
}