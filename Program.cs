//Домашняя работа 8
/*Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию 
элементы каждой строки двумерного массива.
*/
/*
Console.Clear(); 
int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{   
    int[,] array = new int[rows, columns];
    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            array[i,j] = new Random().Next(minValue,maxValue+1);
    return array;
}
void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(  array[i,j] +"\t"  );
        Console.WriteLine();
    }
    Console.WriteLine();
}
int[,] ModifiedArray(int [,] array)
{
    int temp;
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1)-1; j++)
        {
           for (int k = j; k <array.GetLength(1); k++)
           {
                if (array[i, j] < array[i, k])
                {
                    temp = array[i,j];
                    array[i,j] = array[i,k];
                    array[i,k] = temp;
                   
                }
           }
        }
    }
    return array;
}
*/
/*
Console.Write("Input a number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int maxValue = Convert.ToInt32(Console.ReadLine());
int[,] myArray= CreateRandom2dArray(rows, columns, minValue, maxValue);
Show2dArray(myArray);
int[,] modArray=ModifiedArray(myArray);
Show2dArray(modArray);
*/
/*
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить 
строку с наименьшей суммой элементов.
*/
/*
int [] SummRow(int [,] array)
{
    int [] sumRow= new int [array.GetLength(0)];
    int summ=0;
    for( int i = 0; i < array.GetLength(0); i++)
    {  
        summ=0;
        for(int j = 0; j < array.GetLength(1); j++)
            summ= array[i,j]+summ;
        sumRow[i]=summ;
    }
    return sumRow;

}

void minRow(int[] array)
{
    int min=array[0];
    int index=0;
    for(int i = 0; i < array.GetLength(0); i++)
    {
        if (min>array[i]) 
        {
            min=array[i];
            index =i;
        }
    }
    Console.WriteLine(index+1 + " строка");
}
int[] modArray=SummRow(myArray);
minRow(modArray);
*/
/*
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/
/*
int[,] Matrix(int [,] firstArray, int [,] secondArray)
{
    int [,] matrix= new int [firstArray.GetLength(0),firstArray.GetLength(1)];
    if (firstArray.GetLength(0)==secondArray.GetLength(1))
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix[i, j] = 0;
                for (int n = 0; n < firstArray.GetLength(1); n++)
                {
                    matrix[i, j] += firstArray[i, n] * secondArray[n, j];
                }
            }
        }
    }
    return matrix;
}
Console.Write("Input a number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int maxValue = Convert.ToInt32(Console.ReadLine());
int[,] myArray1= CreateRandom2dArray(rows, columns, minValue, maxValue);
Show2dArray(myArray1);
int[,] myArray2= CreateRandom2dArray(rows, columns, minValue, maxValue);
Show2dArray(myArray2);
int[,] myArray3= Matrix(myArray1, myArray2);
Show2dArray(myArray3);
*/
/*
Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/
/*
int[,,] CreateRandom3dArray(int rows, int columns,int planes ,int minValue, int maxValue)
{   
    int[,,] array = new int[ rows, columns,planes];
    int k = 0;
    int size=rows* columns*planes;
    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            for (int n = 0; n < planes; n++)
            {  
                int A = new Random().Next(minValue, maxValue);
                for(int a = 0; a < rows; a++)
                {
                    for(int b = 0; b < columns; b++)
                    {
                        for (int c = 0; c < planes; c++)
                        {
                            if (A != array[a, b,c])
                                k++; 
                        }
                    }
                }
                if (k == size)
                {
                    array[i, j,n] = A;
                    k = 0;
                }
                else
                {
                    k = 0;
                    n = (n - 1);
                    continue;
                }
            }
        }
    }
    return array;
}

void Show3dArray(int[,,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
        for(int j = 0; j < array.GetLength(1); j++)
        {    for(int n = 0; n < array.GetLength(2); n++)
            {
                Console.Write( $"{array[i,j,n]} ({i}, {j}, {n} )      ");

            }
        Console.WriteLine();    
        }
}

Console.Write("Input a number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of columns:  ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of planes :  ");
int planes = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

int[,,] myArray1= CreateRandom3dArray(rows, columns, planes, minValue, maxValue);
Show3dArray(myArray1);
*/
/*
Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/

/*
int [,] SpipalArray (int rows, int columns)
{
    int[,] array = new int[rows, columns];
    int row = 0, col = 0, dx = 1, dy = 0, count = 0, current = columns;
    for (int i = 0; i < array.Length; i++)
    {
        current=current-1;
        array[row, col] = i + 1;
        if (current == 0)
        {
            current = columns*(count%2) + rows*((count + 1)%2) - (count/2 - 1) - 2;
            int temp = dx;
            dx = -dy;
            dy = temp;
            count++;
        }        
        col += dx;
        row += dy;
        }
    return array;
}

void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(  array[i,j] +"\t"  );
        Console.WriteLine();
    }
    Console.WriteLine();
}
Console.Write("Input a number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of columns:  ");
int columns = Convert.ToInt32(Console.ReadLine());
int [,] myArray=SpipalArray (rows, columns);
Show2dArray(myArray);
*/