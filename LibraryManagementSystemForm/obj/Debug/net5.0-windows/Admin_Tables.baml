   M S B A M L   `   `   `  ����V  RLibraryManagementSystemForm, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:LibraryManagementSystemFormLibraryManagementSystemForm  5      .    (LibraryManagementSystemForm.Admin_Tables   5      W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ;local)clr-namespace:LibraryManagementSystemForm     5        N� 
Background
  ����� N� Title$ Admin_Tables��5	      .��5      �  � ColumnDefinitions 5   
   �� 5      $��10 �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��* �6   �� 5      $��10 �6    � RowDefinitions 5   
   �� 5      $��10 �6   �� 5      $
��auto �6   �� 5      $
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
��auto �6   �� 5!      $��* �6   �� 5"      $��10 �6   .+�5$   
   �� $��1��6   $��1��6"    �� Orientation$ 
Horizontal=�62   $	��600��6K   $��	0,10,0,10q�6W   .+�5%      �� -   5         ��Name$ tableContentTypeCbx��5%      $��80��64   $��22��6?    �� SelectedIndex$ 0��6K   $��0,0,60,0q�6]   
���   �.@�5&      �� $��Books��6   �� 5'      $��Users��6   �� 5(      $��Issues��6   5)      �� 5*      -   5        $ searchCategoryCbx��5*      $��80��62   $��22��6=   $ 0��6I   ���	#FF6868686r   �� 5+      -   5         ��Name$ 	searchTbx��5+      $	��300��6)   �� 5,      -   5         ��Name$ 	searchBtn��5,      $��Search��6(   $��70��69   $��10,0,0,0q�6D   6V   5-      &   System.Windows.Controls.DataGrid  5.   
   -   5        	  Name$	 contentTableDgr��5.      $��2��6,   $��1��69   $	��600��6I   $	��280��6X   $��0,0,0,0q�6h   
   
IsReadOnly$

 True��6y    � ContextMenu 5/      �� 50      .@�51      m� -   5         m�Name$ editItemMenu��51      $
��Edit��65   6C   m� 52      -   5        $ deleteItemMenu��52      $��Delete��67   6G   53      55      �� 56   
   $ 
Horizontal=�6   $��3��6.   $��1��6;   $��Right=�6K   $��0,5,0,0q�6g   .+�57      �� -   5        $ prevBtn��57      $
��Prev��6&   $��40��65   $��0,0,0,0q�6@   6Q   �� 58      -	   5         ��Name$ 	pageNoTbl��58      $��50��6+    �� TextAlignment$ Center=�66   �� 59      -
   5        $ nextBtn��59      $
��Next��6&   $��40��65   $��0,0,0,0q�6@   6Q   5:      5;      5<      