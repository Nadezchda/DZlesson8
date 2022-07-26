// Напишите пропграму которая будет 
// преобразовывать десятичное число в двоичное
// 45 -> 101101
// 3 -> 11
// 2-> 10

// int ConvertDecBin (int num){
// int BinNum = 0;
// int count = 0;
// while (num >=1){
//     if (count==0) count = 1;
//     else count = count * 10;
//     BinNum = BinNum + (num % 2)* count;
//     num = num / 2;
// }
// return BinNum;
// }
// Console.WriteLine("Введите положительное число");
// int DecNum = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(DecNum + " -> " + ConvertDecBin(DecNum));

// Классно!
//  Теперь - 2 способ решения этой задачи 

// Console.WriteLine("Введите положительное число");
//  int DecNum = Convert.ToInt32(Console.ReadLine());

// String number = DecNum.ToString();
// int fromBase = 10;
// int toBase = 2;
// string result = Convert.ToString(Convert.ToInt32 (number, fromBase),  toBase);
// Console.WriteLine("второй способ"  + result) ;

// задайте двухмерный массив
//  и поменять местами 1 и последнюю строчку

// int [,] CreateRandomArray (int m, int n, int min, int max)
// {
//      int [,] array = new int[m,n];
//     for (int i = 0; i < m; i++)
//     {
//       for (int j = 0; j < n; j++)
//       {
//         array [i,j] = new Random().Next(min, max);
//       }
//     }
//     return array;
// }
// void ShowArray(int[,]array)
// {
//  for(int i=0; i< array.GetLength(0); i++)
//  {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//     Console.Write(array[i ,j]+" ");
//     }
//     Console.WriteLine();
//  }

// }
// void SwapArray(int[,]array)
// { int buf = 0;
//   int lastRow = array.GetLength(0) - 1 ;
// for (int column = 0;  column < array.GetLength(1); column++)
//  {
//    buf = array[0, column];
//    array[0, column] = array[lastRow, column];
//    array[lastRow, column] = buf;
// 
// // решена !!!

//  задайте двухмерный массив
//  и поменять строки на столбцы

// int [,] CreateRandomArray (int m, int n, int min, int max)
// {
//      int [,] array = new int[m,n];
//     for (int i = 0; i < m; i++)
//     {
//       for (int j = 0; j < n; j++)
//       {
//         array [i,j] = new Random().Next(min, max+1);
//       }
//     }
//     return array;

// void ShowArray (int[,] array);

// int [,] myArray = CreateRandomArray(4, 4, 1, 11);
// ShowArray(myArray);

// int [,] SwapArray (int[,] array)
// {
//      int [,] ArrayNew = new int[array.GetLength(0), array.GetLength(1)];
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//       for (int j = 0; j < array.GetLength(1); j++)
//       {
//         ArrayNew [j,i] = array [i,j];
//       }
//     }
//     Console.WriteLine();
//     return ArrayNew;
// }
//  ShowArray(SwapArray(myArray));

// //   не решена !!!


//  Задача 57 Сщставить частотный словарь элементов двухмерного массивa.
// Частотный словарь содержит информацию о том, сколько раз 
// встречатся элемент вводных данных
// 1,2,3,
// 4,6,1
// 2,1,6
//  1 встречается 3 раза
//  2 встречается 2 раза
//  3 встречается 1 раза
//  4 встречается 1 раза
//  6 встречается 2 раза

//  int [,] CreateRandomArray (int m, int n, int min, int max)
// {
//      int [,] array = new int[m,n];
//     for (int i = 0; i < m; i++)
//     {
//       for (int j = 0; j < n; j++)
//       {
//         array [i,j] = new Random().Next(min, max+1);
//       }
//     }
//     return array;
// }
//     void ShowArrayTwo (int[,] array)
// {

   
// //  for(int i=0; i< array.GetLength(0); i++)
// //  {
// //     for (int j = 0; j < array.GetLength(1); j++)
// //     {
// //        Console.Write(array[i ,j]+" ");
// //     }
// //     Console.WriteLine();
 
