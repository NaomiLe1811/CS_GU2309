﻿using System;

namespace HW_13_File_Serialization
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input file path");
            string path = Console.ReadLine();
            Console.WriteLine("File path: " + path);

            // Instantiate the ReadTextFileExample class and call the correct method
            ReadTextFileExample example = new ReadTextFileExample();
            example.ReadTextFile(path);
        }
    }
}
