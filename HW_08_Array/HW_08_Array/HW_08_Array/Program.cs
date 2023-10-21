using System;
using System.Collections.Generic;

namespace HW_08_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercise1();
            //Exercise2();
            //Exercise3();
            //Exercise4();
            Exercise5();
            Console.ReadKey();
        }
        static void Exercise1()
        {
            //Ex1: Caculate sum of elements in array
            //Declaring a list
            List<int> myList = new List<int>() { 1, 2, 3, 4, 5 };
            Console.WriteLine("Print the sum of elements in list");
            //Caculate the sum
            int sum = 0;
            foreach(var item in myList)
            {
                sum = sum + item;
            }
            //Print the sum
            Console.WriteLine("Sum is: " + sum);
        }
        static void Exercise2()
        {
            //Ex2: Find the value of each element
            //Ứng dụng có sẵn một danh sách tên của sinh viên, cho phép người dùng nhập vào một tên sinh viên, sau đó hiển thị vị trí của sinh viên đó trong danh sách (nếu tìm thấy) hoặc là thông báo không tìm thấy.
            List<string> studentList = new List<string>() { "Christian", "Michael", "Camila", "Sienna", "Tanya", "Connor", "Zachariah", "Mallory", "Zoe", "Emily" };
            Console.WriteLine("PLease input a student name");
            string input = Console.ReadLine();
            int index = -1;

            int i;
            for (i = 0; i < studentList.Count; i++){
                if (input.Equals(studentList[i]))
                {
                    index = i;
                    break;
                } 
            }
            if (index != -1)
            {
                Console.WriteLine($"The student { input} is at position { i} in the list.");
            } else
            {
                Console.WriteLine("Could not find");
            }

        }
        static void Exercise3()
        {
            //Ex3: Find the largest element in the array
            //Ứng dụng cho phép người dùng lần lượt nhập vào giá trị tài sản của các tỷ phú thế giới (đơn vị tỉ đô), tối đa cho phép nhập 20 giá trị, sau đó hiển thị giá trị tài sản lớn nhất và vị trí của nó trong danh sách.

            int size;
            List<int> myList = new List<int>();

        begin:
            Console.WriteLine("Enter a size:");
            size = int.Parse(Console.ReadLine());
            if (size > 20)
            {
                Console.WriteLine("Size should not exceed 20, please input again");
                goto begin;
            }

            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("Enter value for each billionaire:");
                int value = int.Parse(Console.ReadLine());
                myList.Add(value);
            }
            //int max = myList.Max(); DO NOT WORK WITH LIST
            int max = findMax(myList);
            int maxIndex = myList.IndexOf(max);

            Console.WriteLine($"The largest wealth is {max} billion dollars at position {maxIndex} in the list.");
        }

        static int findMax(List<int> list)
        {
            int max = 0; //initilize the max value
            foreach (int item in list)
            {
                if (item > max)
                {
                    max = item;
                }
            } return max;
        }
        static void Exercise4()
        {
            //Cho phép người dùng khai báo mảng mảng số nguyên gồm N phần tử. Nhập một giá trị bất kỳ từ bàn phím và vị trí cần chèn, giá trị này được chèn vào vị trí đó trong mảng.


            List<int> myList = new List<int>();

            Console.WriteLine("Input a size for the array");
            int size = int.Parse(Console.ReadLine());
            for (int i = 0; i < size; i++) //them element vao list
            {
                Console.WriteLine($"input your next element in the list {i + 1}:");
                int element = int.Parse(Console.ReadLine());
                myList.Add(element);
            }

            Console.WriteLine("Input a number you want to add");
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine("Input the position you want to change");
            int position = int.Parse(Console.ReadLine());

            if(position >= 0 && position < size)
            {
                myList.Insert(position, num);
                Console.WriteLine("List after add more var:");
                foreach (var item in myList) //de di qua list
                {
                    Console.Write(item + " ");//in ra
                }
            } else
            {
                Console.WriteLine("Invalid input");
            }
        }
        static void Exercise5()
        {
            //Viết một ứng dụng cho phép người dùng nhập vào một ma trận số thực, sau đó tìm ra tọa độ cũng như giá trị của phần tử lớn nhất.
            Console.WriteLine("How many row?");
            int row = int.Parse(Console.ReadLine());
            Console.WriteLine("How many column?");
            int column = int.Parse(Console.ReadLine());

            List<List<int>> matrix = new List<List<int>>(); //create a list

            for(int i = 0; i < row; i++)
            {
                List<int> rows = new List<int>(); //created the rows list 
                for (int j = 0; j < column; j++) //adding value to row and col
                {
                    Console.WriteLine($"Input value for row at {i + 1} column {j + 1}:");
                    int element = int.Parse(Console.ReadLine());
                    rows.Add(element);
                }
                matrix.Add(rows);
            }

            int max = matrix[0][0]; //initialize value of the matrix
            int maxRow = 0;
            int maxCol = 0;

            for(int i = 0; i < matrix.Count; i++)
            {
                for(int j = 0; j < matrix.Count; j++)
                {
                    if (matrix[i][j] > max)
                    {
                        max = matrix[i][j];
                    
                    }
                }
            }
            Console.WriteLine($"The largest element in the matrix is {max} at row {maxRow + 1}, column {maxCol + 1}.");
        } 
    }
}
