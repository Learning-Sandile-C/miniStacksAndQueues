using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miniStacksAndQueuse
{
    class Person
    {
        string name, surname, idNo;

        public Person(string name, string surname, string idNo)
        {
            this.Name = name;
            this.Surname = surname;
            this.IdNo = idNo;
        }

        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public string IdNo { get => idNo; set => idNo = value; }
    }
}
