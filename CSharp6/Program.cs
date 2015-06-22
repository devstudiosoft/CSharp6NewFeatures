using CSharp6.BaseClass;
using System;

namespace CSharp6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Persons person = new Persons();
            //person.Add(0, new Person { Name = "Megan", Surname = "Fox", PhoneNumber = new PhoneNumber { Type = PhoneType.Home, Number = "034-8547692" } });
            //person.Add(1, new Person { Name = "Raoul", Surname = "Bova", PhoneNumber = new PhoneNumber { Type = PhoneType.Office, Number = "056-80068541" } });
            //person.Add(2, new Person { Name = "Elisabetta", Surname = "Canalis", PhoneNumber = new PhoneNumber { Type = PhoneType.Personal, Number = "333-2159657" } });
            //person.Add(3, new Person { Name = "Ilary", Surname = "Blasi", PhoneNumber = new PhoneNumber { Type = PhoneType.Personal, Number = "334-1834526" } });

            //Persons person = new Persons
            //{
            //    {0, new Person { Name = "Megan", Surname = "Fox", PhoneNumber = new PhoneNumber { Type = PhoneType.Home, Number = "034-8547692" } } },
            //    {1, new Person { Name = "Raoul", Surname = "Bova", PhoneNumber = new PhoneNumber { Type = PhoneType.Office, Number = "056-80068541" } } },
            //    {2, new Person { Name = "Elisabetta", Surname = "Canalis", PhoneNumber = new PhoneNumber { Type = PhoneType.Personal, Number = "333-2159657" } } },
            //    {3, new Person { Name = "Ilary", Surname = "Blasi", PhoneNumber = new PhoneNumber { Type = PhoneType.Personal, Number = "334-1834526" } } }
            //};

            #region IndexInitializer

            Persons person = new Persons
            {
                [0] = new Person { Name = "Megan", Surname = "Fox", PhoneNumber = new PhoneNumber { Type = PhoneType.Home, Number = "034-8547692" } },
                //[1] = new Person { Name = "Raoul", Surname = "Bova" },
                [1] = new Person { Name = "Raoul", Surname = "Bova", PhoneNumber = new PhoneNumber { Type = PhoneType.Home, Number = "034-8547692" } },
                [2] = new Person { Name = "Elisabetta", Surname = "Canalis", PhoneNumber = new PhoneNumber { Type = PhoneType.Personal, Number = "333-2159657" } },
                [3] = new Person { Name = "Ilary", Surname = "Blasi", PhoneNumber = new PhoneNumber { Type = PhoneType.Personal, Number = "334-1834526" } }
            };

            #endregion

            foreach (var item in person)
            {
                Console.WriteLine(string.Format("Index - {0}: {1} = {2}: {3}", item.Key, Person.Property.Name, item.Value.Name, item.Value.PhoneNumber.Number));

                #region StaticUsing
                //WriteLine(string.Format("Index - {0}: {1} = {2}: {3}", item.Key, Person.Property.Name, item.Value.Name, item.Value.PhoneNumber.Number));
                #endregion

                #region NameOf
                //WriteLine(string.Format("Index - {0}: {1} = {2}: {3}", item.Key, nameof(item.Value.Name), item.Value.Name, item.Value.PhoneNumber.Number));
                #endregion

                #region StringInterpolation
                //WriteLine($"Index - {item.Key}: {nameof(item.Value.Name)} = {item.Value.Name}: {item.Value.PhoneNumber.Number}");
                #endregion
            }

            Console.ReadLine();

            #region StaticUsing
            //ReadLine();
            #endregion
        }
    }
}
