// <auto-generated />
using System;
using BankingInternationalSystemsApp.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BankingInternationalSystemsApp.Database.Migrations
{
    [DbContext(typeof(BisContext))]
    [Migration("20210901080413_InitialModel")]
    partial class InitialModel
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BankingInternationalSystemsApp.Model.Models.Account", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AccountNumber")
                        .HasMaxLength(10)
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<double>("InitialBalance")
                        .HasColumnType("float");

                    b.Property<string>("SecondName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.HasIndex("AccountNumber", "Email")
                        .IsUnique();

                    b.ToTable("Accounts");
                });

            modelBuilder.Entity("BankingInternationalSystemsApp.Model.Models.BankService", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("BankServices");
                });

            modelBuilder.Entity("BankingInternationalSystemsApp.Model.Models.LodgeAccount", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AccountId")
                        .HasColumnType("int");

                    b.Property<double>("Ammount")
                        .HasColumnType("float");

                    b.Property<DateTime>("LodgeDateTime")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("AccountId");

                    b.ToTable("LodgeAccounts");
                });

            modelBuilder.Entity("BankingInternationalSystemsApp.Model.Models.WithdrawAccount", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AccountId")
                        .HasColumnType("int");

                    b.Property<double>("Ammount")
                        .HasColumnType("float");

                    b.Property<DateTime>("WithdrawDateTime")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("AccountId");

                    b.ToTable("WithdrawAccounts");
                });

            modelBuilder.Entity("BankingInternationalSystemsApp.Model.Models.LodgeAccount", b =>
                {
                    b.HasOne("BankingInternationalSystemsApp.Model.Models.Account", "Account")
                        .WithMany("LodgeAccounts")
                        .HasForeignKey("AccountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Account");
                });

            modelBuilder.Entity("BankingInternationalSystemsApp.Model.Models.WithdrawAccount", b =>
                {
                    b.HasOne("BankingInternationalSystemsApp.Model.Models.Account", "Account")
                        .WithMany("WithdrawAccounts")
                        .HasForeignKey("AccountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Account");
                });

            modelBuilder.Entity("BankingInternationalSystemsApp.Model.Models.Account", b =>
                {
                    b.Navigation("LodgeAccounts");

                    b.Navigation("WithdrawAccounts");
                });
#pragma warning restore 612, 618
        }
    }
}
