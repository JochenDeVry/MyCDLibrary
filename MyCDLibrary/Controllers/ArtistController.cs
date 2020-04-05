using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyCDLibrary.Controllers
{
    public class ArtistController
    {
        List<string> _artists;

        public ArtistController()
        {
            _artists = new List<string>
            {
                "Grandaddy",
                "Sufjan Stevens",
                "The Antlers",
                "Smashing Pumpkins"
            };
        }

        public string Home()
        {
            return "You reached the artist page via the ArtistController, the very beginning of MVC. MVC? AC-DC!";
        }

        public string List()
        {
            return "This is an overview of all the known artists. So much goodness bundled in one place!";
        }

        public string Grandaddy()
        {
            return "Sorry. Not sorry!";
        }

        public string ArtistDetails(int index)
        {

            return String.Format("What a great band {0} really is!", _artists[index]);
        }
    }
}
