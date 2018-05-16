﻿// <auto-generated />
using EstoqueLivrariaApi.Model.DataBaseContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace EstoqueLivrariaApi.Migrations
{
    [DbContext(typeof(EstoqueLivrariaContext))]
    partial class EstoqueLivrariaContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.3-rtm-10026")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EstoqueLivrariaApi.Model.Livro", b =>
                {
                    b.Property<int>("ID_Codigo")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("DS_Autor");

                    b.Property<string>("DS_Titulo");

                    b.Property<string>("DT_Imagem");

                    b.Property<int>("NR_Estoque");

                    b.HasKey("ID_Codigo");

                    b.ToTable("Livros");
                });
#pragma warning restore 612, 618
        }
    }
}
