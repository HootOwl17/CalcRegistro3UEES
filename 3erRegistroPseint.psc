Algoritmo Calcular_Nota_para_3er_Registro
	Repetir
		Escribir "Nota de 1er Registro";
		Leer N1;
		Escribir "Nota de 2do Registro";
		Leer N2;
		
		N<-6-((N1+N2)*0.3);
		N3 <- N/0.4;
		Borrar Pantalla;
		Escribir "Necesita una nota minima de ",N3;
		Escribir "	<Presione cualquier tecla>	"
		Esperar Tecla;
		Borrar Pantalla;
		Escribir "¿OTRA VEZ? (S/N)"
		Leer OV
		Borrar Pantalla
	Hasta Que OV="N" o OV = "n"
FinAlgoritmo
