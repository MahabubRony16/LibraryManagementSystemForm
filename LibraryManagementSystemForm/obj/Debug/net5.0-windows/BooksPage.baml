   M S B A M L   `   `   `  ����V  RLibraryManagementSystemForm, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:LibraryManagementSystemFormLibraryManagementSystemForm  5      '    !LibraryManagementSystemForm.Books   5      W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ;local)clr-namespace:LibraryManagementSystemForm     5      9data(using:LibraryManagementSystemForm.Models     5        N� Title$  Books��5
       N� 
Foreground
 �   � N� 
Background
 �����.��5      �  � ColumnDefinitions 5   
   �� 5      $��20 �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��* �6   �� 5      $��20 �6    � RowDefinitions 5   
   �� 5      $��10 �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5       $
��auto �6   �� 5!      $
��auto �6   �� 5"      $
��auto �6   �� 5#      $
��auto �6   �� 5$      $��* �6   �� 5%      $��20 �6   .+�5/   
   �� $��1��6   $��1��6"    �� Orientation$ 
Horizontal=�62   $	��500��6K   $��0,10,0,0q�6W   .+�50      �� -   5         ��Name$ searchCategoryCbx��50      $��80��62   $��22��6=    �� SelectedIndex$ 0��6I   ���	#FF686868.@�51      �� $��Title��6   �� 52      $��Author��6   �� 53      $��	Publisher��6   �� 54      $��Genre��6   55      �� 56      -   5         ��Name$ 	searchTbx��56      $	��340��6)   �� 57      -   5        	 ��Name$	 	searchBtn��57      $��Search��6(   $��70��69   $��10,0,0,0q�6D   6V   58      �� 59   
   -   5        
 ��Name$
 booksCvw��59      $��2��6%   $��1��62   $��2��6B   $	��500��6S   $	��290��6_   $��0,5,0,0q�6l   ��5:      �� 5;      .R�5<      �� $ Vertical=�6!   $��0,5,0,5q�68   .+�5=      �� $��16(�6$   ��62   �� *Name+�� 5>      $��12(�6$   ��62   �� *Author+5?      5@      5B      �� 5C   
   $��2��6   $��2��6"   $	��200��62   $	��100��6>   $��	20,20,0,0q�6K   $	��Top=�6^   .+�5D      �� -   5         ��Name$ detailNameTbl��5D      $��18(�6/   $��Stretch=�6=    �� TextAlignment$ Center=�6[   $
��Bold"�6r   $
��Wrap=�6�   �� 5E      -   5        $ detailAuthorTbl��5E      $��16(�61   $��Stretch=�6?   $ Center=�6]   $
��Wrap=�6t   �� 5F      -   5        $ detailPublisherTbl��5F      $��0,10,0,0q�64   $��13(�6F   $��Stretch=�6T   $ Center=�6r   �� 5G      -   5        $ detailGenreTbl��5G      $��13(�60   $��Stretch=�6>   $ Center=�6\   5H      �� 5I   
   $��3��6   $��2��6"   $��30,0,0,0q�62   $ Vertical=�6D   .+�5J      �� -	   5        $	 issueBookBtn��5J      $��
Issue Book��6+   $	��150��6@   $��35��6L   $��0,5,0,5q�6X   $��14(�6i   6w   5K      �� 5L   
   $��4��6   $��1��6"   $ 
Horizontal=�62   $��Center=�6K   $��0,5,0,0q�6h   .+�5M      �� -
   5        $	 prevBtn��5M      $��Previous��6&   $��60��69   $��0,0,5,0q�6D   6U   �� 5N      -   5        $ 	pageNoTbl��5N      $��60��6+   $ Center=�66   $
��Bold"�6M   �� 5O      -   5        $	 nextBtn��5O      $
��Next��6&   $��60��65   $��5,0,0,0q�6@   6Q   5P      5Q      5R      