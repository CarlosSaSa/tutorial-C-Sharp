/* Este script contiene información acerca de las variables */

// Lista de valores enteros
/* 
C#      type/keyword                                            Range	                    Size	    .NET type
sbyte	-128 to 127	                                            Signed 8-bit                integer	    System.SByte
byte	0 to 255	                                            Unsigned 8-bit              integer	    System.Byte
short	-32,768 to 32,767	                                    Signed 16-bit               integer	    System.Int16
ushort	0 to 65,535	                                            Unsigned 16-bit             integer	    System.UInt16
int	    -2,147,483,648 to 2,147,483,647 	                    Signed 32-bit               integer	    System.Int32
uint	0 to 4,294,967,295	                                    Unsigned 32-bit             integer	    System.UInt32
long	-9,223,372,036,854,775,808 to 9,223,372,036,854,775,807	Signed 64-bit               integer	    System.Int64
ulong	0 to 18,446,744,073,709,551,615	                        Unsigned 64-bit             integer	    System.UInt64
nint	Depends on platform (computed at runtime)	            Signed 32-bit or 64-bit     integer	    System.IntPtr
nuint	Depends on platform (computed at runtime)	            Unsigned 32-bit or 64-bit   integer	    System.UIntPtr
*/

// Los valores que mas se usan son int y long

using EnumsTypes;

int a = 200;
long b = 100_000_000;

Console.WriteLine("Minimo valor de int: " + int.MinValue);
Console.WriteLine("Máximo valor de int: " + int.MaxValue);
Console.WriteLine("Valor de a: " + a);
Console.WriteLine("Valor de b: " + b);


// Lista de tipos de datos flotantes
/* 
C# type/keyword	    Approximate range	            Precision	    Size	    .NET type
float	            ±1.5 x 10−45 to ±3.4 x 1038	    ~6-9 digits	    4 bytes	    System.Single
double	            ±5.0 × 10−324 to ±1.7 × 10308	~15-17 digits	8 bytes	    System.Double
decimal	            ±1.0 x 10-28 to ±7.9228 x 1028	28-29 digits	16 bytes	System.Decimal

Los tipos de datos mas usados son el double y el decimal, asi mismo float y double proporcionan constantes que representan
valores infinitos y no númericos, como por ejemplo, Double.NaN, Double.NegativeInfinity y Double.PositiveInfinity  
*/

Console.WriteLine("Valor minimo de double: " + double.MinValue); 
Console.WriteLine("Valor máximo de double: " + double.MaxValue);
double c = 10.1212121212d; // Con esto queremos decir que la variable d es un double porque agregamos la letra d al final, por defecto las variables son double en este caso
float d = 1.121212f; // Para denotar que una variable es float tuvimos que agregar la letra f al final en caso contrario seria un double

Console.WriteLine("Valor double: " + c + " y su tipo de dato es: " + c.GetType().ToString() );
Console.WriteLine("Valor flotante: " + d + " y su tipo de dato es: " + d.GetType().ToString() );

// Como mencionamos también hay una variable del tipo decimal, esta se ocupa mas en el ambito monetario y financiero, como vemos el prefijo es la letra m
decimal e = 2.1m;
decimal f = 2.121212121m;

Console.WriteLine("Valor decimal de e es: " + e + " y es del tipo de dato: " + e.GetType());
Console.WriteLine("Valor decimal de f es: " + f + " y es del tipo de dato: " + f.GetType());

// Tipo de datos booleanos
// Solamente tiene dos valores ya sea true o false.
bool g = true;
bool h = false;
Console.WriteLine("Valor booleano de g es: " + g + " y es del tipo de dato: " + g.GetType());
Console.WriteLine("Valor booleano de h es: " + h + " y es del tipo de dato: " + h.GetType());

// Tipo de dato Char

// Tipos de datos String
/* 
En este caso los strings se pueden comparar con los operadores de igualdad y de diferencia, esto quiere decir que la comparación por valor es aceptada 
en los strings pero no es valido la comparación con referencia, por ejemplo
 */

string saludo = "hello";
string saludo2 = "h";

