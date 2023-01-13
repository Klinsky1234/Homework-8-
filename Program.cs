/* Задача 53. Задайте двумерный массив. Напишите программу, которая меняет первую строчку и последнюю.
Например: 
1 4 7 2     8 4 2 4 
5 9 2 3  -> 5 9 2 3
8 4 2 4     1 4 7 2  
int[,] array = new int[4, 4];
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(10);
        Console.Write($"{array[i, j]} ");
    }
    Console.WriteLine();
}
int x = array.GetLength(0) - 1; // от длины минусуем 1 ,что бы получить индекс (как-то так)
for (int i = 0; i < array.GetLength(1); i++)
{
    (array[0, i], array[x, i]) = (array[x, i], array[0, i]);
}
Console.WriteLine();
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        Console.Write($"{array[i, j]} ");
    }
    Console.WriteLine();
}
*/

/* Задача 55. Задайте двумерный массив. Напишите программу, которая меняет стобцы и строки местами 
Если это невозможно. пользователю должна выводится соответсвующая надпись.
4 4 2 1 
2 9 6 6 
1 3 7 7 
4 2 7 8 
        
4 2 1 4 
4 9 3 2 
2 6 7 7 
1 6 7 8 
int[,] array = new int[4, 4];
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(10);
        Console.Write($"{array[i, j]} ");
    }
    Console.WriteLine();
}
if (array.GetLength(0) != array.GetLength(1))
{
    Console.Write($"Смена данного массива невозможна");
    return;
}
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = i + 1; j < array.GetLength(1); j++)
    {
        (array[i, j], array[j, i]) = (array[j, i], array[i, j]);
    }
}
Console.WriteLine();
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        Console.Write($"{array[i, j]} ");
    }
    Console.WriteLine();
}
*/
/* Задача 59. Из двумерного массива надо удалить строку и столбец, 
на перечении которых расположен наименьший элемент


int[,] array = new int[4, 4];
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(10);
        Console.Write($"{array[i, j]} ");
    }
    Console.WriteLine();
}
int imin = 0; // индекс строки минимального элемента 
int jmin = 0; // индекс столбца минимального элемента 
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        if (array[i, j] < array[imin, jmin]) ; // нашли индексы минмиальных элементов 
        {
            imin = i;
            jmin = j;
        }
    }
}
int[,] array2 = new int[array.GetLength(0) - 1, array.GetLength(1) - 1]; // поскольку мы удаляем строку и столбец, то берём параметры изначального массива и уменьшаем на 1 
for (int i = 0, i2 = 0; i2 < array2.GetLength(0); i++, i2++)
{
    for (int j = 0, j2 = 0; j2 < array2.GetLength(1); j++, j2++)
    {
        if (i == imin) i++;
        if (j == jmin) j++;
        array2[i2, j2] = array[i, j];
    }
}
array = array2;

Console.WriteLine($"\n{imin} {jmin}");
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)

        Console.Write($"{array[i, j]} ");
    Console.WriteLine();

} */

/* Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2 */

