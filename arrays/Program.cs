// 1. Creando un array de 5 elementos sin inicializar valores
int[] arr = new int[5];
foreach(var i in arr){
    Console.WriteLine(i); // 0,0,0,0,0
}

// 2. Creando un array de 5 elementos pero inicializados
string[] arr2 = { "hello", "world", "from", "jc" };
for (int i = 0; i < arr2.Length; i++){
    Console.WriteLine($"i[{i}] = {arr2[i]}");
}

// Podemos crear un array de dos dimensiones de la siguiente manera
// 1. Array de dos dimensiones de dos filas y tres columnas
int[,] arr3 = new int[2,3];
foreach (var item in arr3){ //  item es un array 
    Console.WriteLine($"Element: {item} and his type is: {item.GetType().ToString() }");
}

// 2. Array de dos dimensiones inicializado
int[,] arr4 = { { 1, 2, 3 }, { 4, 5, 6 } };

// 3. Array jagged sin valores
int[][] arr5 = new int[4][];
arr5[0] =  new int[4] {1,2,3,4};
arr5[1] = new int[5] { 1, 2, 3, 4, 5 };
Console.WriteLine( arr5.ToString() );