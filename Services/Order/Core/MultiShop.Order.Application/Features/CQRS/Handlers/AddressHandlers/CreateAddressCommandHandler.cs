using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MultiShop.Order.Application.Features.CQRS.Commands.AddressCommands;
using MultiShop.Order.Application.Interfaces;
using MultiShop.Order.Domain.Entities;

namespace MultiShop.Order.Application.Features.CQRS.Handlers.AddressHandlers
{
    public class CreateAddressCommandHandler
    {
        private readonly IRepository<Address> _repository;

        public CreateAddressCommandHandler(IRepository<Address> repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateAddressCommands createAddressCommands)
        {
            await _repository.CreateAsync( new Address
            {
                City = createAddressCommands.City,
                Detail1 = createAddressCommands.Detail1,
                District = createAddressCommands.District,
                UserId = createAddressCommands.UserId,
                Country = createAddressCommands.Country,
                Description = createAddressCommands.Description,
                Detail2 = createAddressCommands.Detail2,
                Email = createAddressCommands.Email,
                Name = createAddressCommands.Name,
                Phone = createAddressCommands.Phone,    
                Surname = createAddressCommands.Surname,
                ZipCode = createAddressCommands.ZipCode,
            });
        }
    }
}
