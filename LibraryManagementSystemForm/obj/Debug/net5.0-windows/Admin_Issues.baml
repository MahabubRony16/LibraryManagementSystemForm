   M S B A M L   `   `   `  ����V  RLibraryManagementSystemForm, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:LibraryManagementSystemFormLibraryManagementSystemForm  5      .    (LibraryManagementSystemForm.Admin_Issues   5      W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ;local)clr-namespace:LibraryManagementSystemForm     5        N� Title$  Admin_Books��5	       N� 
Background
 �����.��5      �  � ColumnDefinitions 5   
   �� 5      $��30 �6   �� 5      $	��100 �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��* �6   �� 5      $��10 �6    � RowDefinitions 5   
   �� 5      $��20 �6   �� 5      $
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
��auto �6   �� 5$      $��* �6   �� 5%      $��10 �6   .+�5)   
   �� $��1��6   $��1��6!   $��0,5,0,5q�61   $��Issue ID��6B   $��16(�6R   $��Centaur)�6`   �� 5*   
   -   5         ��Name$ 
issueIdTbx��5*      $��1��6&   $��2��63   $��0,5,0,5q�6C   $	��130��6T   $
��Left=�6`   �� 5,   
   $��2��6   $��1��6!   $��0,5,0,5q�61   $��Book ID��6B   $��16(�6Q   $��Centaur)�6_   �� 5-   
   -   5        $ 	bookIdTbx��5-      $��2��6%   $��2��62   $��0,5,0,5q�6B   $	��250��6S   $
��Left=�6_    �� TextWrapping$
 Wrap=�6z   �� 5/   
   $��3��6   $��1��6!   $��0,5,0,5q�61   $��User ID��6B   $��16(�6Q   $��Centaur)�6_   �� 50   
   -   5        $ 	userIdTbx��50      $��3��6%   $��2��62   $��0,5,0,5q�6B   $	��250��6S   $
��Left=�6_   �� 52   
   $��4��6   $��1��6!   $��0,5,0,5q�61   $��
Issue Date��6B   $��16(�6T   $��Centaur)�6b   (  "System.Windows.Controls.DatePicker  53   
   -   5        $��issueDateDpc��53   j   $��4��6   $��2��6"   $��23��62   $
��Left=�6>   $��0,0,0,0q�6Y   $��Center=�6~   $	��105��6�   �� 55   
   $��5��6   $��1��6!   $��0,5,0,5q�61   $��Return Date��6B   $��16(�6U   $��Centaur)�6c     56   
   -   5        $��returnDateDpc��56   j   $��5��6   $��2��6"   $��23��62   $
��Left=�6>   $��0,0,0,0q�6Y   $��Center=�6   $	��105��6�   �� 58   
   $��9��6   $��1��6"   $��0,20,0,0q�62    �� Orientation$ 
Horizontal=�6D   $��2��6]   .+�59      �� -   5         ��Name$ addIssueBtn��59      $��	Add Issue��6*   $��80��6>   $��25��6I   $��0,0,5,0q�6U   6f   �� 5:      -   5        $ editIssueBtn��5:      $��
Edit Issue��6+   $��80��6@   $��25��6K   $��5,0,5,0q�6W   6h   �� 5;      -   5        $ deleteIssueBtn��5;      $��Delete Issue��6-   $��80��6D   $��25��6O   $��5,0,5,0q�6[   6l   5<      5=      5>      