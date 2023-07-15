/*Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

using System;

public class Program
{
    public static void Main()
    {
        int numberOfRows = GetPositiveIntegerFromUser("Введите количество строк: ");
        int numberOfColumns = GetPositiveIntegerFromUser("Введите количество столбцов: ");

        
        int[,] matrix = new int[numberOfRows, numberOfColumns];

      
        Random random = new Random();

       
        for (int i = 0; i < numberOfRows; i++)
        {
            for (int j = 0; j < numberOfColumns; j++)
            {
                matrix[i, j] = random.Next(-1000, 1000 + 1);
            }
        }

        
        Console.WriteLine("\nСгенерированный массив:");
        for (int i = 0; i < numberOfRows; i++)
        {
            for (int j = 0; j < numberOfColumns; j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }

        
        for (int j = 0; j < numberOfColumns; j++)
        {
            
            int columnSum = 0;
            for (int i = 0; i < numberOfRows; i++)
            {
                columnSum += matrix[i, j];
            }

            
            double average = (double)columnSum / numberOfRows;
            Console.WriteLine($"Среднее арифметическое в столбце {j + 1}: {average:F2}");
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
