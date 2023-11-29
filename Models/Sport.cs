using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gregslist_sql_practice.Models
{
    public class Sport
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Teams { get; set; }
        public bool InAmerica { get; set; }
        public bool Watchable { get; set; }
    }
}