saludo2 += "ello"; // hacemos la concatenación

Console.WriteLine("Las cadenas son iguales: " + (saludo == saludo2).ToString() ); // true
Console.WriteLine("Las instancias son iguales: " + object.ReferenceEquals(saludo, saludo2)); // false

/* 
 Hay que recordar que en C# existe diferente clasificación en los tipos de datos los cuales son los siguientes:
1. Values types: Solo pasan su valor y si las variabkes se pasan en funciones y se muta su valor el valor original no cambia, entre estos estan los tipos de datos primitivos
2. Reference types: Almancenan la dirección de memoria en donde esta guardado el valor, si se pasa a una función como parametro y se muta entonces el valor original cambia
   entre estos estan los objetos, arrays, strings, clases etc.
3. Pointer types
 */


//Creando una cadena vacia
string cadenaVacia = string.Empty;
Console.WriteLine("La cadena vacia es: ", cadenaVacia );

// Tambien podemos acceder a los caracteres indivuales del string
char caracter = saludo[1];
Console.WriteLine("El segundo caracter de la cadena: " + saludo + " es: " + caracter + " y es de tipo de dato: " + caracter.GetType() );

/* Los strings literales se pueden escribir de las tres siguientes formas: 
1. Raw (Sin formato): Disponibles a partir de C# 11, pueden contener texto arbitrario sin necesidad de tener secuencias de escape,
                      pueden incluir espacios en blanco y líneas nuevas, comillas incrustadas y otros caracteres especiales, para declararlas hay que hacer uso de tres
                      comillas dobles
2. Quoted: Son las cadenas "normales" que estan encerradas entre comillas dobles
3. Verbatim: Las antecede un signo de @ y tiene algunos usos, el mas comun es ignorar las secuencias de escape
 */

// Inmutabilidad de los strings
string abc = "nueva_cadena";
abc = "abc_d";
// abc[0] = 'a';
Console.WriteLine("Cadena inmutable: " + abc);

// Creando un string raw
string cadenaSinFormato = """
    Esta es una cadena sin formato que no necesita tener 'caracteres' escapados.
    Asi mismo podemos hacer uso de otros caracteres especiales: \\\\/////
    """;
Console.WriteLine("Cadena sin formato: " + cadenaSinFormato);


// Creamos una string verbatim para ignorar las secuencias de escape
string fileUploads = @"c:\Docs\Source\a.txt";
Console.WriteLine("La cadena varbatim es la siguiente: " + fileUploads);


// Por ultimo estan las variables dinamicas que son resueltas en tiempo de ejecución y no en tiempo de compilación
// tambien no se necesita inicializar a diferencia de var, también la variable dynamic puede cambiar su valor en tiempo de ejecución
// mientras que var no puede ya que es obligatorio hacer la inicialización y una vez que eso ocurre el compilador infiere el tipo de dato en la vida del programa
var edad = 10; // El compilador infiere que el tipo de dato es int 
// edad = "diez"; // Esto es un error ya que el tipo de dato es int
Console.WriteLine("La edad es: : " + edad +  " y es de tipo de dato: " + edad.GetType());

// Interpolación de strings. Se realiza con el signo de $ 
string userA = "Carlos";
Console.WriteLine("*** Example of string interpolation ***");
Console.WriteLine($"Welcome {userA} to my system");



dynamic estatura; // No se necesita inicalizar y por lo tanto su valor es null
// Console.WriteLine("La estatura es: : " + estatura  + " y es de tipo de dato: " + estatura.GetType());  Marca error ya que la variable no tiene un valor asignado

estatura = 1.78d; // En primera instancia es un double pero podemos cambiarlo a un string
Console.WriteLine("La estatura es: : " + estatura + " y es de tipo de dato: " + estatura.GetType());
estatura = "1.78m"; // No es un error
Console.WriteLine("La estatura es: : " + estatura + " y es de tipo de dato: " + estatura.GetType());

