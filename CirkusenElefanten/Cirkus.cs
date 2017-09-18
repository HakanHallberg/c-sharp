using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CirkusenElefanten
{
    public class Cirkus
    {
        private string namn;
        private Dictionary<Artist, int> ArtistDictionary =
            new Dictionary<Artist, int>();

        public Cirkus(string namn)
        {
            this.namn = namn;
        }

        public void Anställ(Artist artist)
        {
            ArtistDictionary.Add(artist, 0);
        }

        public void Artistuppträdande(Artist artist)
        {
            ArtistDictionary[artist]++;
        }

        public override string ToString()
        {
            var message = $"Cirkusen {this.namn} har {this.AntalArtister} artister.";
            foreach (var ArtistuppträdandeEntry in ArtistDictionary)
            {
                string gånger = "gång";
                if (ArtistuppträdandeEntry.Value > 1)
                    gånger += "er";
                message += $" {ArtistuppträdandeEntry.Key.namn} har uppträtt {ArtistuppträdandeEntry.Value} {gånger}.";
            }
            return message;
        }

        public int AntalArtister
        {
            get
            {
                return this.ArtistDictionary.Count;
            }
        }
    }
}
