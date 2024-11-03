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

namespace Waveify.CustomControls
{
    /// <summary>
    /// Логика взаимодействия для ToolbarControl.xaml
    /// </summary>
    public partial class ToolbarControl : UserControl
    {

        private ThemeService? themeService;


        private IWavePlayer? waveOut;
    
        public ToolbarControl()
        {
            InitializeComponent();
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

        private void OnDeletePlaylistClicked(object sender, RoutedEventArgs e)
        {
          
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }
    }
}
