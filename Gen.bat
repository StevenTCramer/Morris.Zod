@echo off
cls
cleanup -y .\Source
rd /s /Q "%USERPROFILE%\.nuget\packages\morris.zod"

dotnet build .\Source\Lib\Morris.Zod\Morris.Zod.csproj -c Release
if errorlevel 1 exit /b

dotnet build .\Source\Tests\Morris.Zod.UnitTests.Models\Morris.Zod.UnitTests.Models.csproj -c Release
if errorlevel 1 exit /b

type .\Source\Tests\ZodGeneratedFiles\*.ts