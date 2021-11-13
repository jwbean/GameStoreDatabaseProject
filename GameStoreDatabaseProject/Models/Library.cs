using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStoreDatabaseProject.Models
{
    public class Library
    {
        public int UserId { get; set; }
        public string GameName { get; set; }
        public DateTimeOffset PurchasedDate { get; set; }
    }
}
