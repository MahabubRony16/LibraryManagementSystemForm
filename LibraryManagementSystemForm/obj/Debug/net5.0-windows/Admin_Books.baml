   M S B A M L   `   `   `  ����V  RLibraryManagementSystemForm, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:LibraryManagementSystemFormLibraryManagementSystemForm  5      -    'LibraryManagementSystemForm.Admin_Books   5      W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ;local)clr-namespace:LibraryManagementSystemForm     5        N� Title$  Admin_Books��5	       N� 
Background
 �����.��5      �  � ColumnDefinitions 5   
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
Horizontal=�62   $	��600��6K   $��	0,10,0,10q�6W   .+�5%      �� -   5         ��Name$ searchCategoryCbx��5%      $��80��62   $��22��6=    �� SelectedIndex$ 0��6I   ���	#FF686868.@�5&      �� $��Title��6   �� 5'      $��Author��6   �� 5(      $��	Publisher��6   �� 5)      $��Genre��6   5*      �� 5+      -   5         ��Name$ 	searchTbx��5+      $	��300��6)   �� 5,      -   5         ��Name$ 	searchBtn��5,      $��Search��6(   $��70��69   $��10,0,0,0q�6D   6V   5.      &   System.Windows.Controls.DataGrid  5/   
   -   5        	  Name$	 allBooks��5/      $��2��6%   $��1��62   $	��600��6B   $	��280��6N   $��0,0,0,0q�6^   
   
IsReadOnly$

 True��6o      Columns 50      0  *System.Windows.Controls.DataGridTextColumn  51      ,  &System.Windows.Controls.DataGridColumn   Header$ Book ID��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 66   �� *BookId+  52      $
 Name��6%    63   �� *Name+  53      $ Author��6%    65   �� *Author+  54      $ 	Publisher��6%    68   �� *	Publisher+  55      $ Price��6%    64   �� *Price+  56      $ Genre��6%    64   �� *Genre+  57      $ Purchase Date��6%    6<   �� *PurchaseDate+  58      $ Total Quantitye��6%    6>   �� *TotalQuantity+  59      $ Available Quantity��6%    6A   �� *AvailableQuantity+5;      �� 5<   
   $ 
Horizontal=�6   $��3��6.   $��1��6;   $��Right=�6K   $��0,5,0,0q�6g   .+�5=      �� -   5        $ prevBtn��5=      $
��Prev��6&   $��40��65   $��0,0,0,0q�6@   6Q   �� 5>      -   5         ��Name$ 	pageNoTbl��5>      $��50��6+    �� TextAlignment$ Center=�66   �� 5?      -   5        $ nextBtn��5?      $
��Next��6&   $��40��65   $��0,0,0,0q�6@   6Q   5@      5A      5B      