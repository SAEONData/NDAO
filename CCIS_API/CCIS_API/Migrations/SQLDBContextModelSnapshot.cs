﻿// <auto-generated />
using System;
using CCIS_API.Database.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CCIS_API.Migrations
{
    [DbContext(typeof(SQLDBContext))]
    partial class SQLDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.3-rtm-32065")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CCIS_API.Database.Models.Goal1", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CreateUserId");

                    b.Property<string>("Created");

                    b.Property<string>("DocLastUpdated");

                    b.Property<string>("DocumentLink");

                    b.Property<bool>("HasAssessment");

                    b.Property<string>("LastUpdateUserId");

                    b.Property<string>("LastUpdated");

                    b.HasKey("Id");

                    b.ToTable("Goal1");
                });

            modelBuilder.Entity("CCIS_API.Database.Models.Goal2", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CreateUserId");

                    b.Property<string>("Created");

                    b.Property<bool>("DedicatedChampion");

                    b.Property<bool>("DedicatedFunding");

                    b.Property<string>("DocumentLink");

                    b.Property<string>("FundingAgency");

                    b.Property<int>("FundingDuration");

                    b.Property<int>("IncludedInForums");

                    b.Property<string>("LastUpdateUserId");

                    b.Property<string>("LastUpdated");

                    b.Property<string>("PartneringDepartments");

                    b.Property<int>("TotalBudget");

                    b.HasKey("Id");

                    b.ToTable("Goal2");
                });

            modelBuilder.Entity("CCIS_API.Database.Models.Goal3", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("BudgetDuration");

                    b.Property<string>("CreateUserId");

                    b.Property<string>("Created");

                    b.Property<int>("DisseminationUtilisation");

                    b.Property<string>("FundingAgency");

                    b.Property<string>("LastUpdateUserId");

                    b.Property<string>("LastUpdated");

                    b.Property<int>("MonitoringForcasting");

                    b.Property<string>("PartneringDepartments");

                    b.Property<int>("TotalBudget");

                    b.HasKey("Id");

                    b.ToTable("Goal3");
                });

            modelBuilder.Entity("CCIS_API.Database.Models.Goal4", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("BudgetDuration");

                    b.Property<int>("CapacityBuilding");

                    b.Property<string>("CreateUserId");

                    b.Property<string>("Created");

                    b.Property<string>("FundingAgency");

                    b.Property<string>("LastUpdateUserId");

                    b.Property<string>("LastUpdated");

                    b.Property<string>("PartneringDepartments");

                    b.Property<int>("TotalBudget");

                    b.HasKey("Id");

                    b.ToTable("Goal4");
                });

            modelBuilder.Entity("CCIS_API.Database.Models.Goal5", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CreateUserId");

                    b.Property<string>("Created");

                    b.Property<string>("EvidenceLink");

                    b.Property<string>("LastUpdateUserId");

                    b.Property<string>("LastUpdated");

                    b.Property<int>("TechnologyAwareness");

                    b.HasKey("Id");

                    b.ToTable("Goal5");
                });

            modelBuilder.Entity("CCIS_API.Database.Models.Goal6", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CreateUserId");

                    b.Property<string>("Created");

                    b.Property<int>("IncludedInForums");

                    b.Property<string>("LastUpdateUserId");

                    b.Property<string>("LastUpdated");

                    b.HasKey("Id");

                    b.ToTable("Goal6");
                });

            modelBuilder.Entity("CCIS_API.Database.Models.Goal7", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CreateUserId");

                    b.Property<string>("Created");

                    b.Property<string>("LastUpdateUserId");

                    b.Property<string>("LastUpdated");

                    b.Property<int>("ResultingChange");

                    b.HasKey("Id");

                    b.ToTable("Goal7");
                });

            modelBuilder.Entity("CCIS_API.Database.Models.Goal8", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CreateUserId");

                    b.Property<string>("Created");

                    b.Property<string>("EvidenceLink");

                    b.Property<string>("LastUpdateUserId");

                    b.Property<string>("LastUpdated");

                    b.Property<int>("NonClimateChange");

                    b.HasKey("Id");

                    b.ToTable("Goal8");
                });

            modelBuilder.Entity("CCIS_API.Database.Models.Goal9", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CreateUserId");

                    b.Property<string>("Created");

                    b.Property<string>("EvidenceLink");

                    b.Property<string>("LastUpdateUserId");

                    b.Property<string>("LastUpdated");

                    b.Property<int>("NonClimateChange");

                    b.HasKey("Id");

                    b.ToTable("Goal9");
                });
#pragma warning restore 612, 618
        }
    }
}
