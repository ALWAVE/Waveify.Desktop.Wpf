using NAudio.Wave;
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
using Waveify.ViewModel;
using Microsoft.Win32;
using Waveify.Store;
using Waveify.Utilities;
using Microsoft.EntityFrameworkCore;
using Waveify.Views;
using Waveify.CustomControls;
using Microsoft.Extensions.DependencyInjection;


namespace Waveify.Pages
{
    /// <summary>
    /// Логика взаимодействия для MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        private ThemeService? themeService;
        private readonly IServiceProvider _serviceProvider;

        private IWavePlayer? waveOut;
        private AudioFileReader? audioFileReader;
        public MainPage(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            //MainFrame.Content = new pages.HomePage();
            themeService = new ThemeService();

            _serviceProvider = serviceProvider;


        }

       

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //MainFrame.Content = new pages.HomePage();
        }

        private void SearchBtn_Click(object sender, RoutedEventArgs e)
        {
            //MainFrame.Content = new pages.SearchPage();
        }
       
        private void MyFileBtn_Click(object sender, RoutedEventArgs e)
        {
            //MainFrame.Content = new Pages.MyFilePage();
        }
        private void PlaylistBtn_Click(object sender, RoutedEventArgs e)
        {
            //MainFrame.Content = new pages.PlaylistPage();
        }
        private void ChangeTheme_Click(object sender, RoutedEventArgs e)
        {
            themeService?.ApplyTheme(themeService.CurrentTheme == ThemeType.Light ? ThemeType.Dark : ThemeType.Light);
        }

        private void Button_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void btnPlay_Click(object sender, RoutedEventArgs e)
        {
            //if (lstSongs.SelectedItem != null)
            //{
            //    string selectedSong = lstSongs.SelectedItem.ToString();
            //    PlaySong(selectedSong);
            //}
        }

        private void btnStop_Click(object sender, RoutedEventArgs e)
        {
            waveOut?.Stop();
        }

   

        private void PlaySong(string filePath)
        {
            waveOut?.Stop();
            audioFileReader = new AudioFileReader(filePath);
            waveOut = new WaveOutEvent();
            waveOut.Init(audioFileReader);
            waveOut.Play();
        }

      
    }
}
