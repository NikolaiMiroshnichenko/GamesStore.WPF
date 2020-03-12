using GamesStore.DAL;
using GamesStore.DAL.Entities;
using GamesStore.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

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
            GamesStoreContext gamesStoreContext = new GamesStoreContext();
            
            List<Game> games = new List<Game>();
            Developer developer = new Developer
            {
                Discription = "Some discr",
                Games = games,
                Name = "Blizzard",
                YearOfFoundation = 1996
            };
            Game game1 = new Game
            {
                Developer = developer,
                Discription = "The best MMO with pandas for you",
                Title = "World of PandaCraft",
                Genre = "MMO",
                Price = 20
            };
            games.Add(game1);
            Game game2 = new Game
            {
                Id = 1,
                Developer = developer,
                Discription = "The bestt MMO with pandas for you with new addons",
                Title = "World of PandaCraft",
                Genre = "MMO",
                Price = 30
            };

            Repository<Game> repository = new Repository<Game>(gamesStoreContext);
            repository.Create(game1);
            IEnumerable<Game> list = repository.GetAll();
            //repository.Update(game2);
            //repository.Delete(3);
            repository.SaveChanges();
        }
    }
}
