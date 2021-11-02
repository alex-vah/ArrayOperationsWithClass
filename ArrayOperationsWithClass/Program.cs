using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayOperationsWithClass
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayManager manager = new ArrayManager();
            PrintManager printer = new PrintManager();
            manager._width = Convert.ToInt32(Console.ReadLine());
            manager._height = Convert.ToInt32(Console.ReadLine());
            printer.Print(manager.Create());//prints the 2d array
            printer.Print(manager.GetDiagonal1(manager.Create()));//prints the elements of the primary diagonal
            printer.Print(manager.GetDiagonal2(manager.Create()));//prints the elements of the secondary diagonal
            printer.Print(manager.GetMax(manager.Create()), Console.ReadLine());//prints the max value along with a text given by user
        }
        /// <summary>
        /// Does operations with arrays e.g. finds max and min values, the diagonals etc.
        /// </summary>
        public class ArrayManager
        {
            public int _height;
            public int _width;
            /// <summary>
            /// Creates 2d array filled with random numbers
            /// </summary>
            /// <returns>2d array</returns>
            public int[,] Create()
            {
                Random rnd = new Random();
                int[,] arr = new int[_height, _width];
                for (int i = 0; i < _width; i++)
                {
                    for (int j = 0; j < _height; j++)
                    {
                        arr[i, j] = rnd.Next(10, 100);
                    }
                }
                return arr;
            }
            /// <summary>
            /// Gets the diagonal of the given array
            /// </summary>
            /// <param name="arr">given 2d array</param>
            /// <returns>Int32 array</returns>
            public int[] GetDiagonal1(int[,] arr)
            {
                int[] diagonal = new int[_height];
                for (int i = 0; i < _width; i++)
                {
                    diagonal[i] = arr[i, i];
                }
                return diagonal;
            }
            /// <summary>
            /// Gets the secondary diagonal of the given array
            /// </summary>
            /// <param name="arr">given 2d array</param>
            /// <returns>Int32 array</returns>
            public int[] GetDiagonal2(int[,] arr)
            {
                int[] diagonal = new int[_width];
                for (int i = 0; i < _width; i++)
                {
                    diagonal[i] = arr[i, _width - i - 1];
                }
                return diagonal;
            }
            /// <summary>
            /// Gets the maximum of the given arrfay
            /// </summary>
            /// <param name="arr">any given 2d array</param>
            /// <returns>Int32</returns>
            public int GetMax(int[,] arr)
            {
                int max = arr[0, 0];
                for (int i = 0; i < _width; i++)
                {
                    for (int j = 0; j < _height; j++)
                    {
                        if (arr[i, j] > max)
                        {
                            max = arr[i, j];
                        }
                    }
                }
                return max;
            }
            /// <summary>
            /// Gets the minimum of the given array
            /// </summary>
            /// <param name="arr">any given 2d array</param>
            /// <returns>Int32</returns>
            public int GetMin(int[,] arr)
            {
                int min = arr[0, 0];
                for (int i = 0; i < _width; i++)
                {
                    for (int j = 0; j < _height; j++)
                    {
                        if (arr[i, j] < min)
                        {
                            min = arr[i, j];
                        }
                    }
                }
                return min;
            }
            /// <summary>
            /// Gets the first index of the max value
            /// </summary>
            /// <param name="arr">any given 2d array</param>
            /// <returns>Int32</returns>
            public int GetMaxIndex1(int[,] arr)
            {
                int iMax = 0;
                int max = arr[0, 0];
                for (int i = 0; i < _width; i++)
                {
                    for (int j = 0; j < _height; j++)
                    {
                        if (arr[i, j] > max)
                        {
                            max = arr[i, j];
                            iMax = i;
                        }
                    }
                }
                return iMax;
            }
            /// <summary>
            /// Gets the second index of the max value
            /// </summary>
            /// <param name="arr">any given 2d array</param>
            /// <returns>Int32</returns>
            public int GetMaxIndex2(int[,] arr)
            {
                int jMax = 0;
                int max = arr[0, 0];
                for (int i = 0; i < _width; i++)
                {
                    for (int j = 0; j < _height; j++)
                    {
                        max = arr[i, j];
                        jMax = j;
                    }
                }
                return jMax;
            }
            /// <summary>
            /// Gets the first index of the min value
            /// </summary>
            /// <param name="arr">any given 2d array</param>
            /// <returns>Int32</returns>
            public int GetMinIndex1(int[,] arr)
            {
                int min = arr[0, 0];
                int iMin = 0;
                for (int i = 0; i < _width; i++)
                {
                    for (int j = 0; j < _height; j++)
                    {
                        min = arr[i, j];
                        iMin = i;
                    }
                }
                return iMin;
            }
            /// <summary>
            /// Gets the second index of the min value
            /// </summary>
            /// <param name="arr">any given 2d array</param>
            /// <returns>Int32</returns>
            public int GetMinIndex2(int[,] arr)
            {
                int min = arr[0, 0];
                int jMin = 0;
                for (int i = 0; i < _width; i++)
                {
                    for (int j = 0; j < _height; j++)
                    {
                        min = arr[i, j];
                        jMin = j;
                    }
                }
                return jMin;
            }
            /// <summary>
            /// Swaps any two numbers places of the 2d array
            /// </summary>
            /// <param name="arr">any given 2d array</param>
            /// <param name="i1">first index of the first number</param>
            /// <param name="j1">second index of the first number</param>
            /// <param name="i2">first index of the second number</param>
            /// <param name="j2">second index of the second number</param>
            public void Swap(int[,] arr, int i1, int j1, int i2, int j2)
            {
                int tmp = arr[i1, j1];
                arr[i1, j1] = arr[i2, j2];
                arr[i2, j2] = tmp;
            }

        }
        /// <summary>
        /// Prints 2d arrays, arrays, values
        /// </summary>
        public class PrintManager
        {
            /// <summary>
            /// Prints 2d array
            /// </summary>
            /// <param name="arr">given 2d array</param>
            public void Print(int[,] arr)
            {
                for (int i = 0; i < arr.GetLength(0); i++)
                {
                    for (int j = 0; j < arr.GetLength(1); j++)
                    {
                        Console.Write($"{arr[i, j]} ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
            /// <summary>
            /// Prints array
            /// </summary>
            /// <param name="arr">given array</param>
            public void Print(int[] arr)
            {
                foreach (int i in arr)
                {
                    Console.Write($"{i} ");
                }
                Console.WriteLine("\n");
            }
            /// <summary>
            /// Prints value and text
            /// </summary>
            /// <param name="value">any given integer</param>
            /// <param name="text">any given string</param>
            public void Print(int value, string text)
            {
                Console.WriteLine($"{text} {value}");
                Console.WriteLine();
            }
        }
    }
}
