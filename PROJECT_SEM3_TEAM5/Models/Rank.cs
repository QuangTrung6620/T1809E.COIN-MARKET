using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace PROJECT_SEM3_TEAM5.Models
{
    public class Rank
    {
        public int Id { get; set; }
        public string Value { get; set; }
        public RankStatus Status { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
    public enum RankStatus
    {
        ACTIVE = 0,
        DISABLE = 1,
        DELETED = -1
    }
}