   M S B A M L   `   `   `  ����B  >Waveify, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:Waveify.ViewsWaveify.Views  5      9!clr-namespace:Waveify.ExtentsionsWaveify.Extentsions  5      5clr-namespace:Waveify.UtilitiesWaveify.Utilities  5	      :    4Waveify.CustomControls.Content.PlaylistWorkingVibeCC   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      -localclr-namespace:Waveify.Views     5      1ext!clr-namespace:Waveify.Extentsions     5      b ^SharpVectors.Converters.Wpf, Version=1.8.4.2, Culture=neutral, PublicKeyToken=b532964b8548be771svgc&http://sharpvectors.codeplex.com/svgc/  5      0
componentsclr-namespace:Waveify.Utilities  5	      1   +Waveify.Extentsions.ClickLoseFocusExtension    	IsEnabled$
  True��5      .��5      �  � ColumnDefinitions 5   
   �� 5       � RowDefinitions 5   
   �� 5      $��150px �6   �� 5      $��* �6    � 	Resources 5   
      LoadingTemplate&    Waveify.Utilities.LoadingSpinner   	IsLoading   Diameter   Color   	Thickness  NoSongsTemplate �� Orientation(  "SharpVectors.Converters.SvgViewbox	   Source��%   &	        &	 �     �� 5      .R�5        $��Center=�6,   $��Center=�5   &   $
 True��5   &   $ 50Q�5   &    �#888$ 5Q�5   &   5       �� 5"      .R�5#      �� $ Vertical=�6   $��Center=�5$      $��Center=�5%      .+�5&        $��200px��6&   $��100px��5'       $��0 0 0 20q�5(       $	 ../icons/empty-folder.svg?�5)       �� 5*      $��Center=�6    $��Center=�5+      $��0 0 0 5q�5,      $��No songs found.��5-      $��
Montserrat)�5.      $
��24px(�5/      ���#888$��Light"�51      �� 52      $��Center=�6    $��Center=�53      $&�� Use drag and drop to add some...��54      $��
Montserrat)�55      $
��16px(�56      ���#666$��Light"�58      59      5;      5<      .+�5>   
   �� 
 �� CornerRadius$
 	20 20 0 0��6   $��0��6+     
BorderPage#���  68   5@      �� 5A   
   $
 	0 0 20 20��6   $��1��6*   ���#18181867   � 5B   
    5C      �� 5D      $��150px �6#   �� 5E      $��* �6#   �� 5F      $��150px �6#    5I      �� 5J      $��* �6    �� 5K      $
��auto �6    �� 5L      $��* �6    .+�5O      �� $��0��6   $��2��5P      $��
Montserrat)�5Q      $
��20px(�5R      $��	0 10 10 0q�5S      ���#fff$��Right=�5U      $��Center=�5V      $��Regular"�5W      ��5X      �� *CurrentDateString+�� 5Y      $��1��6   $��0��5Z      $��3��5[      $��Working Vibe��5\      $��
Montserrat)�5]      $
��50px(�5^      $��0 0 0 5q�5_        
menuTittle#���  5`      $��Center=�5a      $��Center=�5b      $
��Bold"�5c      �� 5e      $��2��6   $��0��5f      $-��'Morning, night music is always with you��5g      $��
Montserrat)�5h      $��Center=�5i      $
��20px(�5j      $��
10,0,219,0q�5k      ���#fff$��SemiBold"�5m      $��2��6(   5n      �� 5o   
   $
 	0 0 20 20��6   5q      &   System.Windows.Controls.DataGrid  5r   
   -   5          Name$ 	SongItems��5r      
������    GridLinesVisibility$
 None=�5u         VerticalGridLinesBrush
 ����    HorizontalGridLinesBrush
 ����    CanUserAddRows$ False��5x         CanUserResizeColumns$ False��5y         CanUserReorderColumns$ False��5z         CanUserResizeRows$ False��5{         CanUserDeleteRows$ False��5|         CanUserSortColumns$ False��5}         
IsReadOnly$
 True��5~         HeadersVisibility$ Column=�5      $��5q�5�         AutoGenerateColumns$ False��5�      $��1��5�      $��0��5�         ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 5�      4   .Waveify.Extentsions.DropFilesBehaviorExtension   	IsEnabled$
 True��5�         RowDetailsVisibilityMode$ 	Collapsed=�5�      $��
Montserrat)�5�      $
��True��5�      $��Disabled=�5�      ��5s      �� *
AllSongs+   Columns 5�      4  .System.Windows.Controls.DataGridTemplateColumn  5�      ,  &System.Windows.Controls.DataGridColumn   Width$	 100 6)      CellTemplate 5�      �� 5�      .R�5�      ��   TransparentButton#��[ 6%   ��5�      ��  �� ElementName$ 	SongItems�� �� Path$ DataContext.PlaySong���5�      �� *Id+.��5�   "     $
��30px��62   $
��30px��5�   0   ��5�   &   �� 5�   *     �� 
TargetType"   60   .�5�   .   �� ! �� Property! �@ Source" �� Value$" /icons/play.svg?�6G   # �� Triggers# 5�   .   �� 5�   2   $ �� Binding$ 6>   �� *	Playing+% �� Value% true6Z   .a�5�   6   �� ! �@ Source$" /icons/pause.svg?�6O   5�   3   5�   +   5�   #   5�      5�      5�      0	  *System.Windows.Controls.DataGridTextColumn	  5�      $	 100 5�      &   Header$& #��5�      1
  +System.Windows.Controls.DataGridBoundColumn' 
  Binding' 5�   %   �� $ Number�5�      	  5�      $& Title��5�      ' 5�   %   �� $ Title�( 
  ElementStyle( 5�      �� 5�      "  ��6    ) �� BasedOn#) [B��6@   .�5�      �� ! � ��$" CharacterEllipsis=�6=   5�      5�        5�      $
& Path��6)    5�      �� 5�      .R�5�      �� $��CharacterEllipsis=�5�   "   ��5�   (   �� *Path+* J� InputBindings* 5�   "   d� 5�   &   + d� MouseAction$+ 	LeftClicke�5�   -   , �� Command, 5�   3   �� $ 	SongItems��$ DataContext.OpenExplorer�- �� CommandParameter- 5�   -   �� *Path+5�   -   5�      5�      5�      	  5�      $	 100 5�      $& Duration��5�      ' 5�   %   �� $ Duration�5�        5�      $	 100 6)    5�      �� 5�      .R�5�      �� #��[ 6%   ��5�      �� $ 	SongItems��$ DataContext.DeleteSong���5�      �� *Id+.��5�   "     $
��15px��62   $
��15px��5�   0   $	 /icons/discard.svg?�5�   0   5�      5�      5�      .   RowStyle. 5�      �� 5�      )  #System.Windows.Controls.DataGridRow#) [B 6   "   6H   # 5�      �� 5�      $ 6&   �� *	Playing+% true6B   .a�5�      �� ! � ��" �#2525256;   5�      5�      5�      5�      5�      