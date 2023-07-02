/*Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
лучше обойтись исключительно массивами.

Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []*/

using System;
using static System.Console;
Clear();
string[] array = new string[5] {"1234", "1567", "-2", "computer science", "mmm"};
WriteLine(String.Join("    ", array));
WriteLine();
string[] array1 = new string[array.Length];
SecondArray(array, array1);
PrintArray(array1); 

void SecondArray(string[] array, string[] array1)
{
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
    if(array[i].Length <= 3)
        {
        array1[j] = array[i];
        j++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Write($"{array[i]}    ");
    }
    WriteLine();
}

