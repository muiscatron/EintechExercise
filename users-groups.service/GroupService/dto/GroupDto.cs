using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore.Migrations.Operations;

namespace users_groups.service.GroupService.dto
{
    public class GroupDto
    {
        public int GroupId { get; set; }
        public string GroupName { get; set; }
    }
}
