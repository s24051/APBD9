using EF.CodeFirst.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EF.CodeFirst.Configurations;

public class PrescriptionMedicamentConfiguration: IEntityTypeConfiguration<PrescriptionMedicament>
{
    public void Configure(EntityTypeBuilder<PrescriptionMedicament> builder)
    {
        builder.HasKey(e => new
        {
            e.IdMedicament,
            e.IdPrescription
        }).HasName("PrescriptionMedicament_PK");
        
        builder.Property(e => e.Dose);
        builder.Property(e => e.Details).HasMaxLength(100).IsRequired();

        builder.HasOne(e => e.IdMedicamentNav)
            .WithMany(e => e.PrescriptionMedicaments)
            .HasForeignKey(e => e.IdMedicament)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("Medicament_Prescription_FK");
            
        builder.HasOne(e => e.IdPrescriptionNav)
            .WithMany(e => e.PrescriptionMedicaments)
            .HasForeignKey(e => e.IdPrescription)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("Prescription_Medicament_FK");
        builder.HasData(getMockData());
    }
    
    IEnumerable<PrescriptionMedicament> getMockData()
    {
        var prescriptionsMedicaments = new List<PrescriptionMedicament>
        {
            new PrescriptionMedicament
            {
                IdMedicament = 1, 
                IdPrescription = 1, 
                Dose = 5, 
                Details = "1 Dziennie"
            },
            new PrescriptionMedicament
            {
                IdMedicament = 2, 
                IdPrescription = 2, 
                Dose = 25, 
                Details = "2 Dziennie"
            },
        };
        return prescriptionsMedicaments;
    }
}