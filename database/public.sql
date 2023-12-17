/*
 Navicat Premium Data Transfer

 Source Server         : medicineDB
 Source Server Type    : PostgreSQL
 Source Server Version : 140010
 Source Host           : localhost:5432
 Source Catalog        : medicine4
 Source Schema         : public

 Target Server Type    : PostgreSQL
 Target Server Version : 140010
 File Encoding         : 65001

 Date: 17/12/2023 16:04:37
*/


-- ----------------------------
-- Sequence structure for ActiveElements_Id_seq
-- ----------------------------
DROP SEQUENCE IF EXISTS "public"."ActiveElements_Id_seq";
CREATE SEQUENCE "public"."ActiveElements_Id_seq" 
INCREMENT 1
MINVALUE  1
MAXVALUE 2147483647
START 1
CACHE 1;

-- ----------------------------
-- Sequence structure for AspNetRoleClaims_Id_seq
-- ----------------------------
DROP SEQUENCE IF EXISTS "public"."AspNetRoleClaims_Id_seq";
CREATE SEQUENCE "public"."AspNetRoleClaims_Id_seq" 
INCREMENT 1
MINVALUE  1
MAXVALUE 2147483647
START 1
CACHE 1;

-- ----------------------------
-- Sequence structure for AspNetRoles_Id_seq
-- ----------------------------
DROP SEQUENCE IF EXISTS "public"."AspNetRoles_Id_seq";
CREATE SEQUENCE "public"."AspNetRoles_Id_seq" 
INCREMENT 1
MINVALUE  1
MAXVALUE 2147483647
START 1
CACHE 1;

-- ----------------------------
-- Sequence structure for AspNetUserClaims_Id_seq
-- ----------------------------
DROP SEQUENCE IF EXISTS "public"."AspNetUserClaims_Id_seq";
CREATE SEQUENCE "public"."AspNetUserClaims_Id_seq" 
INCREMENT 1
MINVALUE  1
MAXVALUE 2147483647
START 1
CACHE 1;

-- ----------------------------
-- Sequence structure for AspNetUsers_Id_seq
-- ----------------------------
DROP SEQUENCE IF EXISTS "public"."AspNetUsers_Id_seq";
CREATE SEQUENCE "public"."AspNetUsers_Id_seq" 
INCREMENT 1
MINVALUE  1
MAXVALUE 2147483647
START 1
CACHE 1;

-- ----------------------------
-- Sequence structure for CourseSettings_Id_seq
-- ----------------------------
DROP SEQUENCE IF EXISTS "public"."CourseSettings_Id_seq";
CREATE SEQUENCE "public"."CourseSettings_Id_seq" 
INCREMENT 1
MINVALUE  1
MAXVALUE 2147483647
START 1
CACHE 1;

-- ----------------------------
-- Sequence structure for Courses_Id_seq
-- ----------------------------
DROP SEQUENCE IF EXISTS "public"."Courses_Id_seq";
CREATE SEQUENCE "public"."Courses_Id_seq" 
INCREMENT 1
MINVALUE  1
MAXVALUE 2147483647
START 1
CACHE 1;

-- ----------------------------
-- Sequence structure for DosageLogs_Id_seq
-- ----------------------------
DROP SEQUENCE IF EXISTS "public"."DosageLogs_Id_seq";
CREATE SEQUENCE "public"."DosageLogs_Id_seq" 
INCREMENT 1
MINVALUE  1
MAXVALUE 2147483647
START 1
CACHE 1;

-- ----------------------------
-- Sequence structure for DosingFrequencies_Id_seq
-- ----------------------------
DROP SEQUENCE IF EXISTS "public"."DosingFrequencies_Id_seq";
CREATE SEQUENCE "public"."DosingFrequencies_Id_seq" 
INCREMENT 1
MINVALUE  1
MAXVALUE 2147483647
START 1
CACHE 1;

-- ----------------------------
-- Sequence structure for DosingFrequencyReminders_Id_seq
-- ----------------------------
DROP SEQUENCE IF EXISTS "public"."DosingFrequencyReminders_Id_seq";
CREATE SEQUENCE "public"."DosingFrequencyReminders_Id_seq" 
INCREMENT 1
MINVALUE  1
MAXVALUE 2147483647
START 1
CACHE 1;

-- ----------------------------
-- Sequence structure for DrugCategories_Id_seq
-- ----------------------------
DROP SEQUENCE IF EXISTS "public"."DrugCategories_Id_seq";
CREATE SEQUENCE "public"."DrugCategories_Id_seq" 
INCREMENT 1
MINVALUE  1
MAXVALUE 2147483647
START 1
CACHE 1;

-- ----------------------------
-- Sequence structure for Drugs_Id_seq
-- ----------------------------
DROP SEQUENCE IF EXISTS "public"."Drugs_Id_seq";
CREATE SEQUENCE "public"."Drugs_Id_seq" 
INCREMENT 1
MINVALUE  1
MAXVALUE 2147483647
START 1
CACHE 1;

-- ----------------------------
-- Sequence structure for ReminderLogs_Id_seq
-- ----------------------------
DROP SEQUENCE IF EXISTS "public"."ReminderLogs_Id_seq";
CREATE SEQUENCE "public"."ReminderLogs_Id_seq" 
INCREMENT 1
MINVALUE  1
MAXVALUE 2147483647
START 1
CACHE 1;

-- ----------------------------
-- Sequence structure for Reminders_Id_seq
-- ----------------------------
DROP SEQUENCE IF EXISTS "public"."Reminders_Id_seq";
CREATE SEQUENCE "public"."Reminders_Id_seq" 
INCREMENT 1
MINVALUE  1
MAXVALUE 2147483647
START 1
CACHE 1;

-- ----------------------------
-- Sequence structure for SimilarDrugs_Id_seq
-- ----------------------------
DROP SEQUENCE IF EXISTS "public"."SimilarDrugs_Id_seq";
CREATE SEQUENCE "public"."SimilarDrugs_Id_seq" 
INCREMENT 1
MINVALUE  1
MAXVALUE 2147483647
START 1
CACHE 1;

-- ----------------------------
-- Sequence structure for Therapies_Id_seq
-- ----------------------------
DROP SEQUENCE IF EXISTS "public"."Therapies_Id_seq";
CREATE SEQUENCE "public"."Therapies_Id_seq" 
INCREMENT 1
MINVALUE  1
MAXVALUE 2147483647
START 1
CACHE 1;

-- ----------------------------
-- Sequence structure for TransatedEntityWithDescriptionSequence
-- ----------------------------
DROP SEQUENCE IF EXISTS "public"."TransatedEntityWithDescriptionSequence";
CREATE SEQUENCE "public"."TransatedEntityWithDescriptionSequence" 
INCREMENT 1
MINVALUE  1
MAXVALUE 9223372036854775807
START 1
CACHE 1;

-- ----------------------------
-- Sequence structure for TranslatedDosingFrequencyReminder_Id_seq
-- ----------------------------
DROP SEQUENCE IF EXISTS "public"."TranslatedDosingFrequencyReminder_Id_seq";
CREATE SEQUENCE "public"."TranslatedDosingFrequencyReminder_Id_seq" 
INCREMENT 1
MINVALUE  1
MAXVALUE 2147483647
START 1
CACHE 1;

-- ----------------------------
-- Sequence structure for UserDoctorRelationLogs_Id_seq
-- ----------------------------
DROP SEQUENCE IF EXISTS "public"."UserDoctorRelationLogs_Id_seq";
CREATE SEQUENCE "public"."UserDoctorRelationLogs_Id_seq" 
INCREMENT 1
MINVALUE  1
MAXVALUE 2147483647
START 1
CACHE 1;

-- ----------------------------
-- Sequence structure for UserDoctorRelations_Id_seq
-- ----------------------------
DROP SEQUENCE IF EXISTS "public"."UserDoctorRelations_Id_seq";
CREATE SEQUENCE "public"."UserDoctorRelations_Id_seq" 
INCREMENT 1
MINVALUE  1
MAXVALUE 2147483647
START 1
CACHE 1;

-- ----------------------------
-- Table structure for ActiveElements
-- ----------------------------
DROP TABLE IF EXISTS "public"."ActiveElements";
CREATE TABLE "public"."ActiveElements" (
  "Id" int4 NOT NULL GENERATED BY DEFAULT AS IDENTITY (
INCREMENT 1
MINVALUE  1
MAXVALUE 2147483647
START 1
),
  "DrugId" int4 NOT NULL,
  "Quantity" float8 NOT NULL,
  "CreatedAt" timestamptz(6),
  "CreatedById" int4
)
;

-- ----------------------------
-- Records of ActiveElements
-- ----------------------------

-- ----------------------------
-- Table structure for AspNetRoleClaims
-- ----------------------------
DROP TABLE IF EXISTS "public"."AspNetRoleClaims";
CREATE TABLE "public"."AspNetRoleClaims" (
  "Id" int4 NOT NULL GENERATED BY DEFAULT AS IDENTITY (
INCREMENT 1
MINVALUE  1
MAXVALUE 2147483647
START 1
),
  "RoleId" int4 NOT NULL,
  "ClaimType" text COLLATE "pg_catalog"."default",
  "ClaimValue" text COLLATE "pg_catalog"."default"
)
;

-- ----------------------------
-- Records of AspNetRoleClaims
-- ----------------------------

-- ----------------------------
-- Table structure for AspNetRoles
-- ----------------------------
DROP TABLE IF EXISTS "public"."AspNetRoles";
CREATE TABLE "public"."AspNetRoles" (
  "Id" int4 NOT NULL GENERATED BY DEFAULT AS IDENTITY (
INCREMENT 1
MINVALUE  1
MAXVALUE 2147483647
START 1
),
  "Name" varchar(256) COLLATE "pg_catalog"."default",
  "NormalizedName" varchar(256) COLLATE "pg_catalog"."default",
  "ConcurrencyStamp" text COLLATE "pg_catalog"."default"
)
;

-- ----------------------------
-- Records of AspNetRoles
-- ----------------------------

-- ----------------------------
-- Table structure for AspNetUserClaims
-- ----------------------------
DROP TABLE IF EXISTS "public"."AspNetUserClaims";
CREATE TABLE "public"."AspNetUserClaims" (
  "Id" int4 NOT NULL GENERATED BY DEFAULT AS IDENTITY (
INCREMENT 1
MINVALUE  1
MAXVALUE 2147483647
START 1
),
  "UserId" int4 NOT NULL,
  "ClaimType" text COLLATE "pg_catalog"."default",
  "ClaimValue" text COLLATE "pg_catalog"."default"
)
;

-- ----------------------------
-- Records of AspNetUserClaims
-- ----------------------------

-- ----------------------------
-- Table structure for AspNetUserLogins
-- ----------------------------
DROP TABLE IF EXISTS "public"."AspNetUserLogins";
CREATE TABLE "public"."AspNetUserLogins" (
  "LoginProvider" text COLLATE "pg_catalog"."default" NOT NULL,
  "ProviderKey" text COLLATE "pg_catalog"."default" NOT NULL,
  "ProviderDisplayName" text COLLATE "pg_catalog"."default",
  "UserId" int4 NOT NULL
)
;

-- ----------------------------
-- Records of AspNetUserLogins
-- ----------------------------

-- ----------------------------
-- Table structure for AspNetUserRoles
-- ----------------------------
DROP TABLE IF EXISTS "public"."AspNetUserRoles";
CREATE TABLE "public"."AspNetUserRoles" (
  "UserId" int4 NOT NULL,
  "RoleId" int4 NOT NULL
)
;

-- ----------------------------
-- Records of AspNetUserRoles
-- ----------------------------

-- ----------------------------
-- Table structure for AspNetUserTokens
-- ----------------------------
DROP TABLE IF EXISTS "public"."AspNetUserTokens";
CREATE TABLE "public"."AspNetUserTokens" (
  "UserId" int4 NOT NULL,
  "LoginProvider" text COLLATE "pg_catalog"."default" NOT NULL,
  "Name" text COLLATE "pg_catalog"."default" NOT NULL,
  "Value" text COLLATE "pg_catalog"."default"
)
;

-- ----------------------------
-- Records of AspNetUserTokens
-- ----------------------------

