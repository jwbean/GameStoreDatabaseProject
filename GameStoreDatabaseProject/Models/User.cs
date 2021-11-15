using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStoreDatabaseProject.Models
{
    public class User
    {
        public int UserId{ get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTimeOffset DateJoined { get; set; }
        public DateTimeOffset LastActiveDate { get; set; }
        public bool IsRemoved { get; set; }
    }
    public class ActiveUser
    {
        public int ActiveUsers { get; set; }
    }
    public class NewUser
    {
        public int NewUsers { get; set; }
    }
    public class TopSpender
    {
        public string UserName { get; set; }
        public int TotalSpent { get; set; }
    }
}
