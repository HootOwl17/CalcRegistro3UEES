@echo off
title Programa para Calcular promedio para 3er Registro
set /p num1 = Ingrese Nota de 1er Registro
set /p num2 = Ingrese Nota de 2do Registro  
set /a suma = 6 -((%num1% +%num2%) * 0.3)
set /a promedio = %suma%/0.4
echo
echo Necesita una nota de %promedio%
pause >nul
exit
