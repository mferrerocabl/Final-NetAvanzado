using AppFinal.Contracts;
using AppFinal.Models;
using AutoMapper;
using DomainFinal.Entities;
using DomainFinal.Interfaces;
using FluentValidation;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace AppFinal.Handlers
{
    public class GetPersonListHandler : IRequestHandler<GetPersonListRequest, GetPersonListResponse>
    {
        private readonly IMapper _mapper;
        private readonly IPersonRepository _personRepository;
        private readonly IValidator<GetPersonListRequest> _validator;

        public GetPersonListHandler(IMapper mapper,IPersonRepository personRepository, IValidator<GetPersonListRequest> validator)
        {
            _mapper = mapper;
            _personRepository = personRepository;
            _validator = validator;
        }
        public async Task<GetPersonListResponse> Handle(GetPersonListRequest request, CancellationToken cancellationToken)
        {
            await Task.Delay(0, cancellationToken);

            var response = new GetPersonListResponse();

            var result = _validator.Validate(request);

            var personList = _personRepository.GetList();

            response.PersonList = personList.Select(p =>MapTo(p)).ToList();

            return response;
        }

        private PersonDto MapTo(Person person) 
        {
            return _mapper.Map<PersonDto>(person);
        }

    }
}
