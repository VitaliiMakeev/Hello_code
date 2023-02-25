/*Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3*/
/*
Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
if (num1 >= num2) Console.WriteLine(num1);
else Console.WriteLine(num2);*/

/*Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22*/
/*
Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int num3 = Convert.ToInt32(Console.ReadLine());
if (num1 >= num2 && num1 >= num3) Console.WriteLine(num1);
else if (num2 >= num1 && num2 >= num3) Console.WriteLine(num2);
else Console.WriteLine(num3);*/

/*Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет*/
/*
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num % 2 == 0)
{
    Console.Write("Ваше число: " + num);
    Console.Write(", четное!");
}
else
{
    Console.Write("Ваше число: " + num);
    Console.Write(", нечетное!");
}*/

/*Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8*/
/*
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
string strOut = num + " -> ";
int ind = 1;
while (num != ind)
{
    if (ind % 2 == 0)
    {
        strOut += ind + ", ";
        ind++;
    }
    else ind++;
}
Console.WriteLine(strOut);*/

/*Задача 7 HARD по желанию - идет за 2 необязательных Напишите программу, которая принимает на вход целое число любой разрядности и на выходе показывает вторую цифру слева этого числа или говорит, что такой цифры нет. Через строку решать нельзя.
456111 -> 5
78 -> 8
9146548 -> 1
3 -> нет*/

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
string result = num + " -> ";
if (num < 10) Console.WriteLine("У вашего числа меньше 2-х разрядов");
else
{
    while (true)
    {
        if (num / 100 == 0)
        {
            Console.WriteLine(result + (num % 10));
            break;
        }
        num /= 10;
    }
}

