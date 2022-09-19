using System;
using System.Security.Cryptography;
Console.WriteLine("Выберете действие: ");
Console.WriteLine("\r\n1. Сложить 2 числа\r\n2. Вычесть первое из второго\r\n3. Перемножить два числа\r\n4. Разделить первое на второе\r\n5. Возвести в степень N первое число\r\n6. Найти квадратный корень из числа\r\n7. Найти 1 процент от числа\r\n8. Найти факториал из числа\r\n9. Выйти из программы ");

Console.WriteLine("Введите первое число");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("введите второе число");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите операцию");
int c = Convert.ToInt32(Console.ReadLine());

while (c != 9)
{
    if(c == 1)
    {
        Console.WriteLine(a + b);
    }
    if(c ==2)
    {
        Console.WriteLine(a - b);
    }
    if(c == 3)
    {
        Console.WriteLine(a * b);
    }
    if(c == 4)
    {
        Console.WriteLine(a / b);
    }
    if(c == 5)
    {
        Console.WriteLine(Math.Pow(a,b));
    }
    if(c == 6)
    {
        Console.WriteLine(Math.Sqrt(a));
        Console.WriteLine(Math.Sqrt(b));
    }
    if(c == 7)
    {
        Console.WriteLine(a * 0.01);
        Console.WriteLine(b * 0.01);
    }
    if(c == 8)
    {
        int f = 1;
        for(int i = 1; i<= b; i++)
        {
            f = f * i;
        }
        Console.WriteLine(f);
    }
    Console.WriteLine("введите операцию");
    c = Convert.ToInt32(Console.ReadLine());
}


