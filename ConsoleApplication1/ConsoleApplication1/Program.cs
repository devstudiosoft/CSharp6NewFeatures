using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Persons persons = new Persons
            {
                [1] = new Person("Gaetano", "Franco") { PhoneNumber = new PhoneNumber { NumberType = NumberTypeEnum.Fax, Number = 123456 } },
                [2] = new Person("Gaetano1", "Franco1"),
                [3] = new Person("Gaetano2", "Franco2") { PhoneNumber = new PhoneNumber { NumberType = NumberTypeEnum.Fax, Number = 123456 } },
            };



            foreach (var item in persons)
            {
                WriteLine($"Ciao il mio {nameof(item.Value.Nome)} è: {item.Value.Nome} - Contatto: {item.Value.PhoneNumber?.Number}");
            }



            ReadLine();
        }
    }
}
