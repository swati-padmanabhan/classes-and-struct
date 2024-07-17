using ClassAndStruct.models;

namespace ClassAndStruct
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //creating intance for person class
            Person person = new Person("Ram");

            //creating instance for struct
            Person personStruct = new Person("Shyam");


            //assigning the person object to newPerson
            var newPerson = person;

            //modifying the name of newPerson
            newPerson.Name = "Name Changed";


            //Because "person" & "newPerson" are references to the same object
            Console.WriteLine("==========Using Class==========");
            Console.WriteLine(person.Name); // Name Changed

            var newPersonStruct = personStruct;
            newPerson.Name = "Name Changed";

            //Because "personStruct" and "newPersonStruct" are value types
            Console.WriteLine("==========Using Struct==========");
            Console.WriteLine(personStruct.Name); //Name will not change
        }
    }
}
