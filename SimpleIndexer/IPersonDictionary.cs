using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleIndexer
{
    interface IPersonDictionary
    {
        Person this[string key]
        {
            get;
            set;
        }
    }
}
