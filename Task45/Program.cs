// Задача 45:
// Напишите программу, которая будет создавать
// копию заданного массива с помощью поэлементного
// копирования.

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

int[] CopyArray(int[] origArray)
{
    int length = origArray.Length;
    int[] copyArray = new int[length];
    for (int i = 0; i < length; i++)
    {
        copyArray[i] = origArray[i];
    }
    return copyArray;
}

Console.Clear();
// вводим данные для создания массива
Console.Write("Введите кол-во элементов в массиве: ");
int arrayNums = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите min порог для Random: ");
int arrayMin = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите max порог для Random: ");
int arrayMax = Convert.ToInt32(Console.ReadLine());

// создаем массив - оригинал
int[] origArr = CreateArrayRndInt(arrayNums, arrayMin, arrayMax);
Console.Write("Массив оригинал\t-> ");
PrintArray(origArr);
// создаем копию массива
int[] copyArr = CopyArray(origArr);
Console.Write("Массив копия\t-> ");
PrintArray(copyArr);
// проверяем, что оригинал не пострадал
Console.Write("Массив оригинал\t-> ");
PrintArray(origArr);
