using EF.CodeFirst.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EF.CodeFirst.Configurations;

public class DoctorConfiguration: IEntityTypeConfiguration<Doctor>
{
    public void Configure(EntityTypeBuilder<Doctor> builder)
    {
        builder.HasKey(e => e.IdDoctor).HasName("Doctor_PK");
        builder.Property(e => e.IdDoctor).UseIdentityColumn();

        builder.Property(e => e.FirstName).HasMaxLength(100).IsRequired();
        builder.Property(e => e.LastName).HasMaxLength(100).IsRequired();
        builder.Property( e => e.Email ).HasMaxLength( 100 ).IsRequired();
        
        builder.HasData(getMockData());
    }

    IEnumerable<Doctor> getMockData()
    {
        List<Doctor> doctors = new List<Doctor>();
        doctors.Add(new Doctor
        {
            IdDoctor = 1,
            FirstName = "DAdam",
            LastName = "Adamski",
            Email = "Adamski@gmail.com"
        });
        doctors.Add(new Doctor
        {
            IdDoctor = 2,
            FirstName = "DJan",
            LastName = "Janski",
            Email = "Janski@gmail.com"
        });
        return doctors;
    }
}