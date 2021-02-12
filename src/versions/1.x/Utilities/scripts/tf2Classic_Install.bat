@echo off
title TF2 Classic Installer
SET inspath=%1
SET tfclassicpath=%2
cls
set TF2CLASSICVER=2.0.1
echo Installing TF2 Classic (Version: %TF2CLASSICVER%)
echo This window is installing TF2 Classic to the proper folder.
echo PLEASE DO NOT CLOSE THIS WINDOW, IT WILL STOP THE INSTALL PROGRESS.
echo.
echo.
echo Installing TF2 Classic to: %inspath%
echo TF2 Classic archive: %tfclassicpath%
7za.exe x %tfclassicpath% -o%inspath% * -r -aoa

echo.
echo.
echo TF2 Classic has been installed. Maybe, I can't check if it failed.
echo This window will close in 10 seconds.
ping localhost -n 10 >nul