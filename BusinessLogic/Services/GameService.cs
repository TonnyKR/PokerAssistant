using BusinessLogic.Entity;
using BusinessLogic.Interfaces;

namespace BusinessLogic.Services
{
    public class GameService : IGameService
    {
        private List<Player> players = new List<Player>();
        private int turn = 0;
        private double bigBlind;
        private double smallBlind;

        private int dealer = 0;
        private List<Round> rounds = new List<Round>() { new Round("Pre-Flop"), new Round("Flop"), new Round("Turn"), new Round("River") };
        private int currentRound = 0;


        public void CreateGame(int smallBlind = 10, int bigBlind = 20)
        {
            this.bigBlind = bigBlind;
            this.smallBlind = smallBlind;
            this.dealer = 0;
            this.turn = 0;
            this.currentRound = 0;
        }

        public Player AddPlayer(string name)
        {
            var player = new Player(name);
            players.Add(player);
            return player;
        }

        public List<Player> GetPlayers()
        {
            return players;
        }

        //public GameInfo GetGameInfo()
        //{
        //    //return new GameInfo();
        //}

        //public void SelectCountOfPlayer(int countPlayer)
        //{
        //    players = new List<Player>(countPlayer);
        //    throw new NotImplementedException();
        //}

        //List<string> IGameService.GetPlayerNames()
        //{
        //    throw new NotImplementedException();
        //}
    }
}
