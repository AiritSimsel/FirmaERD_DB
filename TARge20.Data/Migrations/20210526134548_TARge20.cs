using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TARge20.Data.Migrations
{
    public partial class TARge20 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Isikukood = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Aadress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Kontakttelefon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TöölAlates = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Kommentaar = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Ametinimetus",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EmployeeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Nimetus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Kommentaar = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ametinimetus", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ametinimetus_Employee_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Children",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Eesnimi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Perekonnanimi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Isikukood = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Kommentaar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmployeeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Children", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Children_Employee_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Ettepanek",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EmployeeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Kommentaar = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ettepanek", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Ettepanek_Employee_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Haigusleht",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EmployeeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Algus = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Lõpp = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Kommentaar = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Haigusleht", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Haigusleht_Employee_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Laenutus",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EmployeeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Kommentaar = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Laenutus", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Laenutus_Employee_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Ligipääs",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EmployeeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Kommentaar = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ligipääs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ligipääs_Employee_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Puhkus",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EmployeeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Puhkus", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Puhkus_Employee_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Tervisekontroll",
                columns: table => new
                {
                    TervisId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EmployeeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Kuupäev = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Kommentaar = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tervisekontroll", x => x.TervisId);
                    table.ForeignKey(
                        name: "FK_Tervisekontroll_Employee_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Töötamine",
                columns: table => new
                {
                    TöötamineId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AmetinimetusId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    EmployeeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Alates = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Kuni = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Töötamine", x => x.TöötamineId);
                    table.ForeignKey(
                        name: "FK_Töötamine_Ametinimetus_AmetinimetusId",
                        column: x => x.AmetinimetusId,
                        principalTable: "Ametinimetus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Töötamine_Employee_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "LaenutatavAsi",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LaenutusId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Algus = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Lõpp = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Kommentaar = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LaenutatavAsi", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LaenutatavAsi_Laenutus_LaenutusId",
                        column: x => x.LaenutusId,
                        principalTable: "Laenutus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Puhkuseliik",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Algus = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Lõpp = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Kommentaar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PuhkusId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Puhkuseliik", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Puhkuseliik_Puhkus_PuhkusId",
                        column: x => x.PuhkusId,
                        principalTable: "Puhkus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Harukontor",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Aadress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Kontaktisik = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Kommentaar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TöötamineId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Harukontor", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Harukontor_Töötamine_TöötamineId",
                        column: x => x.TöötamineId,
                        principalTable: "Töötamine",
                        principalColumn: "TöötamineId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Firma",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nimi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RegistriNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Aadress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Kontaktisik = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Kommentaar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HarukontorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Firma", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Firma_Harukontor_HarukontorId",
                        column: x => x.HarukontorId,
                        principalTable: "Harukontor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Vihjed",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirmaId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Vihje = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Kommentaar = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vihjed", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Vihjed_Firma_FirmaId",
                        column: x => x.FirmaId,
                        principalTable: "Firma",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ametinimetus_EmployeeId",
                table: "Ametinimetus",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Children_EmployeeId",
                table: "Children",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Ettepanek_EmployeeId",
                table: "Ettepanek",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Firma_HarukontorId",
                table: "Firma",
                column: "HarukontorId");

            migrationBuilder.CreateIndex(
                name: "IX_Haigusleht_EmployeeId",
                table: "Haigusleht",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Harukontor_TöötamineId",
                table: "Harukontor",
                column: "TöötamineId");

            migrationBuilder.CreateIndex(
                name: "IX_LaenutatavAsi_LaenutusId",
                table: "LaenutatavAsi",
                column: "LaenutusId");

            migrationBuilder.CreateIndex(
                name: "IX_Laenutus_EmployeeId",
                table: "Laenutus",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Ligipääs_EmployeeId",
                table: "Ligipääs",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Puhkus_EmployeeId",
                table: "Puhkus",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Puhkuseliik_PuhkusId",
                table: "Puhkuseliik",
                column: "PuhkusId");

            migrationBuilder.CreateIndex(
                name: "IX_Tervisekontroll_EmployeeId",
                table: "Tervisekontroll",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Töötamine_AmetinimetusId",
                table: "Töötamine",
                column: "AmetinimetusId");

            migrationBuilder.CreateIndex(
                name: "IX_Töötamine_EmployeeId",
                table: "Töötamine",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Vihjed_FirmaId",
                table: "Vihjed",
                column: "FirmaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Children");

            migrationBuilder.DropTable(
                name: "Ettepanek");

            migrationBuilder.DropTable(
                name: "Haigusleht");

            migrationBuilder.DropTable(
                name: "LaenutatavAsi");

            migrationBuilder.DropTable(
                name: "Ligipääs");

            migrationBuilder.DropTable(
                name: "Puhkuseliik");

            migrationBuilder.DropTable(
                name: "Tervisekontroll");

            migrationBuilder.DropTable(
                name: "Vihjed");

            migrationBuilder.DropTable(
                name: "Laenutus");

            migrationBuilder.DropTable(
                name: "Puhkus");

            migrationBuilder.DropTable(
                name: "Firma");

            migrationBuilder.DropTable(
                name: "Harukontor");

            migrationBuilder.DropTable(
                name: "Töötamine");

            migrationBuilder.DropTable(
                name: "Ametinimetus");

            migrationBuilder.DropTable(
                name: "Employee");
        }
    }
}
