using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PROJECT_SEM3_TEAM5.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Age { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public DateTime BirthDay { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public UserStatus Status { get; set; }
        [ForeignKey("Post")]
        public int PostID { get; set; }
        public virtual Post Post{ get; set; }
    }
    public enum UserStatus
    {
        ACTIVE = 0,
        DISABLE = 1,
        DELETED = -1
    }
}