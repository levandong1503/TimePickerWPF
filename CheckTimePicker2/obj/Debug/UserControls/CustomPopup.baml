   M S B A M L   `   `   `  ����K  GCheckTimePicker2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullM+clr-namespace:CheckTimePicker2.UserControlsCheckTimePicker2.UserControls  5      /    )CheckTimePicker2.UserControls.CustomPopup   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      =local+clr-namespace:CheckTimePicker2.UserControls     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      
�������  � 	Resources  5         	ShowValue �� 
TargetType �� Property �� Value��%R   &	        �� 5   
   " ��6"   .�5      ��  � ��$ 30(�6)   5      5      .��5      �  � RowDefinitions 5   
   �� 5      $��2* �6   �� 5      $��8* �6   �� 5      $��2* �6    � ColumnDefinitions 5   
   �� 5      $��5* �6   �� 5      $��* �6   �� 5      $��5* �6   .+�5   
   �� $��0��5      $��0��5      $��3��5       $��Center=�5!      $��Center=�5"       �� Orientation$ 
Horizontal=�5#      .+�5$      �� #��[  6   ��6;   ��  �� Path$
 Hour��� 5%      #��[  6   $��:��6;   �� 5&      #��[  6   ��6;   �� $ Minute�5'      �� 5)   
   $ 
Horizontal=�6   $��Center=�6.   $��1��6K   $��0��6X   $��3��6h   .+�5*      �� -   5         ��Name$ HourOptions��5*      $��1��5+      $��0��5,      $��60��5-      $	��150��5.      $��5q�5/      $	��Top=�50      $��20(�51      $
��Auto=�52      $��Visible=�53      	 �� SelectedItem	 54      �� $
 Hour�
 �� Mode$
 TwoWay=��� 55      -   5        $ MinuteOptions��55      $��1��56      $��2��57      $��60��58      $	��150��59      $��5q�5:      $	��Top=�5;      $��20(�5<      	 5=      �� $ Minute�$
 TwoWay=�5>      �� 5?   
   $��3��5@      $��3��5A      $��Right=�5B      $ 
Horizontal=�5C      .+�5D      �� -   5         ��Name$ 	CancelBtn��5E      $��
20,20,0,20q�5F      $��	20,0,20,0q�5G      $��Cancel��5I      �� 5J      -   5        $ OkBtn��5K      $��20q�5L      $��	20,0,20,0q�5M      $��OK��5O      5P      5Q      5R      