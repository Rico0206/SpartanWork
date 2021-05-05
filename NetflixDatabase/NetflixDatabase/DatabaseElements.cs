using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixDatabase
{
    class DatabaseElements
    {
        public string Title { get; set; }
        public string Type { get; set; }
        public int? TitleReleased { get; set; }
        public string Rating { get; set; }
        public string Quality { get; set; }
        public string Actors { get; set; }
        public string Director { get; set; }
        public string Category { get; set; }
        public double? Imdb { get; set; }
        public int? Runtime { get; set; }
        public long NetflixId { get; set; }
        public string DateReleased { get; set; }
        public string Description { get; set; }
        public bool Fourk { get; set; }
        public string Language { get; set; }
    }
}
