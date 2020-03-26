﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using users_groups.data;

namespace users_groups.data.Migrations
{
    [DbContext(typeof(UsersGroupsDbContext))]
    [Migration("20200326144802_SeedData")]
    partial class SeedData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("users_groups.data.Group", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("GroupName");

                    b.HasKey("Id");

                    b.ToTable("Groups");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            GroupName = "Hosts"
                        },
                        new
                        {
                            Id = 2,
                            GroupName = "Replicants"
                        },
                        new
                        {
                            Id = 3,
                            GroupName = "Humans"
                        },
                        new
                        {
                            Id = 4,
                            GroupName = "Cyborgs"
                        });
                });

            modelBuilder.Entity("users_groups.data.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("GroupId");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.HasIndex("GroupId");

                    b.ToTable("Persons");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            GroupId = 1,
                            Name = "Dolores Abernathy"
                        },
                        new
                        {
                            Id = 2,
                            GroupId = 1,
                            Name = "Bernard Lowe"
                        },
                        new
                        {
                            Id = 3,
                            GroupId = 1,
                            Name = "Maeve Millay"
                        },
                        new
                        {
                            Id = 4,
                            GroupId = 2,
                            Name = "Rick Deckard"
                        },
                        new
                        {
                            Id = 5,
                            GroupId = 2,
                            Name = "Rachel"
                        },
                        new
                        {
                            Id = 6,
                            GroupId = 3,
                            Name = "Robert Ford"
                        },
                        new
                        {
                            Id = 7,
                            GroupId = 3,
                            Name = "William"
                        },
                        new
                        {
                            Id = 8,
                            GroupId = 4,
                            Name = "T1000"
                        });
                });

            modelBuilder.Entity("users_groups.data.Person", b =>
                {
                    b.HasOne("users_groups.data.Group", "Group")
                        .WithMany("Persons")
                        .HasForeignKey("GroupId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}