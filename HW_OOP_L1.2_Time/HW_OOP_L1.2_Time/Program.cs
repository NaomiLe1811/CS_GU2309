using System;

namespace HW_OOP_L1._2_Time
{
    class Program
    {
        static void Main(string[] args)
        {
            //Cach1();
            Cach2();
        }

        static void Cach1()
        {
            // Create an instance of the Timer class
            Time time = new Time();

            // Generate an array of 100,000 random numbers
            int[] numbers = new int[100000];
            Random rand = new Random();
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rand.Next();
            }

  

            // Start the timer
            Console.WriteLine("Press any string to start the timer");

            // Read a key from the console
            ConsoleKeyInfo keyInfo = Console.ReadKey();

            // Check if the pressed key is a string (a letter)
            if (char.IsLetter(keyInfo.KeyChar))
            {
                // Start the timer if the key is a letter
                time.Start();
                Console.WriteLine("Timer started.");
            }
            else
            {
                Console.WriteLine("Invalid input. The timer is not started.");
            }

            // Stop the timer
            Console.WriteLine("Press any key to stop the timer.");
            ConsoleKeyInfo stopKeyInfo = Console.ReadKey();
            if (char.IsLetter(stopKeyInfo.KeyChar))
            {
                time.Stop();
                Console.WriteLine("Timer stopped.");
            }
            else
            {
                Console.WriteLine("Invalid input. The timer cannot stopped.");
            }

            // Call the selection sort algorithm
            //SelectionSort(numbers);

            // Get and display the elapsed time
            long elapsedTime = time.GetElapsedTime();
            Console.WriteLine($"Elapsed Time: {elapsedTime} milliseconds");
        }

        static void Cach2()
        {
            // Create an instance of the Timer class
            Time time = new Time();

            // Generate an array of 100,000 random numbers
            int[] numbers = new int[100000];
            Random rand = new Random();
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rand.Next();
            }

            time.Start();
            SelectionSort(numbers);
            time.Stop();

            // Get and display the elapsed time
            long elapsedTime = time.GetElapsedTime();
            Console.WriteLine($"Elapsed Time: {elapsedTime} milliseconds");
        }

        static void SelectionSort(int[] arr)
        {
            int n = arr.Length;

            for (int i = 0; i < n - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[j] < arr[minIndex])
                    {
                        minIndex = j;
                    }
                }

                int temp = arr[minIndex];
                arr[minIndex] = arr[i];
                arr[i] = temp;
            }
        }
    }
}
