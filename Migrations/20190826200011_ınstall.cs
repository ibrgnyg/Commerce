using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Commerce.Migrations
{
    public partial class ınstall : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "kategoris",
                columns: table => new
                {
                    kategoriId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    kategoriName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_kategoris", x => x.kategoriId);
                });

            migrationBuilder.CreateTable(
                name: "users",
                columns: table => new
                {
                    userId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    email = table.Column<string>(nullable: true),
                    password = table.Column<string>(nullable: true),
                    rePassword = table.Column<string>(nullable: true),
                    firstname = table.Column<string>(nullable: true),
                    lastname = table.Column<string>(nullable: true),
                    phone = table.Column<string>(nullable: true),
                    address = table.Column<string>(nullable: true),
                    activationCode = table.Column<string>(nullable: true),
                    resetCode = table.Column<string>(nullable: true),
                    hostName = table.Column<string>(nullable: true),
                    isActive = table.Column<bool>(nullable: false),
                    loginAttempt = table.Column<int>(nullable: false),
                    createdDate = table.Column<DateTime>(nullable: false),
                    loginTime = table.Column<DateTime>(nullable: false),
                    isMailVerified = table.Column<bool>(nullable: false),
                    roleId = table.Column<int>(nullable: false),
                    subscribe = table.Column<bool>(nullable: false),
                    city = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_users", x => x.userId);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    Name = table.Column<string>(maxLength: 128, nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "uruns",
                columns: table => new
                {
                    urunId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    urunName = table.Column<string>(nullable: true),
                    urunAçıklama = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(nullable: false),
                    Resimyolu = table.Column<string>(nullable: true),
                    eklemetarihi = table.Column<DateTime>(nullable: false),
                    stock = table.Column<int>(nullable: false),
                    kategoriId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_uruns", x => x.urunId);
                    table.ForeignKey(
                        name: "FK_uruns_kategoris_kategoriId",
                        column: x => x.kategoriId,
                        principalTable: "kategoris",
                        principalColumn: "kategoriId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "indirims",
                columns: table => new
                {
                    indirimId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    indirimKodu = table.Column<string>(nullable: true),
                    aciklama = table.Column<string>(nullable: true),
                    indirimTutar = table.Column<decimal>(nullable: false),
                    indirimBaslangic = table.Column<DateTime>(nullable: false),
                    indirimBitis = table.Column<DateTime>(nullable: false),
                    indirimDurum = table.Column<bool>(nullable: false),
                    musteriNo = table.Column<int>(nullable: false),
                    kullanıldiMi = table.Column<bool>(nullable: false),
                    userId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_indirims", x => x.indirimId);
                    table.ForeignKey(
                        name: "FK_indirims_users_userId",
                        column: x => x.userId,
                        principalTable: "users",
                        principalColumn: "userId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "sipariss",
                columns: table => new
                {
                    siparisId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    musteriId = table.Column<int>(nullable: false),
                    siparisTarihi = table.Column<DateTime>(nullable: false),
                    firstname = table.Column<string>(nullable: true),
                    lastname = table.Column<string>(nullable: true),
                    address = table.Column<string>(nullable: true),
                    phone = table.Column<string>(nullable: true),
                    company = table.Column<string>(nullable: true),
                    city = table.Column<string>(nullable: true),
                    postakodu = table.Column<int>(nullable: false),
                    email = table.Column<string>(nullable: true),
                    note = table.Column<string>(nullable: true),
                    gonderimtutar = table.Column<decimal>(nullable: false),
                    farkliadres = table.Column<bool>(nullable: false),
                    indirimtutar = table.Column<decimal>(nullable: false),
                    siparistutar = table.Column<decimal>(nullable: false),
                    userId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sipariss", x => x.siparisId);
                    table.ForeignKey(
                        name: "FK_sipariss_users_userId",
                        column: x => x.userId,
                        principalTable: "users",
                        principalColumn: "userId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "baskets",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    producturunId = table.Column<int>(nullable: true),
                    quantity = table.Column<int>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_baskets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_baskets_uruns_producturunId",
                        column: x => x.producturunId,
                        principalTable: "uruns",
                        principalColumn: "urunId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "favorims",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    productId = table.Column<int>(nullable: false),
                    userId = table.Column<int>(nullable: false),
                    urunId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_favorims", x => x.id);
                    table.ForeignKey(
                        name: "FK_favorims_uruns_urunId",
                        column: x => x.urunId,
                        principalTable: "uruns",
                        principalColumn: "urunId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_favorims_users_userId",
                        column: x => x.userId,
                        principalTable: "users",
                        principalColumn: "userId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "resims",
                columns: table => new
                {
                    resimId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    resimAdi = table.Column<string>(nullable: true),
                    urunId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_resims", x => x.resimId);
                    table.ForeignKey(
                        name: "FK_resims_uruns_urunId",
                        column: x => x.urunId,
                        principalTable: "uruns",
                        principalColumn: "urunId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "yorums",
                columns: table => new
                {
                    yorumId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    urunId = table.Column<int>(nullable: false),
                    yorumAdi = table.Column<string>(nullable: true),
                    yorumcu = table.Column<string>(nullable: true),
                    yorumTarihi = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_yorums", x => x.yorumId);
                    table.ForeignKey(
                        name: "FK_yorums_uruns_urunId",
                        column: x => x.urunId,
                        principalTable: "uruns",
                        principalColumn: "urunId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "siparisDetays",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    siparisId = table.Column<int>(nullable: false),
                    urunId = table.Column<int>(nullable: false),
                    miktar = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_siparisDetays", x => x.Id);
                    table.ForeignKey(
                        name: "FK_siparisDetays_sipariss_siparisId",
                        column: x => x.siparisId,
                        principalTable: "sipariss",
                        principalColumn: "siparisId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_siparisDetays_uruns_urunId",
                        column: x => x.urunId,
                        principalTable: "uruns",
                        principalColumn: "urunId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_baskets_producturunId",
                table: "baskets",
                column: "producturunId");

            migrationBuilder.CreateIndex(
                name: "IX_favorims_urunId",
                table: "favorims",
                column: "urunId");

            migrationBuilder.CreateIndex(
                name: "IX_favorims_userId",
                table: "favorims",
                column: "userId");

            migrationBuilder.CreateIndex(
                name: "IX_indirims_userId",
                table: "indirims",
                column: "userId");

            migrationBuilder.CreateIndex(
                name: "IX_resims_urunId",
                table: "resims",
                column: "urunId");

            migrationBuilder.CreateIndex(
                name: "IX_siparisDetays_siparisId",
                table: "siparisDetays",
                column: "siparisId");

            migrationBuilder.CreateIndex(
                name: "IX_siparisDetays_urunId",
                table: "siparisDetays",
                column: "urunId");

            migrationBuilder.CreateIndex(
                name: "IX_sipariss_userId",
                table: "sipariss",
                column: "userId");

            migrationBuilder.CreateIndex(
                name: "IX_uruns_kategoriId",
                table: "uruns",
                column: "kategoriId");

            migrationBuilder.CreateIndex(
                name: "IX_yorums_urunId",
                table: "yorums",
                column: "urunId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "baskets");

            migrationBuilder.DropTable(
                name: "favorims");

            migrationBuilder.DropTable(
                name: "indirims");

            migrationBuilder.DropTable(
                name: "resims");

            migrationBuilder.DropTable(
                name: "siparisDetays");

            migrationBuilder.DropTable(
                name: "yorums");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "sipariss");

            migrationBuilder.DropTable(
                name: "uruns");

            migrationBuilder.DropTable(
                name: "users");

            migrationBuilder.DropTable(
                name: "kategoris");
        }
    }
}
