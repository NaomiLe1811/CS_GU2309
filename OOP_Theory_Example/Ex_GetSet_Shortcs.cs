public class Person
{
    // Auto-implemented property
    public string Name { get; set; }
}

class Program
{
    static void Main()
    {
        // Create an instance of the Person class
        Person person = new Person();

        // Set the value of the Name property
        person.Name = "John Doe";

        // Get the value of the Name property
        string personName = person.Name;

        // Display the result
        Console.WriteLine("Person's Name: " + personName);
    }
}