const int SIZE = 4;
int[,] arr2D = new int[SIZE, SIZE];

//заполнение 
for (int i = 0; i < SIZE; i++)
    for (int j = 0; j < SIZE; j++) do
        {
            Console.Write($"[{i},{j}] = ");
        } while (int.TryParse(Console.ReadLine(), out arr2D[i, j]) == false);
Console.WriteLine("----------------------");
PrintArr2D(arr2D);
//разворот в ономерную по столбцам 
int[] arr = new int[SIZE * SIZE];
for (int i = 0; i < SIZE; i++)
    for (int j = 0; j < SIZE; j++)
        arr[i * SIZE + j] = arr2D[j, i];
Console.WriteLine("----------------------");
string arrString = PrintArr(arr);
Console.WriteLine(arrString);
//запись в файл 
File.WriteAllText("Array.txt", arrString);
Console.WriteLine("запись в файле Array.txt");
Console.ReadKey(true);
void PrintArr2D(in int[,] arr2D)
{

    for (int i = 0; i < SIZE; i++)
    {
        for (int j = 0; j < SIZE; j++)
            Console.Write($"{arr2D[i, j]} ");
        Console.WriteLine();
    }
}
string PrintArr(in int[] arr) => string.Join(" ", arr);


