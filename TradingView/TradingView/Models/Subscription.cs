using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TradingView.Models
{
    public class Subscription
    {
        public int SubscriptionId { get; set; }
        public string Name { get; set; }
        public string Exchange { get; set; }
  
        public User User { get; set; }
    }
}
