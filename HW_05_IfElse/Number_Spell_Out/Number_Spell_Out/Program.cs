using System;

namespace Number_Spell_Out
{
    class Program
    {
        static void Main(string[] args)
        {
            string ones = "teen";
            int input;
            //int khongdenmuoi;
            //int tu11den20;
            Console.WriteLine("Input your number: ");
            bool laso = int.TryParse(Console.ReadLine(), out input);

            if (laso && input >= 0 && input <= 10){
                //Console.WriteLine(khongdenmuoi);
                switch (input)
                {
                    case 0: Console.WriteLine("zero"); break;
                    case 1: Console.WriteLine("one"); break;
                    case 2: Console.WriteLine("two"); break;
                    case 3: Console.WriteLine("three"); break;
                    case 4: Console.WriteLine("four"); break;
                    case 5: Console.WriteLine("five"); break;
                    case 6: Console.WriteLine("six"); break;
                    case 7: Console.WriteLine("seven"); break;
                    case 8: Console.WriteLine("eight"); break;
                    case 9: Console.WriteLine("nine"); break;
                    case 10: Console.WriteLine("ten"); break;
                    default: Console.WriteLine("Out of abilitiy"); break;

                }
            }
            else if(laso && input >= 11 && input <= 20)
            {
                //Console.WriteLine(tu11den20);
                switch (input)
                {
                    case 11: Console.WriteLine("eleven"); break;
                    case 12: Console.WriteLine("twelve"); break;
                    case 13: Console.WriteLine("third" + ones); break;
                    case 14: Console.WriteLine("four" + ones); break;
                    case 15: Console.WriteLine("fifth" + ones); break;
                    case 16: Console.WriteLine("six" + ones); break;
                    case 17: Console.WriteLine("seven" + ones); break;
                    case 18: Console.WriteLine("eight" + ones); break;
                    case 19: Console.WriteLine("nine" + ones); break;
                    case 20: Console.WriteLine("twenty"); break;
                    default: Console.WriteLine("Out of abilitiy"); break;

                }
            } else if (laso && input >= 21 && input <= 99)
            {
                int hangchuc = input / 10;
                int hangdonvi = input % 10;
                
                switch (hangchuc)
                {
                    case 30: Console.WriteLine("thirty"); break;
                    case 40: Console.WriteLine("fourty"); break;
                    case 50: Console.WriteLine("fifhty"); break;
                    case 60: Console.WriteLine("sixty"); break;
                    case 70: Console.WriteLine("seventy"); break;
                    case 80: Console.WriteLine("eighty"); break;
                    case 90: Console.WriteLine("ninety"); break;
                    //default: Console.WriteLine("Out of abilitiy"); break;
                }
                switch (hangdonvi)
                {
                    case 1: Console.WriteLine("one"); break;
                    case 2: Console.WriteLine("two"); break;
                    case 3: Console.WriteLine("three"); break;
                    case 4: Console.WriteLine("four"); break;
                    case 5: Console.WriteLine("five"); break;
                    case 6: Console.WriteLine("six"); break;
                    case 7: Console.WriteLine("seven"); break;
                    case 8: Console.WriteLine("eight"); break;
                    case 9: Console.WriteLine("nine"); break;
                    //default: Console.WriteLine("Out of abilitiy"); break;
                }
                Console.WriteLine(hangchuc * 10 + hangdonvi * 10);
            }

            Console.ReadKey();
        }

       

        //inprocess


    }
}
