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
            person.Add(0, new Person() { Name = "gaetano", Surname = "franco" });
            person.Add(1, new Person() { Name = "pippo", Surname = "franco" });
            person.Add(2, new Person() { Name = "pluto", Surname = "franco" });
            person.Add(3, new Person() { Name = "balto", Surname = "franco" });

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
                Console.WriteLine(string.Format("{0}:{1}={2}", item.Key, Person.Property.Name, item.Value.Name));

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
