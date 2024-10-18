using BusinessLogic.Entity;
using BusinessLogic.Interfaces;
using BusinessLogic.Services;

namespace PokerAssistant
{
    public partial class MainPage : ContentPage
    {

        private readonly IGameService gameService;
        private readonly Table4Players table;
        private readonly Grid grid;

        public MainPage(IGameService gameService, Table4Players table, Grid grid) {
            InitializeComponent();
            this.gameService = gameService;
            this.gameService.CreateGame();
            this.table = table;
            this.grid = grid;
        }

        private void AddPlayerName(object sender, EventArgs e)
        {
            gameService.AddPlayer(NameField.Text);
            NameField.Text = "";

            //SemanticScreenReader.Announce(But.Text);
        }
        private void StartGame(object sender, EventArgs e)
        {
            List<Player> plyrs = gameService.GetPlayers();
            if (plyrs.Count() != 0)
            {
                table.WritePlayersNames(gameService.GetPlayers());
                Navigation.PushAsync(table);
            }
            
        }
        private void ShowGrid(object sender, EventArgs e)
        {
            Navigation.PushAsync(grid);
        }
    }

}
