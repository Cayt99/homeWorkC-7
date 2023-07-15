//  Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

using System;

public class Program
{
    public static void Main()
    {
        int numberOfRows = GetPositiveIntegerFromUser("Введите количество строк двумерного массива: ");
        int numberOfColumns = GetPositiveIntegerFromUser("Введите количество столбцов двумерного массива: ");

        double[,] randomNumbersMatrix = new double[numberOfRows, numberOfColumns];
        Random randomGenerator = new Random();

        for (int i = 0; i < numberOfRows; i++)
        {
            for (int j = 0; j < numberOfColumns; j++)
            {
                double randomNumber = randomGenerator.NextDouble() * 200 - 100;
                randomNumbersMatrix[i, j] = randomNumber;
            }
        }

        for (int i = 0; i < numberOfRows; i++)
        {
            for (int j = 0; j < numberOfColumns; j++)
            {
                Console.Write("{0,10:F2}", randomNumbersMatrix[i, j]);
            }
            Console.WriteLine();
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
