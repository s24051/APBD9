using EF.CodeFirst.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EF.CodeFirst.Configurations;

public class PatientConfiguration: IEntityTypeConfiguration<Patient>
{
    public void Configure(EntityTypeBuilder<Patient> builder)
    {
        builder.HasKey(e => e.IdPatient).HasName("Patient_PK");
        builder.Property(e => e.IdPatient).UseIdentityColumn();
        builder.Property( e => e.FirstName ).IsRequired();
        builder.Property( e => e.LastName ).IsRequired();
        builder.Property( e => e.BirthDate ).IsRequired();

        builder.HasMany( e => e.Prescriptions )
            .WithOne( e => e.IdPatientNav )
            .HasForeignKey( e => e.IdPatient ).IsRequired();
        builder.HasData(getMockData());
    }
    
    
    IEnumerable<Patient> getMockData()
    {
        List<Patient> patients = new List<Patient>
        {
            new Patient
            {
                IdPatient = 1,
                FirstName = "Adrian",
                LastName = "Adrianski",
                BirthDate = DateTime.Now
            },
                
            new Patient
            {
                IdPatient = 2,
                FirstName = "Jacek",
                LastName = "Jackowski",
                BirthDate = DateTime.Now.AddDays(-44)
            }};
        return patients;
    }
}