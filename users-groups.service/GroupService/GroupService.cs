using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
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

        public async Task<GroupDto> CreateGroup(GroupDto @group)
        {
            var addedItem = await _context.Groups.AddAsync(new Group {GroupName = group.GroupName});
            _context.SaveChanges();
            return new GroupDto { GroupId = addedItem.Entity.Id, GroupName = addedItem.Entity.GroupName };
        }
    }
}
