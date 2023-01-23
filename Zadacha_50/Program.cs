// Напишите программу, которая на вход принимает позиции элемента
// в двухмерном массиве, и возвращает значение этого элемента
// или же указание, что такого элемента нет.

Console.Clear();

void ShowMeaning(int[,] array, int meaningM, int meaningN)
{
    if(meaningM < array.GetLength(0) && meaningN < array.GetLength(1))
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if(meaningM == i && meaningN == j)
                {
                    Console.WriteLine($"значение координат {array[i,j]} ");

                }
                
            }
        }
    }
    else
    {
        Console.WriteLine($"{meaningM}, {meaningN} -> такого значения в массиве нет");
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
int[,] matrix = CreateRandomArray(m, n, 10, 99); // Создать случайный массив

// вывести массив в консоль
ShowArray(matrix); // Показать массив

// сравнить заданные координаты с длинной массива
// и вывести указанный элемент
int meaningM = EnterNumber("введите значение M "); // meaning - значение
int meaningN = EnterNumber("введите значение N ");
ShowMeaning(matrix, meaningM, meaningN);