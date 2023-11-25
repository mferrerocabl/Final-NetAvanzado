using AppFinal.Contracts;
using AppFinal.Handlers;
using AppFinal.Models;
using AutoMapper;
using DomainFinal.Entities;
using DomainFinal.Interfaces;
using FluentValidation;
using FluentValidation.Results;
using Moq;
using Xunit;

namespace Final.Test
{
    public class GetPersonListHandlerTest
    {

        private readonly Mock<IMapper> _mapper;
        private readonly Mock<IPersonRepository> _personRepository;
        private readonly Mock<IValidator<GetPersonListRequest>> _validator;

        private GetPersonListHandler handler;

        public GetPersonListHandlerTest()
        {
            var personDto = new PersonDto() 
            {
                FirstName = "Test",
            };

            var result = new ValidationResult();

            var personList = new List<Person> 
            {
                new Person { FirstName = "Test1",},
                new Person { FirstName = "Test2",},
            };


            _validator = new Mock<IValidator<GetPersonListRequest>>();
            _validator.Setup(validator => validator.Validate(It.IsAny<GetPersonListRequest>()))
                      .Returns(result);

            _personRepository = new Mock<IPersonRepository>();
            _personRepository.Setup(repository => repository.GetList()).Returns(personList);

            _mapper = new Mock<IMapper>();
            _mapper.Setup(x => x.Map<PersonDto>(It.IsAny<Person>())).Returns(personDto);


            handler = new GetPersonListHandler(_mapper.Object, _personRepository.Object, _validator.Object);
        }


        [Fact]
        public async void TestValidRequest_ReturnValidResponse()
        {

            var response = await handler.Handle(new GetPersonListRequest(), CancellationToken.None);

            Assert.NotNull(response);
            Assert.NotNull(response.PersonList);
        }
    }
}