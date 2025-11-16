using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication.ExtendedProtection.Configuration;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystemLib
{
    public abstract class Person
    {
        public string Name { get; set; }
        public string UniqueID { get; set; }

        public Person(string name, string uniqueID)
        {
            Name = name;
            UniqueID = uniqueID;
        }

        public virtual string GetDetails()
        {
            return $"Name: {Name} | ID: {UniqueID}";
        }
    }
}
