   M S B A M L   `   `   `  ����F  BPaintAppTwo, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:PaintAppTwoPaintAppTwo  5   	   ;"clr-namespace:PaintAppTwo.CommandsPaintAppTwo.Commands  5   	   C&clr-namespace:PaintAppTwo.UserControlsPaintAppTwo.UserControls  5   	   "    PaintAppTwo.Views.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:PaintAppTwo     5   	   3comm"clr-namespace:PaintAppTwo.Commands     5   	   5UC&clr-namespace:PaintAppTwo.UserControls     5   	     � Title$  Second Paint app��5   	   $	��450��6"   $	��800��62    � SizeToContent$ WidthAndHeight=�5   	   
������� J� CommandBindings 5      )  #System.Windows.Input.CommandBinding  5   
   -   5           Command$
 Open��5      6E     5   
   -   5        $	 New��5      6C     5   
   -   5        $
 Save��5      6E    � 	Resources 5      ��%    5      .��5      �  � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $��* �6   .+�5"   
   ]� $��0��6   .+�5$      o� -   5        $��MainTopMenu��5&      $��1q�5$      $	��Top=�5%      .@�5(      m� $��_File��6   .@�5*      �� m� 5,       m� Command$
 Open��6   5.      �� 5/      m� 50      $	 New��6    52      �� 53      m� 54      $
 Save��6    55      56      57      `� 5:      $��0q�6   $��50��5;       `� 
Background
 �����$��Bottom=�5=      .�5>      c� .@�5?      �� $��Brush size(in pixels):��6   $��1q�5@      �� 5A      -   5        $��brushSizeTextBox��5A      $��1q�5B      $��50��5C      5D      �� 5F      -   5        $��colorBtn��5F      $��Color��5G      $��50��5H      $��30��5I      5J      �� 5L      $��Width:��6   $��Center=�5M      $��1q�5N      �� 5P      -   5        $��PictureSizeXTextBox��5P      $��50��5Q      $��1q�5R      $��Center=�5S      5T      �� 5V      $��Height:��6   $��Center=�5W      $��1q�5X      �� 5[      -   5        $��PictureSizeYTextBox��5[      $��50��5\      $��1q�5]      $��Center=�5^      5_      �� 5a       �� Orientation$ Vertical=�6!   $��Center=�5b   !   .+�5l      �� -	   5        $��eraserBtnTwo��5l   !   $��60��5m      $��30��5n      $��Eraser��5p      $��1q�5q      5t      �� 5w      $��Eraser size(in pixels):��6   $��1q�5x      $��Center=�5y      �� 5{      -
   5        $��eraserSizeTxtBox��5{      $��50��5|      $��1q�5}      5~      5�      5�      5�      5   /PaintAppTwo.UserControls.ColorPickerUserControl  5�   
   -   5        	  Name$	 ColorPickerUC��5�   $   5   /PaintAppTwo.UserControls.ColorPickerUserControl
   
MouseLeave$
 ColorPickerUC_MouseLeave��5�   %   
���   �$��1q�5�   %   $��Right=�5�   %   $��0,1,0,0q�5�   %   5�   %   � 5�   
   
������ $��Center=�5�      $��Center=�5�      $��1��5�      .+�5�      �� -   5        $��
mainCanvas��5�       �� DefaultDrawingAttributes 5�      *  $System.Windows.Ink.DrawingAttributes  5�      -   5        MainCanvasAttribute��   Width$ 3Q�5�   (      Height$ 3Q�5�   (   5�      5�      5�      5�      