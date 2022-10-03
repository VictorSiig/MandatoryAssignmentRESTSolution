using MandatoryAssignmentClassLibrary;

namespace MandatoryAssignmentREST.Managers {
    public class FootballPlayersManager {

        private static int _nextId = 1;

        private static readonly List<FootballPlayer> Data = new List<FootballPlayer>() {
            new FootballPlayer(_nextId,"Victor Siig", 24, 10),
            new FootballPlayer(_nextId,"Peter Schmeichel", 20, 1),
            new FootballPlayer(_nextId,"Michael Laudrup", 30, 4),
            new FootballPlayer(_nextId,"Erling Haaland", 29, 45),
        };

        public IEnumerable<FootballPlayer> GetAll(int? amount) {
            return new List<FootballPlayer>(Data).Take((int)amount);
        }

        public FootballPlayer GetById(int id) {
            return Data.Find(Ipa => Ipa.Id == id);
        }

        public FootballPlayer Add(FootballPlayer newPlayer) {
            newPlayer.Id = _nextId++;
            Data.Add(newPlayer);
            return newPlayer;
        }

        public FootballPlayer Delete(int id) {
            FootballPlayer footballPlayer = Data.Find(footballPlayer1 => footballPlayer1.Id == id);
            if (footballPlayer == null) return null;
            Data.Remove(footballPlayer);
            return footballPlayer;
        }

        public FootballPlayer Update(int id, FootballPlayer updates) {
            FootballPlayer footballPlayer = Data.Find(ipa1 => ipa1.Id == id);
            if (footballPlayer == null) return null;
            footballPlayer.Name = updates.Name;
            footballPlayer.Age = updates.Age;
            footballPlayer.ShirtNumber = updates.ShirtNumber;
            return footballPlayer;
        }

    }
}
