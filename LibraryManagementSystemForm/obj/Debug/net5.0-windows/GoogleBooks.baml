   M S B A M L   `   `   `  ����V  RLibraryManagementSystemForm, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:LibraryManagementSystemFormLibraryManagementSystemForm  5   	   U QSystem.Runtime, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a7,clr-namespace:System;assembly=System.RuntimeSystem 5   	   -    'LibraryManagementSystemForm.GoogleBooks   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ;local)clr-namespace:LibraryManagementSystemForm     5   	   ?System,clr-namespace:System;assembly=System.Runtime     5   	     � Title$  GoogleBooks��5	   	   $	��450��6   $	��800��6*    � WindowStartupLocation$ CenterScreen=�66   .��5
      �  � ColumnDefinitions 5   
   �� 5      $��20 �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��* �6   �� 5      $��20 �6    � RowDefinitions 5   
   �� 5      $��20 �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5       $
��auto �6   �� 5!      $
��auto �6   �� 5"      $��* �6   �� 5#      $��20 �6   .+�5%   
   �� $��1��6   $��1��6"    �� Orientation$ 
Horizontal=�62   .+�5&      �� -   5         ��Name$ searchFieldsCbx��5&      $��80��60   $��22��6;    �� SelectedIndex$ 0��6G   ���	#FF6868686Y   �� 5'      -   5         ��Name$ searchStringTbx��5'      $	��200��6/   �� 5(      -   5         ��Name$ 	searchBtn��5(      $��50��6(   $��Search��63   6D   �� 5)      $��Max Result: ��6   $��70��6,   $��20,0,0,0q�67   $��Center=�6I   �� 5*      -   5        	 ��Name$	 maxResultsSdr��5*      
 � Minimum$
 1Q�6,    � Maximum$ 40Q�68   $��0,0,0,0q�6E   $	��100��6V   $��Center=�6b    � Value$ 10Q�6}    � SmallChange$ 1Q�6�    �� IsSnapToTickEnabled$
 True��6�    �� AutoToolTipPlacement$ TopLeft=�6�    �� AutoToolTipPrecision$ 0��6�   �� 5+      $��20��6   $��0,0,0,0q�6#   $��Center=�64   $��Stretch=�6O   5,      �� 5-   
   -   5         ��Name$ booksCvw��5-      $��2��6%   $��1��62   $��2��6B   $	��290��6S   $	��700��6`   $��0,5,0,0q�6o   ��5.      �� 5/      .R�50      �� $ 
Horizontal=�6!   $��0,5,0,5q�6:   .+�51      ��  ��Name$ thumbnaiMel��6    $��50��65   ��6@   �� *&$volumeInfo.imageLinks.smallThumbnail+�� 52      $ Vertical=�6%   $��10,5,0,5q�6<   .+�53      �� $��16(�6(   ��66   �� *volumeInfo.title+�� 54      $��12(�6(   ��66   �� *volumeInfo.authors[0]+55      56      57      59      �� 5:   
   -   5        $ searchParameterUriTbx��5:      $��4��61   $��1��6>   5;      5<      