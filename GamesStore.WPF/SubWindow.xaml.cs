using Services.Classes;
using Services.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace GamesStore.WPF
{
    /// <summary>
    /// Interaction logic for SubWindow.xaml
    /// </summary>
    public partial class SubWindow : Window
    {
        private GameService _gameService;
        public SubWindow(GameService gameService)
        {
            InitializeComponent();
            _gameService = gameService;
        }
        private void SaveButtonClick(object sender, RoutedEventArgs e)
        {
            _gameService.Create(new GameDto
            {
                Title = Title.Text,
                Genre = Genre.Text,
                Price = int.Parse(Price.Text),
                ImageURL = ImageURL.Text,
                Description = Description.Text
            });
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Close();
        }
        private void ExitButtonClick(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Close();
        }
    }
}