-- ----------------------------
-- Table structure for AspNetUsers
-- ----------------------------
DROP TABLE IF EXISTS "public"."AspNetUsers";
CREATE TABLE "public"."AspNetUsers" (
  "Id" int4 NOT NULL GENERATED BY DEFAULT AS IDENTITY (
INCREMENT 1
MINVALUE  1
MAXVALUE 2147483647
START 1
),
  "Birthday" date,
  "Sex" int4,
  "Language" int4 NOT NULL,
  "Name" text COLLATE "pg_catalog"."default",
  "TimeZone" int4 NOT NULL,
  "Role" int4 NOT NULL,
  "UserName" varchar(256) COLLATE "pg_catalog"."default",
  "NormalizedUserName" varchar(256) COLLATE "pg_catalog"."default",
  "Email" varchar(256) COLLATE "pg_catalog"."default",
  "NormalizedEmail" varchar(256) COLLATE "pg_catalog"."default",
  "EmailConfirmed" bool NOT NULL,
  "PasswordHash" text COLLATE "pg_catalog"."default",
  "SecurityStamp" text COLLATE "pg_catalog"."default",
  "ConcurrencyStamp" text COLLATE "pg_catalog"."default",
  "PhoneNumber" text COLLATE "pg_catalog"."default",
  "PhoneNumberConfirmed" bool NOT NULL,
  "TwoFactorEnabled" bool NOT NULL,
  "LockoutEnd" timestamptz(6),
  "LockoutEnabled" bool NOT NULL,
  "AccessFailedCount" int4 NOT NULL
)
;

-- ----------------------------
-- Records of AspNetUsers
-- ----------------------------
INSERT INTO "public"."AspNetUsers" VALUES (1, '2023-12-17', NULL, 0, NULL, 46, 2, 'mauguzun+doc547470026@gmail.com', 'MAUGUZUN+DOC547470026@GMAIL.COM', 'mauguzun+doc547470026@gmail.com', 'MAUGUZUN+DOC547470026@GMAIL.COM', 't', 'AQAAAAIAAYagAAAAEATEtSOtVmyo3om3UwKYl0eWiWY3G09mAE5dvWwLF/b37hZ5DQTUle6HAOpr0pWQ8A==', '5LBGKPMML45ZZ4PMDMV4RBWWDSWD2VFP', 'de7a987e-208d-48aa-b67c-71e8b31ad9ea', NULL, 'f', 'f', NULL, 't', 0);
INSERT INTO "public"."AspNetUsers" VALUES (2, '2023-12-17', NULL, 0, NULL, 46, 2, 'mauguzun+doc7141953@gmail.com', 'MAUGUZUN+DOC7141953@GMAIL.COM', 'mauguzun+doc7141953@gmail.com', 'MAUGUZUN+DOC7141953@GMAIL.COM', 't', 'AQAAAAIAAYagAAAAEC/qEw+ERqpTOShQFczqU/Skm/cWy6g7+wE4BzMtjOX3BbsA8/oEDh72s6xQlGo6AQ==', 'BNNMIOCF37UWYVYVRMSSKPKU4LHGA2YL', 'dbcc4e35-ae31-45e5-a70e-64ed50e23d26', NULL, 'f', 'f', NULL, 't', 0);
INSERT INTO "public"."AspNetUsers" VALUES (4, '2023-12-17', NULL, 0, NULL, 46, 1, 'mauguzun+1012550876@gmail.com', 'MAUGUZUN+1012550876@GMAIL.COM', 'mauguzun+1012550876@gmail.com', 'MAUGUZUN+1012550876@GMAIL.COM', 't', 'AQAAAAIAAYagAAAAEMHegWWlMTFJSJX43EvIwsr3llbbQGf+M4GSMYfM5EX1mr7+5fFXtWzbC0SJANxvJQ==', 'SOZPYJCJW3WKGT52KYTSMSRV4Z556XYV', 'aaba6fc4-f05c-44f1-8e43-9844a89de16c', NULL, 'f', 'f', NULL, 't', 0);
INSERT INTO "public"."AspNetUsers" VALUES (5, '2023-12-17', NULL, 0, NULL, 46, 1, 'mauguzun+509765432@gmail.com', 'MAUGUZUN+509765432@GMAIL.COM', 'mauguzun+509765432@gmail.com', 'MAUGUZUN+509765432@GMAIL.COM', 't', 'AQAAAAIAAYagAAAAEOC3ir1D0N/koAvdFaQ0q1q6JvpFYH7uZ5ZiK9O15nxaS4bhtXUsBeBiSAFqL0VQrw==', '7Q6LTCOZY4GL3OCKZYFYYOYS33JACHFJ', 'eca8b13b-4ae8-4f46-ad1a-b9847cd41f22', NULL, 'f', 'f', NULL, 't', 0);
INSERT INTO "public"."AspNetUsers" VALUES (6, '2023-12-17', NULL, 0, NULL, 46, 1, 'mauguzun+546467156@gmail.com', 'MAUGUZUN+546467156@GMAIL.COM', 'mauguzun+546467156@gmail.com', 'MAUGUZUN+546467156@GMAIL.COM', 't', 'AQAAAAIAAYagAAAAELZ8AqcjUbq2TQZOZUlNSwoe1oCz8V62Y83IYcd3NdQHhpHLUHOUqEplE1nyrVeKcg==', 'TEOWUSUGRXXZU6PWRO5QW7ASDEVSC4BC', '78874e31-b4ff-4eb1-a65b-9d3a9af4d1e1', NULL, 'f', 'f', NULL, 't', 0);
INSERT INTO "public"."AspNetUsers" VALUES (3, '2023-12-17', NULL, 0, NULL, 46, 2, 'mauguzun+doc884150642@gmail.com', 'MAUGUZUN+DOC884150642@GMAIL.COM', 'mauguzun+doc884150642@gmail.com', 'MAUGUZUN+DOC884150642@GMAIL.COM', 't', 'AQAAAAIAAYagAAAAENX+IEt6Y53HLl6GRfvUkEiu9lHDzeEQI+k475xTUevD54gPpAZFbzboA/8DvfsTwg==', 'T7DEWR65Z2T45SNCHEXGGTVNBQ7XXO5L', 'c4c5a05f-e7b8-48d4-857d-be0796503bd2', NULL, 'f', 'f', NULL, 't', 0);

-- ----------------------------
-- Table structure for CourseGroup
-- ----------------------------
DROP TABLE IF EXISTS "public"."CourseGroup";
CREATE TABLE "public"."CourseGroup" (
  "Id" int4 NOT NULL DEFAULT nextval('"TransatedEntityWithDescriptionSequence"'::regclass),
  "Title" text COLLATE "pg_catalog"."default",
  "Description" text COLLATE "pg_catalog"."default",
  "CreatedAt" timestamptz(6),
  "CreatedById" int4,
  "Language" int4 NOT NULL
)
;

-- ----------------------------
-- Records of CourseGroup
-- ----------------------------

-- ----------------------------
-- Table structure for CourseSettings
-- ----------------------------
DROP TABLE IF EXISTS "public"."CourseSettings";
CREATE TABLE "public"."CourseSettings" (
  "Id" int4 NOT NULL GENERATED BY DEFAULT AS IDENTITY (
INCREMENT 1
MINVALUE  1
MAXVALUE 2147483647
START 1
),
  "CourseId" int4 NOT NULL,
  "Sex" int4 NOT NULL,
  "MinAge" int4,
  "MaxAge" int4,
  "Weight" int4 NOT NULL,
  "CreatedAt" timestamptz(6),
  "CreatedById" int4
)
;

-- ----------------------------
-- Records of CourseSettings
-- ----------------------------

-- ----------------------------
-- Table structure for Courses
-- ----------------------------
DROP TABLE IF EXISTS "public"."Courses";
CREATE TABLE "public"."Courses" (
  "Id" int4 NOT NULL GENERATED BY DEFAULT AS IDENTITY (
INCREMENT 1
MINVALUE  1
MAXVALUE 2147483647
START 1
),
  "TherapyId" int4,
  "CourseGroupID" int4,
  "CourseType" int4 NOT NULL,
  "CreatedAt" timestamptz(6),
  "CreatedById" int4
)
;

-- ----------------------------
-- Records of Courses
-- ----------------------------
INSERT INTO "public"."Courses" VALUES (1, 1, NULL, 0, '2023-12-17 15:01:52.735277+00', 4);
INSERT INTO "public"."Courses" VALUES (2, 1, NULL, 0, '2023-12-17 15:01:52.735564+00', 4);

-- ----------------------------
-- Table structure for DosageLogs
-- ----------------------------
DROP TABLE IF EXISTS "public"."DosageLogs";
CREATE TABLE "public"."DosageLogs" (
  "Id" int4 NOT NULL GENERATED BY DEFAULT AS IDENTITY (
INCREMENT 1
MINVALUE  1
MAXVALUE 2147483647
START 1
),
  "DosageRecommendationId" int4 NOT NULL,
  "Status" int4 NOT NULL,
  "Quantity" float8 NOT NULL,
  "DateTime" timestamptz(6) NOT NULL,
  "CreatedAt" timestamptz(6),
  "CreatedById" int4
)
;

-- ----------------------------
-- Records of DosageLogs
-- ----------------------------

-- ----------------------------
-- Table structure for DosingFrequencies
-- ----------------------------
DROP TABLE IF EXISTS "public"."DosingFrequencies";
CREATE TABLE "public"."DosingFrequencies" (
  "Id" int4 NOT NULL GENERATED BY DEFAULT AS IDENTITY (
INCREMENT 1
MINVALUE  1
MAXVALUE 2147483647
START 1
),
  "CourseId" int4 NOT NULL,
  "DrugId" int4 NOT NULL,
  "Total" float8 NOT NULL,
  "IntervalInDays" int4 NOT NULL,
  "CreatedAt" timestamptz(6),
  "CreatedById" int4
)
;

-- ----------------------------
-- Records of DosingFrequencies
-- ----------------------------
INSERT INTO "public"."DosingFrequencies" VALUES (1, 1, 1, 10, 2, '2023-12-17 15:01:52.888228+00', NULL);
INSERT INTO "public"."DosingFrequencies" VALUES (2, 1, 2, 20, 1, '2023-12-17 15:01:52.888629+00', NULL);

-- ----------------------------
-- Table structure for DosingFrequencyReminders
-- ----------------------------
DROP TABLE IF EXISTS "public"."DosingFrequencyReminders";
CREATE TABLE "public"."DosingFrequencyReminders" (
  "Id" int4 NOT NULL GENERATED BY DEFAULT AS IDENTITY (
INCREMENT 1
MINVALUE  1
MAXVALUE 2147483647
START 1
),
  "Title" text COLLATE "pg_catalog"."default" NOT NULL,
  "UsingDescription" text COLLATE "pg_catalog"."default" NOT NULL,
  "Quantity" float8 NOT NULL,
  "ReminderId" int4 NOT NULL,
  "DosingFrequencyId" int4 NOT NULL,
  "CreatedAt" timestamptz(6),
  "CreatedById" int4
)
;

-- ----------------------------
-- Records of DosingFrequencyReminders
-- ----------------------------
INSERT INTO "public"."DosingFrequencyReminders" VALUES (1, 'Titleb 1 1', 'UsingDescription 1 1', 1, 1, 1, '2023-12-17 15:01:53.100107+00', NULL);

-- ----------------------------
-- Table structure for DrugCategories
-- ----------------------------
DROP TABLE IF EXISTS "public"."DrugCategories";
CREATE TABLE "public"."DrugCategories" (
  "Id" int4 NOT NULL GENERATED BY DEFAULT AS IDENTITY (
INCREMENT 1
MINVALUE  1
MAXVALUE 2147483647
START 1
),
  "CreatedAt" timestamptz(6),
  "CreatedById" int4
)
;

-- ----------------------------
-- Records of DrugCategories
-- ----------------------------
INSERT INTO "public"."DrugCategories" VALUES (1, '2023-12-17 15:01:52.333415+00', NULL);
INSERT INTO "public"."DrugCategories" VALUES (2, '2023-12-17 15:01:52.333437+00', NULL);
INSERT INTO "public"."DrugCategories" VALUES (3, '2023-12-17 15:01:52.333444+00', NULL);
INSERT INTO "public"."DrugCategories" VALUES (4, '2023-12-17 15:01:52.333447+00', NULL);
INSERT INTO "public"."DrugCategories" VALUES (5, '2023-12-17 15:01:52.33346+00', NULL);
INSERT INTO "public"."DrugCategories" VALUES (6, '2023-12-17 15:01:52.333462+00', NULL);
INSERT INTO "public"."DrugCategories" VALUES (7, '2023-12-17 15:01:52.333464+00', NULL);
INSERT INTO "public"."DrugCategories" VALUES (8, '2023-12-17 15:01:52.333466+00', NULL);
INSERT INTO "public"."DrugCategories" VALUES (9, '2023-12-17 15:01:52.333467+00', NULL);
INSERT INTO "public"."DrugCategories" VALUES (10, '2023-12-17 15:01:52.333469+00', NULL);

