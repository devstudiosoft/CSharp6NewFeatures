using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Persons:Dictionary<int,Person>
    {
        public Person GetPersonById(string name) => Values.FirstOrDefault(x => x.Nome == name);


    }
}
