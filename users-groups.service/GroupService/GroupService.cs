using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using users_groups.data;
using users_groups.service.GroupService.dto;

namespace users_groups.service.GroupService
{
    public class GroupService : IGroupService
    {
        private readonly UsersGroupsDbContext _context;
        private readonly ILogger<GroupService> _logger;

        public GroupService(UsersGroupsDbContext context, ILogger<GroupService> logger)
        {
            _context = context;
        }

        public async Task<List<GroupDto>> GetGroups()
        {
            var groups = await _context.Groups.Select(g => new GroupDto {GroupId = g.Id, GroupName = g.GroupName}).ToListAsync();
            return groups;
        }
    }
}
