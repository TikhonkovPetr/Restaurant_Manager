using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Manager
{
    public class Waiter
    {
        public int Id{ get; set; }
        public string Name { get; set; }
        public float Salary_per_day { get; set; }
        public DateTime Device_date { get; set; }
        public int Shifts { get; set; }
    }
}
