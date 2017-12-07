using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryExercise
{
    
    public class person
    {
       public int Id { get; set; }
        public string Name { get; set; }

        
    }

    public class PersonFactory
    {
        public List<person> People = new List<person>();
        private person CreatePerson(string Name) {
            person P = new person();
            P.Name = Name;
            return P;
        }

        //альтернативно можно вставить функционал addpeople в createperson. Но это тогда 2 дела за раз

        public void AddPeople(string Name)
        {

            People.Add(CreatePerson(Name));
            People[People.Count - 1].Id = People.Count - 1;


        }

    }

    


}
