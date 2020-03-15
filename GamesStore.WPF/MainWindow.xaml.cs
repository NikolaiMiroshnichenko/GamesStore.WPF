using GamesStore.DAL;
using GamesStore.DAL.Entities;
using GamesStore.DAL.Repositories;
using Services.Classes;
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
            var developerRepository = new Repository<Developer>(gamesStoreContext);

            var gameService = new GameService(gameRepository);
            var developerService = new DeveloperService(developerRepository);

            var developer = new Developer
            {
                Name = "Pandesda",
                YearOfFoundation = 1998,
                Description = "Some descr."
            };
            developerService.Create(developer);
            gameService.Create(new Game
             {
                 Developer = developer,
                 Description = "Best shooter with panddas",
                 Genre = "Shooter",
                 Price = 20,
                 Title = "PanDoom"
             });

            var someGame = gameService.GetByCondition((x => x.Price == 20));
        }
    }
}
