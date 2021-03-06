// <auto-generated />
using HWS_EntityFrameworkCore_2022_30_05;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HWS_EntityFrameworkCore_2022_30_05.Migrations
{
    [DbContext(typeof(ArenaContext))]
    [Migration("20220531134650_CreateArenaDB2")]
    partial class CreateArenaDB2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("HWS_EntityFrameworkCore_2022_30_05.Gladiator", b =>
                {
                    b.Property<int>("GladiatorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GladiatorId"), 1L, 1);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Level")
                        .HasColumnType("int");

                    b.Property<string>("Proffesion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GladiatorId");

                    b.ToTable("Gladiators");
                });
#pragma warning restore 612, 618
        }
    }
}
