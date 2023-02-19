/*Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, 
является ли оно палиндромом. Через строку решать нельзя.
14212 -> нет
12821 -> да
23432 -> да*/
/*
Задача 19 - HARD необязательная
Напишите программу, которая принимает на вход целое число любой разрядности 
и проверяет, является ли оно палиндромом. Через строку нельзя решать само собой.
*/
// свернул код, т.к. не влазиет в экран (скрин).
/*
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int Rasr(int x)      // Нахожу 10 в степени равную количеству разрядов
{
    int j = 0, b = 1, a = 10, n = x;
    while (j != n)
    {
        j++;
        b *= a;
    }
    return b;
}
string Palindrome(int num)  // Узнаю, является ли число палендромом
{
    int num3 = num;
    int num2 = num;
    int count = 0;
    string number2 = "";
    string res = "";
    while (num > 0)
    {
        count++;
        num /= 10;
    }
    int number1 = num2 / Rasr(count / 2);
    if (count % 2 == 0)
    {
        for (int i = 0; i < count / 2; i++)
        {
            number2 = number2 + $"{num2 % 10}";
            num2 /= 10;
        }
    }
    else
    {
        for (int i = 0; i <= count / 2; i++)
        {
            number2 = number2 + $"{num2 % 10}";
            num2 /= 10;
        }
    }
    if (number1 == Convert.ToInt32(number2))
        res = $"{num3} -> ДА";
    else
    {
        res = $"{num3} -> НЕТ";
    }
    return res;
}

Console.WriteLine(Palindrome(num));
*/
/*
Напишите программу, которая принимает на вход координаты двух 
точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/
/*
Задача 21 - HARD необязательная
Напишите программу, которая принимает на вход координаты двух 
точек и находит расстояние между ними в N-мерном пространстве. 
Сначала задается N с клавиатуры, потом задаются координаты точек.
*/
/*
Console.Write("Введите количество пространств: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array1 = new int[n];
int[] array2 = new int[n];
int i = 0;
while (i < n)           // Заполняю первый список координатами первой точки
{
    i++;
    Console.Write($"Введите координату {i} первой точки: ");
    int elem = Convert.ToInt32(Console.ReadLine());
    i--;
    array1[i] = elem;
    i++;
}
int j = 0;
while (j < n)           // Заполняю второй список координатами второй точки
{
    j++;
    Console.Write($"Введите координату {j} второй точки: ");
    int elem = Convert.ToInt32(Console.ReadLine());
    j--;
    array2[j] = elem;
    j++;
}
double Distance(int[] arr1, int[] arr2)     // Нажодим растояние между точками
{
    double res = 0;
    for (int k = 0; k < array1.Length; k++)
        res += Math.Pow((arr1[k] - arr2[k]), 2);
    res = Math.Round(Math.Sqrt(res), 2);
    return res;
}
Console.WriteLine(Distance(array1, array2));
*/
/*
Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу 
кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/
string Cube(int num)            // try свернул, т.к. не влазиет код в скрин.
{
    double[] array = new double[num];
    string res = $"{num} -> ";
    for (int i = 1; i <= num; i++)
    {
        array[i - 1] = Math.Pow(i, 3);
    }
    res = res + String.Join(", ", array);
    return res;
}
try
{
    Console.Write("Введите целое число: ");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(Cube(n));
}
catch
{
    Console.WriteLine("Введены некорректные данные.");
}