// Задайте двумерный массив из целых чисел.
// найдите среднее арифметическое элементов в каждом столбце.

Console.Clear();

void ShowMeaning(int[,] array)
{
    Console.WriteLine("среднее арифметическое каждого столбца -> ");
    for (int i = 0; i < array.GetLength(1); i++)
    {
        double sum = 0;
        for (int j = 0; j < array.GetLength(0); j++)
        {
            sum += array[j,i];
        }
        sum = sum / array.GetLength(0);
        Console.Write(sum + ", ");
    }
}

void ShowArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}

int[,] CreateRandomArray(int rows, int columns, int leftRange, int rightRange)
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i,j] = new Random().Next(leftRange, rightRange + 1);
        }
    }
    return array;
}

int EnterNumber(string message)  //message - сообщение
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine());
    return number;
}

// получить от пользователя M и N 
int m = EnterNumber("введите значение m ");
int n = EnterNumber("введите значение n ");

// создать двумерный массив и заполнить 
int[,] matrix = CreateRandomArray(m, n, 1, 9); // Создать случайный массив

// вывести массив в консоль
ShowArray(matrix); // Показать массив

// найти среднее арифметическое столбца.
// вывести значение
ShowMeaning(matrix);