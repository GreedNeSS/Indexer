using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleIndexer
{
    class PersonDictionary : IEnumerable, IPersonDictionary
    {
        private Dictionary<string, Person> arrPeople = new();
        public IEnumerator GetEnumerator() => arrPeople.GetEnumerator();

        public Person GetPerson(string key) => arrPeople[key];
        public void AddPerson(string key, Person person) => arrPeople.Add(key, person);
        public void ClearPerson() => arrPeople.Clear();
        public int CountPerson => arrPeople.Count;
        public Person this[string key]
        {
            get => arrPeople[key];
            set => arrPeople[key] = value;
        }
    }
}
