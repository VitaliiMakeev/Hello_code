/*int Metodika(int num, int num1)
{
    int result = 1;
    int i = 0;
    while (i < num1)
    {
        i++;
        result *= num;
    }
    return result;
}

Console.WriteLine(Metodika(5, 7));
double n = Math.Pow(5, 7);
Console.WriteLine(n);*/
/*
int Razr(int num)
{
    int count = 0;
    while (num != 0)
    {
        num /= 10;
        count++;
    }
    return count;
}
try
{
    Console.Write("Введите число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Количество чисел в числе - {Razr(number)}");
}
catch
{
    Console.WriteLine("Введены некорректные данные!");
}
*/


int[] arr = new int[8];
Random rand = new Random();
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = rand.Next(0, 2);
}
Console.WriteLine(string.Join(", ", arr));