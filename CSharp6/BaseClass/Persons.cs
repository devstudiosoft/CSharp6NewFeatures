using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp6.BaseClass
{
    class Persons : Dictionary<int, Person>
    {
        public Person GetPersonFromName(string name)
        {
            return Values.FirstOrDefault(x => x.Name == name);
        }

        public IEnumerable<Person> GetPersonFromMobilePhone(string number)
        {
            return Values.Where(x => x.PhoneNumber != null && x.PhoneNumber.Number.Contains(number));
        }

        #region ExpressionBodyMethodLike
        //public Person GetPersonFromName(string name) => Values.FirstOrDefault(x => x.Name == name);
        #endregion

        #region NullConditionalOperator
        //public IEnumerable<Person> GetPersonFromMobilePhone(string number) => Values.Where(x => (x.PhoneNumber?.Number).Contains(number));
        #endregion
    }
}
