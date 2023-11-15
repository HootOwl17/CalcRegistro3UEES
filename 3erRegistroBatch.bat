@echo off
title Calcular Nota para 3er Registro UEES
echo Cual es la nota de 1er Registro?   (Nota sin decimales Ej. 7.5 = 750)
set/p "num1="
echo Cual es la nota de 2do Registro?   (Nota sin decimales Ej. 7.5 = 750)
set/p "num2="
set/a media = ((%num1% + %num2%) * 3)/10)
set/a resta = 600 - %media%
set/a prom = (%resta% * 10)/(4)
echo.
echo Necesita una nota de %prom%
pause >nul
exit
