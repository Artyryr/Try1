using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    [Serializable]
    public class Collector
    {
        public Collector()
        {
            Collection = new List<Picture>();
        }
        public Collector(string name)
        {
            Name = name;
        }
        public string Name { get; set; }
        public List<Picture> Collection { get; set; }
    }
}
