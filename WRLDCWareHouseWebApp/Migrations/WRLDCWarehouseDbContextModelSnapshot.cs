﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using WRLDCWarehouse.Data;

namespace WRLDCWareHouseWebApp.Migrations
{
    [DbContext(typeof(WRLDCWarehouseDbContext))]
    partial class WRLDCWarehouseDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("WRLDCWarehouse.Core.Entities.AcTransLineCkt", b =>
                {
                    b.Property<int>("AcTransLineCktId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AcTransmissionLineId");

                    b.Property<DateTime>("CODDate");

                    b.Property<string>("CktNumber");

                    b.Property<DateTime>("CommDate");

                    b.Property<int>("ConductorTypeId");

                    b.Property<DateTime>("DeCommDate");

                    b.Property<DateTime>("FtcDate");

                    b.Property<decimal>("Length");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<decimal>("SIL");

                    b.Property<decimal>("ThermalLimitMVA");

                    b.Property<DateTime>("TrialOperationDate");

                    b.Property<int>("VoltLevelId");

                    b.Property<int>("WebUatId");

                    b.HasKey("AcTransLineCktId");

                    b.HasIndex("AcTransmissionLineId");

                    b.HasIndex("ConductorTypeId");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.HasIndex("VoltLevelId");

                    b.HasIndex("WebUatId")
                        .IsUnique();

                    b.HasIndex("AcTransLineCktId", "CktNumber")
                        .IsUnique();

                    b.ToTable("AcTransLineCkts");
                });

            modelBuilder.Entity("WRLDCWarehouse.Core.Entities.AcTransLineCktOwner", b =>
                {
                    b.Property<int>("AcTransLineCktId");

                    b.Property<int>("OwnerId");

                    b.Property<int>("WebUatId");

                    b.HasKey("AcTransLineCktId", "OwnerId");

                    b.HasIndex("OwnerId");

                    b.ToTable("AcTransLineCktOwners");
                });

