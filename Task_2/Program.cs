// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

Console.Clear();

int InputInt(string message)
{
    System.Console.Write(message + " > ");
    string? inputValue = Console.ReadLine();
    int result = Convert.ToInt32(inputValue);
    return result;
}

void CreateArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1,10);
    }
}

void PrintArray(int[] array)
{
    System.Console.Write("[");
    for(int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i]);
        if (i != array.Length-1)
        {
            System.Console.Write(", ");
        }
    }
    System.Console.Write("]");
    System.Console.WriteLine();
}

int SumIndex(int[] array)
{
    int sum = 0;
    for (int j = 0; j < array.Length; j = j + 2)
    {
    sum = sum + array[j];
    }
    Console.WriteLine($"Cумма элементов на нечётных позициях = {sum}");
    return sum;
}

int size = InputInt("Введите количество элементов массива");
int[] array = new int[size];
CreateArray(array);
System.Console.Write("Наш массив: ");
PrintArray(array);
int result = SumIndex(array);