using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace users_groups.data
{
    public class Group
    {
        public int Id { get; set; }
        public string GroupName { get; set; }

        public ICollection<Person> Persons { get; set; }

    }
}
