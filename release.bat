@echo off
dotnet build src/Limbo.Umbraco.Separator --configuration Release /t:rebuild /t:pack -p:PackageOutputPath=../../releases/nuget