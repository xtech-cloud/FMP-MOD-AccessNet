
@echo off

REM !!! Generated by the fmp-cli 1.80.0.  DO NOT EDIT!

md AccessNet\Assets\3rd\fmp-xtc-accessnet

cd ..\vs2022
dotnet build -c Release

copy fmp-xtc-accessnet-lib-mvcs\bin\Release\netstandard2.1\*.dll ..\unity2021\AccessNet\Assets\3rd\fmp-xtc-accessnet\