-- ----------------------------
-- Table structure for DrugDrugCategory
-- ----------------------------
DROP TABLE IF EXISTS "public"."DrugDrugCategory";
CREATE TABLE "public"."DrugDrugCategory" (
  "DrugCategoriesId" int4 NOT NULL,
  "DrugsId" int4 NOT NULL
)
;

-- ----------------------------
-- Records of DrugDrugCategory
-- ----------------------------
INSERT INTO "public"."DrugDrugCategory" VALUES (1, 1);
INSERT INTO "public"."DrugDrugCategory" VALUES (1, 2);
INSERT INTO "public"."DrugDrugCategory" VALUES (1, 3);
INSERT INTO "public"."DrugDrugCategory" VALUES (1, 4);
INSERT INTO "public"."DrugDrugCategory" VALUES (1, 5);
INSERT INTO "public"."DrugDrugCategory" VALUES (1, 6);
INSERT INTO "public"."DrugDrugCategory" VALUES (2, 1);
INSERT INTO "public"."DrugDrugCategory" VALUES (2, 2);
INSERT INTO "public"."DrugDrugCategory" VALUES (2, 3);
INSERT INTO "public"."DrugDrugCategory" VALUES (2, 4);
INSERT INTO "public"."DrugDrugCategory" VALUES (2, 5);
INSERT INTO "public"."DrugDrugCategory" VALUES (2, 6);
INSERT INTO "public"."DrugDrugCategory" VALUES (3, 1);
INSERT INTO "public"."DrugDrugCategory" VALUES (3, 2);
INSERT INTO "public"."DrugDrugCategory" VALUES (3, 3);
INSERT INTO "public"."DrugDrugCategory" VALUES (3, 4);
INSERT INTO "public"."DrugDrugCategory" VALUES (3, 5);
INSERT INTO "public"."DrugDrugCategory" VALUES (3, 6);
INSERT INTO "public"."DrugDrugCategory" VALUES (4, 1);
INSERT INTO "public"."DrugDrugCategory" VALUES (4, 2);
INSERT INTO "public"."DrugDrugCategory" VALUES (4, 3);
INSERT INTO "public"."DrugDrugCategory" VALUES (4, 4);
INSERT INTO "public"."DrugDrugCategory" VALUES (4, 5);
INSERT INTO "public"."DrugDrugCategory" VALUES (4, 6);
INSERT INTO "public"."DrugDrugCategory" VALUES (5, 1);
INSERT INTO "public"."DrugDrugCategory" VALUES (5, 2);
INSERT INTO "public"."DrugDrugCategory" VALUES (5, 3);
INSERT INTO "public"."DrugDrugCategory" VALUES (5, 4);
INSERT INTO "public"."DrugDrugCategory" VALUES (5, 5);
INSERT INTO "public"."DrugDrugCategory" VALUES (5, 6);
INSERT INTO "public"."DrugDrugCategory" VALUES (6, 1);
INSERT INTO "public"."DrugDrugCategory" VALUES (6, 2);
INSERT INTO "public"."DrugDrugCategory" VALUES (6, 3);
INSERT INTO "public"."DrugDrugCategory" VALUES (6, 4);
INSERT INTO "public"."DrugDrugCategory" VALUES (6, 5);
INSERT INTO "public"."DrugDrugCategory" VALUES (6, 6);
INSERT INTO "public"."DrugDrugCategory" VALUES (7, 1);
INSERT INTO "public"."DrugDrugCategory" VALUES (7, 2);
INSERT INTO "public"."DrugDrugCategory" VALUES (7, 3);
INSERT INTO "public"."DrugDrugCategory" VALUES (7, 4);
INSERT INTO "public"."DrugDrugCategory" VALUES (7, 5);
INSERT INTO "public"."DrugDrugCategory" VALUES (7, 6);
INSERT INTO "public"."DrugDrugCategory" VALUES (8, 1);
INSERT INTO "public"."DrugDrugCategory" VALUES (8, 2);
INSERT INTO "public"."DrugDrugCategory" VALUES (8, 3);
INSERT INTO "public"."DrugDrugCategory" VALUES (8, 4);
INSERT INTO "public"."DrugDrugCategory" VALUES (8, 5);
INSERT INTO "public"."DrugDrugCategory" VALUES (8, 6);
INSERT INTO "public"."DrugDrugCategory" VALUES (9, 1);
INSERT INTO "public"."DrugDrugCategory" VALUES (9, 2);
INSERT INTO "public"."DrugDrugCategory" VALUES (9, 3);
INSERT INTO "public"."DrugDrugCategory" VALUES (9, 4);
INSERT INTO "public"."DrugDrugCategory" VALUES (9, 5);
INSERT INTO "public"."DrugDrugCategory" VALUES (9, 6);
INSERT INTO "public"."DrugDrugCategory" VALUES (10, 1);
INSERT INTO "public"."DrugDrugCategory" VALUES (10, 2);
INSERT INTO "public"."DrugDrugCategory" VALUES (10, 3);
INSERT INTO "public"."DrugDrugCategory" VALUES (10, 4);
INSERT INTO "public"."DrugDrugCategory" VALUES (10, 5);
INSERT INTO "public"."DrugDrugCategory" VALUES (10, 6);

-- ----------------------------
-- Table structure for Drugs
-- ----------------------------
DROP TABLE IF EXISTS "public"."Drugs";
CREATE TABLE "public"."Drugs" (
  "Id" int4 NOT NULL GENERATED BY DEFAULT AS IDENTITY (
INCREMENT 1
MINVALUE  1
MAXVALUE 2147483647
START 1
),
  "Title" text COLLATE "pg_catalog"."default",
  "OneUnitSizeInGramm" float8 NOT NULL,
  "SimilarDrugsId" int4 NOT NULL,
  "CreatedAt" timestamptz(6),
  "CreatedById" int4
)
;

-- ----------------------------
-- Records of Drugs
-- ----------------------------
INSERT INTO "public"."Drugs" VALUES (1, 'Drug LatinName 0', 1, 1, '2023-12-17 15:01:52.423549+00', 4);
INSERT INTO "public"."Drugs" VALUES (2, 'Drug LatinName 1', 2, 2, '2023-12-17 15:01:52.423817+00', 4);
INSERT INTO "public"."Drugs" VALUES (3, 'Drug LatinName 0', 1, 3, '2023-12-17 15:01:52.42395+00', 4);
INSERT INTO "public"."Drugs" VALUES (4, 'Drug LatinName 1', 2, 4, '2023-12-17 15:01:52.423953+00', 4);
INSERT INTO "public"."Drugs" VALUES (5, 'Drug LatinName 0', 1, 5, '2023-12-17 15:01:52.424326+00', 4);
INSERT INTO "public"."Drugs" VALUES (6, 'Drug LatinName 1', 2, 6, '2023-12-17 15:01:52.424328+00', 4);

-- ----------------------------
-- Table structure for ReminderLogs
-- ----------------------------
DROP TABLE IF EXISTS "public"."ReminderLogs";
CREATE TABLE "public"."ReminderLogs" (
  "Id" int4 NOT NULL GENERATED BY DEFAULT AS IDENTITY (
INCREMENT 1
MINVALUE  1
MAXVALUE 2147483647
START 1
),
  "ReminderId" int4 NOT NULL,
  "ReminderLogStatus" int4 NOT NULL,
  "Descrpition" text COLLATE "pg_catalog"."default",
  "CreatedAt" timestamptz(6)
)
;

-- ----------------------------
-- Records of ReminderLogs
-- ----------------------------

-- ----------------------------
-- Table structure for Reminders
-- ----------------------------
DROP TABLE IF EXISTS "public"."Reminders";
CREATE TABLE "public"."Reminders" (
  "Id" int4 NOT NULL GENERATED BY DEFAULT AS IDENTITY (
INCREMENT 1
MINVALUE  1
MAXVALUE 2147483647
START 1
),
  "TimeInUtc" text COLLATE "pg_catalog"."default" NOT NULL,
  "CreatedAt" timestamptz(6),
  "CreatedById" int4,
  "Title" text COLLATE "pg_catalog"."default",
  "Description" text COLLATE "pg_catalog"."default"
)
;

-- ----------------------------
-- Records of Reminders
-- ----------------------------
INSERT INTO "public"."Reminders" VALUES (1, '07:00', '2023-12-17 15:01:52.734601+00', 4, 'Title 07:00 Reminders', 'Description 07:00 Reminders');
INSERT INTO "public"."Reminders" VALUES (2, '17:00', '2023-12-17 15:01:52.734786+00', 4, 'Title 17:00 Reminders', 'Description 17:00 Reminders');

-- ----------------------------
-- Table structure for SimilarDrugs
-- ----------------------------
DROP TABLE IF EXISTS "public"."SimilarDrugs";
CREATE TABLE "public"."SimilarDrugs" (
  "Id" int4 NOT NULL GENERATED BY DEFAULT AS IDENTITY (
INCREMENT 1
MINVALUE  1
MAXVALUE 2147483647
START 1
),
  "CreatedAt" timestamptz(6)
)
;

-- ----------------------------
-- Records of SimilarDrugs
-- ----------------------------
INSERT INTO "public"."SimilarDrugs" VALUES (1, '2023-12-17 15:01:52.423548+00');
INSERT INTO "public"."SimilarDrugs" VALUES (2, '2023-12-17 15:01:52.423817+00');
INSERT INTO "public"."SimilarDrugs" VALUES (3, '2023-12-17 15:01:52.42395+00');
INSERT INTO "public"."SimilarDrugs" VALUES (4, '2023-12-17 15:01:52.423953+00');
INSERT INTO "public"."SimilarDrugs" VALUES (5, '2023-12-17 15:01:52.424326+00');
INSERT INTO "public"."SimilarDrugs" VALUES (6, '2023-12-17 15:01:52.424328+00');

-- ----------------------------
-- Table structure for Therapies
-- ----------------------------
DROP TABLE IF EXISTS "public"."Therapies";
CREATE TABLE "public"."Therapies" (
  "Id" int4 NOT NULL GENERATED BY DEFAULT AS IDENTITY (
INCREMENT 1
MINVALUE  1
MAXVALUE 2147483647
START 1
),
  "AssingedToId" int4,
  "Status" int4 NOT NULL,
  "Type" int4 NOT NULL,
  "CreatedAt" timestamptz(6),
  "CreatedById" int4
)
;

-- ----------------------------
-- Records of Therapies
-- ----------------------------
INSERT INTO "public"."Therapies" VALUES (1, 4, 0, 1, '2023-12-17 15:01:53.09896+00', 2);

-- ----------------------------
-- Table structure for TranslatedActiveElement
-- ----------------------------
DROP TABLE IF EXISTS "public"."TranslatedActiveElement";
CREATE TABLE "public"."TranslatedActiveElement" (
  "Id" int4 NOT NULL DEFAULT nextval('"TransatedEntityWithDescriptionSequence"'::regclass),
  "Title" text COLLATE "pg_catalog"."default",
  "Description" text COLLATE "pg_catalog"."default",
  "ActiveElementId" int4 NOT NULL,
  "CreatedAt" timestamptz(6),
  "CreatedById" int4,
  "Language" int4 NOT NULL
)
;

-- ----------------------------
-- Records of TranslatedActiveElement
-- ----------------------------

-- ----------------------------
-- Table structure for TranslatedCourse
-- ----------------------------
DROP TABLE IF EXISTS "public"."TranslatedCourse";
CREATE TABLE "public"."TranslatedCourse" (
  "Id" int4 NOT NULL DEFAULT nextval('"TransatedEntityWithDescriptionSequence"'::regclass),
  "Title" text COLLATE "pg_catalog"."default",
  "Description" text COLLATE "pg_catalog"."default",
  "CourseId" int4 NOT NULL,
  "Version" text COLLATE "pg_catalog"."default",
  "CreatedAt" timestamptz(6),
  "CreatedById" int4,
  "Language" int4 NOT NULL
)
;

-- ----------------------------
-- Records of TranslatedCourse
-- ----------------------------
INSERT INTO "public"."TranslatedCourse" VALUES (33, 'AutoCrated2', 'AutoCreated2', 1, NULL, '2023-12-17 15:01:52.735362+00', NULL, 1);
INSERT INTO "public"."TranslatedCourse" VALUES (34, 'AutoCrated', 'AutoCreated', 1, NULL, '2023-12-17 15:01:52.735365+00', NULL, 0);
INSERT INTO "public"."TranslatedCourse" VALUES (35, 'AutoCrated2', 'AutoCreated2', 2, NULL, '2023-12-17 15:01:52.735565+00', NULL, 1);
INSERT INTO "public"."TranslatedCourse" VALUES (36, 'AutoCrated', 'AutoCreated', 2, NULL, '2023-12-17 15:01:52.735565+00', NULL, 0);

