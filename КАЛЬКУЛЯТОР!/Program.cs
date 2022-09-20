using System;
using System.Security.Cryptography;
Console.WriteLine("Выберете действие : ");
Console.WriteLine("1.Сложить 2 числа");
Console.WriteLine("2. Вычесть первое из второго");
Console.WriteLine("3. Перемножить два числа");
Console.WriteLine("4. Разделить первое на второе");
Console.WriteLine("5. Возвести в степень N первое число");
Console.WriteLine("6. Найти квадратный корень из числа");
Console.WriteLine("7. Найти 1 процент от числа");
Console.WriteLine("8. Найти факториал из числа");
Console.WriteLine("9. Выйти из программы");
Console.WriteLine("Введите первое число");
double numberOne = Convert.ToDouble(Console.ReadLine());
int y = 0;
Console.WriteLine("введите второе число");
double numberTwo = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("введите операцию");
double number = Convert.ToDouble(Console.ReadLine());
while (number != 9)
{
    switch (number)
    {
        case 1:
            Console.WriteLine(numberOne + numberTwo);
            break;
        case 2:
            Console.WriteLine(numberOne - numberTwo);
            break;
        case 3:
            Console.WriteLine(numberOne * numberTwo);
            break;
        case 4:
            Console.WriteLine(numberOne / numberTwo);
            break;
        case 5:

            Console.WriteLine(Math.Pow(numberOne, numberTwo));
            break;
        case 6:
            Console.WriteLine(Math.Sqrt(numberOne));
            break;
        case 7:

            Console.WriteLine(numberOne * 0.01);
            break;
        case 8:


            int f = 1;
            for (int i = 1; i <= numberTwo; i++)
            {
                f = f * i;
            }
            Console.WriteLine(f);

            break;
    }

    Console.WriteLine("введите операцию");
    number = Convert.ToDouble(Console.ReadLine());
}
    



