using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using users_groups.data;
using users_groups.service.SearchService.dto;

namespace users_groups.service.SearchService
{
    public class SearchService : ISearchService
    {
        private readonly UsersGroupsDbContext _context;
        private readonly ILogger<SearchService> _logger;

        public SearchService(UsersGroupsDbContext context, ILogger<SearchService> logger)
        {
            _context = context;
        }

        public IQueryable<SearchResultDto> GetSearchResults(SearchParametersDto parameters)
        {
            var personQuery = _context.Persons.Include(a => a.Group).Select(p => new SearchResultDto { PersonId = p.Id, Name = p.Name, GroupName = p.Group.GroupName, GroupId = p.GroupId });

            if (!String.IsNullOrWhiteSpace(parameters.NameSearch))
            {
                personQuery = _context.Persons.Include(a => a.Group).Where(n => n.Name.Contains(parameters.NameSearch)).Select(p => new SearchResultDto { PersonId = p.Id, Name = p.Name, GroupName = p.Group.GroupName, GroupId = p.GroupId});
            }
            if (!String.IsNullOrWhiteSpace(parameters.GroupSearch))
            {
                personQuery = _context.Persons.Include(a => a.Group).Where(n => n.Group.GroupName.Equals(parameters.GroupSearch)).Select(p => new SearchResultDto { PersonId = p.Id, Name = p.Name, GroupName = p.Group.GroupName, GroupId = p.GroupId}); 
            }

            return personQuery;
        }
    }
}
