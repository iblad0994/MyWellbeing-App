   M S B A M L   `   `   `  ����F  BMyWellbeing, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:MyWellbeingMyWellbeing  5   	       MyWellbeing.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:MyWellbeing     5   	     � Title$  
MainWindow��5   	   $	��450��6   $
��1000��6)    � 
ResizeMode$ NoResize=�66    � WindowStartupLocation$ CenterScreen=�6L    � 	Resources 5	       
  Color1��%'   &	        ��5
   
   	Black��6&   5      .��5      �  � ColumnDefinitions 5   
   �� 5      .+�5   
   �� $��	3,336,0,3q�6   $��
Image2.png��6#   $
��Fill=�67   �� 5   
   $��10,10,424,321q�6   $��
Image4.png��6'   $
��Fill=�6;   �� 5   
   -   5         ��Name$ Location��5      $
��Left=�6$   $��37��6?   $��262,168,0,0q�6K    �� TextWrapping$
 Wrap=�6`   $	��Top=�6t   $	��233��6�   $��24(�6�    �� TextAlignment$ Center=�6�   $
��Bold"�6�   ���	#FF5F7800#��� ��6�    J� RenderTransformOrigin$ 0.5,0.5&�6*  .��6J  	 J� Effect	 5      3  -System.Windows.Media.Effects.DropShadowEffect  5      .��5      z�5      V� 5      .~�5      �� �� 5      �� 5      
 �� Angle$
 -0.208Q�6&   T� 5      5      .��5   '   5      �� 5   
   -   5        $ EmployeeNumber��5      $
��Left=�6*   $��37��6E   $��262,216,0,0q�6Q   $
 Wrap=�6f   $	��Top=�6z   $	��234��6�   $��24(�6�   $ Center=�6�   $
��Bold"�6�   ���	#FF5F7800#��� ��6�   $ 0.5,0.5&�60  .��6P  	 5         5!      .��5"      z�5#      V� 5$      .~�5%      �� �� 5&      �� 5'      $
 -0.208Q�6&   T� 5(      5)      .��5*   '   5+      �� 5,   
   -   5        $ Names��5,      $
��Left=�6!   $��37��6<   $��262,123,0,0q�6H   $
 Wrap=�6]   $	��Top=�6q   $	��233��6�   $��24(�6�   $ Center=�6�   $
��Bold"�6�   ���	#FF5F7800#��� ��6�   $ 0.5,0.5&�6'  .��6f  	 5-        5.         Color# �   6#   .��5/      z�50      V� 51      .~�52      �� �� 53      �� 54      $
 -0.208Q�6&   T� 55      56      .��57   '   58      �� 59   
   -   5        $��Login��59      $
��Left=�6!   $��327,278,0,0q�6<   $	��Top=�6Q   $	��113��6i   $��37��6u   $ 0.332,0.671&�6�   ���	#FFEB8200$��25(�6�   $
��Bold"�6�   �� 5:   
   $��621,71,40,129q�6   $��
Image5.png��6'   $
��Fill=�6;   �� 5;   
   $��First Name:��6   $
��Left=�6&   $��128,126,0,0q�6A   $	��Top=�6V   $��22(�6n   $
��Bold"�6|   �� 5<   
   $��
Last Name:��6   $
��Left=�6%   $��132,170,0,0q�6@   $	��Top=�6U   $��22(�6m   $
��Bold"�6{   �� 5=   
   $��Employee Number:��6   $
��Left=�6+   $��
48,218,0,0q�6F   $	��Top=�6Z   $��22(�6r   $
��Bold"�6�   5?      5@      