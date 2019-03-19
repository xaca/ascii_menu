			    _____  _____ _____ _____            ______ _    _ _   _   
		     /\    / ____|/ ____|_   _|_   _|          |  ____| |  | | \ | |  
		    /  \  | (___ | |      | |   | |    ______  | |__  | |  | |  \| |  
		   / /\ \  \___ \| |      | |   | |   |______| |  __| | |  | | . ` |  
		  / ____ \ ____) | |____ _| |_ _| |_           | |    | |__| | |\  |  
		 /_/    \_\_____/ \_____|_____|_____|          |_|     \____/|_| \_|    
		   
		        /\_/\_/\_/\_/\_/\_/\_/\_/\_/\_/\_/\_/\_/\_/\_/\_/\_/\  
			\/ \/ \/ \/ \/ \/ \/ \/ \/ \/ \/ \/ \/ \/ \/ \/ \/ \/    
			  
# Instrucciones del ejercicio  
  
## Secuencias de escape  
1. Imprimir un diseño de máximo 5 líneas usando ascii art y csharp   
  
> **Recuerde** que para imprimir en consola las cadenas:  
> "hola" y &setmn;hola&setmn;, se debe usar una secuencia de escape, así:  
> \"hola\" y &setmn;&setmn;hola&setmn;&setmn;  
  
```csharp  
Console.WriteLine("&setmn;"hola&setmn;"");  
Console.WriteLine("\\hola\\");  
```  
2. Crear un menú personalizado, usando ascii art y secuencias de escape, se recomienda usar *borders*

3. Cree un ciclo que utilice una variable centinela para detectar cuando salir del menú, el valor para salir es -1.

> Ingrese una opción así:
>  1. Dibujar un cuadrado de N por M líneas
>  2. Traducir un emoji a una expresión escrita
>  3. Códificar un texto usando la clave murcielago
> -1. Para salir
