using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseTrackerProjectRasul.Domain
{
    public class Expenses
    {
        public Guid Expense_ID { get; set; }

        public string Item_Type { get; set; }

        public string Item_Name { get; set; }

        public int Item_Count { get; set; }

        public float Item_Prize { get; set; }

        public DateTime Added_Date { get; set; }
    }
}
