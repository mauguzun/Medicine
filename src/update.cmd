@echo off

dotnet ef migrations add Init --context AppDbContext -p Infrastructure\Implementaion\Medicine.Infrastructure.Implementation.DataAccesPlsql\ -s WebApplication\
dotnet ef database update --context AppDbContext -p Infrastructure\Implementaion\Medicine.Infrastructure.Implementation.DataAccesPlsql\ -s WebApplication\


