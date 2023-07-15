/*Напишите программу, которая на вход принимает позиции элемента в 
двумерном массиве, и возвращает значение этого элемента 
или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет*/

using System;

public class Program
{
    public static void Main()
    {
        
        int numberOfRows = GetPositiveIntegerFromUser("Введите количество строк массива: ");
        int numberOfColumns = GetPositiveIntegerFromUser("Введите количество столбцов массива: ");

        
        int[,] matrix = new int[numberOfRows, numberOfColumns];

       
        Random random = new Random();

        
        for (int i = 0; i < numberOfRows; i++)
        {
            for (int j = 0; j < numberOfColumns; j++)
            {
                matrix[i, j] = random.Next(-1000, 1000 + 1);
            }
        }

       
        Console.WriteLine("\nВаш массив:");
        for (int i = 0; i < numberOfRows; i++)
        {
            for (int j = 0; j < numberOfColumns; j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }

        
        Console.Write("\nВведите индекс строки: ");
        int row = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите индекс столбца: ");
        int column = Convert.ToInt32(Console.ReadLine());

        
        Console.WriteLine(GetElementFromMatrix(matrix, row, column));
    }

    public static string GetElementFromMatrix(int[,] matrix, int row, int column)
    {
        
        if (row >= 0 && row < matrix.GetLength(0) && column >= 0 && column < matrix.GetLength(1))
        {
            return "Значение элемента: " + matrix[row, column].ToString();
        }
        else
        {
            return "Элемент с такими индексами не существует.";
        }
    }

    public static int GetPositiveIntegerFromUser(string prompt)
    {
        int number;
        do
        {
            Console.Write(prompt);
        }
        while (!int.TryParse(Console.ReadLine(), out number) || number <= 0);
        return number;
    }
}
