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
using System.Windows.Threading;

namespace WpfApp4
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var s = textBox1.Text;
                var z = textBox.Text;
                int dlugosc = Convert.ToInt32(s);
                int wysokosc = Convert.ToInt32(z);
            
            

            for (int i=0; i < dlugosc; i++)
            {
                for (int j = 0; j < wysokosc; j++)
                {
                    Rectangle plansza = new Rectangle();

                    plansza.Width = obszarGry.ActualWidth / dlugosc - 2.0;
                    plansza.Height = obszarGry.ActualHeight / wysokosc - 2.0;
                    plansza.Fill = Brushes.Red;
                      obszarGry.Children.Add(plansza);
                    Canvas.SetLeft(plansza, j * obszarGry.ActualWidth / wysokosc);
                    Canvas.SetTop(plansza, i * obszarGry.ActualHeight / dlugosc);

                        textBox.Clear();
                        textBox1.Clear();


                    }
            }
            }
            catch (FormatException)
            {
                MessageBox.Show("Musisz wpisac Liczby !!!");

            }

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
