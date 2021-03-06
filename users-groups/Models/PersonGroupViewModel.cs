﻿using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;
using users_groups.data;

namespace users_groups.Models
{
    public class PersonGroupViewModel
    {
        public List<PersonViewModel> Persons { get; set; }
        public SelectList Groups { get; set; }
        public string Group { get; set; }
    }
}