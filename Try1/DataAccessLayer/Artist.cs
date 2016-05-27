using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    [Serializable]
    public class Artist // Класс художник
    {

        public Artist()
        {
            Pictures = new List<Picture>();
        }
        public Artist(string name)
        {
            Name = name;
        }

        [DisplayName("Имя")]
        public String Name { get; set; }

        [DisplayName("Годы жизни")]
        public String LifeTime { get; set; }
        [DisplayName("Национальность")]
        public String Nationality { get; set; }


        public List<Picture> Pictures { get; set; }
        public List<ArtGenre> ArtGenres { get { return Pictures.Select(x => x.Genre).Distinct().ToList(); } }

    }
}
