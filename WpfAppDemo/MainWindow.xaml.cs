using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Media;


namespace WpfAppDemo
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

        private void Knapp_Click(object sender, RoutedEventArgs e)
        {
            TextEtt.Text = Input.Text;
        }

        private void KnappStor_Click(object sender, RoutedEventArgs e)
        {
            TextEtt.FontSize += 10;
        }

        private void KnappLiten_Click(object sender, RoutedEventArgs e)
        {
            TextEtt.FontSize -= 10;

        }

        private void KnappKul_Click(object sender, RoutedEventArgs e)
        {
            TextEtt.FontFamily = new FontFamily("Comic Sans MS");
        }

        private void KnappTraakig_Click(object sender, RoutedEventArgs e)
        {
            TextEtt.FontFamily = new FontFamily("Consolas");
        }
    }
}
