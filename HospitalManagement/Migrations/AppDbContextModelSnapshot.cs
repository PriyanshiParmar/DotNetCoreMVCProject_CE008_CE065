// <auto-generated />
using System;
using HospitalManagementSystem.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HospitalManagement.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("HospitalManagementSystem.Models.Appointment", b =>
                {
                    b.Property<int>("AppointmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AppointmentId"));

                    b.Property<DateTime>("AppointmentTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("DoctorId")
                        .HasColumnType("int");

                    b.Property<int>("PatientId")
                        .HasColumnType("int");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AppointmentId");

                    b.HasIndex("DoctorId");

                    b.HasIndex("PatientId");

                    b.ToTable("Appointments");
                });

            modelBuilder.Entity("HospitalManagementSystem.Models.Bill", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("Discount")
                        .HasColumnType("int");

                    b.Property<long>("FinalAmount")
                        .HasColumnType("bigint");

                    b.Property<int>("PatientId")
                        .HasColumnType("int");

                    b.Property<int>("PrescriptionId")
                        .HasColumnType("int");

                    b.Property<long>("TotalAmount")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("PatientId");

                    b.HasIndex("PrescriptionId")
                        .IsUnique();

                    b.ToTable("Bills");
                });

            modelBuilder.Entity("HospitalManagementSystem.Models.BillMed", b =>
                {
                    b.Property<int>("MedicineId")
                        .HasColumnType("int");

                    b.Property<int>("BillId")
                        .HasColumnType("int");

                    b.Property<string>("Brand")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Dosage")
                        .HasColumnType("int");

                    b.Property<DateTime>("ExpiryDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("MfgDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("MfgNo")
                        .HasColumnType("int");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<int>("Rate")
                        .HasColumnType("int");

                    b.HasKey("MedicineId", "BillId");

                    b.HasIndex("BillId");

                    b.ToTable("BillMeds");
                });

            modelBuilder.Entity("HospitalManagementSystem.Models.Doctor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("EmergencyNo")
                        .HasColumnType("bigint");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("JoinDate")
                        .HasColumnType("datetime2");

                    b.Property<long>("MobileNo")
                        .HasColumnType("bigint");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Salary")
                        .HasColumnType("int");

                    b.Property<string>("Speciality")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Doctors");
                });

            modelBuilder.Entity("HospitalManagementSystem.Models.Medicine", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AssociatedDiseases")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SideEffects")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WhoCannotTake")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Medicines");
                });

            modelBuilder.Entity("HospitalManagementSystem.Models.MedicineComponent", b =>
                {
                    b.Property<int>("MfgNo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MfgNo"));

                    b.Property<string>("Brand")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Dose")
                        .HasColumnType("int");

                    b.Property<DateTime>("ExpiryDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("MedicineId")
                        .HasColumnType("int");

                    b.Property<DateTime>("MfgDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.HasKey("MfgNo");

                    b.HasIndex("MedicineId");

                    b.ToTable("MedicineComponents");
                });

            modelBuilder.Entity("HospitalManagementSystem.Models.Nurse", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("EmergencyNo")
                        .HasColumnType("bigint");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("JoinDate")
                        .HasColumnType("datetime2");

                    b.Property<long>("MobileNo")
                        .HasColumnType("bigint");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Salary")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Nurses");
                });

            modelBuilder.Entity("HospitalManagementSystem.Models.Patient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("AdmitDate")
                        .HasColumnType("datetime2");

                    b.Property<long>("AmountPaid")
                        .HasColumnType("bigint");

                    b.Property<string>("Condition")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DischargeDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Disease")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DoctorId")
                        .HasColumnType("int");

                    b.Property<long>("MobileNo")
                        .HasColumnType("bigint");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("RoomId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DoctorId");

                    b.HasIndex("RoomId");

                    b.ToTable("Patients");
                });

            modelBuilder.Entity("HospitalManagementSystem.Models.Prescription", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("PatientId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PatientId");

                    b.ToTable("Prescriptions");
                });

            modelBuilder.Entity("HospitalManagementSystem.Models.PrescriptionMedicine", b =>
                {
                    b.Property<int>("PrescriptionId")
                        .HasColumnType("int");

                    b.Property<int>("medicineId")
                        .HasColumnType("int");

                    b.Property<string>("dose")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("noOfTablets")
                        .HasColumnType("int");

                    b.HasKey("PrescriptionId", "medicineId");

                    b.HasIndex("medicineId");

                    b.ToTable("PrescriptionMedicines");
                });

            modelBuilder.Entity("HospitalManagementSystem.Models.Room", b =>
                {
                    b.Property<int>("RoomNo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RoomNo"));

                    b.Property<int>("NoOfBeds")
                        .HasColumnType("int");

                    b.Property<string>("RoomType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("VacantBeds")
                        .HasColumnType("int");

                    b.HasKey("RoomNo");

                    b.ToTable("Rooms");
                });

            modelBuilder.Entity("HospitalManagementSystem.Models.Appointment", b =>
                {
                    b.HasOne("HospitalManagementSystem.Models.Doctor", "Doctor")
                        .WithMany("Appointments")
                        .HasForeignKey("DoctorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HospitalManagementSystem.Models.Patient", "Patient")
                        .WithMany("Appointments")
                        .HasForeignKey("PatientId")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();

                    b.Navigation("Doctor");

                    b.Navigation("Patient");
                });

            modelBuilder.Entity("HospitalManagementSystem.Models.Bill", b =>
                {
                    b.HasOne("HospitalManagementSystem.Models.Patient", "Patient")
                        .WithMany("BillsGiven")
                        .HasForeignKey("PatientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HospitalManagementSystem.Models.Prescription", "Prescription")
                        .WithOne("Bill")
                        .HasForeignKey("HospitalManagementSystem.Models.Bill", "PrescriptionId")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();

                    b.Navigation("Patient");

                    b.Navigation("Prescription");
                });

            modelBuilder.Entity("HospitalManagementSystem.Models.BillMed", b =>
                {
                    b.HasOne("HospitalManagementSystem.Models.Bill", "Bill")
                        .WithMany("MedicinesGiven")
                        .HasForeignKey("BillId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HospitalManagementSystem.Models.Medicine", "Medicine")
                        .WithMany()
                        .HasForeignKey("MedicineId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Bill");

                    b.Navigation("Medicine");
                });

            modelBuilder.Entity("HospitalManagementSystem.Models.MedicineComponent", b =>
                {
                    b.HasOne("HospitalManagementSystem.Models.Medicine", "Medicine")
                        .WithMany()
                        .HasForeignKey("MedicineId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Medicine");
                });

            modelBuilder.Entity("HospitalManagementSystem.Models.Patient", b =>
                {
                    b.HasOne("HospitalManagementSystem.Models.Doctor", "Doctor")
                        .WithMany("Patients")
                        .HasForeignKey("DoctorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HospitalManagementSystem.Models.Room", "Room")
                        .WithMany("Patients")
                        .HasForeignKey("RoomId");

                    b.Navigation("Doctor");

                    b.Navigation("Room");
                });

            modelBuilder.Entity("HospitalManagementSystem.Models.Prescription", b =>
                {
                    b.HasOne("HospitalManagementSystem.Models.Patient", "Patient")
                        .WithMany("PrescriptionsGiven")
                        .HasForeignKey("PatientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Patient");
                });

            modelBuilder.Entity("HospitalManagementSystem.Models.PrescriptionMedicine", b =>
                {
                    b.HasOne("HospitalManagementSystem.Models.Prescription", "PrescriptionAssociated")
                        .WithMany("MedicinesList")
                        .HasForeignKey("PrescriptionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HospitalManagementSystem.Models.Medicine", "medicine")
                        .WithMany()
                        .HasForeignKey("medicineId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PrescriptionAssociated");

                    b.Navigation("medicine");
                });

            modelBuilder.Entity("HospitalManagementSystem.Models.Bill", b =>
                {
                    b.Navigation("MedicinesGiven");
                });

            modelBuilder.Entity("HospitalManagementSystem.Models.Doctor", b =>
                {
                    b.Navigation("Appointments");

                    b.Navigation("Patients");
                });

            modelBuilder.Entity("HospitalManagementSystem.Models.Patient", b =>
                {
                    b.Navigation("Appointments");

                    b.Navigation("BillsGiven");

                    b.Navigation("PrescriptionsGiven");
                });

            modelBuilder.Entity("HospitalManagementSystem.Models.Prescription", b =>
                {
                    b.Navigation("Bill");

                    b.Navigation("MedicinesList");
                });

            modelBuilder.Entity("HospitalManagementSystem.Models.Room", b =>
                {
                    b.Navigation("Patients");
                });
#pragma warning restore 612, 618
        }
    }
}
