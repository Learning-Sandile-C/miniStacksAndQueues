using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miniStacksAndQueuse
{
    class Person
    {
        string name, surname;
        int idNo;
        public override string ToString()
        {
            return name + ", " + surname + ". (" + idNo + ")";
        }

        public Person(string name, string surname, int idNo)
        {
            this.Name = name;
            this.Surname = surname;
            this.IdNo = idNo;
        }

        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public int IdNo { get => idNo; set => idNo = value; }


    }
}
