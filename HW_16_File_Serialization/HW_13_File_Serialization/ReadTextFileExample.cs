using System;
using System.IO;

namespace HW_13_File_Serialization
{
    public class ReadTextFileExample
    {
        public ReadTextFileExample(string filePath)
        {
            try
            {
                FileInfo file = new FileInfo(filePath);
                if (!file.Exists)
                {
                    throw new FileNotFoundException();
                }

                StreamReader reader = new StreamReader(filePath);
                string line = "";
                int sum = 0;
                while ((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                    sum += Int32.Parse(line);
                }
                reader.Close();
                Console.WriteLine("Total: " + sum);
            }
            catch (FileNotFoundException)
            {
                Console.Error.WriteLine("File not found");
            }
            catch (FormatException)
            {
                Console.Error.WriteLine("Invalid content in the file");
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine("An error occurred: " + ex.Message);
            }
        }
    }
}