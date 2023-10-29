using System;
using System.Collections.Generic;

namespace HW_10_2DArray
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercise1(); //array
            Exercise1a1(); //list
            //Exercise2();
            
            Console.ReadKey();
        }

        static void Exercise1()
        {
            Console.WriteLine("Size of input:");
            int size = int.Parse(Console.ReadLine());

            int[,] myArray = new int[size, size];

            //dong duoi day de nhap du lieu vao array
            for (int i = 0; i < size; i++) //tao row
            {         
                for(int j = 0; j < size; j++) //tao col
                {
                    Console.WriteLine("Input your next value");
                    int value = int.Parse(Console.ReadLine());

                    myArray[i, j] = value;
                }
                //Console.WriteLine();
            }
            //sau khi array dc khoi tao, chung ta can in ra array
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write(myArray[i,j] + " "); 
                }
                Console.WriteLine();
            }

            //in hang cheo
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (i == j)
                    {
                        Console.Write(myArray[i,j]);
                    } else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }

        static void Exercise1a1()
        {           
            Console.WriteLine("size of input:"); //b1: khoi tao size (row = col)
            int size = int.Parse(Console.ReadLine());

            List<List<int>> twoDList = new List<List<int>>();//b2: khoi tao 2D list

            //b3: khoi tao list GAN GIONG array 2D, tao i la hang, va tao j la cot
            for (int i = 0; i < size; i++)        
            {
                List<int> row = new List<int>(); //voi List, phai tao them list de them cac phan tu vao hang
                for (int j = 0; j < size; j++)   //them cac phan tu vao hang
                {
                    //chung ta can them phan tu vao list
                    Console.WriteLine("Input your value");
                    int value = int.Parse(Console.ReadLine());
                    //neu la array, thi se la myArray[i,j] = value , nhung day la list, cho nen ta can phai viet:
                    row.Add(value); //them tung phan tu vao hang (row)                
                }
                twoDList.Add(row);//them tung hang vao bang
            }

            //bay gio in ra
            //GIONG nhu thang array
            for(int i = 0; i < size; i++)
            {
                for(int j = 0; j < size; j++)
                {
                    Console.Write(twoDList[i][j] + " ");
                }
                Console.WriteLine(" ");
            }

            //bay gio in ket qua
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if(i == j)
                    {
                        Console.Write(twoDList[i][j] + " ");
                    } else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine(" ");
            }
        }

        static void Exercise2()
        {
            string[,] map = {
            {"*", ".", ".", "."},
            {".", ".", ".", "."},
            {".", "*", ".", "."},
            {".", ".", ".", "."}
        };
            int MAP_HEIGHT = map.GetLength(0);
            int MAP_WIDTH = map.GetLength(1);

            string[,] mapReport = new string[MAP_HEIGHT, MAP_WIDTH];
            for (int yOrdinate = 0; yOrdinate < MAP_HEIGHT; yOrdinate++)
            {
                for (int xOrdinate = 0; xOrdinate < map.GetLength(0); xOrdinate++)
                {
                    string curentCell = map[yOrdinate, xOrdinate];
                    if (curentCell.Equals("*"))
                    {
                        mapReport[yOrdinate, xOrdinate] = "*";
                    }
                    else
                    {
                        int[,] NEIGHBOURS_ORDINATE = {
                        {yOrdinate - 1, xOrdinate - 1}, {yOrdinate - 1, xOrdinate}, {yOrdinate - 1, xOrdinate + 1},
                        {yOrdinate, xOrdinate - 1}, {yOrdinate, xOrdinate + 1},
                        {yOrdinate + 1, xOrdinate - 1}, {yOrdinate + 1, xOrdinate}, {yOrdinate + 1, xOrdinate + 1},};

                        int minesAround = 0;
                        int length = NEIGHBOURS_ORDINATE.GetLength(0);
                        for (int i = 0; i < length; i++)
                        {
                            int xOrdinateOfNeighbour = NEIGHBOURS_ORDINATE[i, 1];
                            int yOrdinateOfNeighbour = NEIGHBOURS_ORDINATE[i, 0];

                            bool isOutOfMapNeighbour = xOrdinateOfNeighbour < 0
                                    || xOrdinateOfNeighbour == MAP_WIDTH
                                    || yOrdinateOfNeighbour < 0
                                    || yOrdinateOfNeighbour == MAP_HEIGHT;
                            if (isOutOfMapNeighbour)
                            {
                                continue;
                            }

                            bool isMineOwnerNeighbour = map[yOrdinateOfNeighbour, xOrdinateOfNeighbour].Equals("*");
                            if (isMineOwnerNeighbour)
                            {
                                minesAround++;
                            }
                        }

                        mapReport[yOrdinate, xOrdinate] = minesAround.ToString();
                    }
                }
            }

            for (int yOrdinate = 0; yOrdinate < MAP_HEIGHT; yOrdinate++)
            {
                Console.WriteLine("\n");
                for (int xOrdinate = 0; xOrdinate < MAP_WIDTH; xOrdinate++)
                {
                    String currentCellReport = mapReport[yOrdinate, xOrdinate];
                    Console.Write(currentCellReport);
                }
            }
            Console.ReadLine();
        }
    }
}
