   M S B A M L   `   `   `  ����B  >Waveify, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:Waveify.ToastWaveify.Toast  5   	       Waveify.Toast.ToastWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:Waveify.Toast     5   	     � WindowStyle$
  None=�5   	    � AllowsTransparency$
 True��5	   	   
������  � ShowInTaskbar$ False��5   	    � Topmost$
 True��5   	   $	��300��5   	   $	��100��5   	    � 	Resources 5         CloseStoryboard �� TargetProperty W� From	 W� To g� Duration��%  &	        �� 5   
   .��5      W� $ Opacity�6    1.05       0.06)   $ 0:0:1D�5      W� 5      $ Width�6    3005       06)   $ 0:0:1D�5      W� 5      $ Height�6    1005       06)   $ 0:0:1D�5      5      5      .��5      �� ���	#FF323232	 �� CornerRadius$	 10��6$   
 �� Padding$
 10q�66   ._�5!   
   �� .+�5"      ��  �� Orientation$ 
Horizontal=�6   .+�5#      �� $��/WaveifyLogo.ico��6   $��19��62   $��35��6>   $��Center=�6I   �� 5$      $��Waveify��6   $��0 0 0 0q�6+   $
��Bold"�6<   
�������$��14(�6a   A� 5%      -   5        $��	170 0 0 0q�5%      $��10��6-   $��10��68   ���	#FFFF6258 � Cursor$
 Hand��6s   5&      �� 5'      -   5         ��Name$ 	TitleText��5'      $��	10 10 0 0q�6+   $
��Bold"�6>   
�������$��14(�6c   �� 5(      -   5        $ ContentText��5(      $��	10 10 0 0q�6.   
�������$��12(�6T   5)      5*      5+      