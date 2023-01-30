// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

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
        array[i] = new Random().Next(100,1000);
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

int CountArray(int[] array)
{
    int count = 0;
    for (int j = 0; j < array.Length; j++)
    {
        if (array[j] % 2 == 0)
        {
            count++;
        }
    }
    System.Console.WriteLine($"В данном массиве чётные цифр > {count}");
    return count;
}

int size = InputInt("Введите количество элементов массива");
int[] array = new int[size];
CreateArray(array);
System.Console.Write("Наш массив:");
PrintArray(array);
int result = CountArray(array);