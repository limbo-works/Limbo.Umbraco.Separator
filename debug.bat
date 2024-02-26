@echo off
dotnet build src/Limbo.Umbraco.Separator --configuration Debug /t:rebuild /t:pack -p:PackageOutputPath=c:\nuget\Umbraco10