-- ----------------------------
-- Table structure for TranslatedCourseGroup
-- ----------------------------
DROP TABLE IF EXISTS "public"."TranslatedCourseGroup";
CREATE TABLE "public"."TranslatedCourseGroup" (
  "Id" int4 NOT NULL DEFAULT nextval('"TransatedEntityWithDescriptionSequence"'::regclass),
  "Title" text COLLATE "pg_catalog"."default",
  "Description" text COLLATE "pg_catalog"."default",
  "CourseGroupId" int4 NOT NULL,
  "CreatedAt" timestamptz(6),
  "CreatedById" int4,
  "Language" int4 NOT NULL
)
;

-- ----------------------------
-- Records of TranslatedCourseGroup
-- ----------------------------

-- ----------------------------
-- Table structure for TranslatedDosingFrequency
-- ----------------------------
DROP TABLE IF EXISTS "public"."TranslatedDosingFrequency";
CREATE TABLE "public"."TranslatedDosingFrequency" (
  "Id" int4 NOT NULL DEFAULT nextval('"TransatedEntityWithDescriptionSequence"'::regclass),
  "Title" text COLLATE "pg_catalog"."default",
  "Description" text COLLATE "pg_catalog"."default",
  "DosingFrequencyId" int4 NOT NULL,
  "CreatedAt" timestamptz(6),
  "CreatedById" int4,
  "Language" int4 NOT NULL
)
;

-- ----------------------------
-- Records of TranslatedDosingFrequency
-- ----------------------------
INSERT INTO "public"."TranslatedDosingFrequency" VALUES (37, 'TranslatedDosingFrequency', 'TranslatedDosingFrequency Description', 1, '2023-12-17 15:01:52.888625+00', NULL, 0);
INSERT INTO "public"."TranslatedDosingFrequency" VALUES (38, 'TranslatedDosingFrequency', 'TranslatedDosingFrequency Description', 1, '2023-12-17 15:01:52.888628+00', NULL, 1);
INSERT INTO "public"."TranslatedDosingFrequency" VALUES (39, 'TranslatedDosingFrequency', 'TranslatedDosingFrequency Description', 2, '2023-12-17 15:01:52.88863+00', NULL, 0);
INSERT INTO "public"."TranslatedDosingFrequency" VALUES (40, 'TranslatedDosingFrequency', 'TranslatedDosingFrequency Description', 2, '2023-12-17 15:01:52.88863+00', NULL, 1);

-- ----------------------------
-- Table structure for TranslatedDosingFrequencyReminder
-- ----------------------------
DROP TABLE IF EXISTS "public"."TranslatedDosingFrequencyReminder";
CREATE TABLE "public"."TranslatedDosingFrequencyReminder" (
  "Id" int4 NOT NULL GENERATED BY DEFAULT AS IDENTITY (
INCREMENT 1
MINVALUE  1
MAXVALUE 2147483647
START 1
),
  "Title" text COLLATE "pg_catalog"."default" NOT NULL,
  "UsingDescription" text COLLATE "pg_catalog"."default" NOT NULL,
  "DosageRecommendationId" int4 NOT NULL,
  "CreatedAt" timestamptz(6),
  "CreatedById" int4,
  "Language" int4 NOT NULL
)
;

-- ----------------------------
-- Records of TranslatedDosingFrequencyReminder
-- ----------------------------

-- ----------------------------
-- Table structure for TranslatedDrugs
-- ----------------------------
DROP TABLE IF EXISTS "public"."TranslatedDrugs";
CREATE TABLE "public"."TranslatedDrugs" (
  "Id" int4 NOT NULL DEFAULT nextval('"TransatedEntityWithDescriptionSequence"'::regclass),
  "Title" text COLLATE "pg_catalog"."default",
  "Description" text COLLATE "pg_catalog"."default",
  "DrugId" int4 NOT NULL,
  "Recomendation" text COLLATE "pg_catalog"."default",
  "CreatedAt" timestamptz(6),
  "CreatedById" int4,
  "Language" int4 NOT NULL
)
;

-- ----------------------------
-- Records of TranslatedDrugs
-- ----------------------------
INSERT INTO "public"."TranslatedDrugs" VALUES (21, '0 TranslatedDrugs  en ', '0 TranslatedDrugs  Description  en', 1, 'Use befor', '2023-12-17 15:01:52.423219+00', NULL, 0);
INSERT INTO "public"."TranslatedDrugs" VALUES (22, '0 TranslatedDrugs  lv ', '0 TranslatedDrugs  Description  lv', 1, 'Use befor', '2023-12-17 15:01:52.42331+00', NULL, 1);
INSERT INTO "public"."TranslatedDrugs" VALUES (23, '1 TranslatedDrugs  en ', '1 TranslatedDrugs  Description  en', 2, 'Use befor', '2023-12-17 15:01:52.423814+00', NULL, 0);
INSERT INTO "public"."TranslatedDrugs" VALUES (24, '1 TranslatedDrugs  lv ', '1 TranslatedDrugs  Description  lv', 2, 'Use befor', '2023-12-17 15:01:52.423816+00', NULL, 1);
INSERT INTO "public"."TranslatedDrugs" VALUES (25, '0 TranslatedDrugs  en ', '0 TranslatedDrugs  Description  en', 3, 'Use befor', '2023-12-17 15:01:52.423947+00', NULL, 0);
INSERT INTO "public"."TranslatedDrugs" VALUES (26, '0 TranslatedDrugs  lv ', '0 TranslatedDrugs  Description  lv', 3, 'Use befor', '2023-12-17 15:01:52.423949+00', NULL, 1);
INSERT INTO "public"."TranslatedDrugs" VALUES (27, '1 TranslatedDrugs  en ', '1 TranslatedDrugs  Description  en', 4, 'Use befor', '2023-12-17 15:01:52.423951+00', NULL, 0);
INSERT INTO "public"."TranslatedDrugs" VALUES (28, '1 TranslatedDrugs  lv ', '1 TranslatedDrugs  Description  lv', 4, 'Use befor', '2023-12-17 15:01:52.423952+00', NULL, 1);
INSERT INTO "public"."TranslatedDrugs" VALUES (29, '0 TranslatedDrugs  en ', '0 TranslatedDrugs  Description  en', 5, 'Use befor', '2023-12-17 15:01:52.424322+00', NULL, 0);
INSERT INTO "public"."TranslatedDrugs" VALUES (30, '0 TranslatedDrugs  lv ', '0 TranslatedDrugs  Description  lv', 5, 'Use befor', '2023-12-17 15:01:52.424325+00', NULL, 1);
INSERT INTO "public"."TranslatedDrugs" VALUES (31, '1 TranslatedDrugs  en ', '1 TranslatedDrugs  Description  en', 6, 'Use befor', '2023-12-17 15:01:52.424327+00', NULL, 0);
INSERT INTO "public"."TranslatedDrugs" VALUES (32, '1 TranslatedDrugs  lv ', '1 TranslatedDrugs  Description  lv', 6, 'Use befor', '2023-12-17 15:01:52.424327+00', NULL, 1);

-- ----------------------------
-- Table structure for TranslatedDrugsCategory
-- ----------------------------
DROP TABLE IF EXISTS "public"."TranslatedDrugsCategory";
CREATE TABLE "public"."TranslatedDrugsCategory" (
  "Id" int4 NOT NULL DEFAULT nextval('"TransatedEntityWithDescriptionSequence"'::regclass),
  "Title" text COLLATE "pg_catalog"."default",
  "Description" text COLLATE "pg_catalog"."default",
  "DrugCategoryId" int4 NOT NULL,
  "CreatedAt" timestamptz(6),
  "CreatedById" int4,
  "Language" int4 NOT NULL
)
;

-- ----------------------------
-- Records of TranslatedDrugsCategory
-- ----------------------------
INSERT INTO "public"."TranslatedDrugsCategory" VALUES (1, '0 TranslatedActiveElement  en', '0 DrugCategory  Description  en', 1, '2023-12-17 15:01:52.333273+00', NULL, 0);
INSERT INTO "public"."TranslatedDrugsCategory" VALUES (2, '0 TranslatedActiveElement  lv', '0 DrugCategory  Description  lv', 1, '2023-12-17 15:01:52.333281+00', NULL, 1);
INSERT INTO "public"."TranslatedDrugsCategory" VALUES (3, '1 TranslatedActiveElement  en', '1 DrugCategory  Description  en', 2, '2023-12-17 15:01:52.333433+00', NULL, 0);
INSERT INTO "public"."TranslatedDrugsCategory" VALUES (4, '1 TranslatedActiveElement  lv', '1 DrugCategory  Description  lv', 2, '2023-12-17 15:01:52.333436+00', NULL, 1);
INSERT INTO "public"."TranslatedDrugsCategory" VALUES (5, '2 TranslatedActiveElement  en', '2 DrugCategory  Description  en', 3, '2023-12-17 15:01:52.333442+00', NULL, 0);
INSERT INTO "public"."TranslatedDrugsCategory" VALUES (6, '2 TranslatedActiveElement  lv', '2 DrugCategory  Description  lv', 3, '2023-12-17 15:01:52.333443+00', NULL, 1);
INSERT INTO "public"."TranslatedDrugsCategory" VALUES (7, '3 TranslatedActiveElement  en', '3 DrugCategory  Description  en', 4, '2023-12-17 15:01:52.333445+00', NULL, 0);
INSERT INTO "public"."TranslatedDrugsCategory" VALUES (8, '3 TranslatedActiveElement  lv', '3 DrugCategory  Description  lv', 4, '2023-12-17 15:01:52.333446+00', NULL, 1);
INSERT INTO "public"."TranslatedDrugsCategory" VALUES (9, '4 TranslatedActiveElement  en', '4 DrugCategory  Description  en', 5, '2023-12-17 15:01:52.333448+00', NULL, 0);
INSERT INTO "public"."TranslatedDrugsCategory" VALUES (10, '4 TranslatedActiveElement  lv', '4 DrugCategory  Description  lv', 5, '2023-12-17 15:01:52.333449+00', NULL, 1);
INSERT INTO "public"."TranslatedDrugsCategory" VALUES (11, '5 TranslatedActiveElement  en', '5 DrugCategory  Description  en', 6, '2023-12-17 15:01:52.333461+00', NULL, 0);
INSERT INTO "public"."TranslatedDrugsCategory" VALUES (12, '5 TranslatedActiveElement  lv', '5 DrugCategory  Description  lv', 6, '2023-12-17 15:01:52.333462+00', NULL, 1);
INSERT INTO "public"."TranslatedDrugsCategory" VALUES (13, '6 TranslatedActiveElement  en', '6 DrugCategory  Description  en', 7, '2023-12-17 15:01:52.333463+00', NULL, 0);
INSERT INTO "public"."TranslatedDrugsCategory" VALUES (14, '6 TranslatedActiveElement  lv', '6 DrugCategory  Description  lv', 7, '2023-12-17 15:01:52.333464+00', NULL, 1);
INSERT INTO "public"."TranslatedDrugsCategory" VALUES (15, '7 TranslatedActiveElement  en', '7 DrugCategory  Description  en', 8, '2023-12-17 15:01:52.333465+00', NULL, 0);
INSERT INTO "public"."TranslatedDrugsCategory" VALUES (16, '7 TranslatedActiveElement  lv', '7 DrugCategory  Description  lv', 8, '2023-12-17 15:01:52.333465+00', NULL, 1);
INSERT INTO "public"."TranslatedDrugsCategory" VALUES (17, '8 TranslatedActiveElement  en', '8 DrugCategory  Description  en', 9, '2023-12-17 15:01:52.333466+00', NULL, 0);
INSERT INTO "public"."TranslatedDrugsCategory" VALUES (18, '8 TranslatedActiveElement  lv', '8 DrugCategory  Description  lv', 9, '2023-12-17 15:01:52.333467+00', NULL, 1);
INSERT INTO "public"."TranslatedDrugsCategory" VALUES (19, '9 TranslatedActiveElement  en', '9 DrugCategory  Description  en', 10, '2023-12-17 15:01:52.333468+00', NULL, 0);
INSERT INTO "public"."TranslatedDrugsCategory" VALUES (20, '9 TranslatedActiveElement  lv', '9 DrugCategory  Description  lv', 10, '2023-12-17 15:01:52.333469+00', NULL, 1);

-- ----------------------------
-- Table structure for TranslatedTherapy
-- ----------------------------
DROP TABLE IF EXISTS "public"."TranslatedTherapy";
CREATE TABLE "public"."TranslatedTherapy" (
  "Id" int4 NOT NULL DEFAULT nextval('"TransatedEntityWithDescriptionSequence"'::regclass),
  "Title" text COLLATE "pg_catalog"."default",
  "Description" text COLLATE "pg_catalog"."default",
  "TherapyId" int4 NOT NULL,
  "CreatedAt" timestamptz(6),
  "CreatedById" int4,
  "Language" int4 NOT NULL
)
;

