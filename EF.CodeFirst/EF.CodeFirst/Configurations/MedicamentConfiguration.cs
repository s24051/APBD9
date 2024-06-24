using EF.CodeFirst.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EF.CodeFirst.Configurations;

public class MedicamentConfiguration: IEntityTypeConfiguration<Medicament>
{
    public void Configure(EntityTypeBuilder<Medicament> builder)
    {
        builder.HasKey(e => e.IdMedicament).HasName("Medicament_PK");
        builder.Property(e => e.IdMedicament).UseIdentityColumn();

        builder.Property(e => e.Name).HasMaxLength(100).IsRequired();
        builder.Property(e => e.Description).HasMaxLength(100).IsRequired();
        builder.Property( e => e.Type ).HasMaxLength( 100 ).IsRequired();
        builder.HasMany( e => e.PrescriptionMedicaments )
            .WithOne( e => e.IdMedicamentNav )
            .HasForeignKey( e => e.IdMedicament ).IsRequired();
        
        builder.HasData(getMockData());
    }
    
    IEnumerable<Medicament> getMockData()
    {
        List<Medicament> medicaments = new List<Medicament>
        {
            new Medicament{IdMedicament = 1, Name = "Polopiryna", Description = "", Type = "Headache"},
            new Medicament{IdMedicament = 2, Name = "Ibuprom", Description = "", Type = "Headache"},
        };
        return medicaments;
    }
}