// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

using System;

class Program
{
    static void Main()
    {

        string[] inputArray = { "Work", "ing", "Tree", "Wtr" };


        string[] resultArray = FilterArray(inputArray);


        Console.WriteLine("Результат: [" + string.Join(", ", resultArray) + "]");
    }

    static string[] FilterArray(string[] array)
    {

        string[] tempArray = new string[array.Length];
        int count = 0;


        foreach (string str in array)
        {

            if (str.Length <= 3)
            {
                tempArray[count] = str;
                count++;
            }
        }


        string[] resultArray = new string[count];
        Array.Copy(tempArray, resultArray, count);

        return resultArray;
    }
}
