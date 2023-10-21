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
            Exercise3();
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

            int max = findMax(myList);
            int maxIndex = myList.IndexOf(max);

            Console.WriteLine($"The largest wealth is {max} billion dollars at position {maxIndex} in the list.");
        }

        static int findMax(List<int> list)
        {
            int max = int.MinValue; //initilize the max value
            foreach (int item in list)
            {
                if (item > max)
                {
                    max = item;
                }
            } return max;
        }
    }
}
