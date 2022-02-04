using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleIndexer
{
    class PersonCollection : IEnumerable
    {
        private ArrayList arrPeople = new ArrayList();
        public IEnumerator GetEnumerator() => arrPeople.GetEnumerator();

        public Person GetPerson(int index) => (Person)arrPeople[index];
        public void AddPerson(Person person) => arrPeople.Add(person);
        public void ClearPerson() => arrPeople.Clear();
        public int CountPerson => arrPeople.Count;
        public Person this[int index]
        {
            get => (Person) arrPeople[index];
            set => arrPeople.Insert(index, value);
        }
    }
}
