   M S B A M L   `   `   `  ����B  >Waveify, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:Waveify.ViewModelWaveify.ViewModel  5   	   5clr-namespace:Waveify.UtilitiesWaveify.Utilities  5   	   ?$clr-namespace:Waveify.CustomControlsWaveify.CustomControls  5	   	   5clr-namespace:Waveify.ViewModelWaveify.ViewModel  5
   	   -clr-namespace:Waveify.ViewsWaveify.Views  5   	   !clr-namespace:WaveifyWaveify  5   	   7 clr-namespace:Waveify.ConvertersWaveify.Converters  5   	       Waveify.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   _ [MaterialDesignThemes.Wpf, Version=5.1.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .vmclr-namespace:Waveify.ViewModel     5   	   0menuclr-namespace:Waveify.Utilities     5   	   8control$clr-namespace:Waveify.CustomControls     5	   	   6
viewModelsclr-namespace:Waveify.ViewModel     5
   	   -viewsclr-namespace:Waveify.Views     5   	   'localclr-namespace:Waveify     5   	   7
converters clr-namespace:Waveify.Converters     5   	   -   5          � Topmost$  False��5   	    � WindowStartupLocation$ CenterScreen=�5   	    � WindowStyle$
 None=�6.   
������  � AllowsTransparency$
 True��5   	    � 
ResizeMode$ CanResizeWithGrip=�5   	   $	��600��6(   $	��900��68    � Title$ Waveify��5   	   $	��900��6   $
��1600��6&    � Icon$  /Waveify_Default_Small.png��63    � 	Resources 5      5   /Waveify.Converters.BooleanToVisibilityConverter    BooleanToVisibilityConverter��%   &	          5   
   62   5       J� Effect 5      -  'System.Windows.Media.Effects.BlurEffect  5   
   -   5        
BlurEffect��	   Radius$	 0Q�5   )   .��5      �� -   5        
 �� CornerRadius$
 25��5        SideBar#���  6<   ._�5$   
   �  � ColumnDefinitions 5&      �� 5'      $��250px �6#   $��150px��5(      $��300px��5)      �� 5*      $��* �6#    � RowDefinitions 5-      �� 5.      $��* �6    �� 5/      $
��90px �6    .+�53       � -   5          �Name$ MainFrameLoaded��56      $��3��54      $��3��55        � NavigationUIVisibility$ Hidden=�57       K� ZIndex$ 1��59      �� 5<      $
 20��6   $��
5 15 15 15q�6'   $��0��6;   $��1��6H   ._�5=      �� ��6!   �� *CurrentView+5>      �� 5@      $��0 0 0 0q�6   $��2��6.   $��0��6;   $��2��6K   ��6_   �� *
PlayerView+�� 5A      $��
15 15 5 15q�6   $��0��61   $��0��6>   ��6N   �� *ToolbarView+�� 5C      $��0��6   $ 1��6"   .+�5E      A� -   5         �� Left$ 33��5E      
 �� Top$ 35��6+   $��10��6;   $��10��6F   ���	#FFFF6258 � Cursor$
 Hand��6   A� 5F      -   5         A�Name$ btnMin��5F   ;   $ 50��6   $ 35��6+   ���#ffdf2f$��10��6Z   $��10��6e   $
 Hand��6�   A� 5G      -   5        $ 67��5G      $ 35��6+   ���#2acd42$��10��6J   $��10��6U   $
 Hand��6|   5H      5O      5P      5Q      