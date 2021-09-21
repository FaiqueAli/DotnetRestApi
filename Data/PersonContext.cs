using System;
using System.Collections.Generic;
using System.Linq;
using testreactapp.Model;

namespace testreactapp.Data{
    public class PersonContext : IPerson
    {
        private readonly DatabaseContext _context;

        public PersonContext(DatabaseContext context)
        {
            _context=context;
        }

        public void CreatePerson(Person P)
        {
            if(P== null)
            {
                throw new ArgumentException(nameof(P));
            }
            _context.Persons.Add(P);
             SaveChanges();
        }

        public Person GetPersonByID(int ID)
        {
         var person= _context.Persons.FirstOrDefault(x=>x.ID==ID);
             return person;
        }

        public IEnumerable<Person> GetPersons()
        {
            return _context.Persons.ToList();
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges()>0);
        }
    }
}