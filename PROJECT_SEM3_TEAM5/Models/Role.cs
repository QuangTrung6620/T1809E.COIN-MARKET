using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PROJECT_SEM3_TEAM5.Models
{
    public class Role
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public RoleStatus Status { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
    public enum RoleStatus
    {
        ACTIVE = 0,
        DISABLE = 1,
        DELETED = -1
    }
}