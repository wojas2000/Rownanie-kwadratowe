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

namespace Równanie_kwadratowe
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        float a, b, c, delta;
        //double x1, x2;

        private void Wsp_c_changed(object sender, TextChangedEventArgs e)
        {
            
        }

        private void Oblicz_Delta_Click(object sender, RoutedEventArgs e)
        {
            if (Wsp_b.Text.Length < 1)
            {
                MessageBox.Show("Brak wsp. b. Podaj liczbę.");
            }
            else
            {
                try
                {
                    b = float.Parse(Wsp_b.Text);
                }
                catch
                {
                    MessageBox.Show("Nieprawidłowe znaki");
                }
            }

            if (Wsp_c.Text.Length < 1)
            {
                MessageBox.Show("Brak wsp. c. Podaj liczbę.");
            }
            else
            {
                try
                {
                    c = float.Parse(Wsp_c.Text);
                }
                catch
                {
                    MessageBox.Show("Nieprawidłowe znaki");
                }
            }

            if (Wsp_a.Text.Length < 1)
            {
                MessageBox.Show("Brak wsp. a. Podaj liczbę.");
            }
            else
            {
                try
                {
                    a = float.Parse(Wsp_a.Text);

                }
                catch
                {
                    MessageBox.Show("Nieprawidłowe znaki");
                }
            }
            delta = (b * b) - (4 * a * c);
            if (delta < 0)
            {
                Wynik_delta.Content = "Równanie nie ma rozw. delta < 0";
            }
            else 
            {
                Wynik_delta.Content = "Delta jest równa: " + delta;
            }            
        }

        private void Delta_Text_Show(object sender, TextCompositionEventArgs e)
        {         
                        
        }

        private void x1_x2_Text_Show(object sender, TextCompositionEventArgs e)
        {

        }

        private void Oblicz_x1_x2_Click(object sender, RoutedEventArgs e)
        {            
            double wyn_x1 = (- b - (double)Math.Sqrt(delta)) / (2 * a);
            double wyn_x2 = (- b + (double)Math.Sqrt(delta)) / (2 * a);
            Wynik_x1_x2.Content = "Równanie kwadratowe jest równe: " + wyn_x1 + wyn_x2;
        }

        private void Wsp_b_changed(object sender, TextChangedEventArgs e)
        {            
           
        }

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Wsp_a_changed(object sender, TextChangedEventArgs e)
        {            
            
        }
    }
}
