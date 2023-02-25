/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

int Exponentiation(int num, int exp)
{
    int result = num;
    int i = 1;
    while (i < exp)
    {
        i++;
        result *= num;
    }
    return result;
}
Console.WriteLine(Exponentiation(3, 5));

/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/
/*
int SumNum(int number)
{
    int result = 0;
    while (number > 0)
    {
        result += number % 10;
        number /= 10;
    }
    return result;
}
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"{num} -> {SumNum(num)}");
*/
/*
Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33-> [6, 1, 33]
*/
/*
void ArrayRandom(int n, int from, int befor)
{
    int[] arr = new int[n];
    Random rand = new Random();
    for (int i = 0; i < arr.Length; i++)
        arr[i] = rand.Next(from, befor);
    Console.WriteLine($"{string.Join(", ", arr)} -> [{string.Join(", ", arr)}]");
}
ArrayRandom(8, 0, 100);
*/