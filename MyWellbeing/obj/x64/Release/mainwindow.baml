   M S B A M L   `   `   `  ���� F  BMyWellbeing, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:MyWellbeingMyWellbeing      MyWellbeing.MainWindow   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     +localclr-namespace:MyWellbeing       � Title$  Reaping Reward��$	��600��$
��1000�� � 
ResizeMode$ NoResize=� � WindowStartupLocation$ CenterScreen=� � 	Resources  
  Color1  TextBox.Static.Border �� Color  TextBox.MouseOver.Border  TextBox.Focus.Border  TextBoxStyle1 �� 
TargetType �� Property �� Value-  'System.Windows.Input.KeyboardNavigation �� 
TargetType	 ��Name
 J� SnapsToDevicePixels ��Name �� Triggers P� Property P� Value �� 
TargetName �� Triggers ]� 
Conditions �� Property �� Value��%�  &	        &	      &	 $     &	 9     &	 N     7  7  7  ��	Black���� $ 	#FFABAdB3���� $ 	#FF7EB4EA���� $ 	#FF569DE5���� " ��.���  � ��# � ����  � ��8   ��  � ��# � ����  � ��$ 1q���  �@ TabNavigation$
 None=���  � ��$
 Left=���  �@�FocusVisualStyle Z� ��  �@J�	AllowDrop . ��  �@��PanningMode$ VerticalFirst=���  �@��IsFlicksEnabled .  ��  � �� �� " ��.R��� $	 border��#��z��#��z��#��z��
 . ._��� $ PART_ContentHost��|�.  $��Hidden=�$��Hidden=�$��33,9,9,9q� P�  � {� .  . ��� $ border�� �@J�Opacity$
 0.56Q�P�  �@J�IsMouseOver . . ��� $ border��8   � ��P�  �@J�IsKeyboardFocused . . ��� $ border��8   � �� ]�  �� + �@��#IsInactiveSelectionHighlightEnabled . ��  �@��IsSelectionActive .  ./���  �@��SelectionBrush# � /�.���  � ColumnDefinitions �� .+��� $��	3,477,2,3q�$��
Image2.png��$
��Fill=��� $��10,10,426,432q�$��
Image4.png��$
��Fill=��� -   $��Login��$
��Left=�$��432,405,0,0q�$	��Top=�$	��123��$��53�� J� RenderTransformOrigin$ 0.332,0.671&����	#FFEB8200$��25(�$
��Bold"��� $��658,187,42,129q�$��
Image5.png��$
��Fill=��� $��First Name:��$
��Left=�$��230,212,0,0q�$	��Top=�$��22(�$
��Bold"�$��54��$	��138���� $��
Last Name:��$
��Left=�$��234,278,0,0q�$	��Top=�$��22(�$
��Bold"�$��54��$	��136���� $�� Employee Number:��$
��Left=�$��144,346,0,0q�$	��Top=�$��22(�$
��Bold"�$��54��$	��226���� -    ��Name$ btn_FirstName��$
��Left=�$��54��$��368,207,0,0q� �� TextWrapping$
 Wrap=�$	��Top=�$	��253��$��24(�$
��Bold"����	#FF1C5DBB#���  ��Z� �� -   $ btn_LastName��$
��Left=�$��54��$��368,274,0,0q�$
 Wrap=�$	��Top=�$	��253��$��24(�$
��Bold"����	#FF1C5DBB#���  ��Z� �� -   $ btn_EmployeeNumber��$
��Left=�$��54��$��368,342,0,0q�$
 Wrap=�$	��Top=�$	��253��$��24(�$
��Bold"����	#FF1C5DBB#���  ��Z� 