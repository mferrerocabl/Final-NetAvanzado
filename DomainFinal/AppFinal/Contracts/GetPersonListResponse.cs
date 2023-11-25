using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppFinal.Models;
using DomainFinal.Entities;

namespace AppFinal.Contracts
{
    public class GetPersonListResponse
    {
        internal List<Person> personList;

        public List<PersonDto> PersonList { get; internal set; }
    }
}
