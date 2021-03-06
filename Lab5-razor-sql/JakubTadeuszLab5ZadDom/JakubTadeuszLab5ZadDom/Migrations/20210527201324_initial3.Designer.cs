// <auto-generated />
using System;
using JakubTadeuszLab5ZadDom.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace JakubTadeuszLab5ZadDom.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20210527201324_initial3")]
    partial class initial3
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.6")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("JakubTadeuszLab5ZadDom.Models.Beast", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<decimal>("MarketValue")
                        .HasColumnType("money");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("TypeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TypeId");

                    b.ToTable("Beasts");
                });

            modelBuilder.Entity("JakubTadeuszLab5ZadDom.Models.BeastType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("BeastTypes");
                });

            modelBuilder.Entity("JakubTadeuszLab5ZadDom.Models.Contract", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ContractorName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("DateAdded")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("PhoneNumber")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<decimal?>("Prize")
                        .HasColumnType("money");

                    b.Property<string>("Region")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<int?>("WitcherId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("WitcherId");

                    b.ToTable("Contracts");
                });

            modelBuilder.Entity("JakubTadeuszLab5ZadDom.Models.Witcher", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("SchoolId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SchoolId");

                    b.ToTable("Witchers");
                });

            modelBuilder.Entity("JakubTadeuszLab5ZadDom.Models.WitcherSchool", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Headquarters")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("WitcherSchools");
                });

            modelBuilder.Entity("JakubTadeuszLab5ZadDom.Models.Beast", b =>
                {
                    b.HasOne("JakubTadeuszLab5ZadDom.Models.BeastType", "Type")
                        .WithMany("Beasts")
                        .HasForeignKey("TypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Type");
                });

            modelBuilder.Entity("JakubTadeuszLab5ZadDom.Models.Contract", b =>
                {
                    b.HasOne("JakubTadeuszLab5ZadDom.Models.Witcher", "Witcher")
                        .WithMany("Contracts")
                        .HasForeignKey("WitcherId");

                    b.Navigation("Witcher");
                });

            modelBuilder.Entity("JakubTadeuszLab5ZadDom.Models.Witcher", b =>
                {
                    b.HasOne("JakubTadeuszLab5ZadDom.Models.WitcherSchool", "WitcherSchool")
                        .WithMany("Witchers")
                        .HasForeignKey("SchoolId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("WitcherSchool");
                });

            modelBuilder.Entity("JakubTadeuszLab5ZadDom.Models.BeastType", b =>
                {
                    b.Navigation("Beasts");
                });

            modelBuilder.Entity("JakubTadeuszLab5ZadDom.Models.Witcher", b =>
                {
                    b.Navigation("Contracts");
                });

            modelBuilder.Entity("JakubTadeuszLab5ZadDom.Models.WitcherSchool", b =>
                {
                    b.Navigation("Witchers");
                });
#pragma warning restore 612, 618
        }
    }
}
