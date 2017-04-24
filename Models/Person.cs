using System;

namespace FirstAspNetCore.Models 
{

    public class Person
    {
        public Person()
        {

        }
        public Person(int iD, string name, string surname, DateTime birthday, string pesel)
        {
            ID = iD;
            Name = name;
            Surname = surname;
            Birthday = birthday;
            Pesel = pesel;
        }

        public int ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime Birthday { get; set; }
        public string Pesel { get; set; }
    }

}