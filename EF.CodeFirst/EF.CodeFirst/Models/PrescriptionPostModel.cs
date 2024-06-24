namespace EF.CodeFirst.Models;

public class PrescriptionPostModel
{
    public Patient Patient { get; set; }
    public IEnumerable<Medicament> Medicaments { get; set; }
    public DateTime Date { get; set; }
    public DateTime DueDate { get; set; }
}