Console.WriteLine(" 2 Hello, World!");

Console.Write("Введите пятизначное число: ");
int N = Convert.ToInt32(Console.ReadLine());
int tmp = N;
int num1 = N / 1000;
string num2 = String.Empty;
if (N / 10000 >= 1 && N / 10000 <= 9)
{
    for (int i = 0; i < 2; i++)
    {
        num2 = num2 + $"{N % 10}";
        N = N / 10;
    }
    if (num1 == Convert.ToInt32(num2)) Console.WriteLine($"{tmp} -> Да");
    else Console.WriteLine($"{tmp} -> Нет");
}
else Console.WriteLine($"{tmp} - Число не пятизначное!");