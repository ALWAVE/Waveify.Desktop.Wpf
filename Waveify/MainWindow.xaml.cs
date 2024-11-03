using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Waveify.Pages;
using Microsoft.Toolkit.Uwp.Notifications; // Библиотека для создания уведомлений
using Waveify.Toast;
using System;
using NAudio.Wave;
using Waveify.Utilities;
using Microsoft.Win32;
using System.Security.Principal;
using System.Windows.Threading;
using MaterialDesignThemes.Wpf;
using Waveify.ViewModel;
using Waveify.CustomControls;
namespace Waveify
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ThemeService? themeService;
        private bool isDocked = false; // NEW
        public MainWindow()
        {
            InitializeComponent();
          
            themeService?.ApplyTheme(ThemeType.Dark);
            this.StateChanged += MainWindow_StateChanged; //NEW
         
            var userProfile = new List<SubItemVM>();
            //userProfile.Add(new SubItemVM("Customer"));
            //userProfile.Add(new SubItemVM("Providers"));
            //userProfile.Add(new SubItemVM("Employees"));
            //userProfile.Add(new SubItemVM("Products"));
            //var profile = new ItemUserProfileVM("YourNick", userProfile, PackIconKind.Register);
            //Menu.Children.Add(new UserProfileControl(profile));
           
        }
        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }
        private void MainWindow_StateChanged(object sender, EventArgs e) //NEW
        {
            if (this.WindowState == WindowState.Maximized)
            {
                isDocked = true;
            }
            else if (this.WindowState == WindowState.Normal)
            {
                isDocked = false;
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            this.Left = (SystemParameters.PrimaryScreenWidth - this.Width) / 2;
            this.Top = (SystemParameters.PrimaryScreenHeight - this.Height) / 2;
        }
        private void ExitApplication(object sender, MouseButtonEventArgs e)
        {
            Application.Current.Shutdown();
          
        }
        async Task DelayExample()
        {
            // Подождать 3 секунды
            await Task.Delay(400);

            // Ваш код после задержки
        }



        public void ShowCustomToastNotification(string title, string content, int time)
        {
            Application.Current.Dispatcher.Invoke(() =>
            {
                var toast = new ToastWindow(title, content, time);
                toast.Show();
            });

        }
      
        private async void MinimizeWindow(object sender, MouseButtonEventArgs e)
        {
            // Создание анимации
            DoubleAnimation animation = new DoubleAnimation();
            animation.From = 1; // Начальное значение (полный размер окна)
            animation.To = 0;   // Конечное значение (сворачивание до нуля)
            animation.Duration = TimeSpan.FromSeconds(0.3); // Продолжительность анимации

            // Привязка анимации к свойству Opacity окна
            this.BeginAnimation(UIElement.OpacityProperty, animation);

            // Свернуть окно на панель задач
            await DelayExample();
            this.WindowState = WindowState.Minimized;
            DoubleAnimation restoreAnimation = new DoubleAnimation();
            restoreAnimation.From = 0; // Начальное значение (прозрачное)
            restoreAnimation.To = 1;   // Конечное значение (полное)
            restoreAnimation.Duration = TimeSpan.FromSeconds(0.3); // Продолжительность анимации

            // Привязка анимации к свойству Opacity окна для восстановления
            this.BeginAnimation(UIElement.OpacityProperty, restoreAnimation);
            ShowCustomToastNotification("Не забудьте вернуться!", "Ваше приложение ожидает вас.", 10);
           
        }
        private void RestoreWindow()
        {
            // Отмена анимации прозрачности
            this.BeginAnimation(UIElement.OpacityProperty, null);

            // Восстановление размеров окна и его видимость
            this.WindowState = WindowState.Normal;
            this.Visibility = Visibility.Visible;

            // Активация окна
            this.Activate();
           
        }
        private void OpenApp(object sender, MouseButtonEventArgs e)
        {
            // Логика для открытия приложения
            // Например, если приложение свернуто на панель задач,
            // вызови метод RestoreWindow для его восстановления
            
            RestoreWindow();
          
        }
        private void MaximizeWindow(object sender, MouseButtonEventArgs e)
        {
            var window = Application.Current.MainWindow;
            // Запомните начальные размеры
            var startWidth = window.ActualWidth;
            var startHeight = window.ActualHeight;

            // Установите конечные размеры
            window.Width = 1600;
            window.Height = 900;

            // Создайте анимации
            var widthAnimation = new DoubleAnimation(startWidth, 1600, TimeSpan.FromSeconds(0.3));
            var heightAnimation = new DoubleAnimation(startHeight, 900, TimeSpan.FromSeconds(0.3));

            // Запустите анимации
            window.BeginAnimation(Window.WidthProperty, widthAnimation);
            window.BeginAnimation(Window.HeightProperty, heightAnimation);

            if (isDocked)
            {
                window.WindowState = WindowState.Normal;
                window.Width = 800;
                window.Height = 600;
                isDocked = false;
            }

        }
        private void RightResizeThumb_DragDelta(object sender, DragDeltaEventArgs e)
        {
            var thumb = (Thumb)sender;
            var border = (Border)thumb.Parent;
            var deltaX = e.HorizontalChange;

            // Устанавливаем новую ширину правого края Border
            border.Width += deltaX;
        }




    }
}