//  Console.WriteLine(String.Join(" ", array));
// }
//  int [] GetOneArray (int [,] arrayTow)
//  {
//     int [] arrayOne = new int[arrayTow.GetLength(0)* arrayTow.GetLength(1)];
//   int index = 0;
// for(int i=0; i< arrayTow.GetLength(0); i++)
//  {
//     for (int j = 0; j <arrayTow.GetLength(1); j++)
//     {
//       arrayOne[index] = arrayTow[i,j];
//       index++;
//     } 
//  }
// return arrayOne;
//  }
//  void SortArray (int[]array)
//  {
//     int buf = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//       for (int j = 0; j < array.Length; j++)
//       {
//         if (array[i] > array [j])
//         {
//           buf = array[i];
//           array[i] = array[j];
//           array[j] = buf;
//         }
//       }
//    } 
//  }
//  void PrintCounElement(int[]array)
//  {
//     int count = 1;
//     int temp = array[0];
//     for (int i = 0; i < array.Length; i++)
//      {
//        if (array[i]!=temp)
//        {
//         Console.WriteLine($"{temp} встречается {count} раз");
//         temp = array[i];
//         count = 1;
//        }
//        else
//        {
//         count ++;
//        }
//     }
//      Console.WriteLine($"{temp} встречается {count} раз");
//  }
//  Console.WriteLine("Введите количество строк: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество cтолбцов: ");
// int colums = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите min число: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите max число: ");
// int max = Convert.ToInt32(Console.ReadLine());
// int[,]myArray = CreateRandomArray(rows,colums,min,max);

// ShowArrayTwo(myArray);
// int[] arrayOne = GetOneArray(myArray);
// Console.WriteLine(String.Join(" ",arrayOne));

// SortArray (arrayOne);
// Console.WriteLine(String.Join(" ",arrayOne));

// PrintCounElement(arrayOne);

// Практическое задание 8 
// Задача 54: Задайте двумерный массив. Напишите программу,
//  которая упорядочит по убыванию элементы каждой строки двумерного массива.
//  Console.WriteLine("Введите количество строк: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество cтолбцов: ");
// int colums = Convert.ToInt32(Console.ReadLine());
// int[,] numbers = new int[rows, colums];
// FillArrayRandomNumbers(numbers);
// Console.WriteLine();
// PrintArray(numbers);

// for (int i = 0; i < numbers.GetLength(0); i++)
// {
//     for (int j = 0; j < numbers.GetLength(1) - 1; j++)
//     {
//         for (int z = 0; z < numbers.GetLength(1) - 1; z++)
//         {
//             if (numbers[i, z] < numbers[i, z + 1]) //для изменения сортировки поменять знак < на противоположный
//             {
//                 int temp = 0;
//                 temp = numbers[i, z];
//                 numbers[i, z] = numbers[i, z + 1];
//                 numbers[i, z + 1] = temp;
//             }
//         }
//     }
// }
// Console.WriteLine();
// PrintArray(numbers);

// void FillArrayRandomNumbers(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(0, 10);
//         }
//     }
// }

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }  
//         Console.WriteLine("");
//     }
// }
// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

//  Console.WriteLine("Введите количество строк: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество cтолбцов: ");
// int colums = Convert.ToInt32(Console.ReadLine());
// int[,] numbers = new int[rows, colums];
// FillArrayRandomNumbers(numbers);
// Console.WriteLine();
// PrintArray(numbers);
// int minsum = Int32.MaxValue;
// int indexLine = 0;
// for (int i = 0; i < numbers.GetLength(0); i++)
// {
//     int sum = 0;
//     for (int j = 0; j < numbers.GetLength(1); j++)
//     {
//         sum = sum + numbers[i, j];        
//     }
//     if (sum < minsum)
//     {
//         minsum = sum;
//         indexLine++;
//     }
// }

// Console.WriteLine("строка с наименьшей суммой елементов под номером: " + (indexLine) + ", с суммой елементов = " + (minsum));

