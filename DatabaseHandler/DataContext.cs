using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;


namespace DatabaseHandler
{
    [Serializable]
    public class DataContext
    {
        private static DataContext _instance;

        public static DataContext Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new DataContext();
                return _instance;
            }
        }

        public List<Picture> Pictures { get; set; }
        public List<Artist> Artists { get; set; }
        public List<Auction> Auctions { get; set; }
        public List<Museum> Museums { get; set; }
        public List<Collector> Collectors { get; set; }
        public string Path { get; set; }

        private DataContext()
        {
            Path = System.IO.Path.Combine(Environment.CurrentDirectory + @"\db.dat");
        }



        public void Initialize()
        {
            Pictures = new List<Picture>();
            Artists = new List<Artist>();
            Auctions = new List<Auction>();
            Museums = new List<Museum>();
            Collectors = new List<Collector>();

            if (!CheckIfDataExists())
                InitializeContext();
            else
                LoadDataContext();
        }

        private void LoadDataContext()
        {
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            using (FileStream fs = new FileStream(Path, FileMode.Open))
            {
                var dataContext = (DataContext)binaryFormatter.Deserialize(fs);
                _instance = dataContext;
            }
        }

        public void ForceClearDatabase()
        {
            if (File.Exists(Path))
                File.Delete(Path);

            InitializeContext();
        }

        private void InitializeContext()
        {
            Pictures = new List<Picture>()
            {
                new Picture() {Title = "Starry Night Over the Rhone", Genre = ArtGenre.Landscape,Verified = true,  Date = new DateTime(1888,01,01) ,  Artist = "Vincent van Gogh", Place = "Musée d'Orsay, Paris"},
                new Picture() {Title = "The Starry Night", Genre = ArtGenre.Landscape,Verified = true,  Date = new DateTime(1889,06,01), Artist= "Vincent van Gogh", Place = "Museum of Modern Art, New York" },
                new Picture() {Title = "Olive Trees with the Alpilles in the Background", Genre = ArtGenre.Still_Life, Verified = true, Date = new DateTime(1889,05,01), Artist = "Vincent van Gogh", Place = "Museum of Modern Art, New York" },
                new Picture() {Title = "Wheatfield with Crows", Genre = ArtGenre.Landscape,Verified = true,Date = new DateTime(1890,07,01), Artist= "Vincent van Gogh", Place = "Van Gogh Museum, Amsterdam" },
                new Picture() {Title = "Sunflowers", Genre = ArtGenre.Still_Life,Verified = true,Date = new DateTime(1888,06,01), Artist= "Vincent van Gogh", Place = "Private collection" },

                new Picture() {Title = "The Persistence of Memory", Genre = ArtGenre.Impression, Verified = true,Date = new DateTime(1931,01,01), Artist = "Salvador Dalí", Place = "Museum of Modern Art, New York" },
                new Picture() {Title = "The Elephants", Genre = ArtGenre.Impression, Verified = true,Date = new DateTime(1948,01,01), Artist = "Salvador Dalí", Place = "Private collection" },
                new Picture() {Title = "Dream Caused by the Flight of a Bee Around a Pomegranate a Second Before Awakening", Genre = ArtGenre.Impression, Verified = true,Date = new DateTime(1944 ,04,01), Artist = "Salvador Dalí", Place = "Thyssen-Bornemisza Museum, Madrid" },

                new Picture() {Title = "Portrait of a Young Woman with a Rosary", Genre = ArtGenre.Portrait, Date = new DateTime(1609,07,01),  Artist = "Peter Paul Rubens", Place = "Thyssen-Bornemisza Museum, Madrid" },
                new Picture() {Title = "Venus at the Mirror", Genre = ArtGenre.Portrait, Date = new DateTime(1615,01,01) ,Artist = "Peter Paul Rubens", Place = "Private collection" },
                new Picture() {Title = "Infanta Isabella Clara Eugenia", Genre = ArtGenre.Portrait, Date = new DateTime(1625,01,01),  Artist = "Peter Paul Rubens", Place = "Kunsthistorisches Museum, Vienna." },
                new Picture() {Title = "Virgin in Adoration before the Christ Child", Genre = ArtGenre.Portrait, Date = new DateTime(1615), Artist = "Peter Paul Rubens", Place = "Private collection" },
                new Picture() {Title = "Miracle of Saint Hubert", Genre = ArtGenre.Landscape, Date = new DateTime(1890,07,01), Artist = "Peter Paul Rubens", Place = "Private collection" },

                new Picture() {Title = "View at Rouelles", Genre = ArtGenre.Landscape,  Artist = "Oscar-Claude Monet", Place = "Private collection" },
                new Picture() {Title = "In the Garden", Genre = ArtGenre.Landscape,  Artist = "Oscar-Claude Monet", Place = " Collection E. G. Buehrle, Zürich" },
                new Picture() {Title = "Weeping Willow", Genre = ArtGenre.Impression,  Artist = "Oscar-Claude Monet", Place = "Kimball Art Museum, Fort Worth, " },
                new Picture() {Title = "Rouen Cathedral at sunset", Genre = ArtGenre.Impression,  Artist = "Oscar-Claude Monet", Place = "Kimball Art Museum, Fort Worth, " },

            };

            Artists = new List<Artist>()
            {
                new Artist() { Name = "Vincent van Gogh",Nationality = "Dutch", LifeTime = "30 March 1853 - 29 July 1890",Pictures = {Pictures[0],Pictures[1],Pictures[2],Pictures[4], Pictures[5] }},
                new Artist() { Name = "Salvador Dalí",LifeTime = "11 May 1904 - 23 January 1989 ", Nationality = "Spanish",Pictures = {Pictures[5], Pictures[6], Pictures[7] }},
                new Artist() { Name = "Peter Paul Rubens",LifeTime = "28 June 1577 - 30 May 1640", Nationality= "Flemish", Pictures = {Pictures[8], Pictures[9], Pictures[10],Pictures[11] }},
                new Artist() { Name = "Oscar-Claude Monet",LifeTime = "14 November 1840 - 5 December 1926 ", Nationality = "French",Pictures = {Pictures[5], Pictures[6], Pictures[7] }},
            };

            var auctionItem = new AuctionItem() { Art = Pictures[0], Price = 500 };
            Auctions = new List<Auction>()
            {
                new Auction() {Title = "QweQEQWe", Date = new DateTime(2016,5,25), Items = { auctionItem } }
            };

            Museums = new List<Museum>()
            {
                new Museum() {Title = "Museum of Modern Art", Place = "New York", Pictures = { Pictures[1],Pictures[2],Pictures[4], } },
                new Museum() {Title = "Thyssen-Bornemisza Museum", Place = "Madrid", Pictures = { Pictures[7],Pictures[8] } },

            };

            Collectors = new List<Collector>()
            {
                new Collector() {Name = "First collector", Collection = Enumerable.Empty<Picture>().ToList()}
            };

            SaveDataContext();
        }

        public void SaveDataContext()
        {
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            using (FileStream fs = new FileStream(Path, FileMode.Create))
            {
                binaryFormatter.Serialize(fs, this);
            }
        }

        private bool CheckIfDataExists()
        {
            if (File.Exists(Path))
            {
                return true;
            }
            return false;
        }

        public Artist GetArtistByName(string name)
        {
            return Artists.FirstOrDefault(x => x.Name.Contains(name));
        }


    }
}
