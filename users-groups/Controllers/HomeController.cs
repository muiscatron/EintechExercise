﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using users_groups.Models;
using users_groups.service.GroupService;
using users_groups.service.GroupService.dto;
using users_groups.service.PersonService;
using users_groups.service.PersonService.dto;
using users_groups.service.SearchService;
using users_groups.service.SearchService.dto;

namespace UsersGroups.Controllers
{
    public class HomeController : Controller
    {
        private readonly ISearchService _searchService;
        private readonly IGroupService _groupService;
        private readonly IPersonService _personService;


        public HomeController(ISearchService searchService, IGroupService groupService, IPersonService personService)
        {
            _searchService = searchService;
            _groupService = groupService;
            _personService = personService;
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

        public async Task<IActionResult> AddPerson()
        {
            var model = new CreatePersonViewModel();
            var groups = await _groupService.GetGroups();
            model.Groups = new SelectList(groups, "GroupId", "GroupName");
            return PartialView("_CreatePersonModalPartial", model);
        }

        [HttpPost]
        public async Task<IActionResult> AddPerson(CreatePersonViewModel model)
        {

            var createdPerson = await _personService.CreatePerson(new CreatePersonDto { Name = model.Name, GroupId = model.GroupId});

            return PartialView("_CreatePersonModalPartial", new CreatePersonViewModel() { PersonId = createdPerson.PersonId, Name = createdPerson.Name, GroupId = createdPerson.GroupId});
        }
    }
}
