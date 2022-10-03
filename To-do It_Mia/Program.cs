using To_do_It_Mia.Models;

namespace To_do_It_Mia
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Below are the details for person: " );

            Person person1 = new Person(1, "Charles","");
            //Person person2 = new Person(2, "Sayeh", "");
            //Person person3 = new Person(3, "Maria", "Svensson");
            Console.WriteLine(person1.PersonId + " " + person1.FirstName + " " + person1.LastName);
            //Console.WriteLine(person2.PersonId + " " + person2.FirstName + " " + person2.LastName);
            //Console.WriteLine(person3.PersonId + " " + person3.FirstName + " " + person3.LastName);
        }
    }
}