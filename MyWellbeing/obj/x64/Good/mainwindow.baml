   M S B A M L   `   `   `  ���� F  BMyWellbeing, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:MyWellbeingMyWellbeing      MyWellbeing.MainWindow   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     +localclr-namespace:MyWellbeing     $	��600��$
��1000��  � 
ResizeMode$  NoResize=� � WindowStartupLocation$ CenterScreen=� � 	Resources  
  Color1  TextBox.Static.Border �� Color  TextBox.MouseOver.Border  TextBox.Focus.Border  TextBoxStyle1 �� 
TargetType �� Property �� Value-  'System.Windows.Input.KeyboardNavigation �� 
TargetType ��Name	 J� SnapsToDevicePixels
 ��Name �� Triggers P� Property P� Value �� 
TargetName �� Triggers ]� 
Conditions �� Property �� Value��%�  &	        &	      &	 $     &	 9     &	 N     7  7  7  ��	Black���� $ 	#FFABAdB3���� $ 	#FF7EB4EA���� $ 	#FF569DE5���� " ��.���  � ��# � ����  � ��8   ��  � ��# � ����  � ��$ 1q���  �@ TabNavigation$
 None=���  � ��$
 Left=���  �@�FocusVisualStyle Z� ��  �@J�	AllowDrop . ��  �@��PanningMode$ VerticalFirst=���  �@��IsFlicksEnabled .  ��  � �� �� " ��.R��� $ border��#��z��#��z��#��z��	 . ._��� $
 PART_ContentHost��|�.  $��Hidden=�$��Hidden=�$��33,9,9,9q� P�  � {� .  . ��� $ border�� �@J�Opacity$
 0.56Q�P�  �@J�IsMouseOver . . ��� $ border��8   � ��P�  �@J�IsKeyboardFocused . . ��� $ border��8   � �� ]�  �� + �@��#IsInactiveSelectionHighlightEnabled . ��  �@��IsSelectionActive .  ./���  �@��SelectionBrush# � /�.���  � ColumnDefinitions �� .+��� $��730,421,52,99q�$��
Image4.png��$
��Fill=��� -   $��Login��$
��Left=�$��408,407,0,0q�$	��Top=�$	��123��$��53�� J� RenderTransformOrigin$ 0.332,0.671&����	#FFEB8200$��25(�$
��Bold"��� $��First Name:��$
��Left=�$��182,212,0,0q�$	��Top=�$��22(�$
��Bold"�$��54��$	��138���� $��
Last Name:��$
��Left=�$��186,278,0,0q�$	��Top=�$��22(�$
��Bold"�$��54��$	��136���� $��Windows Username:��$
��Left=�$��
89,342,0,0q�$	��Top=�$��22(�$
��Bold"�$��54��$	��226��$ 1.102,0.463&��� -    ��Name$ btn_FirstName��$
��Left=�$��54��$��320,207,0,0q� �� TextWrapping$
 Wrap=�$	��Top=�$	��312��$��24(�$
��Bold"����	#FF1C5DBB#���  ��Z� �� -   $ btn_LastName��$
��Left=�$��54��$��320,274,0,0q�$
 Wrap=�$	��Top=�$	��312��$��24(�$
��Bold"����	#FF1C5DBB#���  ��Z� �� -   $ btn_EmployeeNumber��$
��Left=�$��54��$��320,342,0,0q�$
 Wrap=�$	��Top=�$	��312��$��24(�$
��Bold"����	#FF1C5DBB#���  ��Z� �� $��667,91,16,146q�$��pw-centre-stones.png��$
��Fill=��� $��3,-2,876,451q�$��Image33.png��$
��Fill=��� $��113,0,362,451q�$��Image34.png��$
��Fill=��� $��	0,495,0,0q�$��Image35.png��$
��Fill=��� $��855,518,22,12q�$��Picture5.png��$
��Fill=