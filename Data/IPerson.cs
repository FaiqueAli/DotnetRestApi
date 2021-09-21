using System.Collections.Generic;
using testreactapp.Model;

namespace testreactapp.Data
{

    public interface IPerson
    {
        IEnumerable<Person> GetPersons();
        Person GetPersonByID(int ID);
        void CreatePerson(Person P);
        bool SaveChanges();
    }
}