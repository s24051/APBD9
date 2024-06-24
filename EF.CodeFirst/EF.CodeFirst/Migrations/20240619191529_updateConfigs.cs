using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF.CodeFirst.Migrations
{
    /// <inheritdoc />
    public partial class updateConfigs : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameTable(
                name: "Prescription_Medicament",
                newName: "PrescriptionMedicaments");

            migrationBuilder.RenameIndex(
                name: "IX_Prescription_Medicament_IdPrescription",
                table: "PrescriptionMedicaments",
                newName: "IX_PrescriptionMedicaments_IdPrescription");

            migrationBuilder.UpdateData(
                table: "Medicaments",
                keyColumn: "IdMedicament",
                keyValue: 1,
                column: "Type",
                value: "Headache");

            migrationBuilder.UpdateData(
                table: "Medicaments",
                keyColumn: "IdMedicament",
                keyValue: 2,
                column: "Type",
                value: "Headache");

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "IdPatient",
                keyValue: 1,
                column: "BirthDate",
                value: new DateTime(2024, 6, 19, 21, 15, 27, 392, DateTimeKind.Local).AddTicks(1857));

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "IdPatient",
                keyValue: 2,
                column: "BirthDate",
                value: new DateTime(2024, 5, 6, 21, 15, 27, 394, DateTimeKind.Local).AddTicks(8528));

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "IdPrescription",
                keyValue: 1,
                columns: new[] { "Date", "DueDate" },
                values: new object[] { new DateTime(2024, 6, 25, 21, 15, 27, 399, DateTimeKind.Local).AddTicks(5577), new DateTime(2024, 7, 19, 21, 15, 27, 399, DateTimeKind.Local).AddTicks(5836) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "IdPrescription",
                keyValue: 2,
                columns: new[] { "Date", "DueDate" },
                values: new object[] { new DateTime(2024, 7, 1, 21, 15, 27, 399, DateTimeKind.Local).AddTicks(6070), new DateTime(2024, 4, 20, 21, 15, 27, 399, DateTimeKind.Local).AddTicks(6078) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameTable(
                name: "PrescriptionMedicaments",
                newName: "Prescription_Medicament");

            migrationBuilder.RenameIndex(
                name: "IX_PrescriptionMedicaments_IdPrescription",
                table: "Prescription_Medicament",
                newName: "IX_Prescription_Medicament_IdPrescription");

            migrationBuilder.UpdateData(
                table: "Medicaments",
                keyColumn: "IdMedicament",
                keyValue: 1,
                column: "Type",
                value: "Strong");

            migrationBuilder.UpdateData(
                table: "Medicaments",
                keyColumn: "IdMedicament",
                keyValue: 2,
                column: "Type",
                value: "Strong");

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "IdPatient",
                keyValue: 1,
                column: "BirthDate",
                value: new DateTime(2024, 6, 19, 0, 11, 22, 321, DateTimeKind.Local).AddTicks(9078));

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "IdPatient",
                keyValue: 2,
                column: "BirthDate",
                value: new DateTime(2024, 5, 6, 0, 11, 22, 327, DateTimeKind.Local).AddTicks(3237));

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
    }
}
