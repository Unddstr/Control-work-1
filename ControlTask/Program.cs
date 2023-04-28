﻿/* Написать программу, которая из имеющегося массива строк 
формирует новый массив из строк, длина которых меньше, либо равна 3 символам*/

string[] arrString = { "1234", "1567", "-2", "computer science", "fox" };

string[] symbol(string[] arrString)
{
    int n = 0;
    for (int i = 0; i < arrString.Length; i++)
    {
        if (arrString[i].Length <= 3)
            n++;
    }
    string[] result = new string[n];
    int j = 0;
    for (int i = 0; i < arrString.Length; i++)
    {
        if (arrString[i].Length <= 3)
        {
            result[j] = arrString[i];
            j++;
        }
    }
    return result;
}
void printArr(string[] arrString)
{
    Console.Write("[");
    for (int i = 0; i < arrString.Length; i++)
    {
        if (i < arrString.Length - 1)
        {
            Console.Write($"\"{arrString[i]}\", ");
        }
        else
        {
            Console.Write($"\"{arrString[i]}\"");
        }
    }
    Console.Write("]");
}
string[] newArr = symbol(arrString);
printArr(newArr);