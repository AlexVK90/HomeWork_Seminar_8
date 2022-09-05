/*Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

В итоге получается вот такой массив:

1 2 4 7

2 3 5 9

2 4 4 8

Console.Clear();

int[,] Sort(int[,] array)
{
    for( int k = 0; k < array.GetLength(0); k++)
    {
        for (int i = 0; i <array.GetLength(0) -1; i++)
        {
          for ( int j = 0; j < array.GetLength(1) -1; j++)
          {
            if(array[k,j] < array[ k,j +1])
            {
              int temp = array[k, j];
              array[k, j] = array[k, j + 1];
              array[k, j + 1] = temp;
            }
          }
        }
        
    }
    return array;


}

int[,] CreateRandom2dArray(int rows, int colums, int minValue, int maxValue)
{
    int[,] newArray = new int[rows, colums];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            newArray[i, j] = new Random().Next(minValue, maxValue + 1);
        }

    }

    return newArray;
}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++) // вывод первой строки
    {
        for (int j = 0; j < array.GetLength(1); j++)// вывод первого столбца
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}


Console.Write("Input number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of colums: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input minValue of element: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input maxValue of element: ");
int max = Convert.ToInt32(Console.ReadLine());
int[,] array = CreateRandom2dArray(m, n, min, max);


Sort(array);
Show2dArray(array);




*/
/*
            Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

            Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


*/
/* 
Console.Clear();

Console.Write("Input number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of colums: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input minValue of element: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input maxValue of element: ");
int max = Convert.ToInt32(Console.ReadLine());
int[,] array = CreateRandom2dArray(m, n, min, max);

int[,] CreateRandom2dArray(int rows, int colums, int minValue, int maxValue)
{
    int[,] newArray = new int[rows, colums];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            newArray[i, j] = new Random().Next(minValue, maxValue + 1);
        }

    }

    return newArray;
}

int Sum(int [,] array)
{int imin =0;
 int min =int.MaxValue;;

  for (int i = 0; i < array.GetLength(0); i++) 
    {
      int sum = 0;
      for (int j = 0; j < array.GetLength(1); j++)
      {
          sum = sum + array[i,j];
          
          if (sum < min)
          min = sum;
          imin = i; 
      }
    }
  return imin;
}      

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++) // вывод первой строки
    {
        for (int j = 0; j < array.GetLength(1); j++)// вывод первого столбца
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
    


Show2dArray(array);


Console.Write($" Номер строки с наименьшей суммой: {Sum(array)}");




*/
/*Задача 58: Задайте две матрицы.Напишите программу, которая будет находить произведение двух матриц.

Например, заданы 2 массива:

            1 4 7 2

5 9 2 3

8 4 2 4

5 2 6 7

и

1 5 8 5

4 9 4 2

7 2 2 6

2 3 4 7

Их произведение будет равно следующему массиву:

1 20 56 10

20 81 8 6

56 8 4 24

10 6 24 49

*/
/*
Console.Clear();

int m = InputNumbers("Input number of rows array 1: ");
int n = InputNumbers("Input number of colums array 1:  ");
int p = InputNumbers("Input number of colums array 2: ");
int range = InputNumbers("Введите диапазон случайных чисел: от 1 до ");

int[,] firstArray = new int[m, n];
CreateArray(firstArray);

Show2dArray(firstArray);
Console.WriteLine();

int[,] secondArray = new int[n, p];
CreateArray(secondArray);

Show2dArray(secondArray);
Console.WriteLine();

int[,] resultArray = new int[m, p];

MultiplyArray(firstArray, secondArray, resultArray);

Show2dArray(resultArray);

void MultiplyArray(int[,] firstArray, int[,] secondArray, int[,] resultArray)
{
    for (int i = 0; i < resultArray.GetLength(0); i++)
    {
        for (int j = 0; j < resultArray.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < firstArray.GetLength(1); k++)
            {
                sum = firstArray[i, j] * secondArray[i, j];
            }
            resultArray[i, j] = sum;
        }
    }
}

int InputNumbers(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}

void CreateArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(range);
        }
    }
}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}










*/

/*Задача 60.Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

массив размером 2 x 2 x 2

12(0, 0, 0) 22(0, 0, 1)

45(1, 0, 0) 53(1, 0, 1)

*/

int[,,] CreateRandom3dArray(int list, int rows, int colums, int minValue, int maxValue)
{
    bool number = false;
    int[,,] array = new int[list, rows, colums];
    int num;
    for (int k = 0; k < list; k++)
    {
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < colums; j++)
            {
                number = false;
                while (number == false)
                {
                    num = new Random().Next(minValue, maxValue + 1);
                    number = true;
                    for (int a = 0; a < i; a++)
                    {
                        for (int b = 0; b < rows; b++)
                        {
                            for (int c = 0; c < colums; c++)
                            {
                                if (array[a, b, c] == num) number = false;

                            }
                        }
                    }
                    if (number == true) array[k, i, j] = num;
                }
            }
        }
    }
    return array;
}

void Show3dArray(int[,,] array)
{
    Console.WriteLine();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            for (int k = 0; k < array.GetLength(2); k++)
                Console.Write($"{array[i, j, k]} ({i},{j},{k})  ");

        Console.WriteLine();
        Console.WriteLine();
    }
}

int[,,] array = CreateRandom3dArray(2, 2, 2, 10, 99);
Show3dArray(array);



/*
Задача 62.Заполните спирально массив 4 на 4.

Например, на выходе получается вот такой массив:

1 2 3 4

12 13 14 5

11 16 15 6

10 9 8 7

*/

