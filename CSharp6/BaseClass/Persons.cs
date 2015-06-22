using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp6.BaseClass
{
    class Persons : Dictionary<int, Person>
    {
        public Person SearchFromName(string name)
        {
            return Values.FirstOrDefault(x => x.Name.Contains(name));
        }

        public IEnumerable<Person> SearchFromPhoneNumber(string number)
        {
            return Values.Where(x => x.PhoneNumber != null && x.PhoneNumber.Number.Contains(number));
        }

        #region ExpressionBodyMethodLike
        //public Person SearchFromName(string name) => Values.FirstOrDefault(x => x.Name.Contains(name));
        #endregion

        #region NullConditionalOperator
        //public IEnumerable<Person> SearchFromPhoneNumber(string number) => Values.Where(x => (x.PhoneNumber?.Number).Contains(number));
        #endregion

        public async Task ExportToCSV()
        {
            using (StreamWriter file = new StreamWriter(@"C:\ExportFolder\Person.csv"))
            {
                foreach (KeyValuePair<int, Person> item in this)
                {
                    try
                    {
                        string line = $"{item.Key},{item.Value?.Name},{item.Value?.Surname},{item.Value?.PhoneNumber.Type},{item.Value?.PhoneNumber?.Number}";
                        await file.WriteLineAsync(line);
                    }
                    catch (NullReferenceException e)
                    {
                        using (StreamWriter errorFile = new StreamWriter(@"C:\ExportFolder\Error.txt"))
                            await errorFile.WriteLineAsync($"{DateTime.Now} - {e.ToString()}");
                    }
                    catch (Exception e) when (!LogGenericException(e))
                    {
                        throw;
                    }
                }
            }
        }

        private bool LogGenericException(Exception e) => false;
    }
}
