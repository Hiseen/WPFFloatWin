   M S B A M L   `   `   `  ���� F  BWPFFloatWin, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:WPFFloatWinWPFFloatWin      WPFFloatWin.TagWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     +localclr-namespace:WPFFloatWin     -     � Title$  	TagWindow�� � WindowStyle$
 None=� � AllowsTransparency .  J� Opacity$	 0.8Q� � Topmost . $��Center=�$��Center=�$��Center=�$��Center=� � WindowStartupLocation$ CenterScreen=� J� 	AllowDrop .  � ShowInTaskbar .  $��51��$��50�� � 
ResizeMode$ NoResize=���Z� 	 � 	Resources	 
 �� 
TargetType   btnstyle �� Property �� Value �� 
TargetType �� CornerRadius ��Name �� Triggers P� Property P� Value��%  &	        �� "
 ��.���  � ��
 �������  � ��
 ���� ��  �@J�Opacity$	 0.5Q���  � �� �� " ��.R��� $ 1Q�$ 2��#��z��._��� $ content��$��Center=�$��Center=�#��z�� P�  �@J�IsMouseOver . . ���  �@J�Opacity$ 1Q�.��� -    �Name$ tw_grid�� � RowDefinitions �� $
��Auto � � ColumnDefinitions �� $��50 ��� $
��Auto �.+��� -    ��Name$ 	tw_canvas��$��50��$��51��$
��Left=�$	��Top=����	#02000000.+�F� "����@B ��� �@B @B р�� @B 	
�������$��1��F� "���� Zb@B �@��@B �@����� 	
�������$��1��F� "����@�� Zb�@��@��� Zb@��	
�������$��1��F� "����@B  Zb�@B @��р�� @��	
�������$��1���� -    ��Name$ tw_ctrlbutton��#��[  $�� ��$��46��$��46��$��	Agency FB)�$��18(�$
��Bold"�$��Center=�$��Center=�$��2,2,0,0q���Z� �� -    ��Name$ 	tw_border��
���   �$ 10��$��
1,0,-299,0q�$��1�� �� Padding$
 10,5q�$��0q�._��� -   $ 
tw_content���� -    ��Name$ tw_focus_sub��$�� ��$
��Left=�$	��Top=�$��0��$��0�� J� IsHitTestVisible .  