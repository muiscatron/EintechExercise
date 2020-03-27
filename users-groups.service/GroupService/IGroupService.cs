using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using users_groups.service.GroupService.dto;

namespace users_groups.service.GroupService
{
    public interface IGroupService
    {
        Task<GroupDto> CreateGroup(GroupDto group);
    }
}
