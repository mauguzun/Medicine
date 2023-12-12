using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Medicine.Infrastructure.Implementation.DataAccesPlsql.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateSequence(
                name: "TransatedEntityWithDescriptionSequence");

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Birthday = table.Column<DateOnly>(type: "date", nullable: true),
                    Sex = table.Column<int>(type: "integer", nullable: true),
                    Language = table.Column<int>(type: "integer", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: true),
                    TimeZone = table.Column<int>(type: "integer", nullable: false),
                    Role = table.Column<int>(type: "integer", nullable: false),
                    UserName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "boolean", nullable: false),
                    PasswordHash = table.Column<string>(type: "text", nullable: true),
                    SecurityStamp = table.Column<string>(type: "text", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: true),
                    PhoneNumber = table.Column<string>(type: "text", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "boolean", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SimilarDrugs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SimilarDrugs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RoleId = table.Column<int>(type: "integer", nullable: false),
                    ClaimType = table.Column<string>(type: "text", nullable: true),
                    ClaimValue = table.Column<string>(type: "text", nullable: true)
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
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<int>(type: "integer", nullable: false),
                    ClaimType = table.Column<string>(type: "text", nullable: true),
                    ClaimValue = table.Column<string>(type: "text", nullable: true)
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
                    LoginProvider = table.Column<string>(type: "text", nullable: false),
                    ProviderKey = table.Column<string>(type: "text", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "text", nullable: true),
                    UserId = table.Column<int>(type: "integer", nullable: false)
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
                    UserId = table.Column<int>(type: "integer", nullable: false),
                    RoleId = table.Column<int>(type: "integer", nullable: false)
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
                    UserId = table.Column<int>(type: "integer", nullable: false),
                    LoginProvider = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Value = table.Column<string>(type: "text", nullable: true)
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
                name: "CourseGroup",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false, defaultValueSql: "nextval('\"TransatedEntityWithDescriptionSequence\"')"),
                    Title = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    CreatedById = table.Column<int>(type: "integer", nullable: true),
                    Language = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseGroup", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CourseGroup_AspNetUsers_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "DrugCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    CreatedById = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DrugCategories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DrugCategories_AspNetUsers_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Reminders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    TimeInUtc = table.Column<string>(type: "text", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    CreatedById = table.Column<int>(type: "integer", nullable: true),
                    Title = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reminders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reminders_AspNetUsers_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Therapies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    AssingedToId = table.Column<int>(type: "integer", nullable: true),
                    Status = table.Column<int>(type: "integer", nullable: false),
                    Type = table.Column<int>(type: "integer", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    CreatedById = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Therapies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Therapies_AspNetUsers_AssingedToId",
                        column: x => x.AssingedToId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Therapies_AspNetUsers_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "UserDoctorRelations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MedicineWorkerId = table.Column<int>(type: "integer", nullable: true),
                    UserDoctorRelationType = table.Column<int>(type: "integer", nullable: false),
                    CreatedByUser = table.Column<bool>(type: "boolean", nullable: false),
                    AcceptedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    CreatedById = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserDoctorRelations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserDoctorRelations_AspNetUsers_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_UserDoctorRelations_AspNetUsers_MedicineWorkerId",
                        column: x => x.MedicineWorkerId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Drugs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Title = table.Column<string>(type: "text", nullable: true),
                    OneUnitSizeInGramm = table.Column<double>(type: "double precision", nullable: false),
                    SimilarDrugsId = table.Column<int>(type: "integer", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    CreatedById = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Drugs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Drugs_AspNetUsers_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Drugs_SimilarDrugs_SimilarDrugsId",
                        column: x => x.SimilarDrugsId,
                        principalTable: "SimilarDrugs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TranslatedCourseGroup",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false, defaultValueSql: "nextval('\"TransatedEntityWithDescriptionSequence\"')"),
                    Title = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    CourseGroupId = table.Column<int>(type: "integer", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    CreatedById = table.Column<int>(type: "integer", nullable: true),
                    Language = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TranslatedCourseGroup", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TranslatedCourseGroup_AspNetUsers_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TranslatedCourseGroup_CourseGroup_CourseGroupId",
                        column: x => x.CourseGroupId,
                        principalTable: "CourseGroup",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TranslatedDrugsCategory",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false, defaultValueSql: "nextval('\"TransatedEntityWithDescriptionSequence\"')"),
                    Title = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    DrugCategoryId = table.Column<int>(type: "integer", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    CreatedById = table.Column<int>(type: "integer", nullable: true),
                    Language = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TranslatedDrugsCategory", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TranslatedDrugsCategory_AspNetUsers_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TranslatedDrugsCategory_DrugCategories_DrugCategoryId",
                        column: x => x.DrugCategoryId,
                        principalTable: "DrugCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ReminderLogs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ReminderId = table.Column<int>(type: "integer", nullable: false),
                    ReminderLogStatus = table.Column<int>(type: "integer", nullable: false),
                    Descrpition = table.Column<string>(type: "text", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReminderLogs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ReminderLogs_Reminders_ReminderId",
                        column: x => x.ReminderId,
                        principalTable: "Reminders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    TherapyId = table.Column<int>(type: "integer", nullable: true),
                    CourseGroupID = table.Column<int>(type: "integer", nullable: true),
                    CourseType = table.Column<int>(type: "integer", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    CreatedById = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Courses_AspNetUsers_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Courses_CourseGroup_CourseGroupID",
                        column: x => x.CourseGroupID,
                        principalTable: "CourseGroup",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Courses_Therapies_TherapyId",
                        column: x => x.TherapyId,
                        principalTable: "Therapies",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "TranslatedTherapy",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false, defaultValueSql: "nextval('\"TransatedEntityWithDescriptionSequence\"')"),
                    Title = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    TherapyId = table.Column<int>(type: "integer", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    CreatedById = table.Column<int>(type: "integer", nullable: true),
                    Language = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TranslatedTherapy", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TranslatedTherapy_AspNetUsers_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TranslatedTherapy_Therapies_TherapyId",
                        column: x => x.TherapyId,
                        principalTable: "Therapies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserDoctorRelationLogs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserDoctorRelationId = table.Column<int>(type: "integer", nullable: false),
                    UserDoctorRelationType = table.Column<int>(type: "integer", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserDoctorRelationLogs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserDoctorRelationLogs_UserDoctorRelations_UserDoctorRelati~",
                        column: x => x.UserDoctorRelationId,
                        principalTable: "UserDoctorRelations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ActiveElements",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    DrugId = table.Column<int>(type: "integer", nullable: false),
                    Quantity = table.Column<double>(type: "double precision", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    CreatedById = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActiveElements", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ActiveElements_AspNetUsers_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ActiveElements_Drugs_DrugId",
                        column: x => x.DrugId,
                        principalTable: "Drugs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DrugDrugCategory",
                columns: table => new
                {
                    DrugCategoriesId = table.Column<int>(type: "integer", nullable: false),
                    DrugsId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DrugDrugCategory", x => new { x.DrugCategoriesId, x.DrugsId });
                    table.ForeignKey(
                        name: "FK_DrugDrugCategory_DrugCategories_DrugCategoriesId",
                        column: x => x.DrugCategoriesId,
                        principalTable: "DrugCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DrugDrugCategory_Drugs_DrugsId",
                        column: x => x.DrugsId,
                        principalTable: "Drugs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TranslatedDrugs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false, defaultValueSql: "nextval('\"TransatedEntityWithDescriptionSequence\"')"),
                    Title = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    DrugId = table.Column<int>(type: "integer", nullable: false),
                    Recomendation = table.Column<string>(type: "text", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    CreatedById = table.Column<int>(type: "integer", nullable: true),
                    Language = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TranslatedDrugs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TranslatedDrugs_AspNetUsers_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TranslatedDrugs_Drugs_DrugId",
                        column: x => x.DrugId,
                        principalTable: "Drugs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CourseSettings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CourseId = table.Column<int>(type: "integer", nullable: false),
                    Sex = table.Column<int>(type: "integer", nullable: false),
                    MinAge = table.Column<int>(type: "integer", nullable: true),
                    MaxAge = table.Column<int>(type: "integer", nullable: true),
                    Weight = table.Column<int>(type: "integer", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    CreatedById = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseSettings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CourseSettings_AspNetUsers_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CourseSettings_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DosingFrequencies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CourseId = table.Column<int>(type: "integer", nullable: false),
                    DrugId = table.Column<int>(type: "integer", nullable: false),
                    Total = table.Column<double>(type: "double precision", nullable: false),
                    IntervalInDays = table.Column<int>(type: "integer", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    CreatedById = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DosingFrequencies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DosingFrequencies_AspNetUsers_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
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
                name: "TranslatedCourse",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false, defaultValueSql: "nextval('\"TransatedEntityWithDescriptionSequence\"')"),
                    Title = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    CourseId = table.Column<int>(type: "integer", nullable: false),
                    Version = table.Column<string>(type: "text", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    CreatedById = table.Column<int>(type: "integer", nullable: true),
                    Language = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TranslatedCourse", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TranslatedCourse_AspNetUsers_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TranslatedCourse_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TranslatedActiveElement",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false, defaultValueSql: "nextval('\"TransatedEntityWithDescriptionSequence\"')"),
                    Title = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    ActiveElementId = table.Column<int>(type: "integer", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    CreatedById = table.Column<int>(type: "integer", nullable: true),
                    Language = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TranslatedActiveElement", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TranslatedActiveElement_ActiveElements_ActiveElementId",
                        column: x => x.ActiveElementId,
                        principalTable: "ActiveElements",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TranslatedActiveElement_AspNetUsers_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "DosingFrequencyReminders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Title = table.Column<string>(type: "text", nullable: false),
                    UsingDescription = table.Column<string>(type: "text", nullable: false),
                    Quantity = table.Column<double>(type: "double precision", nullable: false),
                    ReminderId = table.Column<int>(type: "integer", nullable: false),
                    DosingFrequencyId = table.Column<int>(type: "integer", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    CreatedById = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DosingFrequencyReminders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DosingFrequencyReminders_AspNetUsers_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_DosingFrequencyReminders_DosingFrequencies_DosingFrequencyId",
                        column: x => x.DosingFrequencyId,
                        principalTable: "DosingFrequencies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DosingFrequencyReminders_Reminders_ReminderId",
                        column: x => x.ReminderId,
                        principalTable: "Reminders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TranslatedDosingFrequency",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false, defaultValueSql: "nextval('\"TransatedEntityWithDescriptionSequence\"')"),
                    Title = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    DosingFrequencyId = table.Column<int>(type: "integer", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    CreatedById = table.Column<int>(type: "integer", nullable: true),
                    Language = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TranslatedDosingFrequency", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TranslatedDosingFrequency_AspNetUsers_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TranslatedDosingFrequency_DosingFrequencies_DosingFrequency~",
                        column: x => x.DosingFrequencyId,
                        principalTable: "DosingFrequencies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DosageLogs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    DosageRecommendationId = table.Column<int>(type: "integer", nullable: false),
                    Status = table.Column<int>(type: "integer", nullable: false),
                    Quantity = table.Column<double>(type: "double precision", nullable: false),
                    DateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    CreatedById = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DosageLogs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DosageLogs_AspNetUsers_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_DosageLogs_DosingFrequencyReminders_DosageRecommendationId",
                        column: x => x.DosageRecommendationId,
                        principalTable: "DosingFrequencyReminders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TranslatedDosingFrequencyReminder",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Title = table.Column<string>(type: "text", nullable: false),
                    UsingDescription = table.Column<string>(type: "text", nullable: false),
                    DosageRecommendationId = table.Column<int>(type: "integer", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    CreatedById = table.Column<int>(type: "integer", nullable: true),
                    Language = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TranslatedDosingFrequencyReminder", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TranslatedDosingFrequencyReminder_AspNetUsers_CreatedById",
                        column: x => x.CreatedById,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TranslatedDosingFrequencyReminder_DosingFrequencyReminders_~",
                        column: x => x.DosageRecommendationId,
                        principalTable: "DosingFrequencyReminders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ActiveElements_CreatedById",
                table: "ActiveElements",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_ActiveElements_DrugId",
                table: "ActiveElements",
                column: "DrugId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

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
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CourseGroup_CreatedById",
                table: "CourseGroup",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_CourseGroupID",
                table: "Courses",
                column: "CourseGroupID");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_CreatedById",
                table: "Courses",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_TherapyId",
                table: "Courses",
                column: "TherapyId");

            migrationBuilder.CreateIndex(
                name: "IX_CourseSettings_CourseId",
                table: "CourseSettings",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_CourseSettings_CreatedById",
                table: "CourseSettings",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_DosageLogs_CreatedById",
                table: "DosageLogs",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_DosageLogs_DosageRecommendationId",
                table: "DosageLogs",
                column: "DosageRecommendationId");

            migrationBuilder.CreateIndex(
                name: "IX_DosingFrequencies_CourseId",
                table: "DosingFrequencies",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_DosingFrequencies_CreatedById",
                table: "DosingFrequencies",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_DosingFrequencies_DrugId",
                table: "DosingFrequencies",
                column: "DrugId");

            migrationBuilder.CreateIndex(
                name: "IX_DosingFrequencyReminders_CreatedById",
                table: "DosingFrequencyReminders",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_DosingFrequencyReminders_DosingFrequencyId",
                table: "DosingFrequencyReminders",
                column: "DosingFrequencyId");

            migrationBuilder.CreateIndex(
                name: "IX_DosingFrequencyReminders_ReminderId",
                table: "DosingFrequencyReminders",
                column: "ReminderId");

            migrationBuilder.CreateIndex(
                name: "IX_DrugCategories_CreatedById",
                table: "DrugCategories",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_DrugDrugCategory_DrugsId",
                table: "DrugDrugCategory",
                column: "DrugsId");

            migrationBuilder.CreateIndex(
                name: "IX_Drugs_CreatedById",
                table: "Drugs",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_Drugs_SimilarDrugsId",
                table: "Drugs",
                column: "SimilarDrugsId");

            migrationBuilder.CreateIndex(
                name: "IX_ReminderLogs_ReminderId",
                table: "ReminderLogs",
                column: "ReminderId");

            migrationBuilder.CreateIndex(
                name: "IX_Reminders_CreatedById",
                table: "Reminders",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_Therapies_AssingedToId",
                table: "Therapies",
                column: "AssingedToId");

            migrationBuilder.CreateIndex(
                name: "IX_Therapies_CreatedById",
                table: "Therapies",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_TranslatedActiveElement_ActiveElementId",
                table: "TranslatedActiveElement",
                column: "ActiveElementId");

            migrationBuilder.CreateIndex(
                name: "IX_TranslatedActiveElement_CreatedById",
                table: "TranslatedActiveElement",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_TranslatedActiveElement_Language_ActiveElementId",
                table: "TranslatedActiveElement",
                columns: new[] { "Language", "ActiveElementId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TranslatedCourse_CourseId",
                table: "TranslatedCourse",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_TranslatedCourse_CreatedById",
                table: "TranslatedCourse",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_TranslatedCourse_Language_CourseId",
                table: "TranslatedCourse",
                columns: new[] { "Language", "CourseId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TranslatedCourseGroup_CourseGroupId",
                table: "TranslatedCourseGroup",
                column: "CourseGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_TranslatedCourseGroup_CreatedById",
                table: "TranslatedCourseGroup",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_TranslatedCourseGroup_Language_CourseGroupId",
                table: "TranslatedCourseGroup",
                columns: new[] { "Language", "CourseGroupId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TranslatedDosingFrequency_CreatedById",
                table: "TranslatedDosingFrequency",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_TranslatedDosingFrequency_DosingFrequencyId",
                table: "TranslatedDosingFrequency",
                column: "DosingFrequencyId");

            migrationBuilder.CreateIndex(
                name: "IX_TranslatedDosingFrequencyReminder_CreatedById",
                table: "TranslatedDosingFrequencyReminder",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_TranslatedDosingFrequencyReminder_DosageRecommendationId",
                table: "TranslatedDosingFrequencyReminder",
                column: "DosageRecommendationId");

            migrationBuilder.CreateIndex(
                name: "IX_TranslatedDosingFrequencyReminder_Language_DosageRecommenda~",
                table: "TranslatedDosingFrequencyReminder",
                columns: new[] { "Language", "DosageRecommendationId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TranslatedDrugs_CreatedById",
                table: "TranslatedDrugs",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_TranslatedDrugs_DrugId",
                table: "TranslatedDrugs",
                column: "DrugId");

            migrationBuilder.CreateIndex(
                name: "IX_TranslatedDrugs_Language_DrugId",
                table: "TranslatedDrugs",
                columns: new[] { "Language", "DrugId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TranslatedDrugsCategory_CreatedById",
                table: "TranslatedDrugsCategory",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_TranslatedDrugsCategory_DrugCategoryId",
                table: "TranslatedDrugsCategory",
                column: "DrugCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_TranslatedDrugsCategory_Language_DrugCategoryId",
                table: "TranslatedDrugsCategory",
                columns: new[] { "Language", "DrugCategoryId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TranslatedTherapy_CreatedById",
                table: "TranslatedTherapy",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_TranslatedTherapy_Language_TherapyId",
                table: "TranslatedTherapy",
                columns: new[] { "Language", "TherapyId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TranslatedTherapy_TherapyId",
                table: "TranslatedTherapy",
                column: "TherapyId");

            migrationBuilder.CreateIndex(
                name: "IX_UserDoctorRelationLogs_UserDoctorRelationId",
                table: "UserDoctorRelationLogs",
                column: "UserDoctorRelationId");

            migrationBuilder.CreateIndex(
                name: "IX_UserDoctorRelations_CreatedById",
                table: "UserDoctorRelations",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_UserDoctorRelations_MedicineWorkerId",
                table: "UserDoctorRelations",
                column: "MedicineWorkerId");
        }

        /// <inheritdoc />
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
                name: "CourseSettings");

            migrationBuilder.DropTable(
                name: "DosageLogs");

            migrationBuilder.DropTable(
                name: "DrugDrugCategory");

            migrationBuilder.DropTable(
                name: "ReminderLogs");

            migrationBuilder.DropTable(
                name: "TranslatedActiveElement");

            migrationBuilder.DropTable(
                name: "TranslatedCourse");

            migrationBuilder.DropTable(
                name: "TranslatedCourseGroup");

            migrationBuilder.DropTable(
                name: "TranslatedDosingFrequency");

            migrationBuilder.DropTable(
                name: "TranslatedDosingFrequencyReminder");

            migrationBuilder.DropTable(
                name: "TranslatedDrugs");

            migrationBuilder.DropTable(
                name: "TranslatedDrugsCategory");

            migrationBuilder.DropTable(
                name: "TranslatedTherapy");

            migrationBuilder.DropTable(
                name: "UserDoctorRelationLogs");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "ActiveElements");

            migrationBuilder.DropTable(
                name: "DosingFrequencyReminders");

            migrationBuilder.DropTable(
                name: "DrugCategories");

            migrationBuilder.DropTable(
                name: "UserDoctorRelations");

            migrationBuilder.DropTable(
                name: "DosingFrequencies");

            migrationBuilder.DropTable(
                name: "Reminders");

            migrationBuilder.DropTable(
                name: "Courses");

            migrationBuilder.DropTable(
                name: "Drugs");

            migrationBuilder.DropTable(
                name: "CourseGroup");

            migrationBuilder.DropTable(
                name: "Therapies");

            migrationBuilder.DropTable(
                name: "SimilarDrugs");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropSequence(
                name: "TransatedEntityWithDescriptionSequence");
        }
    }
}
