﻿using Surging.Hero.Organization.IApplication.Position.Dtos;
using System.Collections.Generic;

namespace Surging.Hero.Organization.IApplication.Department.Dtos
{
    public class CreateDepartmentInput : DepartmentDtoBase
    {
        public long ParentId { get; set; }

        //public long OrgId { get; set; }

        public IEnumerable<CreatePositionInput> Positions { get; set; }
    }
}
