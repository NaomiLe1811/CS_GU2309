public class Person
{
    // Private field to store the value of the property
    private string name;

    // Property with get and set accessors
    public string Name
    {
        get
        {
            // Code executed when the property is read
            return name;
        }
        set
        {
            // Code executed when the property is written to
            name = value;
        }
    }
}

class Program
{
    static void Main()
    {
        // Create an instance of the Person class
        Person person = new Person();

        // Set the value of the Name property using the set accessor
        person.Name = "John Doe";

        // Get the value of the Name property using the get accessor
        string personName = person.Name;

        // Display the result
        Console.WriteLine("Person's Name: " + personName);
    }
}