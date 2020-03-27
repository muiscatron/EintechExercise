using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using users_groups.data;
using users_groups.service.PersonService.dto;

namespace users_groups.service.PersonService
{
    public class PersonService : IPersonService
    {

        private readonly UsersGroupsDbContext _context;
        private readonly ILogger<PersonService> _logger;

        public PersonService(UsersGroupsDbContext context, ILogger<PersonService> logger)
        {
            _context = context;
        }

        public async Task<CreatePersonDto> CreatePerson(CreatePersonDto person)
        {
            var addedItem = await _context.Persons.AddAsync(new Person { Name = person.Name, GroupId = person.GroupId});
            _context.SaveChanges();
            return new CreatePersonDto { PersonId = addedItem.Entity.Id, Name = addedItem.Entity.Name, GroupId = addedItem.Entity.GroupId};
        }

    }
}
