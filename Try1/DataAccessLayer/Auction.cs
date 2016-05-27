using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    [Serializable]
    public class Auction // Класс аукцион
    {
        public Auction()
        {
            Items = new List<AuctionItem>();
        }

        public string Title { get; set; }
        public DateTime Date { get; set; }
        public List<AuctionItem> Items { get; set; }
    }
}