-- ----------------------------
-- Records of TranslatedTherapy
-- ----------------------------
INSERT INTO "public"."TranslatedTherapy" VALUES (41, 'Therapy ', 'Therapy ', 1, '2023-12-17 15:01:53.099426+00', NULL, 0);
INSERT INTO "public"."TranslatedTherapy" VALUES (42, 'Therapy', 'sTherapy ', 1, '2023-12-17 15:01:53.099431+00', NULL, 1);

-- ----------------------------
-- Table structure for UserDoctorRelationLogs
-- ----------------------------
DROP TABLE IF EXISTS "public"."UserDoctorRelationLogs";
CREATE TABLE "public"."UserDoctorRelationLogs" (
  "Id" int4 NOT NULL GENERATED BY DEFAULT AS IDENTITY (
INCREMENT 1
MINVALUE  1
MAXVALUE 2147483647
START 1
),
  "UserDoctorRelationId" int4 NOT NULL,
  "UserDoctorRelationType" int4 NOT NULL,
  "CreatedAt" timestamptz(6)
)
;

-- ----------------------------
-- Records of UserDoctorRelationLogs
-- ----------------------------

-- ----------------------------
-- Table structure for UserDoctorRelations
-- ----------------------------
DROP TABLE IF EXISTS "public"."UserDoctorRelations";
CREATE TABLE "public"."UserDoctorRelations" (
  "Id" int4 NOT NULL GENERATED BY DEFAULT AS IDENTITY (
INCREMENT 1
MINVALUE  1
MAXVALUE 2147483647
START 1
),
  "DoctorId" int4,
  "UserDoctorRelationType" int4 NOT NULL,
  "CreatedByUser" bool NOT NULL,
  "AcceptedAt" timestamptz(6),
  "CreatedAt" timestamptz(6),
  "CreatedById" int4
)
;

-- ----------------------------
-- Records of UserDoctorRelations
-- ----------------------------
INSERT INTO "public"."UserDoctorRelations" VALUES (1, 2, 20, 't', NULL, '2023-12-17 15:01:53.100829+00', 4);

-- ----------------------------
-- Table structure for __EFMigrationsHistory
-- ----------------------------
DROP TABLE IF EXISTS "public"."__EFMigrationsHistory";
CREATE TABLE "public"."__EFMigrationsHistory" (
  "MigrationId" varchar(150) COLLATE "pg_catalog"."default" NOT NULL,
  "ProductVersion" varchar(32) COLLATE "pg_catalog"."default" NOT NULL
)
;

-- ----------------------------
-- Records of __EFMigrationsHistory
-- ----------------------------
INSERT INTO "public"."__EFMigrationsHistory" VALUES ('20231217133242_20231217_143217', '7.0.5');
INSERT INTO "public"."__EFMigrationsHistory" VALUES ('20231217141558_20231217_151542', '7.0.5');
INSERT INTO "public"."__EFMigrationsHistory" VALUES ('20231217145752_20231217_155735', '7.0.5');
INSERT INTO "public"."__EFMigrationsHistory" VALUES ('20231217150101_20231217_160052', '7.0.5');

-- ----------------------------
-- Alter sequences owned by
-- ----------------------------
ALTER SEQUENCE "public"."ActiveElements_Id_seq"
OWNED BY "public"."ActiveElements"."Id";
SELECT setval('"public"."ActiveElements_Id_seq"', 2, false);

-- ----------------------------
-- Alter sequences owned by
-- ----------------------------
ALTER SEQUENCE "public"."AspNetRoleClaims_Id_seq"
OWNED BY "public"."AspNetRoleClaims"."Id";
SELECT setval('"public"."AspNetRoleClaims_Id_seq"', 2, false);

-- ----------------------------
-- Alter sequences owned by
-- ----------------------------
ALTER SEQUENCE "public"."AspNetRoles_Id_seq"
OWNED BY "public"."AspNetRoles"."Id";
SELECT setval('"public"."AspNetRoles_Id_seq"', 2, false);

-- ----------------------------
-- Alter sequences owned by
-- ----------------------------
ALTER SEQUENCE "public"."AspNetUserClaims_Id_seq"
OWNED BY "public"."AspNetUserClaims"."Id";
SELECT setval('"public"."AspNetUserClaims_Id_seq"', 2, false);

-- ----------------------------
-- Alter sequences owned by
-- ----------------------------
ALTER SEQUENCE "public"."AspNetUsers_Id_seq"
OWNED BY "public"."AspNetUsers"."Id";
SELECT setval('"public"."AspNetUsers_Id_seq"', 7, true);

-- ----------------------------
-- Alter sequences owned by
-- ----------------------------
ALTER SEQUENCE "public"."CourseSettings_Id_seq"
OWNED BY "public"."CourseSettings"."Id";
SELECT setval('"public"."CourseSettings_Id_seq"', 2, false);

-- ----------------------------
-- Alter sequences owned by
-- ----------------------------
ALTER SEQUENCE "public"."Courses_Id_seq"
OWNED BY "public"."Courses"."Id";
SELECT setval('"public"."Courses_Id_seq"', 3, true);

-- ----------------------------
-- Alter sequences owned by
-- ----------------------------
ALTER SEQUENCE "public"."DosageLogs_Id_seq"
OWNED BY "public"."DosageLogs"."Id";
SELECT setval('"public"."DosageLogs_Id_seq"', 2, false);

-- ----------------------------
-- Alter sequences owned by
-- ----------------------------
ALTER SEQUENCE "public"."DosingFrequencies_Id_seq"
OWNED BY "public"."DosingFrequencies"."Id";
SELECT setval('"public"."DosingFrequencies_Id_seq"', 3, true);

-- ----------------------------
-- Alter sequences owned by
-- ----------------------------
ALTER SEQUENCE "public"."DosingFrequencyReminders_Id_seq"
OWNED BY "public"."DosingFrequencyReminders"."Id";
SELECT setval('"public"."DosingFrequencyReminders_Id_seq"', 2, true);

-- ----------------------------
-- Alter sequences owned by
-- ----------------------------
ALTER SEQUENCE "public"."DrugCategories_Id_seq"
OWNED BY "public"."DrugCategories"."Id";
SELECT setval('"public"."DrugCategories_Id_seq"', 11, true);

-- ----------------------------
-- Alter sequences owned by
-- ----------------------------
ALTER SEQUENCE "public"."Drugs_Id_seq"
OWNED BY "public"."Drugs"."Id";
SELECT setval('"public"."Drugs_Id_seq"', 7, true);

-- ----------------------------
-- Alter sequences owned by
-- ----------------------------
ALTER SEQUENCE "public"."ReminderLogs_Id_seq"
OWNED BY "public"."ReminderLogs"."Id";
SELECT setval('"public"."ReminderLogs_Id_seq"', 2, false);

-- ----------------------------
-- Alter sequences owned by
-- ----------------------------
ALTER SEQUENCE "public"."Reminders_Id_seq"
OWNED BY "public"."Reminders"."Id";
SELECT setval('"public"."Reminders_Id_seq"', 3, true);

-- ----------------------------
-- Alter sequences owned by
-- ----------------------------
ALTER SEQUENCE "public"."SimilarDrugs_Id_seq"
OWNED BY "public"."SimilarDrugs"."Id";
SELECT setval('"public"."SimilarDrugs_Id_seq"', 7, true);

-- ----------------------------
-- Alter sequences owned by
-- ----------------------------
ALTER SEQUENCE "public"."Therapies_Id_seq"
OWNED BY "public"."Therapies"."Id";
SELECT setval('"public"."Therapies_Id_seq"', 2, true);

-- ----------------------------
-- Alter sequences owned by
-- ----------------------------
SELECT setval('"public"."TransatedEntityWithDescriptionSequence"', 43, true);

-- ----------------------------
-- Alter sequences owned by
-- ----------------------------
ALTER SEQUENCE "public"."TranslatedDosingFrequencyReminder_Id_seq"
OWNED BY "public"."TranslatedDosingFrequencyReminder"."Id";
SELECT setval('"public"."TranslatedDosingFrequencyReminder_Id_seq"', 2, false);

-- ----------------------------
-- Alter sequences owned by
-- ----------------------------
ALTER SEQUENCE "public"."UserDoctorRelationLogs_Id_seq"
OWNED BY "public"."UserDoctorRelationLogs"."Id";
SELECT setval('"public"."UserDoctorRelationLogs_Id_seq"', 2, false);

-- ----------------------------
-- Alter sequences owned by
-- ----------------------------
ALTER SEQUENCE "public"."UserDoctorRelations_Id_seq"
OWNED BY "public"."UserDoctorRelations"."Id";
SELECT setval('"public"."UserDoctorRelations_Id_seq"', 2, true);

-- ----------------------------
-- Indexes structure for table ActiveElements
-- ----------------------------
CREATE INDEX "IX_ActiveElements_CreatedById" ON "public"."ActiveElements" USING btree (
  "CreatedById" "pg_catalog"."int4_ops" ASC NULLS LAST
);
CREATE INDEX "IX_ActiveElements_DrugId" ON "public"."ActiveElements" USING btree (
  "DrugId" "pg_catalog"."int4_ops" ASC NULLS LAST
);

-- ----------------------------
-- Primary Key structure for table ActiveElements
-- ----------------------------
ALTER TABLE "public"."ActiveElements" ADD CONSTRAINT "PK_ActiveElements" PRIMARY KEY ("Id");

-- ----------------------------
-- Indexes structure for table AspNetRoleClaims
-- ----------------------------
CREATE INDEX "IX_AspNetRoleClaims_RoleId" ON "public"."AspNetRoleClaims" USING btree (
  "RoleId" "pg_catalog"."int4_ops" ASC NULLS LAST
);

-- ----------------------------
-- Primary Key structure for table AspNetRoleClaims
-- ----------------------------
ALTER TABLE "public"."AspNetRoleClaims" ADD CONSTRAINT "PK_AspNetRoleClaims" PRIMARY KEY ("Id");

-- ----------------------------
-- Indexes structure for table AspNetRoles
-- ----------------------------
CREATE UNIQUE INDEX "RoleNameIndex" ON "public"."AspNetRoles" USING btree (
  "NormalizedName" COLLATE "pg_catalog"."default" "pg_catalog"."text_ops" ASC NULLS LAST
);

-- ----------------------------
-- Primary Key structure for table AspNetRoles
-- ----------------------------
ALTER TABLE "public"."AspNetRoles" ADD CONSTRAINT "PK_AspNetRoles" PRIMARY KEY ("Id");

-- ----------------------------
-- Indexes structure for table AspNetUserClaims
-- ----------------------------
CREATE INDEX "IX_AspNetUserClaims_UserId" ON "public"."AspNetUserClaims" USING btree (
  "UserId" "pg_catalog"."int4_ops" ASC NULLS LAST
);

-- ----------------------------
-- Primary Key structure for table AspNetUserClaims
-- ----------------------------
ALTER TABLE "public"."AspNetUserClaims" ADD CONSTRAINT "PK_AspNetUserClaims" PRIMARY KEY ("Id");

-- ----------------------------
-- Indexes structure for table AspNetUserLogins
-- ----------------------------
CREATE INDEX "IX_AspNetUserLogins_UserId" ON "public"."AspNetUserLogins" USING btree (
  "UserId" "pg_catalog"."int4_ops" ASC NULLS LAST
);

-- ----------------------------
-- Primary Key structure for table AspNetUserLogins
-- ----------------------------
ALTER TABLE "public"."AspNetUserLogins" ADD CONSTRAINT "PK_AspNetUserLogins" PRIMARY KEY ("LoginProvider", "ProviderKey");

-- ----------------------------
-- Indexes structure for table AspNetUserRoles
-- ----------------------------
CREATE INDEX "IX_AspNetUserRoles_RoleId" ON "public"."AspNetUserRoles" USING btree (
  "RoleId" "pg_catalog"."int4_ops" ASC NULLS LAST
);

-- ----------------------------
-- Primary Key structure for table AspNetUserRoles
-- ----------------------------
ALTER TABLE "public"."AspNetUserRoles" ADD CONSTRAINT "PK_AspNetUserRoles" PRIMARY KEY ("UserId", "RoleId");

-- ----------------------------
-- Primary Key structure for table AspNetUserTokens
-- ----------------------------
ALTER TABLE "public"."AspNetUserTokens" ADD CONSTRAINT "PK_AspNetUserTokens" PRIMARY KEY ("UserId", "LoginProvider", "Name");

