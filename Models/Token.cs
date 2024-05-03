using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp14.Models
{
    public class Token
    {
        public string name { get; set; }
        public string symbol { get; set; }
        public string address { get; set; }
        public decimal amount { get; set; }
        public decimal txamount { get; set; }
        public decimal takeprofit { get; set; }
        public decimal stoploss { get; set; }
        public decimal trailingstoploss { get; set; }
        public decimal sellpercent { get; set; }
    }
}
