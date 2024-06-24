using EF.CodeFirst.Configurations;
using EF.CodeFirst.Models;
using Microsoft.EntityFrameworkCore;

namespace EF.CodeFirst.Context;

public class Apbd9Context: DbContext
{
    public Apbd9Context()
    {
        
    }

    public Apbd9Context(DbContextOptions<Apbd9Context> options)
        : base(options)
    {
        
    }
    public virtual DbSet<Doctor> Doctors { get; set; }
    public virtual DbSet<Prescription> Prescriptions { get; set; }
    public virtual DbSet<Patient> Patients { get; set; }
    public virtual DbSet<Medicament> Medicaments { get; set; }
    public virtual DbSet<PrescriptionMedicament> PrescriptionMedicaments { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new DoctorConfiguration());

        modelBuilder.ApplyConfiguration(new PatientConfiguration());

        modelBuilder.ApplyConfiguration(new PrescriptionConfiguration());

        modelBuilder.ApplyConfiguration(new MedicamentConfiguration());

        modelBuilder.ApplyConfiguration(new PrescriptionMedicamentConfiguration());
    }
}