-- ----------------------------
-- Indexes structure for table AspNetUsers
-- ----------------------------
CREATE INDEX "EmailIndex" ON "public"."AspNetUsers" USING btree (
  "NormalizedEmail" COLLATE "pg_catalog"."default" "pg_catalog"."text_ops" ASC NULLS LAST
);
CREATE UNIQUE INDEX "UserNameIndex" ON "public"."AspNetUsers" USING btree (
  "NormalizedUserName" COLLATE "pg_catalog"."default" "pg_catalog"."text_ops" ASC NULLS LAST
);

-- ----------------------------
-- Primary Key structure for table AspNetUsers
-- ----------------------------
ALTER TABLE "public"."AspNetUsers" ADD CONSTRAINT "PK_AspNetUsers" PRIMARY KEY ("Id");

-- ----------------------------
-- Indexes structure for table CourseGroup
-- ----------------------------
CREATE INDEX "IX_CourseGroup_CreatedById" ON "public"."CourseGroup" USING btree (
  "CreatedById" "pg_catalog"."int4_ops" ASC NULLS LAST
);

-- ----------------------------
-- Primary Key structure for table CourseGroup
-- ----------------------------
ALTER TABLE "public"."CourseGroup" ADD CONSTRAINT "PK_CourseGroup" PRIMARY KEY ("Id");

-- ----------------------------
-- Indexes structure for table CourseSettings
-- ----------------------------
CREATE INDEX "IX_CourseSettings_CourseId" ON "public"."CourseSettings" USING btree (
  "CourseId" "pg_catalog"."int4_ops" ASC NULLS LAST
);
CREATE INDEX "IX_CourseSettings_CreatedById" ON "public"."CourseSettings" USING btree (
  "CreatedById" "pg_catalog"."int4_ops" ASC NULLS LAST
);

-- ----------------------------
-- Primary Key structure for table CourseSettings
-- ----------------------------
ALTER TABLE "public"."CourseSettings" ADD CONSTRAINT "PK_CourseSettings" PRIMARY KEY ("Id");

-- ----------------------------
-- Indexes structure for table Courses
-- ----------------------------
CREATE INDEX "IX_Courses_CourseGroupID" ON "public"."Courses" USING btree (
  "CourseGroupID" "pg_catalog"."int4_ops" ASC NULLS LAST
);
CREATE INDEX "IX_Courses_CreatedById" ON "public"."Courses" USING btree (
  "CreatedById" "pg_catalog"."int4_ops" ASC NULLS LAST
);
CREATE INDEX "IX_Courses_TherapyId" ON "public"."Courses" USING btree (
  "TherapyId" "pg_catalog"."int4_ops" ASC NULLS LAST
);

-- ----------------------------
-- Primary Key structure for table Courses
-- ----------------------------
ALTER TABLE "public"."Courses" ADD CONSTRAINT "PK_Courses" PRIMARY KEY ("Id");

-- ----------------------------
-- Indexes structure for table DosageLogs
-- ----------------------------
CREATE INDEX "IX_DosageLogs_CreatedById" ON "public"."DosageLogs" USING btree (
  "CreatedById" "pg_catalog"."int4_ops" ASC NULLS LAST
);
CREATE INDEX "IX_DosageLogs_DosageRecommendationId" ON "public"."DosageLogs" USING btree (
  "DosageRecommendationId" "pg_catalog"."int4_ops" ASC NULLS LAST
);

-- ----------------------------
-- Primary Key structure for table DosageLogs
-- ----------------------------
ALTER TABLE "public"."DosageLogs" ADD CONSTRAINT "PK_DosageLogs" PRIMARY KEY ("Id");

-- ----------------------------
-- Indexes structure for table DosingFrequencies
-- ----------------------------
CREATE INDEX "IX_DosingFrequencies_CourseId" ON "public"."DosingFrequencies" USING btree (
  "CourseId" "pg_catalog"."int4_ops" ASC NULLS LAST
);
CREATE INDEX "IX_DosingFrequencies_CreatedById" ON "public"."DosingFrequencies" USING btree (
  "CreatedById" "pg_catalog"."int4_ops" ASC NULLS LAST
);
CREATE INDEX "IX_DosingFrequencies_DrugId" ON "public"."DosingFrequencies" USING btree (
  "DrugId" "pg_catalog"."int4_ops" ASC NULLS LAST
);

-- ----------------------------
-- Primary Key structure for table DosingFrequencies
-- ----------------------------
ALTER TABLE "public"."DosingFrequencies" ADD CONSTRAINT "PK_DosingFrequencies" PRIMARY KEY ("Id");

-- ----------------------------
-- Indexes structure for table DosingFrequencyReminders
-- ----------------------------
CREATE INDEX "IX_DosingFrequencyReminders_CreatedById" ON "public"."DosingFrequencyReminders" USING btree (
  "CreatedById" "pg_catalog"."int4_ops" ASC NULLS LAST
);
CREATE INDEX "IX_DosingFrequencyReminders_DosingFrequencyId" ON "public"."DosingFrequencyReminders" USING btree (
  "DosingFrequencyId" "pg_catalog"."int4_ops" ASC NULLS LAST
);
CREATE INDEX "IX_DosingFrequencyReminders_ReminderId" ON "public"."DosingFrequencyReminders" USING btree (
  "ReminderId" "pg_catalog"."int4_ops" ASC NULLS LAST
);

-- ----------------------------
-- Primary Key structure for table DosingFrequencyReminders
-- ----------------------------
ALTER TABLE "public"."DosingFrequencyReminders" ADD CONSTRAINT "PK_DosingFrequencyReminders" PRIMARY KEY ("Id");

-- ----------------------------
-- Indexes structure for table DrugCategories
-- ----------------------------
CREATE INDEX "IX_DrugCategories_CreatedById" ON "public"."DrugCategories" USING btree (
  "CreatedById" "pg_catalog"."int4_ops" ASC NULLS LAST
);

-- ----------------------------
-- Primary Key structure for table DrugCategories
-- ----------------------------
ALTER TABLE "public"."DrugCategories" ADD CONSTRAINT "PK_DrugCategories" PRIMARY KEY ("Id");

-- ----------------------------
-- Indexes structure for table DrugDrugCategory
-- ----------------------------
CREATE INDEX "IX_DrugDrugCategory_DrugsId" ON "public"."DrugDrugCategory" USING btree (
  "DrugsId" "pg_catalog"."int4_ops" ASC NULLS LAST
);

-- ----------------------------
-- Primary Key structure for table DrugDrugCategory
-- ----------------------------
ALTER TABLE "public"."DrugDrugCategory" ADD CONSTRAINT "PK_DrugDrugCategory" PRIMARY KEY ("DrugCategoriesId", "DrugsId");

-- ----------------------------
-- Indexes structure for table Drugs
-- ----------------------------
CREATE INDEX "IX_Drugs_CreatedById" ON "public"."Drugs" USING btree (
  "CreatedById" "pg_catalog"."int4_ops" ASC NULLS LAST
);
CREATE INDEX "IX_Drugs_SimilarDrugsId" ON "public"."Drugs" USING btree (
  "SimilarDrugsId" "pg_catalog"."int4_ops" ASC NULLS LAST
);

-- ----------------------------
-- Primary Key structure for table Drugs
-- ----------------------------
ALTER TABLE "public"."Drugs" ADD CONSTRAINT "PK_Drugs" PRIMARY KEY ("Id");

-- ----------------------------
-- Indexes structure for table ReminderLogs
-- ----------------------------
CREATE INDEX "IX_ReminderLogs_ReminderId" ON "public"."ReminderLogs" USING btree (
  "ReminderId" "pg_catalog"."int4_ops" ASC NULLS LAST
);

-- ----------------------------
-- Primary Key structure for table ReminderLogs
-- ----------------------------
ALTER TABLE "public"."ReminderLogs" ADD CONSTRAINT "PK_ReminderLogs" PRIMARY KEY ("Id");

-- ----------------------------
-- Indexes structure for table Reminders
-- ----------------------------
CREATE INDEX "IX_Reminders_CreatedById" ON "public"."Reminders" USING btree (
  "CreatedById" "pg_catalog"."int4_ops" ASC NULLS LAST
);

-- ----------------------------
-- Primary Key structure for table Reminders
-- ----------------------------
ALTER TABLE "public"."Reminders" ADD CONSTRAINT "PK_Reminders" PRIMARY KEY ("Id");

-- ----------------------------
-- Primary Key structure for table SimilarDrugs
-- ----------------------------
ALTER TABLE "public"."SimilarDrugs" ADD CONSTRAINT "PK_SimilarDrugs" PRIMARY KEY ("Id");

-- ----------------------------
-- Indexes structure for table Therapies
-- ----------------------------
CREATE INDEX "IX_Therapies_AssingedToId" ON "public"."Therapies" USING btree (
  "AssingedToId" "pg_catalog"."int4_ops" ASC NULLS LAST
);
CREATE INDEX "IX_Therapies_CreatedById" ON "public"."Therapies" USING btree (
  "CreatedById" "pg_catalog"."int4_ops" ASC NULLS LAST
);

-- ----------------------------
-- Primary Key structure for table Therapies
-- ----------------------------
ALTER TABLE "public"."Therapies" ADD CONSTRAINT "PK_Therapies" PRIMARY KEY ("Id");

-- ----------------------------
-- Indexes structure for table TranslatedActiveElement
-- ----------------------------
CREATE INDEX "IX_TranslatedActiveElement_ActiveElementId" ON "public"."TranslatedActiveElement" USING btree (
  "ActiveElementId" "pg_catalog"."int4_ops" ASC NULLS LAST
);
CREATE INDEX "IX_TranslatedActiveElement_CreatedById" ON "public"."TranslatedActiveElement" USING btree (
  "CreatedById" "pg_catalog"."int4_ops" ASC NULLS LAST
);
CREATE UNIQUE INDEX "IX_TranslatedActiveElement_Language_ActiveElementId" ON "public"."TranslatedActiveElement" USING btree (
  "Language" "pg_catalog"."int4_ops" ASC NULLS LAST,
  "ActiveElementId" "pg_catalog"."int4_ops" ASC NULLS LAST
);

-- ----------------------------
-- Primary Key structure for table TranslatedActiveElement
-- ----------------------------
ALTER TABLE "public"."TranslatedActiveElement" ADD CONSTRAINT "PK_TranslatedActiveElement" PRIMARY KEY ("Id");

-- ----------------------------
-- Indexes structure for table TranslatedCourse
-- ----------------------------
CREATE INDEX "IX_TranslatedCourse_CourseId" ON "public"."TranslatedCourse" USING btree (
  "CourseId" "pg_catalog"."int4_ops" ASC NULLS LAST
);
CREATE INDEX "IX_TranslatedCourse_CreatedById" ON "public"."TranslatedCourse" USING btree (
  "CreatedById" "pg_catalog"."int4_ops" ASC NULLS LAST
);
CREATE UNIQUE INDEX "IX_TranslatedCourse_Language_CourseId" ON "public"."TranslatedCourse" USING btree (
  "Language" "pg_catalog"."int4_ops" ASC NULLS LAST,
  "CourseId" "pg_catalog"."int4_ops" ASC NULLS LAST
);

-- ----------------------------
-- Primary Key structure for table TranslatedCourse
-- ----------------------------
ALTER TABLE "public"."TranslatedCourse" ADD CONSTRAINT "PK_TranslatedCourse" PRIMARY KEY ("Id");

-- ----------------------------
-- Indexes structure for table TranslatedCourseGroup
-- ----------------------------
CREATE INDEX "IX_TranslatedCourseGroup_CourseGroupId" ON "public"."TranslatedCourseGroup" USING btree (
  "CourseGroupId" "pg_catalog"."int4_ops" ASC NULLS LAST
);
CREATE INDEX "IX_TranslatedCourseGroup_CreatedById" ON "public"."TranslatedCourseGroup" USING btree (
  "CreatedById" "pg_catalog"."int4_ops" ASC NULLS LAST
);
CREATE UNIQUE INDEX "IX_TranslatedCourseGroup_Language_CourseGroupId" ON "public"."TranslatedCourseGroup" USING btree (
  "Language" "pg_catalog"."int4_ops" ASC NULLS LAST,
  "CourseGroupId" "pg_catalog"."int4_ops" ASC NULLS LAST
);

-- ----------------------------
-- Primary Key structure for table TranslatedCourseGroup
-- ----------------------------
ALTER TABLE "public"."TranslatedCourseGroup" ADD CONSTRAINT "PK_TranslatedCourseGroup" PRIMARY KEY ("Id");

