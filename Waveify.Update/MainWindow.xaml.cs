using System.Diagnostics;
using System.Text;
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
using System.IO;

namespace Waveify.Update
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            _dispatcherTimer.Tick += _dispatcherTimer_Tick;
            _dispatcherTimer.Interval = new TimeSpan(0, 0, 2);
            _dispatcherTimer.Start();
        }
        readonly DispatcherTimer _dispatcherTimer = new DispatcherTimer();
     
        private void _dispatcherTimer_Tick(object sender, EventArgs e)
        {
            //MainGrid.Height = 220;
            ProgressBar.Visibility = Visibility.Visible;

            _dispatcherTimer.Tick += _dispatcherTimer_Tick1;
            _dispatcherTimer.Stop();

            _dispatcherTimer.Interval = new TimeSpan(0, 0, 5);
            _dispatcherTimer.Start();
        }
        private async void LaunchMainApplication()
        {
          
            string mainAppPath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"D:\ProjectVS\Waveify\Waveify\bin\Debug\net8.0-windows\Waveify.exe");

            if (System.IO.File.Exists(mainAppPath))
            {
                try
                {
                    await Task.Run(() => Process.Start(mainAppPath));
                    Application.Current.Shutdown(); // Закрыть обновляющее приложение, если нужно
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при запуске основного приложения: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Файл Waveify.exe не найден.");
            }
        }
        private void _dispatcherTimer_Tick1(object sender, EventArgs e)
        {
            _dispatcherTimer.Stop();
            // Запуск основного приложения
            LaunchMainApplication();
            // Закрытие приложения обновления
          
        }
       
        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }
        private void ExitApplication(object sender, MouseButtonEventArgs e)
        {
           Application.Current.Shutdown();
        }
    }
}