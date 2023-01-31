// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

Console.Clear();

int InputInt(string message)
{
    System.Console.Write(message + " > ");
    string? inputValue = Console.ReadLine();
    int result = Convert.ToInt32(inputValue);
    return result;
}

void CleareArray(double[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = Convert.ToDouble(new Random().Next(100,1000)) / 100;
    }
}

void PrintArray(double[] array)
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

void Calculations(double[] array)
{
    double min = Int32.MaxValue;
    double max = Int32.MinValue;
    for (int j = 0; j < array.Length; j++)
    {
        if (array[j] > max)
        {
            max = array[j];
        }
        if (array[j] < min)
        {
            min = array[j];
        }
    }
    System.Console.WriteLine($"Максимальное значение элемента в массиве = {max}.");
    System.Console.WriteLine($"Минимальное значение элемента в массиве = {min}.");
    System.Console.WriteLine($"Разница между максимальным и минимальным значением = {max - min}");
}

int size = InputInt("Введите количество элементов массива");
double[] array = new double[size];
CleareArray(array);
System.Console.Write("Наш массив: ");
PrintArray(array);
Calculations(array);