-- ----------------------------
-- Indexes structure for table TranslatedDosingFrequency
-- ----------------------------
CREATE INDEX "IX_TranslatedDosingFrequency_CreatedById" ON "public"."TranslatedDosingFrequency" USING btree (
  "CreatedById" "pg_catalog"."int4_ops" ASC NULLS LAST
);
CREATE INDEX "IX_TranslatedDosingFrequency_DosingFrequencyId" ON "public"."TranslatedDosingFrequency" USING btree (
  "DosingFrequencyId" "pg_catalog"."int4_ops" ASC NULLS LAST
);

-- ----------------------------
-- Primary Key structure for table TranslatedDosingFrequency
-- ----------------------------
ALTER TABLE "public"."TranslatedDosingFrequency" ADD CONSTRAINT "PK_TranslatedDosingFrequency" PRIMARY KEY ("Id");

-- ----------------------------
-- Indexes structure for table TranslatedDosingFrequencyReminder
-- ----------------------------
CREATE INDEX "IX_TranslatedDosingFrequencyReminder_CreatedById" ON "public"."TranslatedDosingFrequencyReminder" USING btree (
  "CreatedById" "pg_catalog"."int4_ops" ASC NULLS LAST
);
CREATE INDEX "IX_TranslatedDosingFrequencyReminder_DosageRecommendationId" ON "public"."TranslatedDosingFrequencyReminder" USING btree (
  "DosageRecommendationId" "pg_catalog"."int4_ops" ASC NULLS LAST
);
CREATE UNIQUE INDEX "IX_TranslatedDosingFrequencyReminder_Language_DosageRecommenda~" ON "public"."TranslatedDosingFrequencyReminder" USING btree (
  "Language" "pg_catalog"."int4_ops" ASC NULLS LAST,
  "DosageRecommendationId" "pg_catalog"."int4_ops" ASC NULLS LAST
);

-- ----------------------------
-- Primary Key structure for table TranslatedDosingFrequencyReminder
-- ----------------------------
ALTER TABLE "public"."TranslatedDosingFrequencyReminder" ADD CONSTRAINT "PK_TranslatedDosingFrequencyReminder" PRIMARY KEY ("Id");

-- ----------------------------
-- Indexes structure for table TranslatedDrugs
-- ----------------------------
CREATE INDEX "IX_TranslatedDrugs_CreatedById" ON "public"."TranslatedDrugs" USING btree (
  "CreatedById" "pg_catalog"."int4_ops" ASC NULLS LAST
);
CREATE INDEX "IX_TranslatedDrugs_DrugId" ON "public"."TranslatedDrugs" USING btree (
  "DrugId" "pg_catalog"."int4_ops" ASC NULLS LAST
);
CREATE UNIQUE INDEX "IX_TranslatedDrugs_Language_DrugId" ON "public"."TranslatedDrugs" USING btree (
  "Language" "pg_catalog"."int4_ops" ASC NULLS LAST,
  "DrugId" "pg_catalog"."int4_ops" ASC NULLS LAST
);

-- ----------------------------
-- Primary Key structure for table TranslatedDrugs
-- ----------------------------
ALTER TABLE "public"."TranslatedDrugs" ADD CONSTRAINT "PK_TranslatedDrugs" PRIMARY KEY ("Id");

-- ----------------------------
-- Indexes structure for table TranslatedDrugsCategory
-- ----------------------------
CREATE INDEX "IX_TranslatedDrugsCategory_CreatedById" ON "public"."TranslatedDrugsCategory" USING btree (
  "CreatedById" "pg_catalog"."int4_ops" ASC NULLS LAST
);
CREATE INDEX "IX_TranslatedDrugsCategory_DrugCategoryId" ON "public"."TranslatedDrugsCategory" USING btree (
  "DrugCategoryId" "pg_catalog"."int4_ops" ASC NULLS LAST
);
CREATE UNIQUE INDEX "IX_TranslatedDrugsCategory_Language_DrugCategoryId" ON "public"."TranslatedDrugsCategory" USING btree (
  "Language" "pg_catalog"."int4_ops" ASC NULLS LAST,
  "DrugCategoryId" "pg_catalog"."int4_ops" ASC NULLS LAST
);

-- ----------------------------
-- Primary Key structure for table TranslatedDrugsCategory
-- ----------------------------
ALTER TABLE "public"."TranslatedDrugsCategory" ADD CONSTRAINT "PK_TranslatedDrugsCategory" PRIMARY KEY ("Id");

-- ----------------------------
-- Indexes structure for table TranslatedTherapy
-- ----------------------------
CREATE INDEX "IX_TranslatedTherapy_CreatedById" ON "public"."TranslatedTherapy" USING btree (
  "CreatedById" "pg_catalog"."int4_ops" ASC NULLS LAST
);
CREATE UNIQUE INDEX "IX_TranslatedTherapy_Language_TherapyId" ON "public"."TranslatedTherapy" USING btree (
  "Language" "pg_catalog"."int4_ops" ASC NULLS LAST,
  "TherapyId" "pg_catalog"."int4_ops" ASC NULLS LAST
);
CREATE INDEX "IX_TranslatedTherapy_TherapyId" ON "public"."TranslatedTherapy" USING btree (
  "TherapyId" "pg_catalog"."int4_ops" ASC NULLS LAST
);

-- ----------------------------
-- Primary Key structure for table TranslatedTherapy
-- ----------------------------
ALTER TABLE "public"."TranslatedTherapy" ADD CONSTRAINT "PK_TranslatedTherapy" PRIMARY KEY ("Id");

-- ----------------------------
-- Indexes structure for table UserDoctorRelationLogs
-- ----------------------------
CREATE INDEX "IX_UserDoctorRelationLogs_UserDoctorRelationId" ON "public"."UserDoctorRelationLogs" USING btree (
  "UserDoctorRelationId" "pg_catalog"."int4_ops" ASC NULLS LAST
);

-- ----------------------------
-- Primary Key structure for table UserDoctorRelationLogs
-- ----------------------------
ALTER TABLE "public"."UserDoctorRelationLogs" ADD CONSTRAINT "PK_UserDoctorRelationLogs" PRIMARY KEY ("Id");

-- ----------------------------
-- Indexes structure for table UserDoctorRelations
-- ----------------------------
CREATE INDEX "IX_UserDoctorRelations_CreatedById" ON "public"."UserDoctorRelations" USING btree (
  "CreatedById" "pg_catalog"."int4_ops" ASC NULLS LAST
);
CREATE INDEX "IX_UserDoctorRelations_DoctorId" ON "public"."UserDoctorRelations" USING btree (
  "DoctorId" "pg_catalog"."int4_ops" ASC NULLS LAST
);

-- ----------------------------
-- Primary Key structure for table UserDoctorRelations
-- ----------------------------
ALTER TABLE "public"."UserDoctorRelations" ADD CONSTRAINT "PK_UserDoctorRelations" PRIMARY KEY ("Id");

-- ----------------------------
-- Primary Key structure for table __EFMigrationsHistory
-- ----------------------------
ALTER TABLE "public"."__EFMigrationsHistory" ADD CONSTRAINT "PK___EFMigrationsHistory" PRIMARY KEY ("MigrationId");

-- ----------------------------
-- Foreign Keys structure for table ActiveElements
-- ----------------------------
ALTER TABLE "public"."ActiveElements" ADD CONSTRAINT "FK_ActiveElements_AspNetUsers_CreatedById" FOREIGN KEY ("CreatedById") REFERENCES "public"."AspNetUsers" ("Id") ON DELETE NO ACTION ON UPDATE NO ACTION;
ALTER TABLE "public"."ActiveElements" ADD CONSTRAINT "FK_ActiveElements_Drugs_DrugId" FOREIGN KEY ("DrugId") REFERENCES "public"."Drugs" ("Id") ON DELETE CASCADE ON UPDATE NO ACTION;

-- ----------------------------
-- Foreign Keys structure for table AspNetRoleClaims
-- ----------------------------
ALTER TABLE "public"."AspNetRoleClaims" ADD CONSTRAINT "FK_AspNetRoleClaims_AspNetRoles_RoleId" FOREIGN KEY ("RoleId") REFERENCES "public"."AspNetRoles" ("Id") ON DELETE CASCADE ON UPDATE NO ACTION;

-- ----------------------------
-- Foreign Keys structure for table AspNetUserClaims
-- ----------------------------
ALTER TABLE "public"."AspNetUserClaims" ADD CONSTRAINT "FK_AspNetUserClaims_AspNetUsers_UserId" FOREIGN KEY ("UserId") REFERENCES "public"."AspNetUsers" ("Id") ON DELETE CASCADE ON UPDATE NO ACTION;

-- ----------------------------
-- Foreign Keys structure for table AspNetUserLogins
-- ----------------------------
ALTER TABLE "public"."AspNetUserLogins" ADD CONSTRAINT "FK_AspNetUserLogins_AspNetUsers_UserId" FOREIGN KEY ("UserId") REFERENCES "public"."AspNetUsers" ("Id") ON DELETE CASCADE ON UPDATE NO ACTION;

-- ----------------------------
-- Foreign Keys structure for table AspNetUserRoles
-- ----------------------------
ALTER TABLE "public"."AspNetUserRoles" ADD CONSTRAINT "FK_AspNetUserRoles_AspNetRoles_RoleId" FOREIGN KEY ("RoleId") REFERENCES "public"."AspNetRoles" ("Id") ON DELETE CASCADE ON UPDATE NO ACTION;
ALTER TABLE "public"."AspNetUserRoles" ADD CONSTRAINT "FK_AspNetUserRoles_AspNetUsers_UserId" FOREIGN KEY ("UserId") REFERENCES "public"."AspNetUsers" ("Id") ON DELETE CASCADE ON UPDATE NO ACTION;

-- ----------------------------
-- Foreign Keys structure for table AspNetUserTokens
-- ----------------------------
ALTER TABLE "public"."AspNetUserTokens" ADD CONSTRAINT "FK_AspNetUserTokens_AspNetUsers_UserId" FOREIGN KEY ("UserId") REFERENCES "public"."AspNetUsers" ("Id") ON DELETE CASCADE ON UPDATE NO ACTION;

-- ----------------------------
-- Foreign Keys structure for table CourseGroup
-- ----------------------------
ALTER TABLE "public"."CourseGroup" ADD CONSTRAINT "FK_CourseGroup_AspNetUsers_CreatedById" FOREIGN KEY ("CreatedById") REFERENCES "public"."AspNetUsers" ("Id") ON DELETE NO ACTION ON UPDATE NO ACTION;

-- ----------------------------
-- Foreign Keys structure for table CourseSettings
-- ----------------------------
ALTER TABLE "public"."CourseSettings" ADD CONSTRAINT "FK_CourseSettings_AspNetUsers_CreatedById" FOREIGN KEY ("CreatedById") REFERENCES "public"."AspNetUsers" ("Id") ON DELETE NO ACTION ON UPDATE NO ACTION;
ALTER TABLE "public"."CourseSettings" ADD CONSTRAINT "FK_CourseSettings_Courses_CourseId" FOREIGN KEY ("CourseId") REFERENCES "public"."Courses" ("Id") ON DELETE CASCADE ON UPDATE NO ACTION;

-- ----------------------------
-- Foreign Keys structure for table Courses
-- ----------------------------
ALTER TABLE "public"."Courses" ADD CONSTRAINT "FK_Courses_AspNetUsers_CreatedById" FOREIGN KEY ("CreatedById") REFERENCES "public"."AspNetUsers" ("Id") ON DELETE NO ACTION ON UPDATE NO ACTION;
ALTER TABLE "public"."Courses" ADD CONSTRAINT "FK_Courses_CourseGroup_CourseGroupID" FOREIGN KEY ("CourseGroupID") REFERENCES "public"."CourseGroup" ("Id") ON DELETE NO ACTION ON UPDATE NO ACTION;
ALTER TABLE "public"."Courses" ADD CONSTRAINT "FK_Courses_Therapies_TherapyId" FOREIGN KEY ("TherapyId") REFERENCES "public"."Therapies" ("Id") ON DELETE NO ACTION ON UPDATE NO ACTION;

-- ----------------------------
-- Foreign Keys structure for table DosageLogs
-- ----------------------------
ALTER TABLE "public"."DosageLogs" ADD CONSTRAINT "FK_DosageLogs_AspNetUsers_CreatedById" FOREIGN KEY ("CreatedById") REFERENCES "public"."AspNetUsers" ("Id") ON DELETE NO ACTION ON UPDATE NO ACTION;
ALTER TABLE "public"."DosageLogs" ADD CONSTRAINT "FK_DosageLogs_DosingFrequencyReminders_DosageRecommendationId" FOREIGN KEY ("DosageRecommendationId") REFERENCES "public"."DosingFrequencyReminders" ("Id") ON DELETE CASCADE ON UPDATE NO ACTION;

