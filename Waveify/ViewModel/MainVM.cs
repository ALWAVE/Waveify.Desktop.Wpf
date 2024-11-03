using System;
using Windows;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Waveify.Pages;
using Waveify.Store;
using Waveify.ViewModel;
using System.Windows;
using Waveify.Utilities;
using Microsoft.VisualBasic;
using Waveify.Views;



namespace Waveify.ViewModel
{
    public class MainVM : ViewModelBase 
    {
        public string AppTitle { get; } = "Waveify";
        private ViewModelBase? _currentView;

        public ViewModelBase? CurrentView
        {
            get => _currentView;
            set
            {
                
                if (value == _currentView) return;
                _currentView?.Dispose();
                _currentView = value;
                Console.WriteLine("CurrentView изменен на " + value?.GetType().Name);
                OnPropertyChanged();
            }
        }
      


    

        private ViewModelBase? _playerView;
        public ViewModelBase? PlayerView
        {
            get => _playerView;
            set
            {
                if (value == _playerView) return;
                _playerView?.Dispose();
                _playerView = value;
                OnPropertyChanged();
            }
        }

        private ViewModelBase? _toolbarView;
        public ViewModelBase? ToolbarView
        {
            get => _toolbarView;
            set
            {
                if (value == _toolbarView) return;
                _toolbarView?.Dispose();
                _toolbarView = value;
                OnPropertyChanged();
            }
        }

        private ViewModelBase? _modalView;
        public ViewModelBase? ModalView
        {
            get => _modalView;
            set
            {
                if (value == _modalView) return;
                _modalView?.Dispose();
                _modalView = value;
                OnPropertyChanged();
            }
        }

        public MainVM(HomeVM homeView, PlayerVM playerView, ToolbarVM toolbarView)
        {
          
            CurrentView = homeView;
            PlayerView = playerView;
            ToolbarView = toolbarView;
        }
    }
}