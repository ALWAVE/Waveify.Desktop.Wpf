   M S B A M L   `   `   `  ����B  >Waveify, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:Waveify.CustomControlsWaveify.CustomControls  5      &     Waveify.CustomControls.MusicCard   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      6local$clr-namespace:Waveify.CustomControls     5      b ^SharpVectors.Converters.Wpf, Version=1.8.4.2, Culture=neutral, PublicKeyToken=b532964b8548be771svgc&http://sharpvectors.codeplex.com/svgc/  5	      .��5      ��   �� CornerRadius$  15��6   $��2q�6    � Cursor$
 Hand��63   ��5   
   �� 5       �� 
TargetType" ��6   .�5      ��  �� Property � �� �� Value
 ���� 60   �� 5       � ��
 ���� 6/    �� Triggers 5      P� 5       P� Property �@J�IsMouseOver P� Value$
 True��65   . �5      ��  � �� �#11167   5      5      ._�5   
   � .+�5      �� $'��!/Images/Travis Scott - Utopia.jpg��6   $	��200��5      $	��168��6   $��
10,2,10,40q�6)   $
}�True��5      $��UniformToFill=�6$    J� Clip 5      �� 5      	 �� RadiusX$	 15Q�6(   
 �� RadiusY$
 15Q�65    �� Rect$ 0,0,168,200�6B   5"      �� 5#      $��\WaveifyLogo.ico��6   $��142,176,23,55q�6.   �� 5&         TransparentButton#���   6   $	��196��5'      $	��252��6   
������ 
������ $��Center=�5(      $��Center=�6.   ��5)      �� *TogglePlayer+��5*      �� 5+       �� 
TargetType" ��6&   .R�5,      � .+�5-      ��  ��Name$ 	PlayImage��61    J� Opacity$ 0Q�6%   61   (  "SharpVectors.Converters.SvgViewbox  5.        Name$ PlaySvg��6:   $ 0Q�6.   $��54,51,54,111q�6K   ��5/   "   �� 50   &   "  6,   .�51   *   ��  �@ Source$ /icons/play.svg?�6C   �� 52   *    �@J�RenderTransformOrigin$ 0.5,0.5&�6R    53   *   P� 54   .    �@J�IsMouseOver$
 True��6M   . �55   2   ��  � z� 56   6   �� 57   :    �� ScaleX$
 1.05Q�6I    �� ScaleY$
 1.05Q�6W   59   3   5:   /   �� 5;   .    �� Binding 6:   �� *	IsPlaying+ �� Value true6X   .a�5<   2   ��  �@ Source$ /icons/pause.svg?�6K   5=   /   5?   '   5A      '  !System.Windows.VisualStateManager   VisualStateGroups 5C      %  System.Windows.VisualStateGroup  5D   "   CommonStates��   States. 5E   &      System.Windows.VisualState  	MouseOver��   
Storyboard. 5F   *   �� .��5H   .   W�  �� 
TargetName$ 	PlayImage��6>    �� TargetProperty$ Opacity�5I   :    W� From 05J   :   	 W� To 16C    g� Duration$ 0:0:0.3D�6J   W� 5K   .   $ PlaySvg��6>   $ Opacity�5L   :    05M   :    16C   $ 0:0:0.3D�6J   t� 5N   .   $ 	PlayImage��6A   $ Margin�5O   <    t� From 	0,0,19,605P   <   	 t� To 	0,0,19,506M   $ 0:0:0.3D�5Q   <   5R   +   5S   '     5T   &   
Normal��. 5U   *   �� .��5W   .   W� $ 	PlayImage��6>   $ Opacity�5X   :    15Y   :    06C   $ 0:0:0.3D�6J   W� 5Z   .   $ PlaySvg��6>   $ Opacity�5[   :    15\   :    06C   $ 0:0:0.3D�6J   t� 5]   .   $ 	PlayImage��6A   $ Margin�5^   <    	0,0,19,505_   <    	0,0,19,606M   $ 0:0:0.3D�5`   <   5a   +   5b   '   5c   #   5e      5f      5h      �� 5m      $��Bottom=�6   $��0,0,0,10q�64   .+�5n      �� 
�������$
��10px(�6/   $��Travis Scott - Utopia��6?   $��12��5o      $��	0 -20 0 0q�6$   $	��158��67   $��	GothamSSm)�6C   �� 5p      ���#555555$
��10px(�61   $��New playlist��6A   $��12��5q      $��0 0 0 0q�6$   $	��158��65   $��	GothamSSm)�6A   5r      5s      5t      5u      