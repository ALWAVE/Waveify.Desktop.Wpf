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

namespace Waveify.Pages
{
    /// <summary>
    /// Логика взаимодействия для PreparingToLaunchApplication.xaml
    /// </summary>
    public partial class PreparingToLaunchApplication : Page
    {
        readonly DispatcherTimer _dispatcherTimer = new DispatcherTimer();
        public PreparingToLaunchApplication()
        {
            InitializeComponent();
            _dispatcherTimer.Tick += _dispatcherTimer_Tick;
            _dispatcherTimer.Interval = new TimeSpan(0, 0, 2);
            _dispatcherTimer.Start();
        }
        private void _dispatcherTimer_Tick(object sender, EventArgs e)
        {
            MainGrid.Height = 220;
            ProgressBar.Visibility = Visibility.Visible;

            _dispatcherTimer.Tick += _dispatcherTimer_Tick1;
            _dispatcherTimer.Stop();

            _dispatcherTimer.Interval = new TimeSpan(0, 0, 5);
            _dispatcherTimer.Start();
        }
        private void _dispatcherTimer_Tick1(object sender, EventArgs e)
        {
            _dispatcherTimer.Stop();
            if (NavigationService != null)
            {
                NavigationService.RemoveBackEntry(); // Удалить страницу из стека навигации
                NavigationService.Navigate(null); // Или перейти на другую страницу
            }
        }
    }
}
