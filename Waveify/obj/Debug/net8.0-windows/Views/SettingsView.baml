   M S B A M L   `   `   `  ����B  >Waveify, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:Waveify.ViewsWaveify.Views  5      9!clr-namespace:Waveify.ExtentsionsWaveify.Extentsions  5      5clr-namespace:Waveify.ViewModelWaveify.ViewModel  5	      5clr-namespace:Waveify.UtilitiesWaveify.Utilities  5
      -clr-namespace:Waveify.ViewsWaveify.Views  5      -clr-namespace:Waveify.EnumsWaveify.Enums  5      ?$clr-namespace:Waveify.CustomControlsWaveify.CustomControls  5           Waveify.Views.SettingsView   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      -localclr-namespace:Waveify.Views     5      1ext!clr-namespace:Waveify.Extentsions     5      b ^SharpVectors.Converters.Wpf, Version=1.8.4.2, Culture=neutral, PublicKeyToken=b532964b8548be771svgc&http://sharpvectors.codeplex.com/svgc/  5      (vmclr-namespace:Waveify.ViewModel  5	      0
componentsclr-namespace:Waveify.Utilities  5
      'viewsclr-namespace:Waveify.Views  5      'enumsclr-namespace:Waveify.Enums  5      3controls$clr-namespace:Waveify.CustomControls  5      .��5      ��    
BorderView#���   6   ._�5   
   �   HomePage#���  6   $��
0,0,0,-647q�62     � ColumnDefinitions  5      �� 5       � RowDefinitions 5      �� 5      $��100px �6    �� 5      $��* �6    .+�5       �� $��20 0 0 0q�6   $��0��6,   $��0��6<   $��Bottom =�6I   .+�5!      �� $
��30px(�6     
menuTittle#���  6,   $��Настройки��6Q   5$      �� 5&      $��1��6   $��1��6&   $	��Top=�66   $
��Left=�6N   .+�5(      �� $��	20 20 0 0q�6   $
��16px(�60   #���  6@   $#��Тема приложения��6e   �� 5)      -   5         ��Name$ ChangeThemes��5)   >     
menuButton#���  6   $��	20,0,19,3q�6T    � Cursor$
 Hand��6g   $	��199��6�   .��5*      � .+�5,      �� $��Change Themes��6$   $��30,3,0,0q�69   $
��Left=�6K   $	��138��6f   5-      5.      �� 5/      -   5        $ ExclusiveTheme��5/   >   #���  6   $��	20,0,19,3q�6V   $
 Hand��6i   $	��199��6�   .��50      � .+�52      �� $��Premium Theme��6$   $��30,3,0,0q�69   $
��Left=�6K   $	��138��6f   53      54      �� 55      #���  6   $��	20,0,19,3q�6c   $
 Hand��6v   $
��199 ��6�   ��6>   �� *OpenModalCommand+.��56      � .+�58      �� $��Заглушечка��6$   $��30,3,0,0q�66   $
��Left=�6H   $	��138��6c   59      5:      �� 5;      $��	20 20 0 0q�6   $
��16px(�60   #���  6@   $��Язык��6e   �� 5<       �� Orientation$ 
Horizontal=�6   .+�5=      �� ���#888$��	20 20 0 0q�62   $
��14px(�6F   #���  6V   $����Выберите язык. Изменения вступят в силу после перезапуска приложения.��6{   5?      �� 5@      $��	20 20 0 0q�6   $
��16px(�60   #���  6@   $!��Качество звука��6e   �� 5A      $ 
Horizontal=�6   .+�5B      �� ���#888$��	20 20 0 0q�62   $
��14px(�6F   #���  6V   $V��PМузыка в HD качестве. Высокое качество звука.��6{   	� 5C      $��	100 0 0 0q�6"     ToggleButtonStyle#���  65   $	��111��6a   6o   5D      �� 5E      $ 
Horizontal=�6   .+�5F      �� ���#888$��	20 20 0 0q�62   $
��14px(�6F   #���  6V   $}��wПусть уши отдохнут. Ограничить громкость музыки до 50% на сегодняю��6{   	� 5G      $��	100 0 0 0q�6"   #���  65   $	��111��6a   6o   5H      �� 5I      $��	20 20 0 0q�6   $
��16px(�60   #���  6@   $��Моя медиатека��6e   �� 5J      $ 
Horizontal=�6   .+�5K      �� ���#888$��	20 20 0 0q�62   $
��14px(�6F   #���  6V   $;��5Быстрое удаление плейлистов.��6{   �� 5L      $��0��6   $
��33px��6-   $
��33px��6;   $��	250 0 0 0q�6H   $
��12px(�5M      ���#ddd$��
UltraBlack"�5P      $��-��5R      ��5Q      �� *ToggleRemoveActive+��5S      �� 5T       �� 
TargetType" ��5U      .�5V   "   ��  �� Property � �� �� Value �#2226?    �� Triggers 5W   "   �� 5X   &   	 �� Binding	 62   �� 
 �� ElementName$
 PlaylistItems�� �� Path$  DataContext.IsRemoveActive� �� Value true6�    N� EnterActions 5Y   *   �� 5Z   .   .��5[   2   �� .��5\   6   ��  �� TargetProperty$* $(Background).(SolidColorBrush.Color)�6S   .g�5]   :   8  2System.Windows.Media.Animation.EasingColorKeyFrame   �� KeyTime$ 0:0:0.5��6N    �� Value #4446`   5^   7   5_   3   5`   /    N� ExitActions 5b   *   �� 5c   .   .��5d   2   �� .��5e   6   �� $* $(Background).(SolidColorBrush.Color)�6S   .g�5f   :     $ 0:0:0.5��6N    #2226`   5g   7   5h   3   5i   /   5k   '   5m      5p      5q      �� 5r      $��	20 20 0 0q�6   $
��16px(�60   #���  6@   $$��Воспроизведение��6e   �� 5s      $ 
Horizontal=�6   .+�5t      �� ���#888$��	20 20 0 0q�62   $
��14px(�6F   #���  6V   $-��'Включить эквалайзер. ��6{   	� 5u      $��	100 0 0 0q�6"   #���  65   $	��111��6a   6o   5w      �� 5x       �� CornerRadius$ 5��6   ���#1f1f1f$	��638��6?   $	��267��6K    J� RenderTransformOrigin$ 0.5,0.5&�6X   ._�5y      �� .+�5z      �� $��Low Frequencies��6$   $��10q�6;   �� 5{      -   5         ��Name$ LowFreqSlider��5{   !    � Minimum$	 -10Q�68    � Maximum$ 10Q�6F    � Value$ 0Q�6S   $	��200��6]   $��10q�6i   �� 5}      $��Mid Frequencies��6$   $��10q�6;   �� 5~      -   5        $ MidFreqSlider��5~   !   $	 -10Q�68   $ 10Q�6F   $ 0Q�6S   $	��200��6]   $��10q�6i   �� 5�      $��High Frequencies��6$   $��10q�6<   �� 5�      -   5        $ HighFreqSlider��5�   !   $	 -10Q�69   $ 10Q�6G   $ 0Q�6T   $	��200��6^   $��10q�6j   �� 5�      -   5        $��Apply EQ��5�   !   $	��100��64   $��30��6@   6L   5�      5�      5�      5�      5�      5�      