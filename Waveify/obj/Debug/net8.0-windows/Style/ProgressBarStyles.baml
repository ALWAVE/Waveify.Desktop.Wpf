   M S B A M L   `   `   `  ����B  >Waveify, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:Waveify.ConvertersWaveify.Converters  5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089   HideProgressBarStoryboard  g� 	BeginTime g� 
SpeedRatio �� TargetProperty W� From	 W� To g� Duration �� 
TargetType �� Property �� Value	 �� 
TargetType'   !System.Windows.VisualStateManager
    VisualStateGroups%  System.Windows.VisualStateGroup   States   System.Windows.VisualState   
Storyboard g� RepeatBehavior �� 
TargetName � From	 � To ��Name �Name j� TileMode j� Stretch j� Viewport j� ViewportUnits L� Drawing � Brush � Geometry E� 
StartPoint �� Point �� Triggers P� Property P� Value N� EnterActions  ��Name! N� ExitActions" �� BeginStoryboardName,   &Waveify.Converters.StartPointConverter  StartPointConverter)   #Waveify.Converters.ArcSizeConverter  ArcSizeConverter-   'Waveify.Converters.ArcEndPointConverter  ArcEndPointConverter7   1Waveify.Converters.RotateTransformCentreConverter " RotateTransformCentreConverter)   #Waveify.Converters.NotZeroConverter  NotZeroConverter  CircularProgressBar# � 	Resources  Key$ O� KeyTime% O� Value& �� ScaleX' F�Name
( �� Top) �� Left* �� Stretch+ J� RenderTransformOrigin, E� IsFilled- �� ElementName. �� Path/ �� 	Converter0 �� Mode1 �� SweepDirection2 �� Size3 �� Point4 `� 	Converter5   ParameterMidPoint6 `� ConverterParameter7 �� RelativeSource8 �� CenterX9 �� CenterY: ^� 
Conditions; �� Binding< �� Value  IsIndeterminateStoryboard= ]� 
Conditions> �� Property "	 IsFullyIndeterminateStoryboard�� 5      F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     :x,http://schemas.microsoft.com/winfx/2006/xaml     5      /
converters clr-namespace:Waveify.Converters  5      %�  &	        '� �     7   &	      &	 3    &	 F    &	 Y    &	 l    &	     7  7  7  7  7  7  7  7  7  7 	 �� 5        00:00:045      $ 2Q�5      .��5	   
   W� $8 2(UIElement.RenderTransform).(TranslateTransform.X)�5
       05       1005      $ 0:0:1D�5      5      �� 5      " �5   	   .�5   
   ��  � ��
 �����6'   �� 5   
    � ��
 ��  �6'   �� 5   
    � ��$ 8��6#   �� 5   
    � z� 5      T� 5      5      �� 5   
    � �� 5      �� 5      "	 �6"   .R�5      � $��TemplateRoot��6   
 5        5       CommonStates��. 5!   "     Determinate��6.     5"   "   Indeterminate��. 5#   &   �� $ Forever��61   .��5$   &   � $ Stripe��5%   -   $' !(Shape.Fill).(TileBrush.Viewport)�5&   -   $ 0:0:1D�5'   -    0,0,8,85(   -    -8,0,8,86<   5)   '   5*   #   5+      .+�5-      �� #��z��6!   �� 5.      $ 
PART_Track��6$   � 5/      $ PART_Indicator��6   $
}�True��50      $
��Left=�51      .+�52      �� $ 	Indicator��6(   #��z��53   $   �� 54      $��Stripe��55   !   $��RightToLeft=�56   !   ��57   "   L� 58   &   $
 Tile=�59   )   $ Uniform=�5:   )   $ 0,0,8,8�5;   )   $ Absolute=�5<   )    5=   *   � 5>   .   
 ����  5?   2   B� 5@   6   ��5B   >   D� E� 5C   B   $	 0,0&�6M   .��5D   F   �� $	 5,0&�6R   �� 5E   F   $
 10,5&�6R   �� 5F   F   $ 10,10&�6R   5G   C   E� 5H   B   $	 0,5&�6M   .��5I   F   �� $
 5,10&�6R   �� 5J   F   $
 0,10&�6R   5K   C   5L   ?   5N   7   5P   /   5R   '   5T      5U      5V       5W      P� 5X       �@�IsIndeterminate$
 True��6=    5Y      �� 5Z   "   $  HideProgressBarStoryboard��5\   	   8��  ! 5^      �� 5_   "   $" HideProgressBarStoryboard��5`   %   5b      5d      5f      5g        5j      6%     5k      6"     5l      6&     5m      60     5n      6"   �� 5p      " �6(   .�5q   
   ��  � ��
 ���� 6'   �� 5r   
    � �� �#f1439f6'   �� 5s   
    � ��$ 20��6&   �� 5t   
    � ��$ 20��6%   �� 5u   
    � �� 5v      �� 5w      "	 �6"   # 5x      ���� 5y      IsIndeterminateStoryboard $ RotateTransform��6G   $ Angle�6d   $ Forever��6{   .��5z      W�  06.    35967   $ 0:0:2D�6@   5{      �� 5|      "IsFullyIndeterminateStoryboard .��5}      U� $* $FullyIndeterminateGridScaleTransform��6<   $ ScaleX�5~   <   $ Forever��5   <   .\�5�   "   �� $$ 0��67   $	% 0.0Q�6C   �� 5�   "   $$ 0:0:1��67   $	% 1.0Q�6G   �� 5�   "   $$ 0:0:4��67   $	% 0.0Q�6G   5�      W� 5�      $ RotateTransform��6.   $ Angle�5�   .   $ Forever��5�   .    005�   .    35968   $ 0:0:1.25D�6A   5�      5�      .R�5�      � $ TemplateRoot��6   $}�False��61   .+�5�      � $ FullyIndeterminateGrid��6   z�5�      �� 5�   "   ($FullyIndeterminateGridScaleTransform��$& 0Q�6_   5�      � 5�      $ PathGrid��6   $��2q�61   �� 5�      .+�5�      A� #��z��5�   !   #��z��6E   #��z��6e   F� 5�      $
