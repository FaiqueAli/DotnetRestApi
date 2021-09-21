using System.Collections.Generic;
using testreactapp.Model;

namespace testreactapp.Data
{
    public class MockPerson : IPerson
    {
        List<Person> personList=new  List<Person> {
             new Person{ID=0,Name="Faiq", Address="Passau"},
             new Person{ID=1,Name="Ali", Address="Dubai"}
            };
        public void CreatePerson(Person P)
        {
            if(P!=null)
            {
                personList.Add(P);
            }
        }

        public Person GetPersonByID(int ID)
        {
            return personList.Find(x=>x.ID==ID);
        }

        public IEnumerable<Person> GetPersons()
        {
            
            return personList;
        }

        public bool SaveChanges()
        {
            return true;
        }
    }
}