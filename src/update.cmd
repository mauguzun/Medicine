@echo off

dotnet ef migrations add Init --context AppDbContext -p Medicine.Infrastructure.Implementation.DataAccesPsql
dotnet ef database update --context AppDbContext -p to\Medicine.Infrastructure.Implementation.DataAccesPsql
