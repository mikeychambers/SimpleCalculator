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
using System.Media;

namespace DrumMachine
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

        private void Kick(object sender, RoutedEventArgs e)
        {
            SoundPlayer player = new SoundPlayer(Properties.Resources.CYCdh_ElecK01_Kick01);
            player.Play();
        }

 

        private void Snare (object sender, RoutedEventArgs e)
        {
            SoundPlayer player = new SoundPlayer(Properties.Resources.CYCdh_ElecK01_Snr02);
            player.Play();
        }
        private void HiHat (object sender, RoutedEventArgs e)
        {
            SoundPlayer player = new SoundPlayer(Properties.Resources.CYCdh_ElecK01_ClHat01);
            player.Play();
        }

        private void Tom1(object sender, RoutedEventArgs e)
        {
            SoundPlayer player = new SoundPlayer(Properties.Resources.CYCdh_ElecK01_Tom01);
            player.Play();
        }

        private void Tom2(object sender, RoutedEventArgs e)
        {
            SoundPlayer player = new SoundPlayer(Properties.Resources.CYCdh_ElecK01_Tom02);
            player.Play();
        }

        private void Tom3(object sender, RoutedEventArgs e)
        {
            SoundPlayer player = new SoundPlayer(Properties.Resources.CYCdh_ElecK01_Tom03);
            player.Play();
        }

        private void Cymbal1(object sender, RoutedEventArgs e)
        {
            SoundPlayer player = new SoundPlayer(Properties.Resources.CYCdh_ElecK01_OpHat02);
            player.Play();
        }

        private void Cymbal2(object sender, RoutedEventArgs e)
        {
            SoundPlayer player = new SoundPlayer(Properties.Resources.CYCdh_ElecK01_Cymbal);
            player.Play();
        }


    }
}
