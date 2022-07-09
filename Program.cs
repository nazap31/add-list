Console.WriteLine("sumar lista!");

Console.Write("Ingrese la cantidad de numeros: ");
int[] numbers = new int[Int32.Parse(Console.ReadLine() ??"0")];
////const int size = 5;
//int [] numbers = new int [size];

// Llenamos el array
for (int i = 0; i < numbers.Length; i++)
{
    Console.Write("Ingrese un numero: ");
    string input = Console.ReadLine () ?? "0";
    numbers[i] = Int32.Parse(input);
}
//sumamos el array
int total = 0;
for (int i = 0; i < numbers.Length; i++)
{
    total = total + numbers[i];
}
//imprimimos el array
Console.Write("Total: " + total);

//string input0 = Console.Readline() ?? "0";
//numbers[0] = Int32.Parse(input);
//string input1 = Console.Readline() ?? "0";
//numbers[1] = Int32.Parse(input);
//string input2 = Console.Readline() ?? "0";
//numbers[2] = Int32.Parse(input);
//string input3 = Console.Readline() ?? "0";
//numbers[3] = Int32.Parse(input);
//string input4 = Console.Readline() ?? "0";
//numbers[4] = Int32.Parse(input);

//Console.WriteLine(numbers[1]);
//Console.WriteLine(numbers[2]);
//Console.WriteLine(numbers[3]);
//Console.WriteLine(numbers[4]);


//numbers[0] = Int32.Parse(Console.ReadLine());