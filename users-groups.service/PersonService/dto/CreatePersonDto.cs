using System;
using System.Collections.Generic;
using System.Text;

namespace users_groups.service.PersonService.dto
{
    public class CreatePersonDto
    {
        public int? PersonId { get; set; }
        public string Name { get; set; }
        public int GroupId { get; set; }
    }
}
