using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndStruct.models
{
    internal class PersonStruct
    {

        public string Name { get; set; }

        public PersonStruct(string name)
        {
            Name = name;
        }
    }
}
