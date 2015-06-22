using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
   

    public class Person
    {
        public string Nome { get; }
        public string Surname { get; }

        //public string FullName { get { return string.Format("{0} {1}",Name,Surname); } }

        public string FullName => $"{Nome} {Surname}";

        public PhoneNumber PhoneNumber { get; set; }

        public Person(string name, string surname)
        {
            Nome = name;
            Surname = surname;
        }
    }
}
