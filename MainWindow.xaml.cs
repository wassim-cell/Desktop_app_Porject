using Paymoi3.Views;
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

namespace Paymoi3
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
        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                DragMove();
        }

        private void StegBtn(object sender, RoutedEventArgs e)
        {
            steg hp = new steg();
            hp.Show();
            this.Close();
        }

        private void CnssBtn(object sender, RoutedEventArgs e)
        {
            cnss hp = new cnss();
            hp.Show();
            this.Close();
        }

        private void SonedeBtn(object sender, RoutedEventArgs e)
        {
            sonede hp = new sonede();
            hp.Show();
            this.Close();
        }

        private void CnrpsBtn(object sender, RoutedEventArgs e)
        {
            cnrps hp = new cnrps();
            hp.Show();
            this.Close();
        }
    }
}
