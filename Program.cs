/*
Задача: Написать программу, которая из имеющегося массива строк формирует 
новый массив из строк, длина которых меньше, либо равна 3 символам.
Первоначальный массив можно ввести с клавиатуры, либо задать на старте 
выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
лучше обойтись исключительно массивами.
 */
using static System.Console;
Clear();
              
string[] array = new string[4] { "Hello", "2", "world", ":-)" };
string[] newArray = new string[array.Length];
CreateNewArray(array, newArray);
ShowArray(newArray);









void CreateNewArray(string[] array, string[] newArray)
    {
        int count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i].Length <= 3)
            {
                newArray[count] = array[i];
                count++;
            }
        }
    }
void ShowArray(string[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Write($"{array[i]} ");
        }
            WriteLine();
    }