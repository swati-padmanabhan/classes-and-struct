using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndStruct
{
    public class Person
    {
        //classes are reference types and are stored on Heap
        //while structs are value types and are stored on Stack
        //when we pass a value type, we are passing a copy of the object or value itself
        //so changing one does not affect the other
        //when we pass reference type, we are passing a reference to that object

        public string Name { get; set; }

        public Person(string name)
        {
            Name = name;
        }


        public struct PersonStruct
        {
            public string Name { get; set; }

            public PersonStruct(string name)
            {
                Name = name;
            }
        }
    }
}
