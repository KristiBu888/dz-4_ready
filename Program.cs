// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите число A: ");
int A = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число степени B: ");
int B = Convert.ToInt32(Console.ReadLine());

int i = Convert.ToInt32(Math.Pow(A, B));

Console.WriteLine(A + " в степени " + B + " = " + i);

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


using System;
using System.Linq;

public class Example
{
    public static void Main()
    {
        Console.WriteLine("Введите число: ");
        int namber = Convert.ToInt32(Console.ReadLine());
        int[] arr = { namber }; //попытка перевести введенный текст в массив
        void PrintArray(int[] arr) //метод, чтоб пройтись по всем элементам массива
        {
            int count = arr.Length;
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"{arr[i]}");
            }
        }
        int sum = arr.Sum();//хотела использовать метод Sum, и для нег добавила первые 4 строчки кода, думаю это даже не связано(
        PrintArray(sum);
    }
}


// Попытка решения №2

Console.WriteLine("Введите число: ");
int namber = Convert.ToInt32(Console.ReadLine());
int[] arr = { namber };
int sum = 0;
foreach (int item in arr)
{
    sum += item;
}

Console.WriteLine(sum);

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8 };
void PrintArray(int[] arr)
{
    int count = arr.Length;
    for (int i = 0; i < count; i++)
    {
        Console.WriteLine($"{arr[i]}");
    }
}
PrintArray(arr); ..получилось почему то в столбик, не пойму как поменять
