﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using bem_mais_cuidado.API.Persistence;

#nullable disable

namespace bem_mais_cuidado.API.Persistence.Migrations
{
    [DbContext(typeof(MassoterapiaBemMaisCuidadoDbContext))]
    [Migration("20240505150800_FirstMigration")]
    partial class FirstMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("bem_mais_cuidado.API.Entities.AgendaBemMaisCuidado", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("DiaDaSemana")
                        .HasColumnType("int");

                    b.Property<int>("DuracaoSessao")
                        .HasColumnType("int");

                    b.Property<DateTime>("HoraAlmocoFinal")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("HoraAlmocoInicial")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("HoraFinal")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("HoraInicial")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("IdAgendaBemMaisCuidao")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("IdColaborado")
                        .HasColumnType("int");

                    b.Property<Guid>("IdConfiguracaoAgendaBemMaisCuidado")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdLocalAtividadeBemMaisCuidado")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int>("Mes")
                        .HasColumnType("int");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Agendas");
                });

            modelBuilder.Entity("bem_mais_cuidado.API.Entities.AgendamentoBemMaisCuidado", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("Ativo")
                        .HasColumnType("bit");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataAtualizacao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataCriacao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("HorarioFinal")
                        .HasColumnType("datetime2")
                        .HasColumnName("Horario_Final");

                    b.Property<DateTime>("HorarioInicial")
                        .HasColumnType("datetime2")
                        .HasColumnName("Horario_Inicial");

                    b.Property<Guid>("IdAgendaBemMaisCuidado")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdAgendamentoBemMaisCuidado")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdColaboradorBemMaisCuidado")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int>("ResponsavelAtualizacao")
                        .HasColumnType("int");

                    b.Property<int>("ResponsavelCriacao")
                        .HasColumnType("int");

                    b.Property<string>("Titulo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Agendamentos");
                });
#pragma warning restore 612, 618
        }
    }
}
