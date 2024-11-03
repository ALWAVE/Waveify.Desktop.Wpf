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
using Waveify.Utilities;

namespace Waveify.Views
{
    /// <summary>
    /// Логика взаимодействия для SettingsView.xaml
    /// </summary>
    public partial class SettingsView : UserControl
    {
         
        private ThemeService? themeService;
        public SettingsView()
        {
           
            InitializeComponent();
            themeService = new ThemeService();
        }
        private IWavePlayer waveOut;
        private AudioFileReader audioFileReader;
        private EqualizerEffect equalizer;
        private void ApplyEq_Click(object sender, RoutedEventArgs e)
        {
            // Получаем значения слайдеров
            //float lowGain = (float)LowFreqSlider.Value;
            //float midGain = (float)MidFreqSlider.Value;
            //float highGain = (float)HighFreqSlider.Value;

            if (audioFileReader != null)
            {
                // Останавливаем текущий поток
                waveOut.Stop();

                // Переназначаем эквалайзер с новыми параметрами
                var sampleProvider = audioFileReader.ToSampleProvider();
                //equalizer = new EqualizerEffect(sampleProvider, lowGain, midGain, highGain);

                // Заново инициализируем воспроизведение
                waveOut.Init(equalizer);
                waveOut.Play();
            }
        }
        private void ChangeTheme_Click(object sender, RoutedEventArgs e)
        {
            themeService?.ApplyTheme(themeService.CurrentTheme == ThemeType.Light ? ThemeType.Dark : ThemeType.Light);
        }

        private void ExclusiveTheme_Click(object sender, RoutedEventArgs e)
        {
            themeService?.ApplyTheme(ThemeType.Premium);
        }


    }
}
