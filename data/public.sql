/*
 Navicat Premium Data Transfer

 Source Server         : medicineDB
 Source Server Type    : PostgreSQL
 Source Server Version : 140001
 Source Host           : localhost:5432
 Source Catalog        : medicines
 Source Schema         : public

 Target Server Type    : PostgreSQL
 Target Server Version : 140001
 File Encoding         : 65001

 Date: 01/10/2023 15:20:03
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
-- Sequence structure for UserMedicineWorkerLogs_Id_seq
-- ----------------------------
DROP SEQUENCE IF EXISTS "public"."UserMedicineWorkerLogs_Id_seq";
CREATE SEQUENCE "public"."UserMedicineWorkerLogs_Id_seq" 
INCREMENT 1
MINVALUE  1
MAXVALUE 2147483647
START 1
CACHE 1;

-- ----------------------------
-- Sequence structure for UserMedicineWorkers_Id_seq
-- ----------------------------
DROP SEQUENCE IF EXISTS "public"."UserMedicineWorkers_Id_seq";
CREATE SEQUENCE "public"."UserMedicineWorkers_Id_seq" 
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
  "UserId" int4
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
INSERT INTO "public"."AspNetRoles" VALUES (1, 'User', 'USER', NULL);
INSERT INTO "public"."AspNetRoles" VALUES (2, 'MedicineWorker', 'MEDICINEWORKER', NULL);

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
INSERT INTO "public"."AspNetUserRoles" VALUES (1, 1);

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
  "Birthday" timestamptz(6),
  "Sex" int4,
  "Language" int4 NOT NULL,
  "TimeZone" text COLLATE "pg_catalog"."default" NOT NULL,
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
INSERT INTO "public"."AspNetUsers" VALUES (1, '2023-10-01 12:55:58.060794+00', NULL, 0, '(UTC) Coordinated Universal Time', 'mauguzun@gmail.com', 'MAUGUZUN@GMAIL.COM', 'mauguzun@gmail.com', 'MAUGUZUN@GMAIL.COM', 't', 'AQAAAAIAAYagAAAAED0g1p9m48toL9YuHto4I89dpeQwfoR+5i51HGxPij0eelBh0JZGljawO8ReaTLtQA==', 'P6TLTI3B7MGYSZZ4CQ5LSP7XZXG2ZB3X', '93de9712-8377-4c3b-893a-9c86f0acdb92', NULL, 'f', 'f', NULL, 't', 0);

-- ----------------------------
-- Table structure for CourseGroup
-- ----------------------------
DROP TABLE IF EXISTS "public"."CourseGroup";
CREATE TABLE "public"."CourseGroup" (
  "Id" int4 NOT NULL DEFAULT nextval('"TransatedEntityWithDescriptionSequence"'::regclass),
  "Title" text COLLATE "pg_catalog"."default",
  "Description" text COLLATE "pg_catalog"."default",
  "CreatedAt" timestamptz(6),
  "UserId" int4,
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
  "UserId" int4
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
  "TherapyId" int4 NOT NULL,
  "CourseGroupID" int4,
  "CourseType" int4 NOT NULL,
  "CreatedAt" timestamptz(6),
  "UserId" int4
)
;

-- ----------------------------
-- Records of Courses
-- ----------------------------
INSERT INTO "public"."Courses" VALUES (1, 1, NULL, 0, '2023-10-01 12:56:15.734827+00', 1);

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
  "UserId" int4
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
  "UserId" int4
)
;

-- ----------------------------
-- Records of DosingFrequencies
-- ----------------------------
INSERT INTO "public"."DosingFrequencies" VALUES (1, 1, 1, 10, 2, '2023-10-01 12:56:15.735336+00', NULL);

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
  "UserId" int4
)
;

-- ----------------------------
-- Records of DosingFrequencyReminders
-- ----------------------------
INSERT INTO "public"."DosingFrequencyReminders" VALUES (1, 'Title', 'before eat', 1, 1, 1, '2023-10-01 12:56:15.531715+00', NULL);

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
  "UserId" int4
)
;

-- ----------------------------
-- Records of DrugCategories
-- ----------------------------
INSERT INTO "public"."DrugCategories" VALUES (1, '2023-10-01 12:56:13.685748+00', NULL);
INSERT INTO "public"."DrugCategories" VALUES (2, '2023-10-01 12:56:13.685783+00', NULL);
INSERT INTO "public"."DrugCategories" VALUES (3, '2023-10-01 12:56:13.685787+00', NULL);
INSERT INTO "public"."DrugCategories" VALUES (4, '2023-10-01 12:56:13.685791+00', NULL);

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
INSERT INTO "public"."DrugDrugCategory" VALUES (2, 1);
INSERT INTO "public"."DrugDrugCategory" VALUES (2, 2);
INSERT INTO "public"."DrugDrugCategory" VALUES (3, 1);
INSERT INTO "public"."DrugDrugCategory" VALUES (3, 2);
INSERT INTO "public"."DrugDrugCategory" VALUES (4, 1);
INSERT INTO "public"."DrugDrugCategory" VALUES (4, 2);

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
  "UserId" int4
)
;

-- ----------------------------
-- Records of Drugs
-- ----------------------------
INSERT INTO "public"."Drugs" VALUES (1, 'Drug LatinName 0', 1, 3, '2023-10-01 12:56:14.632526+00', 1);
INSERT INTO "public"."Drugs" VALUES (2, 'Drug LatinName 1', 2, 3, '2023-10-01 12:56:14.633028+00', 1);

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
  "UserId" int4,
  "Title" text COLLATE "pg_catalog"."default",
  "Descrptioin" text COLLATE "pg_catalog"."default"
)
;

-- ----------------------------
-- Records of Reminders
-- ----------------------------
INSERT INTO "public"."Reminders" VALUES (1, '07:20', '2023-10-01 12:56:15.378776+00', 1, 'Morning Reminder', NULL);
INSERT INTO "public"."Reminders" VALUES (2, '0:20', '2023-10-01 12:56:15.444974+00', 1, 'Evning Reminder', NULL);

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
INSERT INTO "public"."SimilarDrugs" VALUES (1, '2023-10-01 12:56:14.632526+00');
INSERT INTO "public"."SimilarDrugs" VALUES (2, '2023-10-01 12:56:14.633027+00');
INSERT INTO "public"."SimilarDrugs" VALUES (3, '2023-10-01 12:56:14.631964+00');

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
  "UserId" int4 NOT NULL,
  "Status" int4 NOT NULL,
  "Type" int4 NOT NULL,
  "CreatedAt" timestamptz(6)
)
;

-- ----------------------------
-- Records of Therapies
-- ----------------------------
INSERT INTO "public"."Therapies" VALUES (1, 1, 200, 1, '2023-10-01 12:56:15.733303+00');

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
  "UserId" int4,
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
  "UserId" int4,
  "Language" int4 NOT NULL
)
;

-- ----------------------------
-- Records of TranslatedCourse
-- ----------------------------
INSERT INTO "public"."TranslatedCourse" VALUES (15, 'AutoCrated2', 'AutoCreated2', 1, NULL, '2023-10-01 12:56:15.735128+00', NULL, 1);
INSERT INTO "public"."TranslatedCourse" VALUES (16, 'AutoCrated', 'AutoCreated', 1, NULL, '2023-10-01 12:56:15.735137+00', NULL, 0);

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
  "UserId" int4,
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
  "UserId" int4,
  "Language" int4 NOT NULL
)
;

-- ----------------------------
-- Records of TranslatedDosingFrequency
-- ----------------------------
INSERT INTO "public"."TranslatedDosingFrequency" VALUES (17, 'TranslatedDosingFrequency', 'TranslatedDosingFrequency Description', 1, '2023-10-01 12:56:15.775587+00', NULL, 0);
INSERT INTO "public"."TranslatedDosingFrequency" VALUES (18, 'TranslatedDosingFrequency', 'TranslatedDosingFrequency Description', 1, '2023-10-01 12:56:15.775605+00', NULL, 1);

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
  "UserId" int4,
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
  "UserId" int4,
  "Language" int4 NOT NULL
)
;

-- ----------------------------
-- Records of TranslatedDrugs
-- ----------------------------
INSERT INTO "public"."TranslatedDrugs" VALUES (9, '0 TranslatedDrugs  en ', '0 TranslatedDrugs  Description  en', 1, 'Use befor', '2023-10-01 12:56:14.632156+00', NULL, 0);
INSERT INTO "public"."TranslatedDrugs" VALUES (10, '0 TranslatedDrugs  lv ', '0 TranslatedDrugs  Description  lv', 1, 'Use befor', '2023-10-01 12:56:14.632288+00', NULL, 1);
INSERT INTO "public"."TranslatedDrugs" VALUES (11, '1 TranslatedDrugs  en ', '1 TranslatedDrugs  Description  en', 2, 'Use befor', '2023-10-01 12:56:14.63302+00', NULL, 0);
INSERT INTO "public"."TranslatedDrugs" VALUES (12, '1 TranslatedDrugs  lv ', '1 TranslatedDrugs  Description  lv', 2, 'Use befor', '2023-10-01 12:56:14.633025+00', NULL, 1);

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
  "UserId" int4,
  "Language" int4 NOT NULL
)
;

-- ----------------------------
-- Records of TranslatedDrugsCategory
-- ----------------------------
INSERT INTO "public"."TranslatedDrugsCategory" VALUES (1, '0 TranslatedActiveElement  en', '0 DrugCategory  Description  en', 1, '2023-10-01 12:56:13.684102+00', NULL, 0);
INSERT INTO "public"."TranslatedDrugsCategory" VALUES (2, '0 TranslatedActiveElement  lv', '0 DrugCategory  Description  lv', 1, '2023-10-01 12:56:13.684141+00', NULL, 1);
INSERT INTO "public"."TranslatedDrugsCategory" VALUES (3, '1 TranslatedActiveElement  en', '1 DrugCategory  Description  en', 2, '2023-10-01 12:56:13.685767+00', NULL, 0);
INSERT INTO "public"."TranslatedDrugsCategory" VALUES (4, '1 TranslatedActiveElement  lv', '1 DrugCategory  Description  lv', 2, '2023-10-01 12:56:13.685782+00', NULL, 1);
INSERT INTO "public"."TranslatedDrugsCategory" VALUES (5, '2 TranslatedActiveElement  en', '2 DrugCategory  Description  en', 3, '2023-10-01 12:56:13.685784+00', NULL, 0);
INSERT INTO "public"."TranslatedDrugsCategory" VALUES (6, '2 TranslatedActiveElement  lv', '2 DrugCategory  Description  lv', 3, '2023-10-01 12:56:13.685786+00', NULL, 1);
INSERT INTO "public"."TranslatedDrugsCategory" VALUES (7, '3 TranslatedActiveElement  en', '3 DrugCategory  Description  en', 4, '2023-10-01 12:56:13.685789+00', NULL, 0);
INSERT INTO "public"."TranslatedDrugsCategory" VALUES (8, '3 TranslatedActiveElement  lv', '3 DrugCategory  Description  lv', 4, '2023-10-01 12:56:13.68579+00', NULL, 1);

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
  "UserId" int4,
  "Language" int4 NOT NULL
)
;

-- ----------------------------
-- Records of TranslatedTherapy
-- ----------------------------
INSERT INTO "public"."TranslatedTherapy" VALUES (13, 'AutoCrated', 'AutoCreated', 1, '2023-10-01 12:56:15.734188+00', NULL, 0);
INSERT INTO "public"."TranslatedTherapy" VALUES (14, 'AutoCrated2', 'AutoCreated2', 1, '2023-10-01 12:56:15.734202+00', NULL, 1);

-- ----------------------------
-- Table structure for UserMedicineWorkerLogs
-- ----------------------------
DROP TABLE IF EXISTS "public"."UserMedicineWorkerLogs";
CREATE TABLE "public"."UserMedicineWorkerLogs" (
  "Id" int4 NOT NULL GENERATED BY DEFAULT AS IDENTITY (
INCREMENT 1
MINVALUE  1
MAXVALUE 2147483647
START 1
),
  "UserMedicineWorkerRelationStatus" int4 NOT NULL,
  "CreatedAt" timestamptz(6)
)
;

-- ----------------------------
-- Records of UserMedicineWorkerLogs
-- ----------------------------

-- ----------------------------
-- Table structure for UserMedicineWorkers
-- ----------------------------
DROP TABLE IF EXISTS "public"."UserMedicineWorkers";
CREATE TABLE "public"."UserMedicineWorkers" (
  "Id" int4 NOT NULL GENERATED BY DEFAULT AS IDENTITY (
INCREMENT 1
MINVALUE  1
MAXVALUE 2147483647
START 1
),
  "UserId" int4,
  "MedicineWorkerId" int4,
  "UserMedicineWorkerRelationStatus" int4 NOT NULL,
  "CreatedRequest" timestamptz(6),
  "AcceptedRequest" timestamptz(6),
  "CreatedAt" timestamptz(6)
)
;

-- ----------------------------
-- Records of UserMedicineWorkers
-- ----------------------------

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
INSERT INTO "public"."__EFMigrationsHistory" VALUES ('20231001125236_Init', '7.0.5');

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
SELECT setval('"public"."AspNetRoles_Id_seq"', 4, false);

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
SELECT setval('"public"."AspNetUsers_Id_seq"', 2, true);

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
SELECT setval('"public"."Courses_Id_seq"', 2, true);

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
SELECT setval('"public"."DosingFrequencies_Id_seq"', 2, true);

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
SELECT setval('"public"."DrugCategories_Id_seq"', 5, true);

-- ----------------------------
-- Alter sequences owned by
-- ----------------------------
ALTER SEQUENCE "public"."Drugs_Id_seq"
OWNED BY "public"."Drugs"."Id";
SELECT setval('"public"."Drugs_Id_seq"', 3, true);

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
SELECT setval('"public"."SimilarDrugs_Id_seq"', 4, true);

-- ----------------------------
-- Alter sequences owned by
-- ----------------------------
ALTER SEQUENCE "public"."Therapies_Id_seq"
OWNED BY "public"."Therapies"."Id";
SELECT setval('"public"."Therapies_Id_seq"', 2, true);

-- ----------------------------
-- Alter sequences owned by
-- ----------------------------
SELECT setval('"public"."TransatedEntityWithDescriptionSequence"', 19, true);

-- ----------------------------
-- Alter sequences owned by
-- ----------------------------
ALTER SEQUENCE "public"."TranslatedDosingFrequencyReminder_Id_seq"
OWNED BY "public"."TranslatedDosingFrequencyReminder"."Id";
SELECT setval('"public"."TranslatedDosingFrequencyReminder_Id_seq"', 2, false);

-- ----------------------------
-- Alter sequences owned by
-- ----------------------------
ALTER SEQUENCE "public"."UserMedicineWorkerLogs_Id_seq"
OWNED BY "public"."UserMedicineWorkerLogs"."Id";
SELECT setval('"public"."UserMedicineWorkerLogs_Id_seq"', 2, false);

-- ----------------------------
-- Alter sequences owned by
-- ----------------------------
ALTER SEQUENCE "public"."UserMedicineWorkers_Id_seq"
OWNED BY "public"."UserMedicineWorkers"."Id";
SELECT setval('"public"."UserMedicineWorkers_Id_seq"', 2, false);

-- ----------------------------
-- Indexes structure for table ActiveElements
-- ----------------------------
CREATE INDEX "IX_ActiveElements_DrugId" ON "public"."ActiveElements" USING btree (
  "DrugId" "pg_catalog"."int4_ops" ASC NULLS LAST
);
CREATE INDEX "IX_ActiveElements_UserId" ON "public"."ActiveElements" USING btree (
  "UserId" "pg_catalog"."int4_ops" ASC NULLS LAST
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
CREATE INDEX "IX_CourseGroup_UserId" ON "public"."CourseGroup" USING btree (
  "UserId" "pg_catalog"."int4_ops" ASC NULLS LAST
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
CREATE INDEX "IX_CourseSettings_UserId" ON "public"."CourseSettings" USING btree (
  "UserId" "pg_catalog"."int4_ops" ASC NULLS LAST
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
CREATE INDEX "IX_Courses_TherapyId" ON "public"."Courses" USING btree (
  "TherapyId" "pg_catalog"."int4_ops" ASC NULLS LAST
);
CREATE INDEX "IX_Courses_UserId" ON "public"."Courses" USING btree (
  "UserId" "pg_catalog"."int4_ops" ASC NULLS LAST
);

-- ----------------------------
-- Primary Key structure for table Courses
-- ----------------------------
ALTER TABLE "public"."Courses" ADD CONSTRAINT "PK_Courses" PRIMARY KEY ("Id");

-- ----------------------------
-- Indexes structure for table DosageLogs
-- ----------------------------
CREATE INDEX "IX_DosageLogs_DosageRecommendationId" ON "public"."DosageLogs" USING btree (
  "DosageRecommendationId" "pg_catalog"."int4_ops" ASC NULLS LAST
);
CREATE INDEX "IX_DosageLogs_UserId" ON "public"."DosageLogs" USING btree (
  "UserId" "pg_catalog"."int4_ops" ASC NULLS LAST
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
CREATE INDEX "IX_DosingFrequencies_DrugId" ON "public"."DosingFrequencies" USING btree (
  "DrugId" "pg_catalog"."int4_ops" ASC NULLS LAST
);
CREATE INDEX "IX_DosingFrequencies_UserId" ON "public"."DosingFrequencies" USING btree (
  "UserId" "pg_catalog"."int4_ops" ASC NULLS LAST
);

-- ----------------------------
-- Primary Key structure for table DosingFrequencies
-- ----------------------------
ALTER TABLE "public"."DosingFrequencies" ADD CONSTRAINT "PK_DosingFrequencies" PRIMARY KEY ("Id");

-- ----------------------------
-- Indexes structure for table DosingFrequencyReminders
-- ----------------------------
CREATE INDEX "IX_DosingFrequencyReminders_DosingFrequencyId" ON "public"."DosingFrequencyReminders" USING btree (
  "DosingFrequencyId" "pg_catalog"."int4_ops" ASC NULLS LAST
);
CREATE INDEX "IX_DosingFrequencyReminders_ReminderId" ON "public"."DosingFrequencyReminders" USING btree (
  "ReminderId" "pg_catalog"."int4_ops" ASC NULLS LAST
);
CREATE INDEX "IX_DosingFrequencyReminders_UserId" ON "public"."DosingFrequencyReminders" USING btree (
  "UserId" "pg_catalog"."int4_ops" ASC NULLS LAST
);

-- ----------------------------
-- Primary Key structure for table DosingFrequencyReminders
-- ----------------------------
ALTER TABLE "public"."DosingFrequencyReminders" ADD CONSTRAINT "PK_DosingFrequencyReminders" PRIMARY KEY ("Id");

-- ----------------------------
-- Indexes structure for table DrugCategories
-- ----------------------------
CREATE INDEX "IX_DrugCategories_UserId" ON "public"."DrugCategories" USING btree (
  "UserId" "pg_catalog"."int4_ops" ASC NULLS LAST
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
CREATE INDEX "IX_Drugs_SimilarDrugsId" ON "public"."Drugs" USING btree (
  "SimilarDrugsId" "pg_catalog"."int4_ops" ASC NULLS LAST
);
CREATE INDEX "IX_Drugs_UserId" ON "public"."Drugs" USING btree (
  "UserId" "pg_catalog"."int4_ops" ASC NULLS LAST
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
CREATE INDEX "IX_Reminders_UserId" ON "public"."Reminders" USING btree (
  "UserId" "pg_catalog"."int4_ops" ASC NULLS LAST
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
CREATE INDEX "IX_Therapies_UserId" ON "public"."Therapies" USING btree (
  "UserId" "pg_catalog"."int4_ops" ASC NULLS LAST
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
CREATE UNIQUE INDEX "IX_TranslatedActiveElement_Language_ActiveElementId" ON "public"."TranslatedActiveElement" USING btree (
  "Language" "pg_catalog"."int4_ops" ASC NULLS LAST,
  "ActiveElementId" "pg_catalog"."int4_ops" ASC NULLS LAST
);
CREATE INDEX "IX_TranslatedActiveElement_UserId" ON "public"."TranslatedActiveElement" USING btree (
  "UserId" "pg_catalog"."int4_ops" ASC NULLS LAST
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
CREATE UNIQUE INDEX "IX_TranslatedCourse_Language_CourseId" ON "public"."TranslatedCourse" USING btree (
  "Language" "pg_catalog"."int4_ops" ASC NULLS LAST,
  "CourseId" "pg_catalog"."int4_ops" ASC NULLS LAST
);
CREATE INDEX "IX_TranslatedCourse_UserId" ON "public"."TranslatedCourse" USING btree (
  "UserId" "pg_catalog"."int4_ops" ASC NULLS LAST
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
CREATE UNIQUE INDEX "IX_TranslatedCourseGroup_Language_CourseGroupId" ON "public"."TranslatedCourseGroup" USING btree (
  "Language" "pg_catalog"."int4_ops" ASC NULLS LAST,
  "CourseGroupId" "pg_catalog"."int4_ops" ASC NULLS LAST
);
CREATE INDEX "IX_TranslatedCourseGroup_UserId" ON "public"."TranslatedCourseGroup" USING btree (
  "UserId" "pg_catalog"."int4_ops" ASC NULLS LAST
);

-- ----------------------------
-- Primary Key structure for table TranslatedCourseGroup
-- ----------------------------
ALTER TABLE "public"."TranslatedCourseGroup" ADD CONSTRAINT "PK_TranslatedCourseGroup" PRIMARY KEY ("Id");

-- ----------------------------
-- Indexes structure for table TranslatedDosingFrequency
-- ----------------------------
CREATE INDEX "IX_TranslatedDosingFrequency_DosingFrequencyId" ON "public"."TranslatedDosingFrequency" USING btree (
  "DosingFrequencyId" "pg_catalog"."int4_ops" ASC NULLS LAST
);
CREATE INDEX "IX_TranslatedDosingFrequency_UserId" ON "public"."TranslatedDosingFrequency" USING btree (
  "UserId" "pg_catalog"."int4_ops" ASC NULLS LAST
);

-- ----------------------------
-- Primary Key structure for table TranslatedDosingFrequency
-- ----------------------------
ALTER TABLE "public"."TranslatedDosingFrequency" ADD CONSTRAINT "PK_TranslatedDosingFrequency" PRIMARY KEY ("Id");

-- ----------------------------
-- Indexes structure for table TranslatedDosingFrequencyReminder
-- ----------------------------
CREATE INDEX "IX_TranslatedDosingFrequencyReminder_DosageRecommendationId" ON "public"."TranslatedDosingFrequencyReminder" USING btree (
  "DosageRecommendationId" "pg_catalog"."int4_ops" ASC NULLS LAST
);
CREATE UNIQUE INDEX "IX_TranslatedDosingFrequencyReminder_Language_DosageRecommenda~" ON "public"."TranslatedDosingFrequencyReminder" USING btree (
  "Language" "pg_catalog"."int4_ops" ASC NULLS LAST,
  "DosageRecommendationId" "pg_catalog"."int4_ops" ASC NULLS LAST
);
CREATE INDEX "IX_TranslatedDosingFrequencyReminder_UserId" ON "public"."TranslatedDosingFrequencyReminder" USING btree (
  "UserId" "pg_catalog"."int4_ops" ASC NULLS LAST
);

-- ----------------------------
-- Primary Key structure for table TranslatedDosingFrequencyReminder
-- ----------------------------
ALTER TABLE "public"."TranslatedDosingFrequencyReminder" ADD CONSTRAINT "PK_TranslatedDosingFrequencyReminder" PRIMARY KEY ("Id");

-- ----------------------------
-- Indexes structure for table TranslatedDrugs
-- ----------------------------
CREATE INDEX "IX_TranslatedDrugs_DrugId" ON "public"."TranslatedDrugs" USING btree (
  "DrugId" "pg_catalog"."int4_ops" ASC NULLS LAST
);
CREATE UNIQUE INDEX "IX_TranslatedDrugs_Language_DrugId" ON "public"."TranslatedDrugs" USING btree (
  "Language" "pg_catalog"."int4_ops" ASC NULLS LAST,
  "DrugId" "pg_catalog"."int4_ops" ASC NULLS LAST
);
CREATE INDEX "IX_TranslatedDrugs_UserId" ON "public"."TranslatedDrugs" USING btree (
  "UserId" "pg_catalog"."int4_ops" ASC NULLS LAST
);

-- ----------------------------
-- Primary Key structure for table TranslatedDrugs
-- ----------------------------
ALTER TABLE "public"."TranslatedDrugs" ADD CONSTRAINT "PK_TranslatedDrugs" PRIMARY KEY ("Id");

-- ----------------------------
-- Indexes structure for table TranslatedDrugsCategory
-- ----------------------------
CREATE INDEX "IX_TranslatedDrugsCategory_DrugCategoryId" ON "public"."TranslatedDrugsCategory" USING btree (
  "DrugCategoryId" "pg_catalog"."int4_ops" ASC NULLS LAST
);
CREATE UNIQUE INDEX "IX_TranslatedDrugsCategory_Language_DrugCategoryId" ON "public"."TranslatedDrugsCategory" USING btree (
  "Language" "pg_catalog"."int4_ops" ASC NULLS LAST,
  "DrugCategoryId" "pg_catalog"."int4_ops" ASC NULLS LAST
);
CREATE INDEX "IX_TranslatedDrugsCategory_UserId" ON "public"."TranslatedDrugsCategory" USING btree (
  "UserId" "pg_catalog"."int4_ops" ASC NULLS LAST
);

-- ----------------------------
-- Primary Key structure for table TranslatedDrugsCategory
-- ----------------------------
ALTER TABLE "public"."TranslatedDrugsCategory" ADD CONSTRAINT "PK_TranslatedDrugsCategory" PRIMARY KEY ("Id");

-- ----------------------------
-- Indexes structure for table TranslatedTherapy
-- ----------------------------
CREATE UNIQUE INDEX "IX_TranslatedTherapy_Language_TherapyId" ON "public"."TranslatedTherapy" USING btree (
  "Language" "pg_catalog"."int4_ops" ASC NULLS LAST,
  "TherapyId" "pg_catalog"."int4_ops" ASC NULLS LAST
);
CREATE INDEX "IX_TranslatedTherapy_TherapyId" ON "public"."TranslatedTherapy" USING btree (
  "TherapyId" "pg_catalog"."int4_ops" ASC NULLS LAST
);
CREATE INDEX "IX_TranslatedTherapy_UserId" ON "public"."TranslatedTherapy" USING btree (
  "UserId" "pg_catalog"."int4_ops" ASC NULLS LAST
);

-- ----------------------------
-- Primary Key structure for table TranslatedTherapy
-- ----------------------------
ALTER TABLE "public"."TranslatedTherapy" ADD CONSTRAINT "PK_TranslatedTherapy" PRIMARY KEY ("Id");

-- ----------------------------
-- Primary Key structure for table UserMedicineWorkerLogs
-- ----------------------------
ALTER TABLE "public"."UserMedicineWorkerLogs" ADD CONSTRAINT "PK_UserMedicineWorkerLogs" PRIMARY KEY ("Id");

-- ----------------------------
-- Indexes structure for table UserMedicineWorkers
-- ----------------------------
CREATE INDEX "IX_UserMedicineWorkers_MedicineWorkerId" ON "public"."UserMedicineWorkers" USING btree (
  "MedicineWorkerId" "pg_catalog"."int4_ops" ASC NULLS LAST
);
CREATE INDEX "IX_UserMedicineWorkers_UserId" ON "public"."UserMedicineWorkers" USING btree (
  "UserId" "pg_catalog"."int4_ops" ASC NULLS LAST
);

-- ----------------------------
-- Primary Key structure for table UserMedicineWorkers
-- ----------------------------
ALTER TABLE "public"."UserMedicineWorkers" ADD CONSTRAINT "PK_UserMedicineWorkers" PRIMARY KEY ("Id");

-- ----------------------------
-- Primary Key structure for table __EFMigrationsHistory
-- ----------------------------
ALTER TABLE "public"."__EFMigrationsHistory" ADD CONSTRAINT "PK___EFMigrationsHistory" PRIMARY KEY ("MigrationId");

-- ----------------------------
-- Foreign Keys structure for table ActiveElements
-- ----------------------------
ALTER TABLE "public"."ActiveElements" ADD CONSTRAINT "FK_ActiveElements_AspNetUsers_UserId" FOREIGN KEY ("UserId") REFERENCES "public"."AspNetUsers" ("Id") ON DELETE NO ACTION ON UPDATE NO ACTION;
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
ALTER TABLE "public"."CourseGroup" ADD CONSTRAINT "FK_CourseGroup_AspNetUsers_UserId" FOREIGN KEY ("UserId") REFERENCES "public"."AspNetUsers" ("Id") ON DELETE NO ACTION ON UPDATE NO ACTION;

-- ----------------------------
-- Foreign Keys structure for table CourseSettings
-- ----------------------------
ALTER TABLE "public"."CourseSettings" ADD CONSTRAINT "FK_CourseSettings_AspNetUsers_UserId" FOREIGN KEY ("UserId") REFERENCES "public"."AspNetUsers" ("Id") ON DELETE NO ACTION ON UPDATE NO ACTION;
ALTER TABLE "public"."CourseSettings" ADD CONSTRAINT "FK_CourseSettings_Courses_CourseId" FOREIGN KEY ("CourseId") REFERENCES "public"."Courses" ("Id") ON DELETE CASCADE ON UPDATE NO ACTION;

-- ----------------------------
-- Foreign Keys structure for table Courses
-- ----------------------------
ALTER TABLE "public"."Courses" ADD CONSTRAINT "FK_Courses_AspNetUsers_UserId" FOREIGN KEY ("UserId") REFERENCES "public"."AspNetUsers" ("Id") ON DELETE NO ACTION ON UPDATE NO ACTION;
ALTER TABLE "public"."Courses" ADD CONSTRAINT "FK_Courses_CourseGroup_CourseGroupID" FOREIGN KEY ("CourseGroupID") REFERENCES "public"."CourseGroup" ("Id") ON DELETE NO ACTION ON UPDATE NO ACTION;
ALTER TABLE "public"."Courses" ADD CONSTRAINT "FK_Courses_Therapies_TherapyId" FOREIGN KEY ("TherapyId") REFERENCES "public"."Therapies" ("Id") ON DELETE CASCADE ON UPDATE NO ACTION;

-- ----------------------------
-- Foreign Keys structure for table DosageLogs
-- ----------------------------
ALTER TABLE "public"."DosageLogs" ADD CONSTRAINT "FK_DosageLogs_AspNetUsers_UserId" FOREIGN KEY ("UserId") REFERENCES "public"."AspNetUsers" ("Id") ON DELETE NO ACTION ON UPDATE NO ACTION;
ALTER TABLE "public"."DosageLogs" ADD CONSTRAINT "FK_DosageLogs_DosingFrequencyReminders_DosageRecommendationId" FOREIGN KEY ("DosageRecommendationId") REFERENCES "public"."DosingFrequencyReminders" ("Id") ON DELETE CASCADE ON UPDATE NO ACTION;

-- ----------------------------
-- Foreign Keys structure for table DosingFrequencies
-- ----------------------------
ALTER TABLE "public"."DosingFrequencies" ADD CONSTRAINT "FK_DosingFrequencies_AspNetUsers_UserId" FOREIGN KEY ("UserId") REFERENCES "public"."AspNetUsers" ("Id") ON DELETE NO ACTION ON UPDATE NO ACTION;
ALTER TABLE "public"."DosingFrequencies" ADD CONSTRAINT "FK_DosingFrequencies_Courses_CourseId" FOREIGN KEY ("CourseId") REFERENCES "public"."Courses" ("Id") ON DELETE CASCADE ON UPDATE NO ACTION;
ALTER TABLE "public"."DosingFrequencies" ADD CONSTRAINT "FK_DosingFrequencies_Drugs_DrugId" FOREIGN KEY ("DrugId") REFERENCES "public"."Drugs" ("Id") ON DELETE CASCADE ON UPDATE NO ACTION;

-- ----------------------------
-- Foreign Keys structure for table DosingFrequencyReminders
-- ----------------------------
ALTER TABLE "public"."DosingFrequencyReminders" ADD CONSTRAINT "FK_DosingFrequencyReminders_AspNetUsers_UserId" FOREIGN KEY ("UserId") REFERENCES "public"."AspNetUsers" ("Id") ON DELETE NO ACTION ON UPDATE NO ACTION;
ALTER TABLE "public"."DosingFrequencyReminders" ADD CONSTRAINT "FK_DosingFrequencyReminders_DosingFrequencies_DosingFrequencyId" FOREIGN KEY ("DosingFrequencyId") REFERENCES "public"."DosingFrequencies" ("Id") ON DELETE CASCADE ON UPDATE NO ACTION;
ALTER TABLE "public"."DosingFrequencyReminders" ADD CONSTRAINT "FK_DosingFrequencyReminders_Reminders_ReminderId" FOREIGN KEY ("ReminderId") REFERENCES "public"."Reminders" ("Id") ON DELETE CASCADE ON UPDATE NO ACTION;

-- ----------------------------
-- Foreign Keys structure for table DrugCategories
-- ----------------------------
ALTER TABLE "public"."DrugCategories" ADD CONSTRAINT "FK_DrugCategories_AspNetUsers_UserId" FOREIGN KEY ("UserId") REFERENCES "public"."AspNetUsers" ("Id") ON DELETE NO ACTION ON UPDATE NO ACTION;

-- ----------------------------
-- Foreign Keys structure for table DrugDrugCategory
-- ----------------------------
ALTER TABLE "public"."DrugDrugCategory" ADD CONSTRAINT "FK_DrugDrugCategory_DrugCategories_DrugCategoriesId" FOREIGN KEY ("DrugCategoriesId") REFERENCES "public"."DrugCategories" ("Id") ON DELETE CASCADE ON UPDATE NO ACTION;
ALTER TABLE "public"."DrugDrugCategory" ADD CONSTRAINT "FK_DrugDrugCategory_Drugs_DrugsId" FOREIGN KEY ("DrugsId") REFERENCES "public"."Drugs" ("Id") ON DELETE CASCADE ON UPDATE NO ACTION;

-- ----------------------------
-- Foreign Keys structure for table Drugs
-- ----------------------------
ALTER TABLE "public"."Drugs" ADD CONSTRAINT "FK_Drugs_AspNetUsers_UserId" FOREIGN KEY ("UserId") REFERENCES "public"."AspNetUsers" ("Id") ON DELETE NO ACTION ON UPDATE NO ACTION;
ALTER TABLE "public"."Drugs" ADD CONSTRAINT "FK_Drugs_SimilarDrugs_SimilarDrugsId" FOREIGN KEY ("SimilarDrugsId") REFERENCES "public"."SimilarDrugs" ("Id") ON DELETE CASCADE ON UPDATE NO ACTION;

-- ----------------------------
-- Foreign Keys structure for table ReminderLogs
-- ----------------------------
ALTER TABLE "public"."ReminderLogs" ADD CONSTRAINT "FK_ReminderLogs_Reminders_ReminderId" FOREIGN KEY ("ReminderId") REFERENCES "public"."Reminders" ("Id") ON DELETE CASCADE ON UPDATE NO ACTION;

-- ----------------------------
-- Foreign Keys structure for table Reminders
-- ----------------------------
ALTER TABLE "public"."Reminders" ADD CONSTRAINT "FK_Reminders_AspNetUsers_UserId" FOREIGN KEY ("UserId") REFERENCES "public"."AspNetUsers" ("Id") ON DELETE NO ACTION ON UPDATE NO ACTION;

-- ----------------------------
-- Foreign Keys structure for table Therapies
-- ----------------------------
ALTER TABLE "public"."Therapies" ADD CONSTRAINT "FK_Therapies_AspNetUsers_UserId" FOREIGN KEY ("UserId") REFERENCES "public"."AspNetUsers" ("Id") ON DELETE CASCADE ON UPDATE NO ACTION;

-- ----------------------------
-- Foreign Keys structure for table TranslatedActiveElement
-- ----------------------------
ALTER TABLE "public"."TranslatedActiveElement" ADD CONSTRAINT "FK_TranslatedActiveElement_ActiveElements_ActiveElementId" FOREIGN KEY ("ActiveElementId") REFERENCES "public"."ActiveElements" ("Id") ON DELETE CASCADE ON UPDATE NO ACTION;
ALTER TABLE "public"."TranslatedActiveElement" ADD CONSTRAINT "FK_TranslatedActiveElement_AspNetUsers_UserId" FOREIGN KEY ("UserId") REFERENCES "public"."AspNetUsers" ("Id") ON DELETE NO ACTION ON UPDATE NO ACTION;

-- ----------------------------
-- Foreign Keys structure for table TranslatedCourse
-- ----------------------------
ALTER TABLE "public"."TranslatedCourse" ADD CONSTRAINT "FK_TranslatedCourse_AspNetUsers_UserId" FOREIGN KEY ("UserId") REFERENCES "public"."AspNetUsers" ("Id") ON DELETE NO ACTION ON UPDATE NO ACTION;
ALTER TABLE "public"."TranslatedCourse" ADD CONSTRAINT "FK_TranslatedCourse_Courses_CourseId" FOREIGN KEY ("CourseId") REFERENCES "public"."Courses" ("Id") ON DELETE CASCADE ON UPDATE NO ACTION;

-- ----------------------------
-- Foreign Keys structure for table TranslatedCourseGroup
-- ----------------------------
ALTER TABLE "public"."TranslatedCourseGroup" ADD CONSTRAINT "FK_TranslatedCourseGroup_AspNetUsers_UserId" FOREIGN KEY ("UserId") REFERENCES "public"."AspNetUsers" ("Id") ON DELETE NO ACTION ON UPDATE NO ACTION;
ALTER TABLE "public"."TranslatedCourseGroup" ADD CONSTRAINT "FK_TranslatedCourseGroup_CourseGroup_CourseGroupId" FOREIGN KEY ("CourseGroupId") REFERENCES "public"."CourseGroup" ("Id") ON DELETE CASCADE ON UPDATE NO ACTION;

-- ----------------------------
-- Foreign Keys structure for table TranslatedDosingFrequency
-- ----------------------------
ALTER TABLE "public"."TranslatedDosingFrequency" ADD CONSTRAINT "FK_TranslatedDosingFrequency_AspNetUsers_UserId" FOREIGN KEY ("UserId") REFERENCES "public"."AspNetUsers" ("Id") ON DELETE NO ACTION ON UPDATE NO ACTION;
ALTER TABLE "public"."TranslatedDosingFrequency" ADD CONSTRAINT "FK_TranslatedDosingFrequency_DosingFrequencies_DosingFrequency~" FOREIGN KEY ("DosingFrequencyId") REFERENCES "public"."DosingFrequencies" ("Id") ON DELETE CASCADE ON UPDATE NO ACTION;

-- ----------------------------
-- Foreign Keys structure for table TranslatedDosingFrequencyReminder
-- ----------------------------
ALTER TABLE "public"."TranslatedDosingFrequencyReminder" ADD CONSTRAINT "FK_TranslatedDosingFrequencyReminder_AspNetUsers_UserId" FOREIGN KEY ("UserId") REFERENCES "public"."AspNetUsers" ("Id") ON DELETE NO ACTION ON UPDATE NO ACTION;
ALTER TABLE "public"."TranslatedDosingFrequencyReminder" ADD CONSTRAINT "FK_TranslatedDosingFrequencyReminder_DosingFrequencyReminders_~" FOREIGN KEY ("DosageRecommendationId") REFERENCES "public"."DosingFrequencyReminders" ("Id") ON DELETE CASCADE ON UPDATE NO ACTION;

-- ----------------------------
-- Foreign Keys structure for table TranslatedDrugs
-- ----------------------------
ALTER TABLE "public"."TranslatedDrugs" ADD CONSTRAINT "FK_TranslatedDrugs_AspNetUsers_UserId" FOREIGN KEY ("UserId") REFERENCES "public"."AspNetUsers" ("Id") ON DELETE NO ACTION ON UPDATE NO ACTION;
ALTER TABLE "public"."TranslatedDrugs" ADD CONSTRAINT "FK_TranslatedDrugs_Drugs_DrugId" FOREIGN KEY ("DrugId") REFERENCES "public"."Drugs" ("Id") ON DELETE CASCADE ON UPDATE NO ACTION;

-- ----------------------------
-- Foreign Keys structure for table TranslatedDrugsCategory
-- ----------------------------
ALTER TABLE "public"."TranslatedDrugsCategory" ADD CONSTRAINT "FK_TranslatedDrugsCategory_AspNetUsers_UserId" FOREIGN KEY ("UserId") REFERENCES "public"."AspNetUsers" ("Id") ON DELETE NO ACTION ON UPDATE NO ACTION;
ALTER TABLE "public"."TranslatedDrugsCategory" ADD CONSTRAINT "FK_TranslatedDrugsCategory_DrugCategories_DrugCategoryId" FOREIGN KEY ("DrugCategoryId") REFERENCES "public"."DrugCategories" ("Id") ON DELETE CASCADE ON UPDATE NO ACTION;

-- ----------------------------
-- Foreign Keys structure for table TranslatedTherapy
-- ----------------------------
ALTER TABLE "public"."TranslatedTherapy" ADD CONSTRAINT "FK_TranslatedTherapy_AspNetUsers_UserId" FOREIGN KEY ("UserId") REFERENCES "public"."AspNetUsers" ("Id") ON DELETE NO ACTION ON UPDATE NO ACTION;
ALTER TABLE "public"."TranslatedTherapy" ADD CONSTRAINT "FK_TranslatedTherapy_Therapies_TherapyId" FOREIGN KEY ("TherapyId") REFERENCES "public"."Therapies" ("Id") ON DELETE CASCADE ON UPDATE NO ACTION;

-- ----------------------------
-- Foreign Keys structure for table UserMedicineWorkers
-- ----------------------------
ALTER TABLE "public"."UserMedicineWorkers" ADD CONSTRAINT "FK_UserMedicineWorkers_AspNetUsers_MedicineWorkerId" FOREIGN KEY ("MedicineWorkerId") REFERENCES "public"."AspNetUsers" ("Id") ON DELETE NO ACTION ON UPDATE NO ACTION;
ALTER TABLE "public"."UserMedicineWorkers" ADD CONSTRAINT "FK_UserMedicineWorkers_AspNetUsers_UserId" FOREIGN KEY ("UserId") REFERENCES "public"."AspNetUsers" ("Id") ON DELETE NO ACTION ON UPDATE NO ACTION;
