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

namespace MadlibGUI
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

        private void Noun1Button_Click(object sender, RoutedEventArgs e)
        {
            MadlibItem noun1 = new MadlibItem();
            noun1.Noun = Noun1.Text;
        }

        private void Noun2Button_Click(object sender, RoutedEventArgs e)
        {
            MadlibItem noun2 = new MadlibItem();
            noun2.Noun = Noun2.Text;
        }

        private void Noun3Button_Click(object sender, RoutedEventArgs e)
        {
            MadlibItem noun3 = new MadlibItem();
            noun3.Noun = Noun3.Text;
        }

        private void Adjective1Button_Click(object sender, RoutedEventArgs e)
        {
            MadlibItem adjective1 = new MadlibItem();
            adjective1.Adjective = Adjective1.Text;
        }

        private void Adjective2Button_Click(object sender, RoutedEventArgs e)
        {
            MadlibItem adjective2 = new MadlibItem();
            adjective2.Adjective = Adjective2.Text;
        }

        private void Adjective3Button_Click(object sender, RoutedEventArgs e)
        {
            MadlibItem adjective3 = new MadlibItem();
            adjective3.Adjective = Adjective3.Text;
        }

        private void Adjective4Button_Click(object sender, RoutedEventArgs e)
        {
            MadlibItem adjective4 = new MadlibItem();
            adjective4.Adjective = Adjective4.Text;
        }

        private void Occupation1Button_Click(object sender, RoutedEventArgs e)
        {
            MadlibItem occupation1 = new MadlibItem();
            occupation1.Occupation = Occupation1.Text;
        }

        private void Occupation2Button_Click(object sender, RoutedEventArgs e)
        {
            MadlibItem occupation2 = new MadlibItem();
            occupation2.Occupation = Occupation2.Text;
        }

        private void Occupation3Button_Click(object sender, RoutedEventArgs e)
        {
            MadlibItem occupation3 = new MadlibItem();
            occupation3.Occupation = Occupation3.Text;
        }

        private void WriteMadlib_Click(object sender, RoutedEventArgs e)
        {
            MadlibCompleted.Text = $"They all agreed that it was a huge {Noun1.Text}, {Adjective1.Text}, {Adjective2.Text}, and {Adjective3.Text}. I have cross-examined these men, one of them a hard-headed {Occupation1.Text}, one a {Occupation2.Text}, and one a moorland {Occupation3.Text}, who all tell the same story of this {Adjective4.Text} {Noun2.Text}, exactly corresponding to the hell-{Noun3.Text} of the legend.";
        }
    }
}
