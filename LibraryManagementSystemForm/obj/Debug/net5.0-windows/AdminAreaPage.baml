   M S B A M L   `   `   `  ����V  RLibraryManagementSystemForm, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:LibraryManagementSystemFormLibraryManagementSystemForm  5      /    )LibraryManagementSystemForm.AdminAreaPage   5      W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ;local)clr-namespace:LibraryManagementSystemForm     5        N� Title$  AdminAreaPage��5	       N� 
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
   �� $��1��6   $��1��6"   $	��100��62    �� Orientation$ Vertical=�6>   $��0,15,0,0q�6U   .+�5%      �� -   5         ��Name$ showBooksBtn��5%      $��Tables��6+   $��20��6<   $��0,5,0,5q�6H   6Y   �� 5&      -   5        $ addBooksBtn��5&      $��Add Book��6*   $��20��6=   $��0,5,0,5q�6I   6Z   �� 5'      -   5        $ showIssuesBtn��5'      $��	Edit User��6,   $��20��6@   $��0,5,0,5q�6L   6]   �� 5(      -   5        $ taskBtn��5(      $��Add/Edit Issue��6&   $��20��6?   $��0,5,0,5q�6K   6\   5)      �� 5*   
   $��1��6   $��2��6"   .+�5+       � -   5          �Name$ adminFrm��5+        � NavigationUIVisibility$ Hidden=�6&   5,      5-      5.      