            modelBuilder.Entity("WRLDCWarehouse.Core.Entities.AcTransmissionLine", b =>
                {
                    b.Property<int>("AcTransmissionLineId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("FromSubstationId");

                    b.Property<int>("Name");

                    b.Property<int>("ToSubstationId");

                    b.Property<int>("VoltLevelId");

                    b.Property<int>("WebUatId");

                    b.HasKey("AcTransmissionLineId");

                    b.HasIndex("FromSubstationId");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.HasIndex("ToSubstationId");

                    b.HasIndex("VoltLevelId");

                    b.HasIndex("WebUatId")
                        .IsUnique();

                    b.ToTable("AcTransmissionLines");
                });

            modelBuilder.Entity("WRLDCWarehouse.Core.Entities.Bus", b =>
                {
                    b.Property<int>("BusId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("BusNumber");

                    b.Property<int>("Name");

                    b.Property<int>("SubstationId");

                    b.Property<int>("VoltLevelId");

                    b.Property<int>("WebUatId");

                    b.HasKey("BusId");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.HasIndex("VoltLevelId");

                    b.HasIndex("WebUatId")
                        .IsUnique();

                    b.HasIndex("SubstationId", "BusNumber")
                        .IsUnique();

                    b.ToTable("Buses");
                });

            modelBuilder.Entity("WRLDCWarehouse.Core.Entities.ConductorType", b =>
                {
                    b.Property<int>("ConductorTypeId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<int>("WebUatId");

                    b.HasKey("ConductorTypeId");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.HasIndex("WebUatId")
                        .IsUnique();

                    b.ToTable("ConductorTypes");
                });

            modelBuilder.Entity("WRLDCWarehouse.Core.Entities.MajorSubstation", b =>
                {
                    b.Property<int>("MajorSubstationId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<int>("StateId");

                    b.Property<int>("WebUatId");

                    b.HasKey("MajorSubstationId");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.HasIndex("StateId");

                    b.HasIndex("WebUatId")
                        .IsUnique();

                    b.ToTable("MajorSubstations");
                });

            modelBuilder.Entity("WRLDCWarehouse.Core.Entities.Owner", b =>
                {
                    b.Property<int>("OwnerId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<int>("WebUatId");

                    b.HasKey("OwnerId");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.HasIndex("WebUatId")
                        .IsUnique();

                    b.ToTable("Owners");
                });

            modelBuilder.Entity("WRLDCWarehouse.Core.Entities.Region", b =>
                {
                    b.Property<int>("RegionId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("FullName")
                        .IsRequired();

                    b.Property<string>("ShortName")
                        .IsRequired();

                    b.Property<int>("WebUatId");

                    b.HasKey("RegionId");

                    b.HasIndex("FullName")
                        .IsUnique();

                    b.HasIndex("ShortName")
                        .IsUnique();

                    b.HasIndex("WebUatId")
                        .IsUnique();

                    b.ToTable("Regions");
                });

            modelBuilder.Entity("WRLDCWarehouse.Core.Entities.State", b =>
                {
                    b.Property<int>("StateId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("FullName")
                        .IsRequired();

                    b.Property<int>("RegionId");

                    b.Property<string>("ShortName")
                        .IsRequired();

                    b.Property<int>("WebUatId");

                    b.HasKey("StateId");

                    b.HasIndex("FullName")
                        .IsUnique();

                    b.HasIndex("RegionId");

                    b.HasIndex("ShortName")
                        .IsUnique();

                    b.HasIndex("WebUatId")
                        .IsUnique();

                    b.ToTable("States");
                });

            modelBuilder.Entity("WRLDCWarehouse.Core.Entities.Substation", b =>
                {
                    b.Property<int>("SubstationId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("BusbarScheme")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue("NA");

                    b.Property<string>("Classification");

                    b.Property<DateTime>("CodDate");

                    b.Property<DateTime>("CommDate");

                    b.Property<DateTime>("DecommDate");

                    b.Property<int>("MajorSubstationId");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<int>("StateId");

                    b.Property<int>("VoltLevelId");

                    b.Property<int>("WebUatId");

                    b.HasKey("SubstationId");

                    b.HasIndex("MajorSubstationId");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.HasIndex("StateId");

                    b.HasIndex("VoltLevelId");

                    b.HasIndex("WebUatId")
                        .IsUnique();

                    b.ToTable("Substations");
                });

            modelBuilder.Entity("WRLDCWarehouse.Core.Entities.SubstationOwner", b =>
                {
                    b.Property<int>("SubstationId");

                    b.Property<int>("OwnerId");

                    b.Property<int>("WebUatId");

                    b.HasKey("SubstationId", "OwnerId");

                    b.HasIndex("OwnerId");

                    b.ToTable("SubstationOwners");
                });

            modelBuilder.Entity("WRLDCWarehouse.Core.Entities.VoltLevel", b =>
                {
                    b.Property<int>("VoltLevelId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("EntityType");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<int>("WebUatId");

                    b.HasKey("VoltLevelId");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.HasIndex("WebUatId")
                        .IsUnique();

                    b.ToTable("VoltLevels");
                });

            modelBuilder.Entity("WRLDCWarehouse.Core.Frequency.MartDailyFrequencySummary", b =>
                {
                    b.Property<int>("MartDailyFrequencySummaryId")
                        .ValueGeneratedOnAdd();

                    b.Property<decimal>("AverageFrequency")
                        .HasColumnType("decimal(4,2)");

                    b.Property<DateTime>("DataDate")
                        .HasColumnType("date");

                    b.Property<decimal>("FVIFrequency")
                        .HasColumnType("decimal(5,3)");

                    b.Property<decimal>("MaxBlkFreq")
                        .HasColumnType("decimal(4,2)");

                    b.Property<decimal>("MaxFrequency")
                        .HasColumnType("decimal(4,2)");

                    b.Property<DateTime>("MaxFrequencyTime");

                    b.Property<decimal>("MinBlkFreq")
                        .HasColumnType("decimal(4,2)");

                    b.Property<decimal>("MinFrequency")
                        .HasColumnType("decimal(4,2)");

                    b.Property<DateTime>("MinFrequencyTime");

                    b.Property<decimal>("NumOutOfIEGCHrs")
                        .HasColumnType("decimal(5,3)");

                    b.Property<decimal>("PercGreat50_05")
                        .HasColumnType("decimal(4,2)");

                    b.Property<decimal>("PercGreatEq49_9LessEq50_05")
                        .HasColumnType("decimal(4,2)");

                    b.Property<decimal>("PercLess48_8")
                        .HasColumnType("decimal(4,2)");

                    b.Property<decimal>("PercLess49")
                        .HasColumnType("decimal(4,2)");

                    b.Property<decimal>("PercLess49_2")
                        .HasColumnType("decimal(4,2)");

                    b.Property<decimal>("PercLess49_5")
                        .HasColumnType("decimal(4,2)");

                    b.Property<decimal>("PercLess49_7")
                        .HasColumnType("decimal(4,2)");

                    b.Property<decimal>("PercLess49_9")
                        .HasColumnType("decimal(4,2)");

                    b.Property<decimal>("StandardDeviationFrequency")
                        .HasColumnType("decimal(5,3)");

                    b.HasKey("MartDailyFrequencySummaryId");

                    b.HasIndex("DataDate")
                        .IsUnique();

                    b.ToTable("MartDailyFrequencySummaries");
                });

            modelBuilder.Entity("WRLDCWarehouse.Core.Frequency.RawFrequency", b =>
                {
                    b.Property<int>("RawFrequencyId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DataTime");

                    b.Property<decimal>("Frequency")
                        .HasColumnType("decimal(5,3)");

                    b.HasKey("RawFrequencyId");

                    b.HasIndex("DataTime")
                        .IsUnique();

                    b.ToTable("RawFrequencies");
                });

            modelBuilder.Entity("WRLDCWarehouse.Core.Entities.AcTransLineCkt", b =>
                {
                    b.HasOne("WRLDCWarehouse.Core.Entities.AcTransmissionLine", "AcTransmissionLine")
                        .WithMany()
                        .HasForeignKey("AcTransmissionLineId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("WRLDCWarehouse.Core.Entities.ConductorType", "ConductorType")
                        .WithMany()
                        .HasForeignKey("ConductorTypeId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("WRLDCWarehouse.Core.Entities.VoltLevel", "VoltLevel")
                        .WithMany()
                        .HasForeignKey("VoltLevelId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("WRLDCWarehouse.Core.Entities.AcTransLineCktOwner", b =>
                {
                    b.HasOne("WRLDCWarehouse.Core.Entities.AcTransLineCkt", "AcTransLineCkt")
                        .WithMany("AcTransLineCktOwners")
                        .HasForeignKey("AcTransLineCktId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("WRLDCWarehouse.Core.Entities.Owner", "Owner")
                        .WithMany()
                        .HasForeignKey("OwnerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("WRLDCWarehouse.Core.Entities.AcTransmissionLine", b =>
                {
                    b.HasOne("WRLDCWarehouse.Core.Entities.Substation", "FromSubstation")
                        .WithMany()
                        .HasForeignKey("FromSubstationId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("WRLDCWarehouse.Core.Entities.Substation", "ToSubstation")
                        .WithMany()
                        .HasForeignKey("ToSubstationId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("WRLDCWarehouse.Core.Entities.VoltLevel", "VoltLevel")
                        .WithMany()
                        .HasForeignKey("VoltLevelId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("WRLDCWarehouse.Core.Entities.Bus", b =>
                {
                    b.HasOne("WRLDCWarehouse.Core.Entities.Substation", "Substation")
                        .WithMany()
                        .HasForeignKey("SubstationId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("WRLDCWarehouse.Core.Entities.VoltLevel", "VoltLevel")
                        .WithMany()
                        .HasForeignKey("VoltLevelId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("WRLDCWarehouse.Core.Entities.MajorSubstation", b =>
                {
                    b.HasOne("WRLDCWarehouse.Core.Entities.State", "State")
                        .WithMany()
                        .HasForeignKey("StateId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("WRLDCWarehouse.Core.Entities.State", b =>
                {
                    b.HasOne("WRLDCWarehouse.Core.Entities.Region", "Region")
                        .WithMany()
                        .HasForeignKey("RegionId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("WRLDCWarehouse.Core.Entities.Substation", b =>
                {
                    b.HasOne("WRLDCWarehouse.Core.Entities.MajorSubstation", "MajorSubstation")
                        .WithMany()
                        .HasForeignKey("MajorSubstationId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("WRLDCWarehouse.Core.Entities.State", "State")
                        .WithMany()
                        .HasForeignKey("StateId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("WRLDCWarehouse.Core.Entities.VoltLevel", "VoltLevel")
                        .WithMany()
                        .HasForeignKey("VoltLevelId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("WRLDCWarehouse.Core.Entities.SubstationOwner", b =>
                {
                    b.HasOne("WRLDCWarehouse.Core.Entities.Owner", "Owner")
                        .WithMany()
                        .HasForeignKey("OwnerId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("WRLDCWarehouse.Core.Entities.Substation", "Substation")
                        .WithMany("SubstationOwners")
                        .HasForeignKey("SubstationId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
