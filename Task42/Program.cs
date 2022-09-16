// Задача 42:
// Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10


int ConvertDecToBin(int num)    // преобразование Dec -> Bin с разворотом числа
{
    int result = 0;
    int count = 1;
    while (num != 0)
    {
        result += (num % 2) * count;
        num /= 2;
        count *= 10;
    }
    return result;
}


Console.Clear();
int number = default;
Console.Write("Введите целое число: ");
    while (!int.TryParse(Console.ReadLine(), out number))
    {
        Console.Write("Ошибка ввода.\nВведите целое число: ");
    }

int resultNum = ConvertDecToBin(number);
Console.WriteLine(resultNum);
