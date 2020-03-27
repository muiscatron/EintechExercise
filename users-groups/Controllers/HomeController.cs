using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using users_groups.Models;
using users_groups.service.SearchService;
using users_groups.service.SearchService.dto;

namespace UsersGroups.Controllers
{
    public class HomeController : Controller
    {
        private readonly ISearchService _searchService;

        public HomeController(ISearchService searchService)
        {
            _searchService = searchService;
        }

        public async Task<IActionResult> Index(string group, string searchString)
        {
            var searchParameters = new SearchParametersDto {GroupSearch = group, NameSearch = searchString};
            var result = _searchService.GetSearchResults(searchParameters);

            var searchResultViewModel = new PersonGroupViewModel
            {
                Groups = new SelectList(result.GroupBy(p => p.GroupId).Select(g => g.First().GroupName)),
                Persons = await
                    result.Select(p => new PersonViewModel()
                    {
                        PersonId = p.PersonId, Name = p.Name, GroupName = p.GroupName
                    }).ToListAsync()
            };

            return View(searchResultViewModel);
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
