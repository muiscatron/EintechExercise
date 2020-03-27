using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;
using users_groups.data;

namespace users_groups.Models
{
    public class PersonGroupViewModel
    {
        public List<Person> Persons;
        public SelectList Groups;
        public string Group { get; set; }
    }
}