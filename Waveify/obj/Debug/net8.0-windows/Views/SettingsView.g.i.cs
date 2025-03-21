﻿#pragma checksum "..\..\..\..\Views\SettingsView.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5042F0EB53B60A401349E3F088B97DFF5E664690"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using SharpVectors.Converters;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;
using Waveify.CustomControls;
using Waveify.Enums;
using Waveify.Extentsions;
using Waveify.Utilities;
using Waveify.ViewModel;
using Waveify.Views;


namespace Waveify.Views {
    
    
    /// <summary>
    /// SettingsView
    /// </summary>
    public partial class SettingsView : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 41 "..\..\..\..\Views\SettingsView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ChangeThemes;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\..\Views\SettingsView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ExclusiveTheme;
        
        #line default
        #line hidden
        
        
        #line 123 "..\..\..\..\Views\SettingsView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider LowFreqSlider;
        
        #line default
        #line hidden
        
        
        #line 126 "..\..\..\..\Views\SettingsView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider MidFreqSlider;
        
        #line default
        #line hidden
        
        
        #line 129 "..\..\..\..\Views\SettingsView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider HighFreqSlider;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.5.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Waveify;component/views/settingsview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Views\SettingsView.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.5.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.ChangeThemes = ((System.Windows.Controls.Button)(target));
            
            #line 41 "..\..\..\..\Views\SettingsView.xaml"
            this.ChangeThemes.Click += new System.Windows.RoutedEventHandler(this.ChangeTheme_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.ExclusiveTheme = ((System.Windows.Controls.Button)(target));
            
            #line 47 "..\..\..\..\Views\SettingsView.xaml"
            this.ExclusiveTheme.Click += new System.Windows.RoutedEventHandler(this.ExclusiveTheme_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.LowFreqSlider = ((System.Windows.Controls.Slider)(target));
            return;
            case 4:
            this.MidFreqSlider = ((System.Windows.Controls.Slider)(target));
            return;
            case 5:
            this.HighFreqSlider = ((System.Windows.Controls.Slider)(target));
            return;
            case 6:
            
            #line 131 "..\..\..\..\Views\SettingsView.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ApplyEq_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

