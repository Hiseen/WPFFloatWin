   M S B A M L   `   `   `  ����[  WSystem.Windows.Forms, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089Y@clr-namespace:System.Windows.Forms;assembly=System.Windows.FormsSystem.Windows.Forms  5   	   F BWPFFloatWin, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:WPFFloatWinWPFFloatWin 5   	      WPFFloatWin.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Owf@clr-namespace:System.Windows.Forms;assembly=System.Windows.Forms     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:WPFFloatWin     5   	   -   5          � Title$  
MainWindow��5	   	   $	��120��6   $	��123��6)    � AllowsTransparency .  � WindowStyle$
 None=�6O    J� Opacity$	 0.8Q�6b    � Topmost . $	��123��6�   $	��120��6�   $	��123��6�   $	��120��6�    � 
ResizeMode$ NoResize=�6�    � ShowInTaskbar .  ��6   Z� .��5      � -   5         �Name$ 
WindowGrid��5      $��1,0,-1,0q�6    � ContextMenu 5   
   �� 5      .@�5      m� -   5        $��更改主题��5      6)   m� 5      -   5        $��退出��5      6'   5      .+�5   
   A� -   5        	 A�Name$	 ArcBg��5      ���	#FF71C7D4$	��120��62   $��0,0,3,0q�6?   F� 5   
   -   5        
 F�Name$
 ArcPath��5      ���	#FF008FCD$��5��63   $��0,0,-17,-20q�6G   A� 5   
   -   5        $	 InnerCircle��5      ���	#FF65AADD$	��110��68   $	��110��6D   $��5,5,5,5q�6Q   $
��Left=�6b   F� 5   
   -   5        $
 
SemiCircle��5      ���	#FF5A43986#   �� 5   
   $��18(�6   $��10,61,77,37q�6"   $��	Agency FB)�67   $
��Bold"�6N   $
��Down��6`   ���	#FFBBE2F16l   �� 5   
   -	   5         ��Name$ UpLoad��5      $��
0,34,43,64q�6$   $��18(�68   $��    0��6F   $��	Agency FB)�6S    � UseLayoutRounding .  $
��Bold"�6�   ���	#FFBBE2F1$��Right=�6�   $��35��6�    �� TextAlignment$ Right=�6�   �� 5   
   -
   5        $ DownLoad��5      $��18(�6&   $��    0��64   $��
0,61,43,36q�6A   $��	Agency FB)�6U   $
��Bold"�6l   ���	#FFBBE2F1$��Right=�6�   $��34��6�   $ Right=�6�   �� 5   
   $��18(�6   $��10,35,89,63q�6"   $��	Agency FB)�67   $
��Bold"�6N   $��Up��6`   ���	#FFBBE2F16j   �� 5   
   -   5        $ UpSpeed��5      $��18(�6%   $��80,34,10,64q�63   $��	Agency FB)�6H   $
��Bold"�6_   $
��KB/s��6q   ���	#FFBBE2F1$
��Left=�6�   �� 5   
   -   5        $ 	DownSpeed��5      $��18(�6'   $��80,61,10,37q�65   $��	Agency FB)�6J   $
��Bold"�6a   $
��KB/s��6s   ���	#FFBBE2F1$
��Left=�6�   5      5      