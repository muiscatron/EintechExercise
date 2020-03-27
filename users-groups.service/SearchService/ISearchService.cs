using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using users_groups.service.SearchService.dto;

namespace users_groups.service.SearchService
{
    public interface ISearchService
    {
        IQueryable<SearchResultDto> GetSearchResults(SearchParametersDto parameters);
    }
}
