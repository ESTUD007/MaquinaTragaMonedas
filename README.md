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


Definición de los premios
La máquina tragaperras está diseñada para dispensar una amplia gama de premios, divididos en dos categorías principales: (1) premios simples y (2) premios aleatorios. Cada categoría de premios engloba los siguientes atributos comunes:
•	Nombre (string): nombre del premio
•	Símbolo 1 (int): símbolo que debe aparecer en el primer rodillo
•	Símbolo 2 (int): símbolo que debe aparecer en el segundo rodillo
•	Símbolo 3 (int): símbolo que debe aparecer en el tercer rodillo
Cada tipo de premio se define por sus propias características:
•	Los premios simples cuentan con consejos específicos que se muestran cuando aparece la combinación de símbolos correspondiente.
•	Los premios aleatorios presentan dos tipos de consejos (consejo 1 y consejo 2), junto con la probabilidad de que se produzca cada uno de ellos. Esto significa que cuando se gana un premio aleatorio, se da uno de los dos consejos en función de las probabilidades predefinidas para ese premio.
Los usuarios administradores son responsables de cargar la máquina tragaperras utilizando un método de carga masiva con un archivo CSV (Comma-Separated Values). Este archivo utiliza punto y coma (;) para separar la información, estructurada de la siguiente manera:
•	tipo: especifica la categoría del premio: 1 para premios simples; y 2 para premios aleatorios. Esto ayuda a garantizar que los premios se cargan correctamente en la máquina.
•	nombre: especifica el nombre del premio.
•	simbolo1: indica el símbolo del primer rodillo.
•	simbolo2: indica el símbolo del segundo rodillo.
•	simbolo3: indica el símbolo del tercer rodillo.
•	consejo1: para los premios simples, es el consejo mostrado; para los premios aleatorios, es el primer consejo potencial.
•	consejo2: indica el segundo consejo potencial para los premios aleatorios.
•	probabilidad: indica la probabilidad de que se muestre el primer consejo cuando se gana un premio. Por tanto, la probabilidad para el segundo consejo se establece automáticamente como 1 - probabilidad.


