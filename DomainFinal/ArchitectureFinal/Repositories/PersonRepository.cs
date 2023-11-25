using DomainFinal.Entities;
using DomainFinal.Interfaces;
using InfrastructureFinal.DataBases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace InfrastructureFinal.Repositories
{
    public class PersonRepository : IPersonRepository
    {
        private readonly SqlServerContext _context;

        public PersonRepository(SqlServerContext context) 
        {
            _context = context;
        }

        //public Person GetPerson(int id)
        //{
        //    
        //    return new Person
        //    {
        //        Id = id,
        //        FirstName = "Mateo",
        //        LastName = "Ferrero",    
        //   };
        //}

        public List<Person> GetList() 
        {
            return _context.Set<Person>().ToList();
            
            
            //var personList = _context.Persons.ToList();

            //return personList;

            //return new List<Person>
            //{
            //    new Person { Id = 1, FirstName = "Mateo", LastName = "Ferrero" },
            //    new Person { Id = 2, FirstName = "Franco", LastName = "Ferrero" },
            //   new Person { Id = 3, FirstName = "Dana", LastName = "Ferrero" }
            //};
        }

    }
}
