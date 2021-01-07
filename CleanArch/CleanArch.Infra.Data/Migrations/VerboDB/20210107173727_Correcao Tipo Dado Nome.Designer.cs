﻿// <auto-generated />
using CleanArch.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CleanArch.Infra.Data.Migrations.VerboDB
{
    [DbContext(typeof(VerboDBContext))]
    [Migration("20210107173727_Correcao Tipo Dado Nome")]
    partial class CorrecaoTipoDadoNome
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("CleanArch.Domain.Models.TParoquiaComunidade", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<short>("Cidade")
                        .HasColumnType("smallint");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<short>("Estado")
                        .HasColumnType("smallint");

                    b.Property<string>("Nome")
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)");

                    b.Property<string>("Responsavel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Site")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TParoquiaComunidades");
                });
#pragma warning restore 612, 618
        }
    }
}
