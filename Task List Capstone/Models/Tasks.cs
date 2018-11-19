using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Task_List_Capstone.Models
{
    public class Tasks
    {
        public int ID { get; set; }
        public string UserID { get; set; }
        public string Description { get; set; }
        public DateTime DueDate { get; set; }
        public bool Complete { get; set; }
    }

    public class DBTasksContext : DbContext
    {
        public System.Data.Entity.DbSet<Task_List_Capstone.Models.Tasks> TaskLists { get; set; }
    }
}