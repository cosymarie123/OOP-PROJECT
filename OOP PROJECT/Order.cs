using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_PROJECT
{
    public class Birthdate
    {
        int day;
        string month;
        int year;
        public Birthdate(int d, string m ,int y)
        {
            day = d;
            month = m;
            year = y;
        }
        public Birthdate() { }
    }
    public class Person
    {
        public string name;
        public string email;
        public Birthdate bday;
        public string password;
        public Person() { }
        public Person(string m, string p, string n,int d, string mon, int y)
        {
            email = m;
            password = p;
            name = n;
            bday = new Birthdate(d, mon, y);
        }
        public string FirstName
        {
            get
            {
                string[] words = name.Split(' ');
                return words[words.Length - 1];
            }
        }
    }
    
}
