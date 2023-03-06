﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Medicine.DataAccess.Sql.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CourseSettings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Sex = table.Column<int>(type: "int", nullable: false),
                    MinAge = table.Column<int>(type: "int", nullable: true),
                    MaxAge = table.Column<int>(type: "int", nullable: true),
                    Weight = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseSettings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Drugs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Recomendation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OneUnitSizeInGramm = table.Column<double>(type: "float", nullable: false),
                    DrugId = table.Column<int>(type: "int", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Drugs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Drugs_Drugs_DrugId",
                        column: x => x.DrugId,
                        principalTable: "Drugs",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Reminders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TimeInUtc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Descrptioin = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reminders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Therapies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Therapies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserSettings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Birthday = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Sex = table.Column<int>(type: "int", nullable: false),
                    TimeZone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserSettings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DrugCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DrugId = table.Column<int>(type: "int", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DrugCategories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DrugCategories_Drugs_DrugId",
                        column: x => x.DrugId,
                        principalTable: "Drugs",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TherapyId = table.Column<int>(type: "int", nullable: true),
                    CourseSettingsId = table.Column<int>(type: "int", nullable: true),
                    CourseType = table.Column<int>(type: "int", nullable: false),
                    CourseId = table.Column<int>(type: "int", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Courses_CourseSettings_CourseSettingsId",
                        column: x => x.CourseSettingsId,
                        principalTable: "CourseSettings",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Courses_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Courses_Therapies_TherapyId",
                        column: x => x.TherapyId,
                        principalTable: "Therapies",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "TransatedEntityWithDescription",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descrptioin = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DrugCategoryId = table.Column<int>(type: "int", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    Language = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransatedEntityWithDescription", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TransatedEntityWithDescription_DrugCategories_DrugCategoryId",
                        column: x => x.DrugCategoryId,
                        principalTable: "DrugCategories",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "DosingFrequencies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourseId = table.Column<int>(type: "int", nullable: false),
                    DrugId = table.Column<int>(type: "int", nullable: false),
                    Total = table.Column<double>(type: "float", nullable: false),
                    IntervalInDays = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DosingFrequencies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DosingFrequencies_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DosingFrequencies_Drugs_DrugId",
                        column: x => x.DrugId,
                        principalTable: "Drugs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TranslatedActiveElement",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TranslatedActiveElement", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TranslatedActiveElement_TransatedEntityWithDescription_Id",
                        column: x => x.Id,
                        principalTable: "TransatedEntityWithDescription",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TranslatedCourse",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Version = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CourseId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TranslatedCourse", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TranslatedCourse_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TranslatedCourse_TransatedEntityWithDescription_Id",
                        column: x => x.Id,
                        principalTable: "TransatedEntityWithDescription",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TranslatedDrugs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    DrugId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TranslatedDrugs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TranslatedDrugs_Drugs_DrugId",
                        column: x => x.DrugId,
                        principalTable: "Drugs",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TranslatedDrugs_TransatedEntityWithDescription_Id",
                        column: x => x.Id,
                        principalTable: "TransatedEntityWithDescription",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TranslatedTherapy",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    TherapyId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TranslatedTherapy", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TranslatedTherapy_Therapies_TherapyId",
                        column: x => x.TherapyId,
                        principalTable: "Therapies",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TranslatedTherapy_TransatedEntityWithDescription_Id",
                        column: x => x.Id,
                        principalTable: "TransatedEntityWithDescription",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DosageRecommendations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Quantity = table.Column<double>(type: "float", nullable: false),
                    DosingFrequencyId = table.Column<int>(type: "int", nullable: false),
                    ReminderId = table.Column<int>(type: "int", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DosageRecommendations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DosageRecommendations_DosingFrequencies_DosingFrequencyId",
                        column: x => x.DosingFrequencyId,
                        principalTable: "DosingFrequencies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DosageRecommendations_Reminders_ReminderId",
                        column: x => x.ReminderId,
                        principalTable: "Reminders",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "TranslatedDosingFrequency",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    DosingFrequencyId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TranslatedDosingFrequency", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TranslatedDosingFrequency_DosingFrequencies_DosingFrequencyId",
                        column: x => x.DosingFrequencyId,
                        principalTable: "DosingFrequencies",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TranslatedDosingFrequency_TransatedEntityWithDescription_Id",
                        column: x => x.Id,
                        principalTable: "TransatedEntityWithDescription",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ActiveElements",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Quantity = table.Column<double>(type: "float", nullable: false),
                    TranslatedActiveElementId = table.Column<int>(type: "int", nullable: false),
                    DrugId = table.Column<int>(type: "int", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActiveElements", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ActiveElements_Drugs_DrugId",
                        column: x => x.DrugId,
                        principalTable: "Drugs",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ActiveElements_TranslatedActiveElement_TranslatedActiveElementId",
                        column: x => x.TranslatedActiveElementId,
                        principalTable: "TranslatedActiveElement",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DosageLogs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DosageRecommendationId = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<double>(type: "float", nullable: false),
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DosageLogs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DosageLogs_DosageRecommendations_DosageRecommendationId",
                        column: x => x.DosageRecommendationId,
                        principalTable: "DosageRecommendations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TranslatedDosageRecommendation",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    DosageRecommendationId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TranslatedDosageRecommendation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TranslatedDosageRecommendation_DosageRecommendations_DosageRecommendationId",
                        column: x => x.DosageRecommendationId,
                        principalTable: "DosageRecommendations",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TranslatedDosageRecommendation_TransatedEntityWithDescription_Id",
                        column: x => x.Id,
                        principalTable: "TransatedEntityWithDescription",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ActiveElements_DrugId",
                table: "ActiveElements",
                column: "DrugId");

            migrationBuilder.CreateIndex(
                name: "IX_ActiveElements_TranslatedActiveElementId",
                table: "ActiveElements",
                column: "TranslatedActiveElementId");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_CourseId",
                table: "Courses",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_CourseSettingsId",
                table: "Courses",
                column: "CourseSettingsId");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_TherapyId",
                table: "Courses",
                column: "TherapyId");

            migrationBuilder.CreateIndex(
                name: "IX_DosageLogs_DosageRecommendationId",
                table: "DosageLogs",
                column: "DosageRecommendationId");

            migrationBuilder.CreateIndex(
                name: "IX_DosageRecommendations_DosingFrequencyId",
                table: "DosageRecommendations",
                column: "DosingFrequencyId");

            migrationBuilder.CreateIndex(
                name: "IX_DosageRecommendations_ReminderId",
                table: "DosageRecommendations",
                column: "ReminderId");

            migrationBuilder.CreateIndex(
                name: "IX_DosingFrequencies_CourseId",
                table: "DosingFrequencies",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_DosingFrequencies_DrugId",
                table: "DosingFrequencies",
                column: "DrugId");

            migrationBuilder.CreateIndex(
                name: "IX_DrugCategories_DrugId",
                table: "DrugCategories",
                column: "DrugId");

            migrationBuilder.CreateIndex(
                name: "IX_Drugs_DrugId",
                table: "Drugs",
                column: "DrugId");

            migrationBuilder.CreateIndex(
                name: "IX_TransatedEntityWithDescription_DrugCategoryId",
                table: "TransatedEntityWithDescription",
                column: "DrugCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_TranslatedCourse_CourseId",
                table: "TranslatedCourse",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_TranslatedDosageRecommendation_DosageRecommendationId",
                table: "TranslatedDosageRecommendation",
                column: "DosageRecommendationId");

            migrationBuilder.CreateIndex(
                name: "IX_TranslatedDosingFrequency_DosingFrequencyId",
                table: "TranslatedDosingFrequency",
                column: "DosingFrequencyId");

            migrationBuilder.CreateIndex(
                name: "IX_TranslatedDrugs_DrugId",
                table: "TranslatedDrugs",
                column: "DrugId");

            migrationBuilder.CreateIndex(
                name: "IX_TranslatedTherapy_TherapyId",
                table: "TranslatedTherapy",
                column: "TherapyId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ActiveElements");

            migrationBuilder.DropTable(
                name: "DosageLogs");

            migrationBuilder.DropTable(
                name: "TranslatedCourse");

            migrationBuilder.DropTable(
                name: "TranslatedDosageRecommendation");

            migrationBuilder.DropTable(
                name: "TranslatedDosingFrequency");

            migrationBuilder.DropTable(
                name: "TranslatedDrugs");

            migrationBuilder.DropTable(
                name: "TranslatedTherapy");

            migrationBuilder.DropTable(
                name: "UserSettings");

            migrationBuilder.DropTable(
                name: "TranslatedActiveElement");

            migrationBuilder.DropTable(
                name: "DosageRecommendations");

            migrationBuilder.DropTable(
                name: "TransatedEntityWithDescription");

            migrationBuilder.DropTable(
                name: "DosingFrequencies");

            migrationBuilder.DropTable(
                name: "Reminders");

            migrationBuilder.DropTable(
                name: "DrugCategories");

            migrationBuilder.DropTable(
                name: "Courses");

            migrationBuilder.DropTable(
                name: "Drugs");

            migrationBuilder.DropTable(
                name: "CourseSettings");

            migrationBuilder.DropTable(
                name: "Therapies");
        }
    }
}