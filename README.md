			    _____  _____ _____ _____            ______ _    _ _   _   
		     /\    / ____|/ ____|_   _|_   _|          |  ____| |  | | \ | |  
		    /  \  | (___ | |      | |   | |    ______  | |__  | |  | |  \| |  
		   / /\ \  \___ \| |      | |   | |   |______| |  __| | |  | | . ` |  
		  / ____ \ ____) | |____ _| |_ _| |_           | |    | |__| | |\  |  
		 /_/    \_\_____/ \_____|_____|_____|          |_|     \____/|_| \_|    
		   
		        /\_/\_/\_/\_/\_/\_/\_/\_/\_/\_/\_/\_/\_/\_/\_/\_/\_/\  
			\/ \/ \/ \/ \/ \/ \/ \/ \/ \/ \/ \/ \/ \/ \/ \/ \/ \/    
			  
# Instructions for Exercise
  
## Escape Sequences
1. Print a design of maximum 5 lines using ascii art and csharp
  
> **Remember** to print the chains on console:  
> "hello" and & bsol; hello & bsol ;, an escape sequence should be used, like this: 
> \"hola\" y &bsol;&bsol;hola&bsol;&bsol;  
  
```csharp  
Console.WriteLine("\"hola\"");  
Console.WriteLine("\\hola\\");  
```  

2. Create a custom menu, using ascii art and escape sequences, it is recommended to use *borders*.

3. Create a cycle that uses a sentinel variable to detect when exiting the menu, the value to exit is -1.

> Enter an option like this:  
>  1. Draw a square of N by M lines
>  2. Translate an emoji to a written expression
>  3. Code a text using the bat key
> -1. To exit  

4. Request the data, validate that it is entered correctly using the switch structure and TryParse.

5. If the user enters an incorrect number, ask for the value again, if you enter -1, finish the program.

6. Implement the code of each menu option.

### Reference sites

+ [Ascii art, a good gallery of examples.](https://asciiart.website)  
+ [Ascii art text](http://patorjk.com/software/taag/#p=display&f=Impossible&t=xaca%20rana)  
+ [Another text option](http://www.network-science.de/ascii/)  