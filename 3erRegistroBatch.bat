@echo off
title Programa para Calcular promedio para 3er Registro
echo Bienvenido %hostname%
set /p num1 = Ingrese Nota de 1er Registro
set /p num2 = Ingrese Nota de 2do Registro
set /a suma = 6- ((%num1%+%num2%)*(3/10))
set /a promedio= %suma% / (4/10)
echo
echo Necesita una nota de %promedio%
pause >nul
exit
