﻿// <auto-generated />
using System;
using MVC_API_Core_MasterDetails.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MVC_API_Core_MasterDetails.Migrations
{
    [DbContext(typeof(CandidateDbContext))]
    [Migration("20240905184808_Momeen Ahmed")]
    partial class MomeenAhmed
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MVC_API_Core_MasterDetails.Models.Candidate", b =>
                {
                    b.Property<int>("CandidateId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CandidateId"));

                    b.Property<string>("CandidateName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("date");

                    b.Property<bool>("Fresher")
                        .HasColumnType("bit");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CandidateId");

                    b.ToTable("Candidates");
                });

            modelBuilder.Entity("MVC_API_Core_MasterDetails.Models.CandidateSkill", b =>
                {
                    b.Property<int>("CandidateSkillId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CandidateSkillId"));

                    b.Property<int>("CandidateId")
                        .HasColumnType("int");

                    b.Property<int>("SkillId")
                        .HasColumnType("int");

                    b.HasKey("CandidateSkillId");

                    b.HasIndex("CandidateId");

                    b.HasIndex("SkillId");

                    b.ToTable("CandidateSkills");
                });

            modelBuilder.Entity("MVC_API_Core_MasterDetails.Models.Skill", b =>
                {
                    b.Property<int>("SkillId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SkillId"));

                    b.Property<string>("SkillName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("SkillId");

                    b.ToTable("Skills");

                    b.HasData(
                        new
                        {
                            SkillId = 1,
                            SkillName = "Angular"
                        },
                        new
                        {
                            SkillId = 2,
                            SkillName = "React"
                        },
                        new
                        {
                            SkillId = 3,
                            SkillName = "HTML"
                        },
                        new
                        {
                            SkillId = 4,
                            SkillName = "MS SQL"
                        });
                });

            modelBuilder.Entity("MVC_API_Core_MasterDetails.Models.CandidateSkill", b =>
                {
                    b.HasOne("MVC_API_Core_MasterDetails.Models.Candidate", "Candidate")
                        .WithMany("CandidateSkills")
                        .HasForeignKey("CandidateId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MVC_API_Core_MasterDetails.Models.Skill", "Skill")
                        .WithMany("SkillCandidates")
                        .HasForeignKey("SkillId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Candidate");

                    b.Navigation("Skill");
                });

            modelBuilder.Entity("MVC_API_Core_MasterDetails.Models.Candidate", b =>
                {
                    b.Navigation("CandidateSkills");
                });

            modelBuilder.Entity("MVC_API_Core_MasterDetails.Models.Skill", b =>
                {
                    b.Navigation("SkillCandidates");
                });
#pragma warning restore 612, 618
        }
    }
}
