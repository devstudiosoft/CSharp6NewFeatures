using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp6.BaseClass
{
    class Person
    {
        public string Name { get; set; }

        #region PropertyInitializer
        //public string Name { get; set; } = "Prova1";
        //public string Name { get; } = "Prova1";
        #endregion
        public string Surname { get; set; }

        public PhoneNumber PhoneNumber { get; set; }

        public string FullName { get { return string.Format("{0} {1}", Name, Surname); } }

        #region ExpressionBodyPropertyLike
        //public string FullName => string.Format("{0} {1}", Name, Surname);
        #endregion

        #region StringInterpolation
        //public string FullName => $"{Name} {Surname}";
        #endregion

        #region ConstructorAssignament

        //public Person(string name, string surname)
        //{
        //    Name = name;
        //    Surname = surname;
        //}

        #endregion

        public static class Property
        {
            public const string Name = "Name";
            public const string Surname = "Surname";
            public const string FullName = "FullName";
        }
    }
}
