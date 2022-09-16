// Задача 44: 
// Не используя рекурсию, выведите первые N чисел
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

void Fibonacci(int num)     // через переменные
{
    int f1 = 0;
    int f2 = 1;
    int result = default;
    Console.Write($"{f1} {f2} ");
    for (int i = 2; i < num; i++)
    {
        result = f1 + f2;
        Console.Write($"{result} ");
        f1 = f2;
        f2 = result;
    }
}

int[] FibonacchiArray(int num)  // через массив
{
    int[] array = new int[num];
    array[0] = 0;
    array[1] = 1;
    for (int i = 2; i < num; i++)
    {
        array[i] = array[i-1] + array[i-2];
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


Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

Fibonacci(number);  // через переменные
Console.WriteLine();
int[] resultArray = FibonacchiArray(number);    // через массив
PrintArray(resultArray);