// void FillArrayRandomNumbers(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(0, 10);
//         }
//     }
// }

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         Console.Write("[ ");
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.Write("]");
//         Console.WriteLine("");
//     }
// }

// решена!

// Задача 58: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.
// int InputInt(string output)
// {
//     Console.Write(output);
//     return int.Parse(Console.ReadLine());
// }

// void FillArrayRandomNumbers(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(1, 5); //Для увеличения размера чисел в матрицах поменять число 5 на большее
//         }
//     }
// }

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         Console.Write("[ ");
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.Write("]");
//         Console.WriteLine("");
//     }
// }

// int size = InputInt("размерность матриц: ");
// int[,] matrixA = new int[size, size];
// int[,] matrixB = new int[size, size];
// FillArrayRandomNumbers(matrixA);
// FillArrayRandomNumbers(matrixB);
// int[,] matrixC = new int[size, size];

// for (int i = 0; i < size; i++)
// {
//     for (int j = 0; j < size; j++)
//     {
//         for (int k = 0; k < size; k++)
//         {
//             matrixC[i, j] = matrixC[i, j] + (matrixA[i, k] * matrixB[k, j]);
//         }
//     }
// }
// Console.WriteLine("Матрица - А");
// PrintArray(matrixA);
// Console.WriteLine();
// Console.WriteLine("Матрица - В");
// PrintArray(matrixB);
// Console.WriteLine();
// Console.WriteLine("Произведение матриц А*В");
// PrintArray(matrixC);
 
//  А могла бы и сама решить

// Задача 60: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
//  Напишите программу, которая будет построчно выводить массив, 
//  добавляя индексы каждого элемента.
// int deep1 = InputInt("Введите размерность 1: ");
// int deep2 = InputInt("Введите размерность 2: ");
// int deep3 = InputInt("Введите размерность 3: ");
// int countNums = 89;

// if (deep1 * deep2 * deep3 > countNums)
// {
//     Console.Write("Массив слишком большой");
//     return;
// }

// int[,,] resultNums = Create3DMassive(deep1, deep2, deep3);

// for (int i = 0; i < resultNums.GetLength(0); i++)
// {
//     for (int j = 0; j < resultNums.GetLength(1); j++)
//     {
//         for (int k = 0; k < resultNums.GetLength(2); k++)
//         {
//             Console.WriteLine($"[{i},{j},{k}] - {resultNums[i, j, k]}");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }


// int[,,] Create3DMassive(int size1, int size2, int size3)
// {
//     int[,,] array = new int[size1, size2, size3];
//     int[] values = new int[countNums];
//     int num
//      = 10;
//     for (int i = 0; i < values.Length; i++)
//         values[i] = num
//         ++;

//     for (int i = 0; i < values.Length; i++)
//     {
//         int randomInd = new Random().Next(0, values.Length);
//         int temp = values[i];
//         values[i] = values[randomInd];
//         values[randomInd] = temp;
//     }

//     int valueIndex = 0;

//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int k = 0; k < array.GetLength(2); k++)
//             {
//                 array[i, j, k] = values[valueIndex++];
//             }
//         }
//     }
//     return array;
// }


// int InputInt(string output)
// {
//     Console.Write(output);
//     return int.Parse(Console.ReadLine());
// }

// Задача 62: Заполните спирально массив 4 на 4.

// Console.WriteLine("Введите размер массива");
// int size = Convert.ToInt32(Console.ReadLine());

// int[,] nums = new int[size, size];

// int num = 1;
// int i = 0;
// int j = 0;

// while (num <= size * size)
// {
//     nums[i, j] = num;
//     if (i <= j + 1 && i + j < size - 1)
//         ++j;
//     else if (i < j && i + j >= size - 1)
//         ++i;
//     else if (i >= j && i + j > size - 1)
//         --j;
//     else
//         --i;
//     ++num;
// }

// PrintArray(nums);

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         Console.Write("[ ");
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.Write("]");
//         Console.WriteLine("");
//     }
// }