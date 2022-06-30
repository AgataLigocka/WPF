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

namespace AL_WPF33
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private int _counter = 0;
        private bool _turn = true;
        public void StartGame()
        {
            button00.IsEnabled = true;
            button00.Content = string.Empty;

            button01.IsEnabled = true;
            button01.Content = string.Empty;

            button02.IsEnabled = true;
            button02.Content = string.Empty;

            button10.IsEnabled = true;
            button10.Content = string.Empty;

            button11.IsEnabled = true;
            button11.Content = string.Empty;

            button12.IsEnabled = true;
            button12.Content = string.Empty;

            button20.IsEnabled = true;
            button20.Content = string.Empty;

            button21.IsEnabled = true;
            button21.Content = string.Empty;

            button22.IsEnabled = true;
            button22.Content = string.Empty;

            _counter = 0;
            _turn = true;
            buttonCounter.Content = _counter;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            var button = sender as Button;

            if (button.IsEnabled)
            {
                if (_turn == true) button.Content = "X";
                else button.Content = "O";
                _turn = !_turn;
                _counter++;
                buttonCounter.Content = _counter;
                
                if (_turn == true) buttonTurn.Background = Brushes.Green;
                else buttonTurn.Background = Brushes.Red;
                button.IsEnabled = false;

                if (_counter == 9)
                {
                    MessageBox.Show("Nowa gra!");
                    StartGame();
                }
            }
            else return;
        }

        private void StartGame(object sender, RoutedEventArgs e)
        {
            StartGame();
        }
    }
}