-- ----------------------------
-- Foreign Keys structure for table DosingFrequencies
-- ----------------------------
ALTER TABLE "public"."DosingFrequencies" ADD CONSTRAINT "FK_DosingFrequencies_AspNetUsers_CreatedById" FOREIGN KEY ("CreatedById") REFERENCES "public"."AspNetUsers" ("Id") ON DELETE NO ACTION ON UPDATE NO ACTION;
ALTER TABLE "public"."DosingFrequencies" ADD CONSTRAINT "FK_DosingFrequencies_Courses_CourseId" FOREIGN KEY ("CourseId") REFERENCES "public"."Courses" ("Id") ON DELETE CASCADE ON UPDATE NO ACTION;
ALTER TABLE "public"."DosingFrequencies" ADD CONSTRAINT "FK_DosingFrequencies_Drugs_DrugId" FOREIGN KEY ("DrugId") REFERENCES "public"."Drugs" ("Id") ON DELETE CASCADE ON UPDATE NO ACTION;

-- ----------------------------
-- Foreign Keys structure for table DosingFrequencyReminders
-- ----------------------------
ALTER TABLE "public"."DosingFrequencyReminders" ADD CONSTRAINT "FK_DosingFrequencyReminders_AspNetUsers_CreatedById" FOREIGN KEY ("CreatedById") REFERENCES "public"."AspNetUsers" ("Id") ON DELETE NO ACTION ON UPDATE NO ACTION;
ALTER TABLE "public"."DosingFrequencyReminders" ADD CONSTRAINT "FK_DosingFrequencyReminders_DosingFrequencies_DosingFrequencyId" FOREIGN KEY ("DosingFrequencyId") REFERENCES "public"."DosingFrequencies" ("Id") ON DELETE CASCADE ON UPDATE NO ACTION;
ALTER TABLE "public"."DosingFrequencyReminders" ADD CONSTRAINT "FK_DosingFrequencyReminders_Reminders_ReminderId" FOREIGN KEY ("ReminderId") REFERENCES "public"."Reminders" ("Id") ON DELETE CASCADE ON UPDATE NO ACTION;

-- ----------------------------
-- Foreign Keys structure for table DrugCategories
-- ----------------------------
ALTER TABLE "public"."DrugCategories" ADD CONSTRAINT "FK_DrugCategories_AspNetUsers_CreatedById" FOREIGN KEY ("CreatedById") REFERENCES "public"."AspNetUsers" ("Id") ON DELETE NO ACTION ON UPDATE NO ACTION;

-- ----------------------------
-- Foreign Keys structure for table DrugDrugCategory
-- ----------------------------
ALTER TABLE "public"."DrugDrugCategory" ADD CONSTRAINT "FK_DrugDrugCategory_DrugCategories_DrugCategoriesId" FOREIGN KEY ("DrugCategoriesId") REFERENCES "public"."DrugCategories" ("Id") ON DELETE CASCADE ON UPDATE NO ACTION;
ALTER TABLE "public"."DrugDrugCategory" ADD CONSTRAINT "FK_DrugDrugCategory_Drugs_DrugsId" FOREIGN KEY ("DrugsId") REFERENCES "public"."Drugs" ("Id") ON DELETE CASCADE ON UPDATE NO ACTION;

-- ----------------------------
-- Foreign Keys structure for table Drugs
-- ----------------------------
ALTER TABLE "public"."Drugs" ADD CONSTRAINT "FK_Drugs_AspNetUsers_CreatedById" FOREIGN KEY ("CreatedById") REFERENCES "public"."AspNetUsers" ("Id") ON DELETE NO ACTION ON UPDATE NO ACTION;
ALTER TABLE "public"."Drugs" ADD CONSTRAINT "FK_Drugs_SimilarDrugs_SimilarDrugsId" FOREIGN KEY ("SimilarDrugsId") REFERENCES "public"."SimilarDrugs" ("Id") ON DELETE CASCADE ON UPDATE NO ACTION;

-- ----------------------------
-- Foreign Keys structure for table ReminderLogs
-- ----------------------------
ALTER TABLE "public"."ReminderLogs" ADD CONSTRAINT "FK_ReminderLogs_Reminders_ReminderId" FOREIGN KEY ("ReminderId") REFERENCES "public"."Reminders" ("Id") ON DELETE CASCADE ON UPDATE NO ACTION;

-- ----------------------------
-- Foreign Keys structure for table Reminders
-- ----------------------------
ALTER TABLE "public"."Reminders" ADD CONSTRAINT "FK_Reminders_AspNetUsers_CreatedById" FOREIGN KEY ("CreatedById") REFERENCES "public"."AspNetUsers" ("Id") ON DELETE NO ACTION ON UPDATE NO ACTION;

-- ----------------------------
-- Foreign Keys structure for table Therapies
-- ----------------------------
ALTER TABLE "public"."Therapies" ADD CONSTRAINT "FK_Therapies_AspNetUsers_AssingedToId" FOREIGN KEY ("AssingedToId") REFERENCES "public"."AspNetUsers" ("Id") ON DELETE NO ACTION ON UPDATE NO ACTION;
ALTER TABLE "public"."Therapies" ADD CONSTRAINT "FK_Therapies_AspNetUsers_CreatedById" FOREIGN KEY ("CreatedById") REFERENCES "public"."AspNetUsers" ("Id") ON DELETE NO ACTION ON UPDATE NO ACTION;

-- ----------------------------
-- Foreign Keys structure for table TranslatedActiveElement
-- ----------------------------
ALTER TABLE "public"."TranslatedActiveElement" ADD CONSTRAINT "FK_TranslatedActiveElement_ActiveElements_ActiveElementId" FOREIGN KEY ("ActiveElementId") REFERENCES "public"."ActiveElements" ("Id") ON DELETE CASCADE ON UPDATE NO ACTION;
ALTER TABLE "public"."TranslatedActiveElement" ADD CONSTRAINT "FK_TranslatedActiveElement_AspNetUsers_CreatedById" FOREIGN KEY ("CreatedById") REFERENCES "public"."AspNetUsers" ("Id") ON DELETE NO ACTION ON UPDATE NO ACTION;

-- ----------------------------
-- Foreign Keys structure for table TranslatedCourse
-- ----------------------------
ALTER TABLE "public"."TranslatedCourse" ADD CONSTRAINT "FK_TranslatedCourse_AspNetUsers_CreatedById" FOREIGN KEY ("CreatedById") REFERENCES "public"."AspNetUsers" ("Id") ON DELETE NO ACTION ON UPDATE NO ACTION;
ALTER TABLE "public"."TranslatedCourse" ADD CONSTRAINT "FK_TranslatedCourse_Courses_CourseId" FOREIGN KEY ("CourseId") REFERENCES "public"."Courses" ("Id") ON DELETE CASCADE ON UPDATE NO ACTION;

-- ----------------------------
-- Foreign Keys structure for table TranslatedCourseGroup
-- ----------------------------
ALTER TABLE "public"."TranslatedCourseGroup" ADD CONSTRAINT "FK_TranslatedCourseGroup_AspNetUsers_CreatedById" FOREIGN KEY ("CreatedById") REFERENCES "public"."AspNetUsers" ("Id") ON DELETE NO ACTION ON UPDATE NO ACTION;
ALTER TABLE "public"."TranslatedCourseGroup" ADD CONSTRAINT "FK_TranslatedCourseGroup_CourseGroup_CourseGroupId" FOREIGN KEY ("CourseGroupId") REFERENCES "public"."CourseGroup" ("Id") ON DELETE CASCADE ON UPDATE NO ACTION;

-- ----------------------------
-- Foreign Keys structure for table TranslatedDosingFrequency
-- ----------------------------
ALTER TABLE "public"."TranslatedDosingFrequency" ADD CONSTRAINT "FK_TranslatedDosingFrequency_AspNetUsers_CreatedById" FOREIGN KEY ("CreatedById") REFERENCES "public"."AspNetUsers" ("Id") ON DELETE NO ACTION ON UPDATE NO ACTION;
ALTER TABLE "public"."TranslatedDosingFrequency" ADD CONSTRAINT "FK_TranslatedDosingFrequency_DosingFrequencies_DosingFrequency~" FOREIGN KEY ("DosingFrequencyId") REFERENCES "public"."DosingFrequencies" ("Id") ON DELETE CASCADE ON UPDATE NO ACTION;

-- ----------------------------
-- Foreign Keys structure for table TranslatedDosingFrequencyReminder
-- ----------------------------
ALTER TABLE "public"."TranslatedDosingFrequencyReminder" ADD CONSTRAINT "FK_TranslatedDosingFrequencyReminder_AspNetUsers_CreatedById" FOREIGN KEY ("CreatedById") REFERENCES "public"."AspNetUsers" ("Id") ON DELETE NO ACTION ON UPDATE NO ACTION;
ALTER TABLE "public"."TranslatedDosingFrequencyReminder" ADD CONSTRAINT "FK_TranslatedDosingFrequencyReminder_DosingFrequencyReminders_~" FOREIGN KEY ("DosageRecommendationId") REFERENCES "public"."DosingFrequencyReminders" ("Id") ON DELETE CASCADE ON UPDATE NO ACTION;

-- ----------------------------
-- Foreign Keys structure for table TranslatedDrugs
-- ----------------------------
ALTER TABLE "public"."TranslatedDrugs" ADD CONSTRAINT "FK_TranslatedDrugs_AspNetUsers_CreatedById" FOREIGN KEY ("CreatedById") REFERENCES "public"."AspNetUsers" ("Id") ON DELETE NO ACTION ON UPDATE NO ACTION;
ALTER TABLE "public"."TranslatedDrugs" ADD CONSTRAINT "FK_TranslatedDrugs_Drugs_DrugId" FOREIGN KEY ("DrugId") REFERENCES "public"."Drugs" ("Id") ON DELETE CASCADE ON UPDATE NO ACTION;

-- ----------------------------
-- Foreign Keys structure for table TranslatedDrugsCategory
-- ----------------------------
ALTER TABLE "public"."TranslatedDrugsCategory" ADD CONSTRAINT "FK_TranslatedDrugsCategory_AspNetUsers_CreatedById" FOREIGN KEY ("CreatedById") REFERENCES "public"."AspNetUsers" ("Id") ON DELETE NO ACTION ON UPDATE NO ACTION;
ALTER TABLE "public"."TranslatedDrugsCategory" ADD CONSTRAINT "FK_TranslatedDrugsCategory_DrugCategories_DrugCategoryId" FOREIGN KEY ("DrugCategoryId") REFERENCES "public"."DrugCategories" ("Id") ON DELETE CASCADE ON UPDATE NO ACTION;

-- ----------------------------
-- Foreign Keys structure for table TranslatedTherapy
-- ----------------------------
ALTER TABLE "public"."TranslatedTherapy" ADD CONSTRAINT "FK_TranslatedTherapy_AspNetUsers_CreatedById" FOREIGN KEY ("CreatedById") REFERENCES "public"."AspNetUsers" ("Id") ON DELETE NO ACTION ON UPDATE NO ACTION;
ALTER TABLE "public"."TranslatedTherapy" ADD CONSTRAINT "FK_TranslatedTherapy_Therapies_TherapyId" FOREIGN KEY ("TherapyId") REFERENCES "public"."Therapies" ("Id") ON DELETE CASCADE ON UPDATE NO ACTION;

-- ----------------------------
-- Foreign Keys structure for table UserDoctorRelationLogs
-- ----------------------------
ALTER TABLE "public"."UserDoctorRelationLogs" ADD CONSTRAINT "FK_UserDoctorRelationLogs_UserDoctorRelations_UserDoctorRelati~" FOREIGN KEY ("UserDoctorRelationId") REFERENCES "public"."UserDoctorRelations" ("Id") ON DELETE CASCADE ON UPDATE NO ACTION;

-- ----------------------------
-- Foreign Keys structure for table UserDoctorRelations
-- ----------------------------
ALTER TABLE "public"."UserDoctorRelations" ADD CONSTRAINT "FK_UserDoctorRelations_AspNetUsers_CreatedById" FOREIGN KEY ("CreatedById") REFERENCES "public"."AspNetUsers" ("Id") ON DELETE NO ACTION ON UPDATE NO ACTION;
ALTER TABLE "public"."UserDoctorRelations" ADD CONSTRAINT "FK_UserDoctorRelations_AspNetUsers_DoctorId" FOREIGN KEY ("DoctorId") REFERENCES "public"."AspNetUsers" ("Id") ON DELETE NO ACTION ON UPDATE NO ACTION;
