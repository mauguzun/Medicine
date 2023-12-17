@echo off

REM Get the current date and time in the format YYYYMMDD_HHMMSS
for /f "tokens=1-6 delims=/:. " %%i in ('echo %date% %time%') do set "datetimestamp=%%k%%j%%i_%%l%%m%%n"

REM Run the EF Core migrations command with the timestamped migration name
dotnet ef migrations add %datetimestamp% --context AppDbContext -p Infrastructure\Implementaion\Medicine.Infrastructure.Implementation.DataAccesPlsql\ -s WebApplication\

REM Run the EF Core database update command with the timestamped migration name
dotnet ef database update --context AppDbContext -p Infrastructure\Implementaion\Medicine.Infrastructure.Implementation.DataAccesPlsql\ -s WebApplication\

echo Migration and database update completed with timestamp: %datetimestamp%
