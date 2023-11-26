using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolekcija_Rjecnik
{
    internal class Student
    {
        string jmbag, ime, prezime;
        public Student(string jmbag, string ime, string prezime)
        {
            this.jmbag = jmbag;
            this.ime = ime;
            this.prezime = prezime;
        }
        public override string ToString()
            => $"{jmbag} ({prezime},{ime})";
        public override bool Equals(object? obj)
        {
            if (obj is Student s)
                return s.jmbag == jmbag;
            return false;
        }
        public override int GetHashCode()
            => jmbag.GetHashCode();
    }
}
