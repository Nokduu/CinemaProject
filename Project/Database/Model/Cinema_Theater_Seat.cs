using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Database.Model
{
    class Cinema_Theater_Seat
    {
        public Cinema_tbl cinema { get; set; }
        public Theater_tbl theater { get; set; }
        public Seat_tbl seat { get; set; }

    }
}
