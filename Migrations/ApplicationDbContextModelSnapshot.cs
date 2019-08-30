﻿// <auto-generated />
using System;
using Commerce.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Commerce.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Commerce.Areas.Admin.Models.User", b =>
                {
                    b.Property<int>("userId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("activationCode");

                    b.Property<string>("address");

                    b.Property<string>("city");

                    b.Property<DateTime>("createdDate");

                    b.Property<string>("email");

                    b.Property<string>("firstname");

                    b.Property<string>("hostName");

                    b.Property<bool>("isActive");

                    b.Property<bool>("isMailVerified");

                    b.Property<string>("lastname");

                    b.Property<int>("loginAttempt");

                    b.Property<DateTime>("loginTime");

                    b.Property<string>("password");

                    b.Property<string>("phone");

                    b.Property<string>("rePassword");

                    b.Property<string>("resetCode");

                    b.Property<int>("roleId");

                    b.Property<bool>("subscribe");

                    b.HasKey("userId");

                    b.ToTable("users");
                });

            modelBuilder.Entity("Commerce.Areas.Admin.Models.favorim", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("productId");

                    b.Property<int?>("urunId");

                    b.Property<int>("userId");

                    b.HasKey("id");

                    b.HasIndex("urunId");

                    b.HasIndex("userId");

                    b.ToTable("favorims");
                });

            modelBuilder.Entity("Commerce.Areas.Admin.Models.indirim", b =>
                {
                    b.Property<int>("indirimId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("aciklama");

                    b.Property<DateTime>("indirimBaslangic");

                    b.Property<DateTime>("indirimBitis");

                    b.Property<bool>("indirimDurum");

                    b.Property<string>("indirimKodu");

                    b.Property<decimal>("indirimTutar");

                    b.Property<bool>("kullanıldiMi");

                    b.Property<int>("musteriNo");

                    b.Property<int?>("userId");

                    b.HasKey("indirimId");

                    b.HasIndex("userId");

                    b.ToTable("indirims");
                });

            modelBuilder.Entity("Commerce.Areas.Admin.Models.kategori", b =>
                {
                    b.Property<int>("kategoriId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("kategoriName");

                    b.HasKey("kategoriId");

                    b.ToTable("kategoris");
                });

            modelBuilder.Entity("Commerce.Areas.Admin.Models.resim", b =>
                {
                    b.Property<int>("resimId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("resimAdi");

                    b.Property<int>("urunId");

                    b.HasKey("resimId");

                    b.HasIndex("urunId");

                    b.ToTable("resims");
                });

            modelBuilder.Entity("Commerce.Areas.Admin.Models.siparis", b =>
                {
                    b.Property<int>("siparisId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("address");

                    b.Property<string>("city");

                    b.Property<string>("company");

                    b.Property<string>("email");

                    b.Property<bool>("farkliadres");

                    b.Property<string>("firstname");

                    b.Property<decimal>("gonderimtutar");

                    b.Property<decimal>("indirimtutar");

                    b.Property<string>("lastname");

                    b.Property<int>("musteriId");

                    b.Property<string>("note");

                    b.Property<string>("phone");

                    b.Property<int>("postakodu");

                    b.Property<DateTime>("siparisTarihi");

                    b.Property<decimal>("siparistutar");

                    b.Property<int?>("userId");

                    b.HasKey("siparisId");

                    b.HasIndex("userId");

                    b.ToTable("sipariss");
                });

            modelBuilder.Entity("Commerce.Areas.Admin.Models.siparisDetay", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("miktar");

                    b.Property<int>("siparisId");

                    b.Property<int>("urunId");

                    b.HasKey("Id");

                    b.HasIndex("siparisId");

                    b.HasIndex("urunId");

                    b.ToTable("siparisDetays");
                });

            modelBuilder.Entity("Commerce.Areas.Admin.Models.urun", b =>
                {
                    b.Property<int>("urunId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Price");

                    b.Property<string>("Resimyolu");

                    b.Property<DateTime>("eklemetarihi");

                    b.Property<int>("kategoriId");

                    b.Property<int>("stock");

                    b.Property<string>("urunAçıklama");

                    b.Property<string>("urunName");

                    b.HasKey("urunId");

                    b.HasIndex("kategoriId");

                    b.ToTable("uruns");
                });

            modelBuilder.Entity("Commerce.Areas.Admin.Models.yorum", b =>
                {
                    b.Property<int>("yorumId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("urunId");

                    b.Property<string>("yorumAdi");

                    b.Property<DateTime>("yorumTarihi");

                    b.Property<string>("yorumcu");

                    b.HasKey("yorumId");

                    b.HasIndex("urunId");

                    b.ToTable("yorums");
                });

            modelBuilder.Entity("Commerce.Models.Basket", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DateCreated");

                    b.Property<int?>("producturunId");

                    b.Property<int>("quantity");

                    b.HasKey("Id");

                    b.HasIndex("producturunId");

                    b.ToTable("baskets");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .HasMaxLength(128);

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Commerce.Areas.Admin.Models.favorim", b =>
                {
                    b.HasOne("Commerce.Areas.Admin.Models.urun", "urun")
                        .WithMany()
                        .HasForeignKey("urunId");

                    b.HasOne("Commerce.Areas.Admin.Models.User", "user")
                        .WithMany()
                        .HasForeignKey("userId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Commerce.Areas.Admin.Models.indirim", b =>
                {
                    b.HasOne("Commerce.Areas.Admin.Models.User", "user")
                        .WithMany()
                        .HasForeignKey("userId");
                });

            modelBuilder.Entity("Commerce.Areas.Admin.Models.resim", b =>
                {
                    b.HasOne("Commerce.Areas.Admin.Models.urun", "urun")
                        .WithMany("resims")
                        .HasForeignKey("urunId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Commerce.Areas.Admin.Models.siparis", b =>
                {
                    b.HasOne("Commerce.Areas.Admin.Models.User", "user")
                        .WithMany()
                        .HasForeignKey("userId");
                });

            modelBuilder.Entity("Commerce.Areas.Admin.Models.siparisDetay", b =>
                {
                    b.HasOne("Commerce.Areas.Admin.Models.siparis", "sipariş")
                        .WithMany("siparisDetay")
                        .HasForeignKey("siparisId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Commerce.Areas.Admin.Models.urun", "urun")
                        .WithMany()
                        .HasForeignKey("urunId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Commerce.Areas.Admin.Models.urun", b =>
                {
                    b.HasOne("Commerce.Areas.Admin.Models.kategori", "Kategori")
                        .WithMany("Uruns")
                        .HasForeignKey("kategoriId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Commerce.Areas.Admin.Models.yorum", b =>
                {
                    b.HasOne("Commerce.Areas.Admin.Models.urun", "urun")
                        .WithMany()
                        .HasForeignKey("urunId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Commerce.Models.Basket", b =>
                {
                    b.HasOne("Commerce.Areas.Admin.Models.urun", "product")
                        .WithMany()
                        .HasForeignKey("producturunId");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
