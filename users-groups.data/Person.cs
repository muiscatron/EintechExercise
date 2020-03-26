using System;
using System.Collections.Generic;
using System.Text;

namespace users_groups.data
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int GroupId { get; set; }
        public Group Group { get; set; }
    }
}
