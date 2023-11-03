// 1. Creando un array de 5 elementos sin inicializar valores
int[] arr = new int[5];
foreach(var i in arr){
    Console.WriteLine(i); // 0,0,0,0,0
}

// 2. Creando un array de 5 elementos pero inicializados
string[] arr2 = { "hello", "world", "from", "jc", "c#" };
for (int i = 0; i < arr2.Length; i++){
    Console.WriteLine($"i[{i}] = {arr2[i]}");
}

// Accediendo al ultimo elemento del array arr2
var lastElement = arr2[^1];
Console.WriteLine("Last element: " + lastElement); // Last element: jc

Index penultimateElement = ^2;
Console.WriteLine("Penultime element: " + arr2[penultimateElement]  ); // Penultime element: from

// Rangos: Mejor conocidos como slices, permite obtener una parte de un array
// string[] arr2 = { "hello", "world", "from", "jc", "c#" };

var subarr1 = arr2[1..]; // Desde el indice 1 hasta el ultimo
Console.WriteLine( string.Join(',', subarr1) ); // ["world", "from", "jc"];

// 2. Desde el primer elemento hasta el elemento 2 (3)
var subarr2 = arr2[..3];
Console.WriteLine( string.Join(',', subarr2 ) ); // hello,world,from

// 3. Desde el elemento 1 hasta el elemento 2
var subarr3 = arr2[1..3]; 
Console.WriteLine( string.Join(',', subarr3 ) ); // word, from

// 4. Desde el elemento 1 hasta el penultimo elemento
var subarr4 = arr2[1..^1];
Console.WriteLine( string.Join(',', subarr4) ); // world,from,jc

// Almacenando en una variable
Range range1 = ^3..^1; // Desde el tercer elemento hacia atras hasta el penultimo elemento
Console.WriteLine( string.Join(',',arr2[range1]) ); // "from", "jc"


// Podemos crear un array de dos dimensiones de la siguiente manera
// 1. Array de dos dimensiones de dos filas y tres columnas
int[,] arr3 = new int[2,3];
foreach (var item in arr3){ //  item es un array 
    Console.WriteLine($"Element: {item} and his type is: {item.GetType().ToString() }");
}

// 2. Array de dos dimensiones inicializado
int[,] arr4 = { { 1, 2, 3 }, { 4, 5, 6 } };
// Podemos cambiar un elemento de un array
arr4[0,0] = 10;

// 3. Array jagged sin valores
int[][] arr5 = new int[4][];
arr5[0] =  new int[4] {1,2,3,4};
arr5[1] = new int[5] { 1, 2, 3, 4, 5 };
Console.WriteLine( arr5.ToString() );