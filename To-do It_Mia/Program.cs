using To_do_It_Mia.Models;

namespace To_do_It_Mia
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Below are the details for person: " );

            Person person1 = new Person(1, "Charles", "Rudahusha");
            Console.WriteLine(person1.PersonId + " " + person1.FirstName + " " + person1.LastName);
        }
    }
}