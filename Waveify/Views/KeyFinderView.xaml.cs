using Microsoft.Win32;
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
using System.IO;
namespace Waveify.Views
{
    /// <summary>
    /// Логика взаимодействия для KeyFinderView.xaml
    /// </summary>
    public partial class KeyFinderView : UserControl
    {
        public KeyFinderView()
        {
            InitializeComponent();
         
        }
          private void BrowseButton_Click(object sender, RoutedEventArgs e)
        {
            var openFileDialog = new OpenFileDialog
            {
                Filter = "Audio Files|*.mp3;*.wav;*.flac;*.aac;*.ogg",
                Multiselect = true // Если вы хотите разрешить выбор нескольких файлов
            };

            if (openFileDialog.ShowDialog() == true)
            {
                foreach (var file in openFileDialog.FileNames)
                {
                    AnalyzeMusic(file);
                }
            }
        }

        private void Border_Drop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                foreach (var file in files)
                {
                    AnalyzeMusic(file);
                }
            }
        }

        private void Border_DragOver(object sender, DragEventArgs e)
        {
            e.Effects = DragDropEffects.Copy; // Указываем, что файл можно перетащить
            e.Handled = true;
        }

        private void AnalyzeMusic(string filePath)
        {
            // Здесь вы можете добавить логику анализа музыки
            MessageBox.Show($"Analyzing {System.IO.Path.GetFileName(filePath)}");
        }
    }
}
