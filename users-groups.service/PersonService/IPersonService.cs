using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using users_groups.service.PersonService.dto;

namespace users_groups.service.PersonService
{
    public interface IPersonService
    {
        Task<CreatePersonDto> CreatePerson(CreatePersonDto person);

    }
}
