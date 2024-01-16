using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseTrackerProjectRasul.Domain
{
    public class ExpensesResponse
    {
        public string Type { get; set; }

        public string Name { get; set; }

        public int Count { get; set; }

        public float Prize { get; set; }

        public DateTime DateofAdding {  get; set; }
    }
}