' Path��6#   #��z��61   $��4��6W   $( 2��5�   #   $) 2��62   $
* None=�5�   #   $
+ 0, 0&�5�   #   ��5�   "   B� 5�   &   .��5�   *   E� $, False��65    6F   �� $- PathGrid��$. ActualWidth�8/   $0 OneWay=�.��5�   .   �� $1 	Clockwise=�5�   9   2 5�   9   �� $- PathGrid��$. ActualWidth�8/  $0 OneWay=�3 5�   2   `� 5�   6   84  #6 Z5 5�   9   .1�5�   :   �� $- PathGrid��6B   $. ActualWidth�6Y   �� 5�   :   $. Value�6t   7 6B   �� *TemplatedParent+6t   �� 5�   :   $. Minimum�6t   7 6B   �� *TemplatedParent+6t   �� 5�   :   $. Maximum�6t   7 6B   �� *TemplatedParent+6t   �� 5�   :   $*- $FullyIndeterminateGridScaleTransform��6B   $. ScaleX�6u   5�   7   5�   /   �� 5�   .   $1 	Clockwise=�5�   9   2 5�   9   �� $- PathGrid��$. ActualWidth�8/  $0 OneWay=�3 5�   2   `� 5�   6   84  .1�5�   :   �� $- PathGrid��6B   $. ActualWidth�6Y   �� 5�   :   $. Value�6t   7 6B   �� *TemplatedParent+6t   �� 5�   :   $. Minimum�6t   7 6B   �� *TemplatedParent+6t   �� 5�   :   $. Maximum�6t   7 6B   �� *TemplatedParent+6t   �� 5�   :   $*- $FullyIndeterminateGridScaleTransform��6B   $. ScaleX�6u   5�   7   5�   /   5�   +   5�   '   z�5�   "   V� 5�   &   .~�5�   *   �� RotateTransform��8 5�   :   �� $- PathGrid��$. ActualWidth�8/  $0 OneWay=�9 5�   :   �� $- PathGrid��$. ActualWidth�8/  $0 OneWay=�5�   '   5�      5�      5�       5�      ^� 5�      : 5�      �� 5�   "   ; 6,   �� *IsIndeterminate+7 �� *Self+< True6v   �� 5�   "   ; 6,   �� *	IsVisible+7 �� *Self+< True6p   �� 5�   "   ; 6,   �� *Value+7 �� *Self+8/  < True6�    5�      �� 5�   "   $  IsIndeterminateStoryboard��5�   2   8�� ! 5�      �� 5�   "   $" IsIndeterminateStoryboard��63   5�      ]� 5�      = 5�      �� 5�   "   > �@�IsIndeterminate$
< True��6G   �� 5�   "   > �@J�	IsVisible$
< True��6A   �� 5�   "   > �@�Value$< 0Q�6=    5�      �� 5�   "   $$  IsFullyIndeterminateStoryboard��5�   2   8��	 ! 5�      �� 5�   "   $$" IsFullyIndeterminateStoryboard��63   5�      5�      5�      5�      5�      