using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseTrackerProjectRasul.Domain
{
    public class Users
    {
        public Guid User_ID { get; set; }

        public string User_Name { get; set;}
        public string User_SurName { get; set; }

        public string User_Email { get; set;}

        public string User_Password { get; set;}

        public DateTime Birth_Date { get; set; }

        public DateTime Created_Date { get; set; }
    }
}
