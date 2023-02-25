/*
Console.Write("Введите свое имя: ");
string username = Console.ReadLine();
if (username.ToLower() == "маша")
{
    Console.WriteLine("Ура, это же Маша!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}
*/
// Урок 5
/*
Задача 32: Напишите программу замена элементов массива: 
положительные элементы замените на соответствующие отрицательные, и наоборот.
[-4, -8, 8, 2] -> [4, 8, -8, -2] 
*/
void PrintArray(int[] array)
{
    foreach (var el in array)
        Console.Write($"{el} ");
    Console.WriteLine();
}

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(-100, 101);
}
/*
int[] array1 = new int[4];
FillArray(array1);
PrintArray(array1);

for (int i = 0; i < array1.Length; i++)
{
    array1[i] = -array1[i];
}*/

/*
Задача 33: Задайте массив. Напишите программу, которая определяет, 
присутствует ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет
-3; массив [6, 7, 19, 345, 3] -> да
*/
/*
string Serch(int num, int[] array)
{
    string result = "Числа нет в массиве";
    foreach (var el in array)
    {
        if (el == num)
            result = "Число есть в массиве";
    }
    return result;
}

int[] array2 = new int[10];
int number = 4;
FillArray(array2);
PrintArray(array2);
Console.WriteLine(Serch(number, array2));
*/
/*
Задача 35: Задайте одномерный массив из 12 случайных чисел в 
диапазоне от -100 до 100. Найдите количество элементов массива, 
значения которых лежат в отрезке [10,99]. 
Пример для массива из 5, а не 12 элементов. В своём решении сделайте для 123
[5, 18, 123, 6, 2] -> 1
[1, 2, 3, 6, 2] -> 0
[10, 11, 12, 13, 14] -> 5
*/
/*
int[] array3 = new int[12];
FillArray(array3);


int CountEl(int[] array)
{
    int count = 0;
    foreach (var el in array)
    {
        if (el <= 99 && el >= 10)
            count++;
    }
    return count;
}
PrintArray(array3);
Console.WriteLine(CountEl(array3));
*/


/*
Задача 37: Найдите произведение пар чисел в одномерном массиве. 
Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21
*/


int[] Master(int[] array)
{
    int result = 0;
    int i = 0;
    int[] tmp = new int[array.Length / 2 + array.Length % 2];
    if (array.Length % 2 == 0)
    {
        for (int k = 0; k < array.Length / 2; k++)
        {
            i++;
            result = array[i - 1] * array[array.Length - i];
            tmp[i - 1] = result;
        }
    }
    else
    {
        tmp[^1] = array[array.Length / 2];
    }
    return tmp;
}

int[] array4 = new int[4];
FillArray(array4);
PrintArray(array4);
PrintArray(Master(array4));