/* Nullables */
// Otro tipo de dato son las variables que tienen el valor de null, es decir, que no tienen ningun valor, normalmente se representa como T?
// las variables que son nulas quieren decir que pueden almacenar valores nulos y su valor como tal, podemos declarar una variable nullable como lo siguiente
Console.WriteLine("***************** Nullables **************** ");
bool? isLogin = true;
Console.WriteLine($"The user: { userA } is logged: { isLogin }");

// Simulando que el usuario cerró sesión u ocurrió un error
isLogin = null;
Console.WriteLine($"The user: {userA} is not logged: {isLogin} - { isLogin?.GetType() }");
Console.WriteLine($"The value of isLogin is a boolean: { isLogin is bool  } ");

// Para las variables nullables podemos usar el metodo hasValue ya que una variable nullable es del tipo Nullable<T>
// entonces esto nos proporciona los metodos HasValue y Value, el primero devuelve un booleano e indicar si tiene un valor subyacente 
// y con Value obtenemos el valor subyacente, si el nullable no tiene valor y se accede a Value entonces genera una excepción
Console.WriteLine($"Variable isLogin has value: { (isLogin.HasValue ? isLogin.Value : "No") }");

// Tambien podemos hacer la comparación con null es decir isLogin == null
/******************** Constantes **********************/
// Son aquellas variables que no pueden cambiar en tiempo de ejecución
const int miEdad = 18;
Console.WriteLine("La edad constante es: " + miEdad);
// miEdad = 11220; Es un erro de compilación


// Variables de fechas.
var hoy = DateTime.Now.ToString();
Console.WriteLine("La fecha de hoy es: " + hoy); //29/10/2023 07:41:47 p. m.

var hoy2 = DateTime.Today.ToString("dd-MM-yyyy");
Console.WriteLine("Fecha con formato: " + hoy2); //29 - 10 - 2023

// Para hacer el casteo de variables podemos hacer con los metodos Parse de los tipos primitivos
var cadenaNumero = "5";
int numeroDesdeCadena = int.Parse(cadenaNumero);
numeroDesdeCadena++;
Console.WriteLine("Numero de la cadena: " + numeroDesdeCadena); //6

// Podemos hacerlo desde booleanos tambien
var booleano1 = "true";
bool booleano2 = bool.Parse(booleano1);
Console.WriteLine("Valor booleano convertido: " + booleano2 + " y su tipo de dato es: " + booleano2.GetType().ToString()); // True, Boolean

var fechaString = "29/10/2023";

DateTime fecha2 = DateTime.Parse(fechaString);
// Fecha formateada es: 29/10/2023 12:00:00 a. m. y su tipo de dato es: System.DateTime
Console.WriteLine("Fecha formateada es: " + fecha2 + " y su tipo de dato es: " + fecha2.GetType().ToString());

// Ejemplo de TryParse
var cadena3 = "2023-10-29";
DateTime fecha3;
if ( DateTime.TryParse(cadena3, out fecha3) ){ // Si el parseo es correcto se ejecuta el codigo
    Console.WriteLine("Fecha con un año adelantado: " + fecha3.AddYears(1).ToString()); // Fecha con un año adelantado: 29 / 10 / 2024 12:00:00 a.m.
} else { // Si el parseo fue incorrecto
    Console.WriteLine($"La cadena {cadena3} no tiene el formato adecuado"); // La cadena Hello world no tiene el formato adecuado
}

// Ejemplo de casting explicito
var numeroa = 1;
var numerob = 3;
Console.WriteLine("Resultado de la división: " + ( (double) numeroa / numerob)); // 0

// Ejemplo de ENUMS
var estatusPersona1 = ESTATUS.ERROR_NOT_FOUND;
// Valor de estatus: ERROR_NOT_FOUND y su valor entero es: 4
Console.WriteLine("Valor de estatus: " + estatusPersona1 + " y su valor entero es: " + (int)ESTATUS.ERROR_NOT_FOUND); 


// Sources:
/* 
 1. https://www.geeksforgeeks.org/difference-between-var-and-dynamic-in-c-sharp/
 2. https://www.geeksforgeeks.org/c-sharp-verbatim-string-literal/
 3. https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/reference-types#the-string-type
 
 */






