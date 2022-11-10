int[,] CreateRandom2DArray()
    {
        Console.Write("Input number of rows: ");
        int rows = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input number of colons: ");
        int colons = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input number of min: ");
        int minValue = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input number of  max: ");
        int maxValue = Convert.ToInt32(Console.ReadLine());

        int[,] array = new int[rows, colons];

        for(int i= 0; i < rows; i++)
        {
            for(int j = 0; j < colons; j++)
            { 
                array[i,j] =  new Random().Next(minValue, maxValue+1);

            }
        }

        return array;
    }


void Show2DArray(int[,] array)
{
     for(int i = 0; i< array.GetLength(0); i++)
     {
            for(int j =0; j < array.GetLength(1); j++)
                Console.Write(array[i,j] + " ");

             Console.WriteLine();   
     }
}





////// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

/*
void SteamLine(int[,] array)
{
    for(int i =0; i< array.GetLength(0); i++)
    {
        for(int j =0; j< array.GetLength(1); j++)
        { 
            for(int k =0; k < array.GetLength(1) - 1; k++)
            {
                if(array[i,k] < array[i,k+1])
                {
                    int temp = array[i,k+1];
                    array[i, k+1] = array[i,k];
                    array[i,k] = temp;

                }
            }
        }
    }
   
}




int[,] myArray = CreateRandom2DArray();
Show2DArray(myArray);

Console.WriteLine();
Console.WriteLine("Преобразованный массив: ");
Console.WriteLine();
SteamLine(myArray);
Show2DArray(myArray);

*/





/////  Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

///Например, задан массив:
///1 4 7 2
///5 9 2 3
//8 4 2 4
//5 2 6 7
//Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


/*

int[,] CreateRectangleArray()
    {
        Console.Write("Введите кличество строк и столбцов массива. Количество строк и столбцов не должно совпадать! ");

        Console.Write("Количество строк: ");
        int rows = Convert.ToInt32(Console.ReadLine());
        Console.Write("Количество столцов: ");
        int colons = Convert.ToInt32(Console.ReadLine());
        Console.Write("Минимальное знаение диапозона: ");
        int minValue = Convert.ToInt32(Console.ReadLine());
        Console.Write("Макимальное значение диапозона: ");
        int maxValue = Convert.ToInt32(Console.ReadLine());

        int[,] array = new int[rows, colons];

        for(int i= 0; i < rows; i++)
        {
            for(int j = 0; j < colons; j++)
            { 
                array[i,j] =  new Random().Next(minValue, maxValue+1);

            }
        }

        return array;
    }



int[,] array = CreateRectangleArray();
Show2DArray(array);


int SumLineElements(int[,] array, int i)
{
    int sumLine = array[i,0];
    for (int j=1; j < array.GetLength(1); j++)
    { 
        sumLine += array[i,j];

    }

    return sumLine;
}


int minSumLine = 0;
int sumLine = SumLineElements(array,0);
for(int i = 1; i< array.GetLength(0); i++ )
{ 
    int tempSumLine = SumLineElements(array,i);
    if(sumLine > tempSumLine)
    {
        sumLine = tempSumLine;
        minSumLine = i;

    }
}




Console.WriteLine($" \n{minSumLine+1} - строка с наименьше суммой ({sumLine}) элементов");

*/



//////// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
//Например, даны 2 матрицы:
//2 4 | 3 4
//3 2 | 3 3
//Результирующая матрица будет:
//18 20
//15 18




        Console.Write("Введите кличество строк и столбцов 1й матрицы. ");

        Console.Write("Количество строк 1 матрицы: ");
        int rows = Convert.ToInt32(Console.ReadLine());
        Console.Write("Количество столцов 1 матрицы: ");
        int colons = Convert.ToInt32(Console.ReadLine());
        Console.Write("Минимальное знаение диапозона: ");
        int minValue = Convert.ToInt32(Console.ReadLine());
        Console.Write("Макимальное значение диапозона: ");
        int maxValue = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();



        Console.Write("Введите кличество строк и столбцов 2й матрицы. ");

        Console.Write("Количество строк 2 матрицы: ");
        int r = Convert.ToInt32(Console.ReadLine());
        Console.Write("Количество столцов 2 матрицы: ");
        int c = Convert.ToInt32(Console.ReadLine());
        Console.Write("Минимальное знаение диапозона: ");
        int minV = Convert.ToInt32(Console.ReadLine());
        Console.Write("Макимальное значение диапозона: ");
        int maxV = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();

int[,] CreateFirstMatrixArray()
    {
        

        int[,] array = new int[rows, colons];

        for(int i= 0; i < rows; i++)
        {
            for(int j = 0; j < colons; j++)
            { 
                array[i,j] =  new Random().Next(minValue, maxValue+1);

            }
        }

        return array;
    }


int[,] CreateSecondMatrixArray()


    {
        
        int[,] array = new int[r, c];

        for(int i= 0; i < r; i++)
        {
            for(int j = 0; j < c; j++)
            { 
                array[i,j] =  new Random().Next(minV, maxV+1);

            }
        }

        return array;
    }


int[,] firstarray = CreateFirstMatrixArray();
Show2DArray(firstarray);
Console.WriteLine();

int[,] secondarray = CreateSecondMatrixArray();
Show2DArray(secondarray);

void MatrixProduct(int[,] firstarray, int[,] secondarray, int[,] thirdarray)
{
     for(int i =0; i < thirdarray.GetLength(0); i++)
    {
        for(int j =0; j< thirdarray.GetLength(1); j++)
        { 
            int sum = 0;
            for(int k =0; k< firstarray.GetLength(1); k++)
            { 
                sum += firstarray[i,k] * secondarray[k,j];
            }
        thirdarray[i,j] = sum;

        }
    }

}   




int[,] trirdarray = new int[rows, c];
MatrixProduct(firstarray, secondarray, trirdarray);
Console.WriteLine($"\n Произведение матриц: ");
Console.WriteLine();

Show2DArray(trirdarray);


       





