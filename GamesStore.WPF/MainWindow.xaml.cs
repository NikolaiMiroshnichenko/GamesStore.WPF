using GamesStore.DAL;
using GamesStore.DAL.Entities;
using GamesStore.DAL.Repositories;
using Services.Classes;
using Services.Dto;
using System.Windows;

namespace GamesStore.WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var gamesStoreContext = new GamesStoreContext();

            var gameRepository = new Repository<Game>(gamesStoreContext);
            var gameService = new GameService(gameRepository);
            var list = gameService.GetAll();
            GamesListView.ItemsSource = list;

        }
    }
}
