using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using HospitEST_JuliaMizuguchiJulianaLeite.Models;

namespace HospitEST_JuliaMizuguchiJulianaLeite.Data
{
    public class HospitEST_JuliaMizuguchiJulianaLeiteContext : DbContext
    {
        public HospitEST_JuliaMizuguchiJulianaLeiteContext (DbContextOptions<HospitEST_JuliaMizuguchiJulianaLeiteContext> options)
            : base(options)
        {
        }

        public DbSet<HospitEST_JuliaMizuguchiJulianaLeite.Models.Patient_JMJL> Patient_JMJL { get; set; } = default!;
        public DbSet<HospitEST_JuliaMizuguchiJulianaLeite.Models.Doctor_JMJL> Doctor_JMJL { get; set; } = default!;
        public DbSet<HospitEST_JuliaMizuguchiJulianaLeite.Models.Hospital_JMJL> Hospital_JMJL { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Save list of Ids for the relations hospital-doctors and doctor-patients
            List<Guid> HospitalIds = new List<Guid>() { Guid.NewGuid(), Guid.NewGuid() };
            List<Guid> DoctorIds = new List<Guid>() { Guid.NewGuid(), Guid.NewGuid(), Guid.NewGuid(), Guid.NewGuid() };

            modelBuilder.Entity<Hospital_JMJL>().HasData(
                    new Hospital_JMJL
                    {
                        Id_JMJL = HospitalIds[0],
                        Name_JMJL = "Centro Hospitalar Lisboa Norte",
                        Location_JMJL = "Lisboa"
                    },
                    new Hospital_JMJL
                    {
                        Id_JMJL = HospitalIds[1],
                        Name_JMJL = "Centro Hospitalara de Setúbal",
                        Location_JMJL = "Setúbal"
                    }
            );

            modelBuilder.Entity<Doctor_JMJL>().HasData(
                    new Doctor_JMJL
                    {
                        Id_JMJL = DoctorIds[0],
                        Hospital_JMJLId = HospitalIds[0],
                        Name_JMJL = "Luis Silva",
                        Practice_JMJL = "Neurocirurgião",
                        PracticeYears_JMJL = 19
                    },
                    new Doctor_JMJL
                    {
                        Id_JMJL = DoctorIds[1],
                        Hospital_JMJLId = HospitalIds[0],
                        Name_JMJL = "Manuel Esteves",
                        Practice_JMJL = "Medicina Geral e Familiar",
                        PracticeYears_JMJL = 13
                    },
                    new Doctor_JMJL
                    {
                        Id_JMJL = DoctorIds[2],
                        Hospital_JMJLId = HospitalIds[1],
                        Name_JMJL = "Sofia Feliz",
                        Practice_JMJL = "Pediatra",
                        PracticeYears_JMJL = 4
                    },
                    new Doctor_JMJL
                    {
                        Id_JMJL = DoctorIds[3],
                        Hospital_JMJLId = HospitalIds[1],
                        Name_JMJL = "Miguel Neves",
                        Practice_JMJL = "Ortopedista",
                        PracticeYears_JMJL = 13
                    }
                );

            modelBuilder.Entity<Patient_JMJL>().HasData(
                        new Patient_JMJL
                        {
                            Id_JMJL = Guid.NewGuid(),
                            Doctor_JMJLId = DoctorIds[0],
                            Name_JMJL = "Bernardo Pereira",
                            DateOfBirth_JMJL = new DateTime(1990, 03, 22),
                            Pathology_JMJL = "Traumatismo Craniano"
                        },
                        new Patient_JMJL
                        {
                            Id_JMJL = Guid.NewGuid(),
                            Doctor_JMJLId = DoctorIds[0],
                            Name_JMJL = "Helena Porto",
                            DateOfBirth_JMJL = new DateTime(1957, 07, 30),
                            Pathology_JMJL = "AVC"
                        },
                        new Patient_JMJL
                        {
                            Id_JMJL = Guid.NewGuid(),
                            Doctor_JMJLId = DoctorIds[0],
                            Name_JMJL = "Otávio Campos",
                            DateOfBirth_JMJL = new DateTime(1990, 03, 22),
                            Pathology_JMJL = "Tumor no cérebro"
                        },
                        new Patient_JMJL
                        {
                            Id_JMJL = Guid.NewGuid(),
                            Doctor_JMJLId = DoctorIds[1],
                            Name_JMJL = "Ana Júlia Araújo",
                            DateOfBirth_JMJL = new DateTime(1984, 01, 08),
                            Pathology_JMJL = "Gripe"
                        },
                        new Patient_JMJL
                        {
                            Id_JMJL = Guid.NewGuid(),
                            Doctor_JMJLId = DoctorIds[2],
                            Name_JMJL = "Maitê Alves",
                            DateOfBirth_JMJL = new DateTime(2019, 10, 14),
                            Pathology_JMJL = "Asperger"
                        },
                        new Patient_JMJL
                        {
                            Id_JMJL = Guid.NewGuid(),
                            Doctor_JMJLId = DoctorIds[3],
                            Name_JMJL = "António Campos",
                            DateOfBirth_JMJL = new DateTime(2004, 12, 12),
                            Pathology_JMJL = "Perna partida"
                        },
                        new Patient_JMJL
                        {
                            Id_JMJL = Guid.NewGuid(),
                            Doctor_JMJLId = DoctorIds[3],
                            Name_JMJL = "Daniel Moreira",
                            DateOfBirth_JMJL = new DateTime(2005, 04, 29),
                            Pathology_JMJL = "Cotovelo Rachado"
                        },
                        new Patient_JMJL
                        {
                            Id_JMJL = Guid.NewGuid(),
                            Doctor_JMJLId = DoctorIds[3],
                            Name_JMJL = "David Nogueira",
                            DateOfBirth_JMJL = new DateTime(2001, 04, 13),
                            Pathology_JMJL = "Ombro deslocado"
                        }
                );
        }
    }
}
