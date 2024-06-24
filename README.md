# MaquinaTragaMonedas
Asignatura de Programación Orientada a Objetos

El programa debe mostrar una interfaz de usuario básica con las siguientes opciones:
Jugar: esta opción permite al usuario jugar una partida:
1.	El juego comienza mostrando las posiciones aleatorias iniciales de los símbolos en tres rodillos.
2.	El usuario dispondrá de dos opciones:
	Jugar: que hace girar los rodillos, reordenando aleatoriamente los símbolos.
	Salir: que devuelve al usuario al menú principal.
3.	Si el usuario consigue una línea de símbolos ganadora (los 3 símbolos iguales), recibe como recompensa una de las frases motivacionales predeterminadas.
•	Mostrar premios: esta opción permite al usuario ver los diferentes premios cargados en la máquina. El proceso debe seguir los siguientes pasos:
o	Mostrar todos los premios disponibles, incluido el nombre. 
o	Pide el identificador (id) del premio al usuario. 
o	Si el premios existe, debe mostrar información detallada sobre el producto, incluido el nombre, la línea de símbolos y la frase de consejo asociada. 
•	Carga de premios (Admin): esta opción permite a los usuarios admin cargar premios subiendo un archivo. El proceso debe seguir los siguientes pasos:
o	
	Preguntará por el nombre del archivo
	Se comprueba que el archivo especificado existe. En caso afirmativo, se procederá al siguiente paso.
	Sustituye los premios actuales de la máquina tragaperras por los premios que figuran en el archivo cargado.
•	Salir: esta opción finalizará la ejecución del programa.
Las opciones de administración requieren la introducción de una clave secreta para continuar. Esto significa que debe pedir al usuario la clave cuando se elige esta opción y volver al menú principal si la clave no es válida. 

Ejecución del Programa
El siguiente diagrama ilustra la funcionalidad principal del programa, donde:
•	Función roja: función estática definida dentro del programa principal (main). Esta función se puede implementar en la clase del programa. 
•	Funciones naranja: métodos públicos (funciones) pertenecientes a una clase central, idealmente llamada SlotMachine.
![image](https://github.com/ESTUD007/MaquinaTragaMonedas/assets/151021863/7767936f-73cd-4ee3-bfc6-508cb8b1be0f)
