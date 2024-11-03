using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Waveify;
using Waveify.Model;
namespace Waveify
{
    public class ThemeService
    {
        private static ResourceDictionary _lightTheme;
        private static ResourceDictionary _darkTheme;
        private static ResourceDictionary _premiumTheme;
        public ThemeType CurrentTheme { get; private set; } = ThemeType.Dark; // Начальная тема

        public ThemeService()
        {
            _lightTheme = Application.LoadComponent(new Uri("Themes/Light.xaml", UriKind.Relative)) as ResourceDictionary;
            _darkTheme = Application.LoadComponent(new Uri("Themes/Dark.xaml", UriKind.Relative)) as ResourceDictionary;
            _premiumTheme = Application.LoadComponent(new Uri("Themes/Premium.xaml", UriKind.Relative)) as ResourceDictionary;
        }

        public void ApplyTheme(ThemeType themeType)
        {
            // Меняем тему
            if (themeType == ThemeType.Light)
            {
                Application.Current.Resources.MergedDictionaries.Clear();
                Application.Current.Resources.MergedDictionaries.Add(_lightTheme);
            }
            else if (themeType == ThemeType.Dark) { 
            
                Application.Current.Resources.MergedDictionaries.Clear();
                Application.Current.Resources.MergedDictionaries.Add(_darkTheme);
            }
            else if (themeType == ThemeType.Premium)
            {

                Application.Current.Resources.MergedDictionaries.Clear();
                Application.Current.Resources.MergedDictionaries.Add(_premiumTheme);
            }
            // Обновляем CurrentTheme после смены темы
            CurrentTheme = themeType; // Важно: обновляем CurrentTheme!
        }
    }
    public enum ThemeType
    {
        Light,
        Dark,
        Premium
    }
}