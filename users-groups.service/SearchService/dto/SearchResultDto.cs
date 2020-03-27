using System;
using System.Collections.Generic;
using System.Text;

namespace users_groups.service.SearchService.dto
{
    public class SearchResultDto
    {
        public int PersonId { get; set; }
        public string Name { get; set; }
        public string GroupName { get; set; }
        public int GroupId { get; set; }
    }
}
