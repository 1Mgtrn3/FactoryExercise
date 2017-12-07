using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Factory Test");
            PersonFactory P = new PersonFactory();
            P.AddPeople("Jane");
            P.AddPeople("Jack");
            P.AddPeople("Jeff");
            P.AddPeople("Keith");
            P.AddPeople("Mary");
            foreach(person k in P.People)
            {
                Console.WriteLine("Name: " + k.Name + " Id " + k.Id.ToString());
            }
            Console.ReadKey();
        }
    }
}
