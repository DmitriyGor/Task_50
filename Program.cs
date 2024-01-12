/*
Задача 50: 
Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
1,7 -> числа с такими позициями в массиве нет
*/
// Двумерный массив

// Метод для создания массива
// Двумерный массив = matrix
// m - количество строчек, n - количество столбцов
Console.Write("Введите количество строчек : ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов : ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное число диапазона чисел из которого будут заполнены элементы массива  : ");
int minElements = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное число диапазона чисел из которого будут заполнены элементы массива  : ");
int maxElements = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int[,] resMatrix = GetMatrix(rows, columns, minElements, maxElements);

// rows = 3 columns = 4 => таблица из 3-х строк и 4 -х столбцов, элемент: число от min до max включительно
PrintMatrix(resMatrix); // PrintMatrix(матрица)
Console.WriteLine();
ReplaceByEvenIndex(resMatrix);

int[,] GetMatrix(int m, int n, int minElements, int maxElements)
{
    int[,] matrix = new int[m,n]; // Таблица из m - строк и n - столбцов
    for (int i = 0; i < matrix.GetLength(0); i++) // Цикл по строчкам, i < m
    {
       // i, j, m, k
       for (int j = 0; j < matrix.GetLength(1); j++) // Цикл по столбцам, j < n
       {
        matrix[i, j] = new Random().Next(minElements, maxElements+1);
       } 
    }
    return matrix;
}

// Метод, который печатает массив
void PrintMatrix(int[,] array2D)
{
    for (int i = 0; i < array2D.GetLength(0); i++) // строчки
    {
       for (int j = 0; j < array2D.GetLength(1); j++) // столбцы
       {
        Console.Write(array2D[i, j] + "\t"); // "\t" = Tab = 4 пробела между элементами
       } 
       Console.WriteLine();
    }
}

// Метод, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
void ReplaceByEvenIndex(int[,] array2D)
{
Console.Write("Введите элемент (строка), который нужно вывести на экран   : ");
int indexsM = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите элемент (столбец), который нужно вывести на экран   : ");
int indexsN = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

    for (int i = 0; i < array2D.GetLength(0); i++) // строчки
    {
       for (int j = 0; j < array2D.GetLength(1); j++) // столбцы
       {
            if (indexsM < 0 | indexsM > array2D.GetLength(0) - 1 | indexsN < 0 | indexsN > array2D.GetLength(1) - 1)
            {
                Console.WriteLine("Введенные данные за пределами данного массива. Числа с такими позициями в массиве нет !!! ");
                return; 
            }
            else
            {
                
            }       
        }        
    }
Console.WriteLine($"Значение элемента массива с индексами [{indexsM},{indexsN}]   =   {array2D[indexsM, indexsN]}");     
}         



