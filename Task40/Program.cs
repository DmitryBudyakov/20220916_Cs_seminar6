// Задача 40:
// Напишите программу, которая принимает на вход три
// числа и проверяет, может ли существовать треугольник с сторонами
// такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон.

bool CheckTriangleExist(int num1, int num2, int num3)
{
    if (num1 < num2 + num3 
        && num2 < num1 + num3 
        && num3 < num1 + num2
        ) return true;
    else return false;
}

// вводим стороны треугольника
Console.Write("Введите длину 1-ой стороны треугольника: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите длину 2-ой стороны треугольника: ");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите длину 3-ой стороны треугольника: ");
int number3 = Convert.ToInt32(Console.ReadLine());

// результат проверки
bool verdict = CheckTriangleExist(number1, number2, number3);
// вывод в консоль
if (verdict) Console.WriteLine("Такой треугольник может существовать.");
else Console.WriteLine("Такой треугольник не может существовать.");
