using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayGroundLibForberedelse
{
    public class PlayGroundsRepository
    {
        private readonly List<PlayGround> _playGrounds; // Liste til PlayGround objekter
        private int _nextId = 1; // Variable til at tildele nye IDs

        // Constructor
        public PlayGroundsRepository()
        {
            _playGrounds = new List<PlayGround>
            {
                new PlayGround { Id = _nextId++, Name = "Millpark", MaxChildren = 10, MinAge = 5 },
                new PlayGround { Id = _nextId++, Name = "Secret Playground", MaxChildren = 12, MinAge = 4 },
                new PlayGround { Id = _nextId++, Name = "Library", MaxChildren = 8, MinAge = 3 },
                new PlayGround { Id = _nextId++, Name = "School", MaxChildren = 15, MinAge = 7 }
            };
        }

        // Returnerer alle PlayGround objekter
        public List<PlayGround> GetAll()
        {
            return _playGrounds;
        }

        // Returnerer et PlayGround objekt med et bestemt ID, ellers null
        public PlayGround GetById(int id)
        {
            return _playGrounds.FirstOrDefault(pg => pg.Id == id);
        }

        // Tilføjer et nyt PlayGround objekt og returnerer det tilføjede objekt
        public PlayGround Add(PlayGround playGr)
        {
            playGr.Id = _nextId++; // Tildel nyt ID og opdater _nextId
            _playGrounds.Add(playGr);
            return playGr;
        }

        // Opdaterer et eksisterende PlayGround objekt med et bestemt ID
        public PlayGround Update(int id, PlayGround updatedPlayGr)
        {
            var existingPlayGr = GetById(id);
            if (existingPlayGr != null)
            {
                existingPlayGr.Name = updatedPlayGr.Name;
                existingPlayGr.MaxChildren = updatedPlayGr.MaxChildren;
                existingPlayGr.MinAge = updatedPlayGr.MinAge;
            }
            return existingPlayGr;
        }

    }
}
