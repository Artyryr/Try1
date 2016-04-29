using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    [Serializable]
    public class Museum
    {
        public Museum()
        {
            Pictures = new List<Picture>();
        }
        [DisplayName("Название")]
        public string Title { get; set; }
        [DisplayName("Местонахождение")]
        public string Place { get; set; }
        [DisplayName("Картины")]
        public List<Picture> Pictures { get; set; }
        [DisplayName("Кол-во картин")]
        public int PicrutesCount { get { return Pictures.Count; } }
    }
}
