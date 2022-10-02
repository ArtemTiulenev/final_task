Console.Clear();
string[] M1;
Console.WriteLine("Введите массив строк через пробел");
string text = Console.ReadLine();
M1 = text.Split(' ');
string[] M2 = new string[M1.Length];

void ResArray(string[] M1, string[] M2)
{
    int j = 0;
    for (int i = 0; i < M1.Length; i++)
    {
    if(M1[i].Length <= 3)
        {
        M2[j] = M1[i];
        j++;
        }
    }
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

ResArray(M1, M2);

PrintArray(M2);