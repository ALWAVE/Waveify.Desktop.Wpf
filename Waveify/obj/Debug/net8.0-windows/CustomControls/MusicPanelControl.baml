   M S B A M L   `   `   `  ����B  >Waveify, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:Waveify.UtilitiesWaveify.Utilities  5      ?$clr-namespace:Waveify.CustomControlsWaveify.CustomControls  5      .    (Waveify.CustomControls.MusicPanelControl   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      5	componentclr-namespace:Waveify.Utilities     5      6local$clr-namespace:Waveify.CustomControls     5      b ^SharpVectors.Converters.Wpf, Version=1.8.4.2, Culture=neutral, PublicKeyToken=b532964b8548be771svgc&http://sharpvectors.codeplex.com/svgc/  5      .��5      �   � ColumnDefinitions  5   
   �� 5      $	��20* �6   �� 5      $	��60* �6   �� 5      $	��20* �6    � RowDefinitions 5   
   �� 5      $��* �6   .+�5   
   �� $��0��6   $��3��6      MusicPanell#���   62    �� CornerRadius$ 	0 0 25 25��6X    J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         ShadowDepth$ 10Q�5         	Direction$ 90Q�5         Color$ #212121��5         Opacity$	 0.1Q�5         
BlurRadius$
 10.0Q�5      5      �� 5   
   	 �� Orientation$	 Vertical=�6   $��	10 0 10 0q�5       $��Center=�5!      .+�5"      �� $��Center=�6   $��Center=�5#      $��0��5$      $��0��5%      ���#fff$
��14px(�5'      $��0 0 0 0q�5(      $��DemiBold"�5)      $��CharacterEllipsis=�5*      ��5,      �� *
SongName+5=      �� 5?   
   -   5        $��ParentPanel��5C      $��0��5?      $��1��5@      $��Center=�5A      $	 Vertical=�5B      .+�5E      �� $��Center=�6   $	 
Horizontal=�5F      $��0 0 0 5q�5G      .+�5H      ��   TransparentButton#��[ 6   $��0 0 25 0q�5J      ��5I      �� *PlayBackward+.��5K      (  "SharpVectors.Converters.SvgViewbox  $
��18px��6"   $
��20px��6/   
   Source$
 /icons/backward.svg?�6=   5L      �� 5M      #���  6   $��0 0 25 0q�5N      ��5O      �� *TogglePlayer+.��5P        $
��35px��6&   $
��35px��5Q      ��5R      �� 5S       �� 
TargetType"  6$   .�5T   "   ��  �� Property �@ Source �� Value$ /icons/play.svg?�6;   �� 5U   "    �@J�RenderTransformOrigin$ 0.5,0.5&�6J    �� Triggers 5W   "   P� 5X   &    P� Property �@J�IsMouseOver P� Value$
 True��6E   . �5Y   *   ��  � z� 5Z   .   �� 5[   2    �� ScaleX$
 1.05Q�6A    �� ScaleY$
 1.05Q�6O   5^   +   5_   '   �� 5`   &    �� Binding 62   �� *	IsPlaying+ �� Value true6P   .a�5a   *   ��  �@ Source$ /icons/pause.svg?�6C   5b   '   5d      5f      5g      �� 5h      #��[ 6   ��5i      �� *PlayForward+.��5j        $
��18px��6&   $
��20px��63   $
 /icons/forward.svg?�6A   5k      5o      � 5q        5r      �� 5s      $��100px �6'   �� 5t      $��* �6'   �� 5u      $��100px �6'    5x      �� 5y      .+�5|      �� $��0��6   $��0��5}      $��0 0 10 0q�5~      $��Right=�5      $��Center=�5�      ���#bbb$
��11px(�5�      $��SemiBold"�5�      ��5�      �� *SongProgressFormatted+   Waveify.Utilities.DSlider  5�        PrettySlider#��[ 6$    � Minimum$ 0Q�5�   $   $��0��5�   $   $��1��5�   $   $��Stretch=�5�   $    �� IsMoveToPointEnabled$
 True��5�   $    � Cursor$
 Hand��5�   $    � Maximum 5�   $   �� *SongDuration+ � Value 5�   $   �� *SongProgress+ �� Mode$ TwoWay=�5�   $   �� 5�      $��0��6   $��2��5�      $��10 0 0 0q�5�      $
��Left=�5�      $��Center=�5�      ���#bbb$
��11px(�5�      $��SemiBold"�5�      ��5�      �� *SongDurationFormatted+5�      5�      �� 5�   
   $��0��6   $��2��5�      $	 
Horizontal=�5�      $��Center=�5�      .+�5�      �� #��[ 6   $��30��5�      $��25��5�      $��0 0 5 0q�5�      $��Right=�5�      $��Center=�5�      ��5�      �� *ToggleVolume+��5�      �� *Volume+.��5�        ��5�      �� 5�      "  6    .�5�      ��  �@ Source$ /icons/volume1.svg?�67   �� 5�       � ��$
 20px��66   �� 5�       � ��$
 20px��67    5�      �� 5�   "    6.   �� *Volume+ 06I   .a�5�   &   ��  �@ Source$ /icons/muted.svg?�6?   �� 5�   &    � ��$
 20px��6>   �� 5�   &    � ��$
 20px��6?   5�   #   5�      5�      5�      �� 5�      #��[ 6   $��Center=�5�      $
��Left=�5�      $
 True��5�      $ 0Q�5�      $	 100Q�5�      $
 Hand��5�       5�      �� *Volume+$ TwoWay=�5�      5�      5�      5�      