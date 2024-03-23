﻿// <auto-generated />
using System;
using BtkProje.Model.Db;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BtkProje.Model.Migrations
{
    [DbContext(typeof(BtkProjeDbContext))]
    [Migration("20240323072110_Mig1")]
    partial class Mig1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.17")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BtkProje.Model.Modeller.TblBirim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("BirimAd")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<DateTime?>("GuncellemeTarihi")
                        .HasColumnType("datetime2");

                    b.Property<int?>("GuncelleyenKullaniciId")
                        .HasColumnType("int");

                    b.Property<int?>("OlusturanKullaniciId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("OlusturmaTarihi")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("GuncelleyenKullaniciId");

                    b.HasIndex("OlusturanKullaniciId");

                    b.ToTable("Birimler");
                });

            modelBuilder.Entity("BtkProje.Model.Modeller.TblKategori", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("GuncellemeTarihi")
                        .HasColumnType("datetime2");

                    b.Property<int?>("GuncelleyenKullaniciId")
                        .HasColumnType("int");

                    b.Property<string>("KategoriAd")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("OlusturanKullaniciId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("OlusturmaTarihi")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("GuncelleyenKullaniciId");

                    b.HasIndex("OlusturanKullaniciId");

                    b.ToTable("Kategoriler");
                });

            modelBuilder.Entity("BtkProje.Model.Modeller.TblKullanici", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Ad")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime?>("GuncellemeTarihi")
                        .HasColumnType("datetime2");

                    b.Property<int?>("GuncelleyenKullaniciId")
                        .HasColumnType("int");

                    b.Property<string>("KullaniciAdi")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("OlusturanKullaniciId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("OlusturmaTarihi")
                        .HasColumnType("datetime2");

                    b.Property<string>("Parola")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Soyad")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Yetki")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("GuncelleyenKullaniciId");

                    b.HasIndex("OlusturanKullaniciId");

                    b.ToTable("Kullanicilar");
                });

            modelBuilder.Entity("BtkProje.Model.Modeller.TblUrun", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Aciklama")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("BirimId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("GuncellemeTarihi")
                        .HasColumnType("datetime2");

                    b.Property<int?>("GuncelleyenKullaniciId")
                        .HasColumnType("int");

                    b.Property<int>("KategoriId")
                        .HasColumnType("int");

                    b.Property<double?>("MaksStok")
                        .HasColumnType("float");

                    b.Property<double?>("MinStok")
                        .HasColumnType("float");

                    b.Property<int?>("OlusturanKullaniciId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("OlusturmaTarihi")
                        .HasColumnType("datetime2");

                    b.Property<string>("UrunAd")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("UrunKod")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("BirimId");

                    b.HasIndex("GuncelleyenKullaniciId");

                    b.HasIndex("KategoriId");

                    b.HasIndex("OlusturanKullaniciId");

                    b.ToTable("Urunler");
                });

            modelBuilder.Entity("BtkProje.Model.Modeller.TblBirim", b =>
                {
                    b.HasOne("BtkProje.Model.Modeller.TblKullanici", "GuncelleyenKullanici")
                        .WithMany()
                        .HasForeignKey("GuncelleyenKullaniciId");

                    b.HasOne("BtkProje.Model.Modeller.TblKullanici", "OlusturanKullanici")
                        .WithMany()
                        .HasForeignKey("OlusturanKullaniciId");

                    b.Navigation("GuncelleyenKullanici");

                    b.Navigation("OlusturanKullanici");
                });

            modelBuilder.Entity("BtkProje.Model.Modeller.TblKategori", b =>
                {
                    b.HasOne("BtkProje.Model.Modeller.TblKullanici", "GuncelleyenKullanici")
                        .WithMany()
                        .HasForeignKey("GuncelleyenKullaniciId");

                    b.HasOne("BtkProje.Model.Modeller.TblKullanici", "OlusturanKullanici")
                        .WithMany()
                        .HasForeignKey("OlusturanKullaniciId");

                    b.Navigation("GuncelleyenKullanici");

                    b.Navigation("OlusturanKullanici");
                });

            modelBuilder.Entity("BtkProje.Model.Modeller.TblKullanici", b =>
                {
                    b.HasOne("BtkProje.Model.Modeller.TblKullanici", "GuncelleyenKullanici")
                        .WithMany()
                        .HasForeignKey("GuncelleyenKullaniciId");

                    b.HasOne("BtkProje.Model.Modeller.TblKullanici", "OlusturanKullanici")
                        .WithMany()
                        .HasForeignKey("OlusturanKullaniciId");

                    b.Navigation("GuncelleyenKullanici");

                    b.Navigation("OlusturanKullanici");
                });

            modelBuilder.Entity("BtkProje.Model.Modeller.TblUrun", b =>
                {
                    b.HasOne("BtkProje.Model.Modeller.TblBirim", "Birim")
                        .WithMany()
                        .HasForeignKey("BirimId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BtkProje.Model.Modeller.TblKullanici", "GuncelleyenKullanici")
                        .WithMany()
                        .HasForeignKey("GuncelleyenKullaniciId");

                    b.HasOne("BtkProje.Model.Modeller.TblKategori", "Kategori")
                        .WithMany("Urunler")
                        .HasForeignKey("KategoriId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BtkProje.Model.Modeller.TblKullanici", "OlusturanKullanici")
                        .WithMany()
                        .HasForeignKey("OlusturanKullaniciId");

                    b.Navigation("Birim");

                    b.Navigation("GuncelleyenKullanici");

                    b.Navigation("Kategori");

                    b.Navigation("OlusturanKullanici");
                });

            modelBuilder.Entity("BtkProje.Model.Modeller.TblKategori", b =>
                {
                    b.Navigation("Urunler");
                });
#pragma warning restore 612, 618
        }
    }
}
