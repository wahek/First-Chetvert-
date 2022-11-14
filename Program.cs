
string[,] Array = GetString(3,3);
Console.WriteLine("Исходный массив");
PrintArray(Array);
Console.WriteLine("Массив выборки");
Selection(Array);

string[,] GetString(int row, int col)
{
    string[,] myStr = new string[row, col];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            Console.WriteLine($"Введите элемент на [{i}{j}] позиции");
            myStr[i, j] = Console.ReadLine()!;
        }
    }
    return myStr;
}

void PrintArray(string[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

void Selection(string[,] myArray)
{
    for (int i = 0; i < myArray.GetLength(0); i++)
    {
        for (int j = 0; j < myArray.GetLength(1); j++)
        {
            if (myArray[i,j].Length < 4)
            {
                Console.Write($"[{myArray[i,j]}]");
            }
        }
        Console.WriteLine();
    }
}
