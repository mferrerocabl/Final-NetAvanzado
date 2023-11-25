using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainFinal.Entities;


namespace DomainFinal.Interfaces
{
    public interface IPersonRepository
    {
        List<Person> GetList();
        //Person GetPerson(int id);
    }
}
