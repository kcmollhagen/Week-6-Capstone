using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Task_List_Capstone.Models
{
    public class User
    {
        public int ID { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }

    public class DBUserContext : DbContext
    {
        public System.Data.Entity.DbSet<Task_List_Capstone.Models.User> Users { get; set; }
    }

}