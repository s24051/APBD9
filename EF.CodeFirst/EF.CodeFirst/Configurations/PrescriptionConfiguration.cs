using EF.CodeFirst.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EF.CodeFirst.Configurations;

public class PrescriptionConfiguration: IEntityTypeConfiguration<Prescription>
{
    public void Configure(EntityTypeBuilder<Prescription> builder)
    {
        builder.HasKey( e => e.IdPrescription ).HasName( "Prescription_pk" );

        builder.Property( e => e.Date ).IsRequired();
        builder.Property( e => e.DueDate );

        builder.HasOne(e => e.IdDoctorNav)
            .WithMany(e => e.Prescriptions)
            .HasForeignKey(e => e.IdDoctor)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("Doctor_Prescription_FK");

        builder.HasOne(e => e.IdPatientNav)
            .WithMany(e => e.Prescriptions)
            .HasForeignKey(e => e.IdPatient)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("Patient_Prescription_FK");
        builder.HasData(getMockData());
    }
    
    IEnumerable<Prescription> getMockData()
    {
        var prescriptions = new List<Prescription>
        {
            new Prescription
            {
                IdPrescription = 1,
                IdDoctor = 1,
                IdPatient = 1,
                Date = DateTime.Now.AddDays(6),
                DueDate = DateTime.Now.AddDays(30),
            },
                
            new Prescription
            {
                IdPrescription = 2,
                IdDoctor = 2,
                IdPatient = 2,
                Date = DateTime.Now.AddDays(12),
                DueDate = DateTime.Now.AddDays(-60),
            }
        };
        return prescriptions;
    }
}