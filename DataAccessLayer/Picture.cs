using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    [Serializable]
    public enum ArtGenre
    {
        History,
        Portrait,
        Genre,
        Landscape,
        Still_Life,
        Mythologic,
        Impression
    }

    [Serializable]
    public class Picture
    {
        public Picture()
        {
            Verified = true;
            Date = DateTime.Now;
        }

        [DisplayName("Название")]
        public string Title { get; set; }

        [DisplayName("Cоздатель")]
        public string Artist { get; set; }

        [DisplayName("Подлинность")]
        public bool Verified { get; set; }

        [DisplayName("Жанр")]
        public ArtGenre Genre { get; set; }

        [DisplayName("Дата создания")]
        public DateTime Date { get; set; }


        [DisplayName("Местонахождение")]
        public string Place { get; set; }

    }
}
