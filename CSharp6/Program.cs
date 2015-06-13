using CSharp6.BaseClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp6
{
    class Program
    {
        static void Main(string[] args)
        {
            Persons person = new Persons();
            person.Add(0, new Person() { Name = "gaetano", Surname = "franco", PhoneNumber = new PhoneNumber() { Type = PhoneType.Mobile, Number = "333456789" } });
            person.Add(1, new Person() { Name = "pippo", Surname = "franco", PhoneNumber = new PhoneNumber() { Type = PhoneType.Fax, Number = "04576855" } });
            person.Add(2, new Person() { Name = "pluto", Surname = "franco", PhoneNumber = new PhoneNumber() { Type = PhoneType.Telephone, Number = "04576854" } });
            person.Add(3, new Person() { Name = "balto", Surname = "franco" , PhoneNumber = new PhoneNumber() { Type = PhoneType.Telephone, Number = "045768444" } });

            #region IndexInitializer

            //Persons person = new Persons()
            //{
            //    [0] = new Person() { Name = "gaetano", Surname = "franco" },
            //    [1] = new Person() { Name = "pippo", Surname = "franco" },
            //    [2] = new Person() { Name = "pluto", Surname = "franco" },
            //    [3] = new Person() { Name = "balto", Surname = "franco" }
            //};

            #endregion

            foreach (var item in person)
            {
                Console.WriteLine(string.Format("{0}:{1}={2} - PhoneNember:{3}", item.Key, Person.Property.Name, item.Value.Name, item.Value.PhoneNumber.Number));

                #region StaticUsing
                //WriteLine(string.Format("{0}:{1}={2}", item.Key, Person.Property.Name, item.Value.Name));
                #endregion

                #region NameOf
                //WriteLine(string.Format("{0}:{1}={2}", item.Key, nameof(item.Value.Name), item.Value.Name));
                #endregion

                #region StringInterpolation
                //WriteLine($"{item.Key}:{nameof(item.Value.Name)}={item.Value.Name}");
                #endregion
            }

            Console.ReadLine();

            #region StaticUsing
            //ReadLine();
            #endregion
        }
    }
}
