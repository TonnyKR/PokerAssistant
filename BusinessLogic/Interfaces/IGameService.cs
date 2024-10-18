using BusinessLogic.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Interfaces
{
    public interface IGameService
    {
        Player AddPlayer(string name);
        void CreateGame(int smallBlind = 10, int bigBlind = 20);
        List<Player> GetPlayers();
    }
}
