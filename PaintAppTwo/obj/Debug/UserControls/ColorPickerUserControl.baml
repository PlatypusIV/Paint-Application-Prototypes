   M S B A M L   `   `   `  ����F  BPaintAppTwo, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:PaintAppTwo.UserControlsPaintAppTwo.UserControls  5      5    /PaintAppTwo.UserControls.ColorPickerUserControl   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      8local&clr-namespace:PaintAppTwo.UserControls     5      
�������.��5      �   � RowDefinitions  5   
   �� 5      $
��auto �6   �� 5      $��* �6   �� 5      $
��auto �6    � ColumnDefinitions 5   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��80 �6   .+�5   
   �� -   5        $��colorPickerRect��5      $��3��5      $��3��5      $��1��5      $��70��5      $��Stretch=�5      5"      �� 5$   
   $	��Red��6   $��0��5%      $��Center=�5&      $��Center=�5'      $��1q�5(      �� 5*   
   $��Green��6   $��0��5+      $��1��5,      $��Center=�5-      $��Center=�5.      $��1q�5/      �� 51   
   $
��Blue��6   $��0��52      $��2��53      $��Center=�54      $��Center=�55      $��1q�56      �� 58   
   -   5        $��RSlider��58      $��1��59      $��0��5:      $��1q�5;      $��Center=�5<      $��Center=�5=       � Minimum$ 0Q�5>       � Maximum$	 255Q�5?       �� Orientation$ Vertical=�5@      $	��125��5A       �� TickFrequency$ 1Q�5B       �� TickPlacement$ TopLeft=�5C       �� IsSnapToTickEnabled . 5E      �� 5S   
   -   5        $��RTextBox��5T      $��2��5U      $��0��5V      $��Center=�5W      $��Center=�5X      $��1q�5Y      $��30��5Z       �� TextAlignment$ Center=�5[      ��5S      �� 	 �� ElementName$	 RSlider��
 �� Path$
 Value� �� UpdateSourceTrigger$ PropertyChanged=�5[      �� 5]   
   -   5        $��GSlider��5]      $��1��5^      $��1��5_      $��1q�5`      $��Center=�5a      $ 0Q�5b      $	 255Q�5c      $ Vertical=�5d      $ 1Q�5e      $ TopLeft=�5f      $	��125��5g       . $��Center=�5i      5j      �� 5l   
   -   5        $��GTextBox��5m      $��2��5n      $��1��5o      $��Center=�5p      $��Center=�5q      $��1q�5r      $��30��5s      $ Center=�5t      ��5l      �� $	 GSlider��$
 Value�$ PropertyChanged=�5t      �� 5v   
   -   5        $��BSlider��5v      $��1��5w      $��2��5x      $��1q�5y      $��Center=�5z      $ 0Q�5{      $	 255Q�5|      $ Vertical=�5}      $ 1Q�5~      $ TopLeft=�5      $	��125��5�       . $��Center=�5�      5�      �� 5�   
   -   5        $��BTextBox��5�      $��2��5�      $��2��5�      $��Center=�5�      $��Center=�5�      $��1q�5�      $��30��5�      $ Center=�5�      ��5�      �� $	 BSlider��$
 Value�$ PropertyChanged=�5�      5�      5�      