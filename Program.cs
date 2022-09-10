﻿/* Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. 
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
Примеры:
["hello", "2", "world", ":-)"]->["2", ":-)"]*/

int size = 4;
string[] strArray = new string[size];
int maxLength = 3;

FillArray(strArray);
Console.WriteLine("Массив");
PrintArray(strArray);

int rusultArraySize = SizeResultArray(strArray, maxLength);
string[] resultArray = new string[resultArraySize];

FillReultArray(strArray, resultArray, maxLength);
Console.WriteLine("РезалтМассив");
PrintArray(resultArray);

void FillArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите {i + 1} строку: ");
        array[i] = Console.ReadLine();
    }
}

void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i == array.Length - 1) Console.Write($"'{array[i]}'");
        else{
            Console.Write($"'{array[i]}', ");
        }
    }
    Console.Write("]");
    Console.WriteLine();
}
