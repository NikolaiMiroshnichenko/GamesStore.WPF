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
        private GameService _gameService;
        public MainWindow()
        {
            InitializeComponent();
            var gamesStoreContext = new GamesStoreContext();

            var gameRepository = new Repository<Game>(gamesStoreContext);
            _gameService = new GameService(gameRepository);
            var list = _gameService.GetAll();
            GamesListView.ItemsSource = list;
        }
        private void AddGameClick(object sender, RoutedEventArgs e)
        {
            SubWindow subWindow = new SubWindow(_gameService);
            subWindow.Show();
            Close();
        }
        private void ExitClick(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
