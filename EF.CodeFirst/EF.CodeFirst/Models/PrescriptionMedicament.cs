using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF.CodeFirst.Models;

public class PrescriptionMedicament
{
    public int IdMedicament { get; set; }
    public Medicament IdMedicamentNav { get; set; }

    public int IdPrescription { get; set; }
    public Prescription IdPrescriptionNav { get; set; }

    public int Dose { get; set; }
    public string Details { get; set; }
}