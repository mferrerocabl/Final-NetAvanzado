using DomainFinal.Entities;
using DomainFinal.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppFinal.Handlers
{
    public class PersonHandler
    {
        private readonly IPersonRepository _personRepository;

        public PersonHandler(IPersonRepository personRepository)
        {
            _personRepository = personRepository;
        }

        // public Person GetPerson(int id)
        //{
        //    return _personRepository.GetPerson(id);
        //}


    }

}
