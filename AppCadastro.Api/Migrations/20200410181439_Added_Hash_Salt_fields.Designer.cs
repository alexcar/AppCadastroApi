﻿// <auto-generated />
using System;
using AppCadastro.Infra;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AppCadastro.Api.Migrations
{
    [DbContext(typeof(AppCadastroContext))]
    [Migration("20200410181439_Added_Hash_Salt_fields")]
    partial class Added_Hash_Salt_fields
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AppCadastro.Domain.Entities.Sexo", b =>
                {
                    b.Property<int>("SexoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("nvarchar(15)")
                        .HasMaxLength(15);

                    b.HasKey("SexoId");

                    b.ToTable("Sexo");
                });

            modelBuilder.Entity("AppCadastro.Domain.Entities.Usuario", b =>
                {
                    b.Property<int>("UsuarioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Ativo")
                        .HasColumnType("bit");

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Hash")
                        .IsRequired()
                        .HasColumnType("nvarchar(90)")
                        .HasMaxLength(90);

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<string>("Salt")
                        .IsRequired()
                        .HasColumnType("nvarchar(90)")
                        .HasMaxLength(90);

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<int>("SexoId")
                        .HasColumnType("int");

                    b.HasKey("UsuarioId");

                    b.HasIndex("SexoId");

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("AppCadastro.Domain.Entities.Usuario", b =>
                {
                    b.HasOne("AppCadastro.Domain.Entities.Sexo", "Sexo")
                        .WithMany("Usuarios")
                        .HasForeignKey("SexoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
