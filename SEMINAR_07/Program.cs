class Program
{
    static void Main(string[] args)
    {
        #region SEMINAR

        #region Задача 1
        //**Задача 48:**Задайте двумерный массив размера m на n,
        //каждый элемент в массиве находится по формуле: Aₘₙ = m + n. Выведите полученный массив на экран.
        //m = 3, n = 4.
        //0 1 2 3
        //1 2 3 4
        //2 3 4 5

        Console.WriteLine("Введите размер массива: ");
        int[,] array = GetArray(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
        FillArray(array);
        PrintArray(array);

        #endregion

        #region Задача 2




        #endregion

        #region Задача 3




        #endregion

        #region Задача 4




        #endregion

        #endregion

        #region HOMEWORK

        #region Задача 47
        //Задача 47.Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
        //m = 3, n = 4.
        //1 7 - 2 - 85
        //1 - 3 8 - 9
        //8 7 - 7 9
        //int[,] array = GetArray(5, 5);
        //FillArray(array, true); // по умолчанию минимальное значение 0, максимальное 10
        //PrintArray(array);

        #endregion

        #region Задача 50
        //Задача 50.Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
        //и возвращает значение этого элемента или же указание, что такого элемента нет.
        //Например, задан массив:
        //1 4 7 2
        //5 9 2 3
        //8 4 2 4
        //i = 4, j = 2->такого числа в массиве нет
        //i = 1, j = 3-> 2

        //int[,] array = GetArray(5, 5);
        //FillArray(array, true, 1, 10);
        //Console.Write("Массив создан, введите число от 1 до 9: ");
        //FindElementInArray(array, int.Parse(Console.ReadLine()));
        //PrintArray(array);


        #endregion

        #region Задача 52
        //Задача 52.Задайте двумерный массив из целых чисел.Найдите среднее арифметическое элементов в каждом столбце.
        //Например, задан массив:
        //1 4 7 2
        //5 9 2 3
        //8 4 2 4

        //int[,] array = GetArray(5, 5);
        //FillArray(array, true);
        //PrintArray(array);
        //Console.WriteLine();
        //AvarageArrayColum(array);

        #endregion

        #endregion
    }
    static int[,] GetArray(int lines, int colum)
    {
        return new int[lines, colum];
    }
    static void FillArray(int[,] array, bool random, int min = 0, int max = 10)
    {
        if (random)
        {
            Random rand = new Random();

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = rand.Next(min, max);
                }
            }
        }
        else
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    int value;
                    Console.Write($"Введите значение для {i + 1} строки и {j + 1} столбца");
                    int.TryParse(Console.ReadLine(), out value);
                    array[i, j] = value;
                }
            }
        }
    }
    static void FillArray(int[,] array)
    {
        for (int m = 0; m < array.GetLength(0); m++)
        {
            for (int n = 0; n < array.GetLength(1); n++)
            {
                array[m, n] = m + n;
            }
        }
    }
    static void PrintArray(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write($"{array[i, j]} ");
            }
            Console.WriteLine();
        }
    }
    static void FindElementInArray(int[,] array, int value)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (array[i, j] == value)
                {
                    Console.WriteLine($"Первый найденный элемент {value} находится в {i} строке, {j} колонке");
                    return;
                }
            }
        }
        Console.WriteLine("Элемент не найден");
    }
    static void AvarageArrayColum(int[,] array)
    {
        float sum = 0;

        for (int i = 0; i < array.GetLength(1); i++)
        {
            for (int j = 0; j < array.GetLength(0); j++)
            {
                sum += array[i, j];
            }
            Console.WriteLine($"Среднее арифметическое {i} столбика = {sum / array.GetLength(1)}");
            sum = 0;
        }
    }
}