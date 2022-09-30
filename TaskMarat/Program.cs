// написать программу, которая изимеющегося массива строк, формирует массив из строк длина которых, меньше либо равна 3 символа. 
//Первоначальный массив можно ввести с клавиатуры, либо задать настарте выполнения алгоритма. При решении использовать массивы.

using System;
using static System.Console;
string[] ThreeSizeCharacters(string[] array)   //Метод для создания массива из строк, 
{                                              //длина которых меньше или равна 3 символа.
    int sizeResultArray = 0;

    for (int i = 0; i < array.Length; i++)
        if (array[i].Length <= 3)
            sizeResultArray++;

    string[] resultArray = new string[sizeResultArray];
    int j = 0;

    for (int i = 0; i < array.Length; i++)
        if (array[i].Length <= 3)
        {
            resultArray[j] = array[i];
            j++;
        }
    return resultArray;
}

void ShowArray(string[] array)
{
    Console.Write($"[{String.Join(", ", array)}]");
}

Clear();
Write("Введите через пробел массив строк: ");
string[] startArray = ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries); //При вводе исключаем ошибку двойных и более пробелов.

string[] newArray = ThreeSizeCharacters(startArray);
ShowArray(startArray);
Write(" -> ");
ShowArray(newArray);