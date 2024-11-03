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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace Waveify.Toast
{
    /// <summary>
    /// Логика взаимодействия для ToastWindow.xaml
    /// </summary>
    public partial class ToastWindow : Window
    {
        private DispatcherTimer _timer;

        public ToastWindow(string title, string content, int time)
        {
            InitializeComponent();
            TitleText.Text = title;
            ContentText.Text = content;

            this.Left = SystemParameters.WorkArea.Width - this.Width - 10;
            this.Top = SystemParameters.WorkArea.Height - this.Height - 10;

            // Таймер для автоматического закрытия уведомления
            _timer = new DispatcherTimer
            {
                Interval = TimeSpan.FromSeconds(time) // Время отображения уведомления
            };
            _timer.Tick += (sender, args) => StartCloseAnimation();
            _timer.Start();
        }
        private void StartCloseAnimation()
        {
            // Остановить таймер
            _timer.Stop();

            // Запустить анимацию закрытия
            var storyboard = (Storyboard)this.Resources["CloseStoryboard"];
            storyboard.Completed += (s, e) => this.Close();
            storyboard.Begin(this);
        }
        private void ToastWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!_timer.IsEnabled)
            {
                e.Cancel = true;
                StartCloseAnimation();
            }
        }

        private void Ellipse_MouseDown(object sender, MouseButtonEventArgs e)
        {

            StartCloseAnimation();
        }
    }
}
