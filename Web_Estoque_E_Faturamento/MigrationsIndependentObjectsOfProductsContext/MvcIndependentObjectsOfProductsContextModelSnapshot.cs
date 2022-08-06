﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Web_Estoque_E_Faturamento.MigrationsIndependentObjectsOfProductsContext
{
    [DbContext(typeof(MvcIndependentObjectsOfProductsContext))]
    partial class MvcIndependentObjectsOfProductsContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Web_Estoque_E_Faturamento._Models.ProductListReminderToBuyWithoutUseProductAlreadyRegistered", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<bool>("AlreadyBuyed")
                        .HasColumnType("boolean");

                    b.Property<string>("CodeOfProduct")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("DateOfCreation")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("NameOfProduct")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("ProductListReminderToBuyWithoutUseProductAlreadyRegistered");
                });
#pragma warning restore 612, 618
        }
    }
}
