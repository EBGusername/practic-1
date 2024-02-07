using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xaml;

namespace practic_1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Random random = new Random();
        Button[] buttons;
        Button[][] proverka = new Button[8][];
        public MainWindow()
        {
            InitializeComponent();
            buttons = new Button[9] { button1, button2, button3, button4, button5, button6, button7, button8, button9 };
            proverka[0] = new Button[] { button1, button4, button2 };
            proverka[1] = new Button[] { button1, button3, button7 };
            proverka[2] = new Button[] { button1, button6, button8 };
            proverka[3] = new Button[] { button3, button4, button9 };
            proverka[4] = new Button[] { button7, button5, button2 };
            proverka[5] = new Button[] { button6, button4, button5 };
            proverka[6] = new Button[] { button8, button9, button2 };
            proverka[7] = new Button[] { button8, button4, button7 };
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (button.Content.ToString() == "Start Game")
            {
                foreach (var item in buttons)
                {
                    item.IsEnabled = true;
                }
                button.Content = "Game Stop/Over";
                text.Text = "PleyerX";
            }
            else if (button.Content.ToString() == "Game Stop/Over")
            {
                foreach (var item in buttons)
                {
                    item.IsEnabled = false;
                }
                var result = MessageBox.Show("Начать заново?", "Игра окончена!", MessageBoxButton.OK);
                if (result == MessageBoxResult.OK)
                {
                    foreach (var item in buttons)
                    {
                        item.Content = "";
                        button.Content = "New Game";
                    }
                }
            }
            else if(button.Content.ToString() == "New Game")
            {
                //string m = "PleyerO";
                //MessageBox.Show(m);
                //if (m == " You PleyerO")
                //{
                //    
                //}
                bool isFirstMovePlayerO = false;

                if (!isFirstMovePlayerO)
                {
                    int randomIndex = random.Next(0, 9); 

                    isFirstMovePlayerO = true;
                }
                text.Text = "PleyerO";
                foreach (var item in buttons)
                {
                    item.Content = "";
                    item.IsEnabled = true;
                }
            }
        }

        private void button8_Click(object sender, RoutedEventArgs e)
        {
            if (text.Text == "PleyerX")
            {
                (sender as Button).Content = "X";
                text.Text = "PleyerO";
            }
            else
            {
                (sender as Button).Content = "O";
                text.Text = "PleyerX";
            }
            (sender as Button).IsEnabled = false;

            int klic = random.Next(0, 9);

            if (buttons.All(x => x.IsEnabled == false))
            {

            }
            else
            {
                while (buttons[klic].IsEnabled == false)
                    klic = random.Next(0, 9);
                if (text.Text == "PleyerX")
                {
                    buttons[klic].Content = "X";
                    buttons[klic].IsEnabled = false;
                    text.Text = "PleyerO";
                }
                else
                {
                    buttons[klic].IsEnabled = false;
                    text.Text = "PleyerX";
                    buttons[klic].Content = "O";
                }
            }

            if (proverka[0].All(x => x.Content == "X") || proverka[0].All(x => x.Content == "O"))
            {
                MessageBox.Show($"Winner {proverka[0][0].Content}");
                foreach (var item in buttons)
                {
                    item.IsEnabled = false;
                }
            }
            else if (proverka[1].All(x => x.Content == "X") || proverka[1].All(x => x.Content == "O" ))
            {
                MessageBox.Show($"Winner {proverka[1][0].Content}");
                foreach (var item in buttons)
                {
                    item.IsEnabled = false;
                }
            }
            else if (proverka[2].All(x => x.Content == "X") || proverka[2].All(x => x.Content == "O"))
            {
                MessageBox.Show($"Winner {proverka[2][0].Content}");
                foreach (var item in buttons)
                {
                    item.IsEnabled = false;
                }
            }
            else if (proverka[3].All(x => x.Content == "X") || proverka[3].All(x => x.Content == "O"))
            {
                MessageBox.Show($"Winner {proverka[3][0].Content}"); foreach (var item in buttons)
                {
                    item.IsEnabled = false;
                }
            }
            else if (proverka[4].All(x => x.Content == "X") || proverka[4].All(x => x.Content == "O"))
            {
                MessageBox.Show($"Winner {proverka[4][0].Content}");
                foreach (var item in buttons)
                {
                    item.IsEnabled = false;
                }
            }
            else if (proverka[5].All(x => x.Content == "X") || proverka[5].All(x => x.Content == "O"))
            {
                MessageBox.Show($"Winner {proverka[5][0].Content}");
                foreach (var item in buttons)
                {
                    item.IsEnabled = false;
                }
            }
            else if (proverka[6].All(x => x.Content == "X") || proverka[6].All(x => x.Content == "O"))
            {
                MessageBox.Show($"Winner {proverka[6][0].Content}");
                foreach (var item in buttons)
                {
                    item.IsEnabled = false;
                }
            }
            else if (proverka[7].All(x => x.Content == "X") || proverka[7].All(x => x.Content == "O"))
            {
                MessageBox.Show($"Winner {proverka[7][0].Content}");
                foreach (var item in buttons)
                {
                    item.IsEnabled = false;
                }
            }
            else if (!buttons.Any(x => x.IsEnabled))
            {
                MessageBox.Show("Ничья! Нет победителя.");
            }
        }
    }
} 