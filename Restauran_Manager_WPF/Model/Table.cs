using System;
using System.Collections.Generic;

namespace Restaurant_Manager
{
    public class Table
    {
        public int Id { get; set; }
        public int Places { get; set; }
        public int Total_cost { get; set; }
        public List<Dish> Order { get; set; }
        public bool Busy { get; set; }
        public Waiter waiter { get; set; }
    }
}
