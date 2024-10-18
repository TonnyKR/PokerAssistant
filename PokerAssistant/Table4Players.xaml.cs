using BusinessLogic.Entity;
using BusinessLogic.Interfaces;

namespace PokerAssistant;

public partial class Table4Players : ContentPage
{
    private readonly IGameService gameService;

    public Table4Players(IGameService gameService)
	{
        InitializeComponent();
        this.gameService = gameService;
    }


    public void WritePlayersNames(List<Player> players)
    {
        //to-do добавить проверку
        string[] plyrs = players.Select(n => n.Name).ToArray();
        Player1.Text = plyrs[0];
        Player2.Text = plyrs[1];
        Player3.Text = plyrs[2];
        Player4.Text = plyrs[3];
    }
}