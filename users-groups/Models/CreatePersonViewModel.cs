using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace users_groups.Models
{
    public class CreatePersonViewModel
    {
        public int? PersonId { get; set; }
        public string Name { get; set; }
        public SelectList Groups { get; set; }
        public int GroupId { get; set; }
    }
}
