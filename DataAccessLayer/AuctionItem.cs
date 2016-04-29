using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    [Serializable]
    public class AuctionItem
    {
        [Browsable(false)]
        public Picture Art { get; set; }

        [DisplayName("Название картины")]
        public string ArtTitle { get { return Art.Title; } }

        private int _price;

        [DisplayName("Цена")]
        public int Price
        {
            get { return _price; }
            set
            {
                if (value >= 0)
                    _price = value;
            }
        }

        [DisplayName("Владелец")]
        public string Owner
        {
            get { return Art.Title; }
        }

        public AuctionItem() { }

        public AuctionItem(Picture item, int price)
        {
            Art = item;
            Price = price;
        }


    }
}
