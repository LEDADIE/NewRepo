// <auto-generated />
using System;
using EFNetCore5AccessDataLibrairy.DatabaseContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EFNetCore5AccessDataLibrairy.Migrations
{
    [DbContext(typeof(APIDatabaseContext))]
    [Migration("20210524213419_CreationInitiale")]
    partial class CreationInitiale
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.6")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EFNetCore5AccessDataLibrairy.EntityModels.Address", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<Guid?>("ClientId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreateDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("getutcdate()");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("StreetAdress")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<DateTime>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ZipCode")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)");

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.ToTable("dle_adresseBase");
                });

            modelBuilder.Entity("EFNetCore5AccessDataLibrairy.EntityModels.Client", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreateDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("getutcdate()");

                    b.Property<string>("FullName")
                        .HasMaxLength(405)
                        .HasColumnType("nvarchar(405)");

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Prenoms")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.Property<string>("Sexe")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Telephone")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<DateTime>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("dle_clientBase");
                });

            modelBuilder.Entity("EFNetCore5AccessDataLibrairy.EntityModels.Email", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("ClientId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreateDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("getutcdate()");

                    b.Property<string>("EmailAdress")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.Property<DateTime>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.ToTable("dle_adresseEmailBase");
                });

            modelBuilder.Entity("EFNetCore5AccessDataLibrairy.EntityModels.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreateDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("getutcdate()");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsAdmin")
                        .HasColumnType("bit");

                    b.Property<string>("JobFunction")
                        .HasMaxLength(500)
                        .HasColumnType("varchar(500)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(1024)
                        .HasColumnType("varchar(1024)");

                    b.Property<string>("Picture")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pseudo")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<DateTime>("UpdateDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("getutcdate()");

                    b.HasKey("Id");

                    b.ToTable("dle_utilisateurBase");
                });

            modelBuilder.Entity("EFNetCore5AccessDataLibrairy.ModelsTest.Project", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DeadLine")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Projects");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DeadLine = new DateTime(2121, 5, 24, 21, 34, 17, 584, DateTimeKind.Local).AddTicks(5157),
                            Name = "Buy Google",
                            StartDate = new DateTime(2021, 5, 24, 21, 34, 17, 584, DateTimeKind.Local).AddTicks(3233)
                        },
                        new
                        {
                            Id = 3,
                            DeadLine = new DateTime(2021, 5, 24, 21, 34, 17, 584, DateTimeKind.Local).AddTicks(9194),
                            Name = "Be Happy",
                            StartDate = new DateTime(2021, 5, 24, 21, 34, 17, 584, DateTimeKind.Local).AddTicks(9189)
                        },
                        new
                        {
                            Id = 2,
                            DeadLine = new DateTime(2023, 5, 24, 21, 34, 17, 584, DateTimeKind.Local).AddTicks(9153),
                            Name = "Develop new Pied Pipper",
                            StartDate = new DateTime(2021, 5, 24, 21, 34, 17, 584, DateTimeKind.Local).AddTicks(9137)
                        });
                });

            modelBuilder.Entity("EFNetCore5AccessDataLibrairy.ModelsTest.ProjectTineos", b =>
                {
                    b.Property<int>("ProjectId")
                        .HasColumnType("int");

                    b.Property<int>("TineosId")
                        .HasColumnType("int");

                    b.HasKey("ProjectId", "TineosId");

                    b.HasIndex("TineosId");

                    b.ToTable("ProjectTineos");

                    b.HasData(
                        new
                        {
                            ProjectId = 3,
                            TineosId = 1
                        },
                        new
                        {
                            ProjectId = 3,
                            TineosId = 2
                        },
                        new
                        {
                            ProjectId = 3,
                            TineosId = 3
                        },
                        new
                        {
                            ProjectId = 2,
                            TineosId = 3
                        },
                        new
                        {
                            ProjectId = 1,
                            TineosId = 1
                        },
                        new
                        {
                            ProjectId = 1,
                            TineosId = 2
                        });
                });

            modelBuilder.Entity("EFNetCore5AccessDataLibrairy.ModelsTest.Tineos", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("JobFunction")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Tineos");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            FirstName = "John",
                            JobFunction = "Communication Expert",
                            LastName = "DOE",
                            Mail = "john.doe@mail.com",
                            Password = "6niXyt4vhoOWhG6N/Rje0e4wGrGndK0eSbahkJdu7kk=",
                            StartDate = new DateTime(2021, 5, 24, 21, 34, 17, 446, DateTimeKind.Local).AddTicks(510)
                        },
                        new
                        {
                            Id = 2,
                            FirstName = "Jeny",
                            JobFunction = "Big Boss",
                            LastName = "ANDERSON",
                            Mail = "jeny.anderson@mail.com",
                            Password = "6niXyt4vhoOWhG6N/Rje0e4wGrGndK0eSbahkJdu7kk=",
                            StartDate = new DateTime(2021, 5, 24, 21, 34, 17, 507, DateTimeKind.Local).AddTicks(5377)
                        },
                        new
                        {
                            Id = 3,
                            FirstName = "Carl",
                            JobFunction = "Lead Developer",
                            LastName = "WICK",
                            Mail = "carl.wick@mail.com",
                            Password = "6niXyt4vhoOWhG6N/Rje0e4wGrGndK0eSbahkJdu7kk=",
                            StartDate = new DateTime(2021, 5, 24, 21, 34, 17, 546, DateTimeKind.Local).AddTicks(3247)
                        });
                });

            modelBuilder.Entity("EFNetCore5AccessDataLibrairy.EntityModels.Address", b =>
                {
                    b.HasOne("EFNetCore5AccessDataLibrairy.EntityModels.Client", null)
                        .WithMany("Addresses")
                        .HasForeignKey("ClientId");
                });

            modelBuilder.Entity("EFNetCore5AccessDataLibrairy.EntityModels.Client", b =>
                {
                    b.HasOne("EFNetCore5AccessDataLibrairy.EntityModels.User", null)
                        .WithMany("ClientsUser")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("EFNetCore5AccessDataLibrairy.EntityModels.Email", b =>
                {
                    b.HasOne("EFNetCore5AccessDataLibrairy.EntityModels.Client", null)
                        .WithMany("EmailAddresses")
                        .HasForeignKey("ClientId");
                });

            modelBuilder.Entity("EFNetCore5AccessDataLibrairy.ModelsTest.ProjectTineos", b =>
                {
                    b.HasOne("EFNetCore5AccessDataLibrairy.ModelsTest.Project", "Project")
                        .WithMany("ProjectTineos")
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EFNetCore5AccessDataLibrairy.ModelsTest.Tineos", "Tineos")
                        .WithMany()
                        .HasForeignKey("TineosId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Project");

                    b.Navigation("Tineos");
                });

            modelBuilder.Entity("EFNetCore5AccessDataLibrairy.EntityModels.Client", b =>
                {
                    b.Navigation("Addresses");

                    b.Navigation("EmailAddresses");
                });

            modelBuilder.Entity("EFNetCore5AccessDataLibrairy.EntityModels.User", b =>
                {
                    b.Navigation("ClientsUser");
                });

            modelBuilder.Entity("EFNetCore5AccessDataLibrairy.ModelsTest.Project", b =>
                {
                    b.Navigation("ProjectTineos");
                });
#pragma warning restore 612, 618
        }
    }
}
