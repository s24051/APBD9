using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF.CodeFirst.Migrations
{
    /// <inheritdoc />
    public partial class ChangeConfigs : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Medicaments",
                keyColumn: "IdMedicament",
                keyValue: 1,
                columns: new[] { "Description", "Name" },
                values: new object[] { "", "Polopiryna" });

            migrationBuilder.UpdateData(
                table: "Medicaments",
                keyColumn: "IdMedicament",
                keyValue: 2,
                columns: new[] { "Description", "Name" },
                values: new object[] { "", "Ibuprom" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "IdPatient",
                keyValue: 1,
                columns: new[] { "BirthDate", "FirstName", "LastName" },
                values: new object[] { new DateTime(2024, 6, 19, 0, 11, 22, 321, DateTimeKind.Local).AddTicks(9078), "Adrian", "Adrianski" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "IdPatient",
                keyValue: 2,
                columns: new[] { "BirthDate", "FirstName", "LastName" },
                values: new object[] { new DateTime(2024, 5, 6, 0, 11, 22, 327, DateTimeKind.Local).AddTicks(3237), "Jacek", "Jackowski" });

            migrationBuilder.UpdateData(
                table: "Prescription_Medicament",
                keyColumns: new[] { "IdMedicament", "IdPrescription" },
                keyValues: new object[] { 1, 1 },
                columns: new[] { "Details", "Dose" },
                values: new object[] { "1 Dziennie", 5 });

            migrationBuilder.UpdateData(
                table: "Prescription_Medicament",
                keyColumns: new[] { "IdMedicament", "IdPrescription" },
                keyValues: new object[] { 2, 2 },
                columns: new[] { "Details", "Dose" },
                values: new object[] { "2 Dziennie", 25 });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "IdPrescription",
                keyValue: 1,
                columns: new[] { "Date", "DueDate" },
                values: new object[] { new DateTime(2024, 6, 25, 0, 11, 22, 336, DateTimeKind.Local).AddTicks(7621), new DateTime(2024, 7, 19, 0, 11, 22, 336, DateTimeKind.Local).AddTicks(8105) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "IdPrescription",
                keyValue: 2,
                columns: new[] { "Date", "DueDate" },
                values: new object[] { new DateTime(2024, 7, 1, 0, 11, 22, 336, DateTimeKind.Local).AddTicks(8532), new DateTime(2024, 4, 20, 0, 11, 22, 336, DateTimeKind.Local).AddTicks(8544) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Medicaments",
                keyColumn: "IdMedicament",
                keyValue: 1,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Headache medicament", "Apap" });

            migrationBuilder.UpdateData(
                table: "Medicaments",
                keyColumn: "IdMedicament",
                keyValue: 2,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Better headache medicament", "Ibum" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "IdPatient",
                keyValue: 1,
                columns: new[] { "BirthDate", "FirstName", "LastName" },
                values: new object[] { new DateTime(2024, 6, 18, 23, 45, 37, 748, DateTimeKind.Local).AddTicks(6599), "Marian", "Zielony" });

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "IdPatient",
                keyValue: 2,
                columns: new[] { "BirthDate", "FirstName", "LastName" },
                values: new object[] { new DateTime(2024, 6, 23, 23, 45, 37, 752, DateTimeKind.Local).AddTicks(4854), "Janina", "Pietruszka" });

            migrationBuilder.UpdateData(
                table: "Prescription_Medicament",
                keyColumns: new[] { "IdMedicament", "IdPrescription" },
                keyValues: new object[] { 1, 1 },
                columns: new[] { "Details", "Dose" },
                values: new object[] { "Prescription for 1 medicament", 100 });

            migrationBuilder.UpdateData(
                table: "Prescription_Medicament",
                keyColumns: new[] { "IdMedicament", "IdPrescription" },
                keyValues: new object[] { 2, 2 },
                columns: new[] { "Details", "Dose" },
                values: new object[] { "Prescription details", 1000 });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "IdPrescription",
                keyValue: 1,
                columns: new[] { "Date", "DueDate" },
                values: new object[] { new DateTime(2024, 9, 18, 23, 45, 37, 759, DateTimeKind.Local).AddTicks(4448), new DateTime(2024, 3, 18, 23, 45, 37, 759, DateTimeKind.Local).AddTicks(4914) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "IdPrescription",
                keyValue: 2,
                columns: new[] { "Date", "DueDate" },
                values: new object[] { new DateTime(2024, 12, 18, 23, 45, 37, 759, DateTimeKind.Local).AddTicks(5402), new DateTime(2024, 4, 18, 23, 45, 37, 759, DateTimeKind.Local).AddTicks(5446) });
        }
    }
}
