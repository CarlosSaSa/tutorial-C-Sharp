/* En este programa se revisan las estrcuturas de control como if, if-eslse, else y switch*/

/************* Estructura de control if - else **********/
var edad = 20;
if (edad >= 18){
    Console.WriteLine("Eres mayor de edad, puedes pasar"); 
}else {
    Console.WriteLine("Aún eres menor de edad, no puedes ingresar ");
}

/********** Estructura de control con if-else if - if ***************/
var cadena = "Hello world from this program";
// Verificamos si la cadena empieza con ciertas palabras, de ejemplo
if ( cadena.StartsWith("a", true, null ) ){
    Console.WriteLine($"La cadena: {cadena} empieza con la letra a ");
} else if ( cadena.StartsWith("b",true, null) ) {
    Console.WriteLine($"La cadena {cadena} empieza con la letra b");
} else{
    Console.WriteLine($"La cadena: {cadena} no empieza ni con a ni con b");
}

// Existe un operador llamado ternario y sirve mayormente para asignar un valor a una variable en base a una condición
Console.WriteLine("************** Operador ternario ****************");
bool isLogged = true;
string mensajeBienvenida = isLogged ? "Esta logueado": "No permitido";
Console.WriteLine(mensajeBienvenida);

Console.WriteLine("************** Switch case ****************");
/* Setencia de control de switch - case */
var medida = 50.12;
switch( medida ){
    case < 0:
        Console.WriteLine("La medida es menor a 0");
        break;
    case double n when( n >= 0 && n < 100): // en este caso para hacer la operación con AND se tuvo que definir n en el ambito del case y usar el operador when 
        // n toma el valor de comparación del switch en este caso n = 50.12
        Console.WriteLine("La medida es mayor a 0");
        break;
    case double.NaN: // equivalente a decir medida == double.NaN
        Console.WriteLine("La medida no es un numero");
        break;
    default:
        Console.WriteLine("La medida es mayor a 100");
        break;
}

/* El operador swtich puede ser usado en diferentes ambitos es decir en patrones, los siguientes son: patron relacional (relational pattern) y patron constante (constant pattern) 
   esto lo veremos mas adelante:
    https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/patterns
 */

/**************+ Ciclo for  ****************/
// Hacemos un ciclo for de 10 iteraciones
Console.WriteLine("************** Ciclo for  ****************");
for( int i = 0; i<= 10; i++){
    Console.WriteLine("Inicio de iterador: " + i );
}

/********* Ciclo foreach ************/
/* El ciclo foreach no solo está limitado a recorrerse en listas, entonces se puede usar en las siguientes variables que tengan lo siguiente:
    1. Que tenga el metodo publico GetEnumerator sin parametros
    2. El tipo de valor devuelto por el metodo GetEnumerator tiene la propiedad publica Current y el metodo MoveNext publico que no recibe parametros devuelve un booleano
 */
Console.WriteLine("************** Ciclo foreach ****************");
var edades = new List<int> { 18,19,20,21,22,23,24,25 };
// Recorremos las edades
Console.WriteLine("Recorriendo una lista de edades ");
foreach( int edadA in edades ) {
    Console.WriteLine("Edades permitidas: " + edadA );
}

Console.WriteLine("Recorriendo un string");
var saludo = "Hello world";
foreach (var caracter in saludo) {
    Console.WriteLine("Letra de saludo: " + caracter );
}

/* Hay otros ciclos como do-while, while, break, continue, return, goto, yield */

// Como ejercicio vamos a realizar el factorial de un numero de forma iterativa
const int numeroFactorial = 5;
int resultadoFactorial = 1;

for (int i = 1; i <= numeroFactorial; i++){
    resultadoFactorial *= i;
}
Console.WriteLine($"El factorial de: { numeroFactorial } es: { resultadoFactorial }");

// Aunque no se ha visto arreglos podemos hacer uso de una lista 
List<int> numerosAleatorios = new List<int>{}; // Creamos una lista de enteros vacias
Random random = new Random(); // Creamos una instancia de random para generar numeros aleatorios
// Hacemos un ciclo de 100 veces
for (int i = 0; i < 10000; i++){
    // Generamos el numero aleatorio entre 0 y 1000
    var numeroAleatorio = random.Next( 0, 1000 );
    numerosAleatorios.Add( numeroAleatorio );
}

Console.WriteLine("El tamaño de la lista es de: " + numerosAleatorios.Count );
Console.WriteLine("Recorriendo la lista para encontrar los numeros pares e impares");
int totalPares = 0; // Para almacenar los pares
int totalImpares = 0; // para almacenar los impares
numerosAleatorios.ForEach( delegate( int numero ) { // usamos delegate para pasar un metodo como parametro de otro metodo, similar a un callback en js, este es un uso de los delegates en C#
    if ( numero %2  == 0) {
        totalPares += 1;
    } else {
        totalImpares += 1;
    }
});
Console.WriteLine($"En lista hay { totalPares } numeros pares");
Console.WriteLine($"En lista hay { totalImpares } numeros impares");






