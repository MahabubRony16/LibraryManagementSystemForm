   M S B A M L   `   `   `  ����V  RLibraryManagementSystemForm, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:LibraryManagementSystemFormLibraryManagementSystemForm  5      2    ,LibraryManagementSystemForm.RegistrationPage   5      W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ;local)clr-namespace:LibraryManagementSystemForm     5        N� Title$  RegistrationPage��5	       N� 
Foreground
 �   � N� 
Background
 �����.��5      �  � ColumnDefinitions 5   
   �� 5      $��20 �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��* �6   �� 5      $��20 �6    � RowDefinitions 5   
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
��auto �6   �� 5!      $��* �6   �� 5"      $��20 �6   .+�5$   
   �� $��1��6   $��1��6!   $��4��61   $��0,0,0,25q�6E   $��Registration��6W   $��25(�6k   $��Calibri)�6y    �� TextAlignment$ Center=�6�   $
��Bold"�6�   �� 5&   
   $��2��6   $��1��6!   $��0,5,0,5q�61   $��
First Name��6B   $��16(�6T   $��Centaur)�6b   �� 5'   
   -   5         ��Name$ firstNameTbx��5'      $��2��6(   $��2��65   $��0,5,0,5q�6E   $	��130��6V   $
��Left=�6b   �� 5(   
   $��3��6   $��1��6!   $��0,5,0,5q�61   $��	Last Name��6B   $��16(�6S   $��Centaur)�6a   �� 5)   
   -   5        $ lastNameTbx��5)      $��3��6'   $��2��64   $��0,5,0,5q�6D   $	��130��6U   $
��Left=�6a   �� 5*   
   $��4��6   $��1��6!   $��0,5,0,5q�61   $��Email��6B   $��16(�6O   $��Centaur)�6]   �� 5+   
   -   5        $ emailTbx��5+      $��4��6$   $��2��61   $��0,5,0,5q�6A   $	��200��6R   $
��Left=�6^   �� 5,   
   $��5��6   $��1��6!   $��0,5,0,5q�61   $��Contact��6B   $��16(�6Q   $��Centaur)�6_   �� 5-   
   -   5        $ 
contactTbx��5-      $��5��6&   $��2��63   $��0,5,0,5q�6C   $	��200��6T   $
��Left=�6`   �� 5.   
   $��6��6   $��1��6!   $��0,5,0,5q�61   $��Address��6B   $��16(�6Q   $��Centaur)�6_   �� 5/   
   -   5        $ 
addressTbx��5/      $��6��6&   $��2��63   $��0,5,0,5q�6C   $	��200��6T   $��60��6`   $
��Left=�6l   �� 51   
   $��8��6   $��1��6!   $��0,5,0,5q�61   $��Password��6B   $��16(�6R   $��Centaur)�6`   �� 52   
   -   5        $ passwordTbx��52      $��8��6'   $��2��64   $��0,5,0,5q�6D   $	��200��6U   $
��Left=�6a   �� 53   
   $��9��6   $��1��6!   $��0,5,10,5q�61   $��Confirm Password��6C   $��16(�6[   $��Centaur)�6i   �� 54   
   -   5        $ confirmPasswordTbx��54      $��9��6.   $��2��6;   $��0,5,0,5q�6K   $	��200��6\   $
��Left=�6h   �� 56   
   -   5         ��Name$ applyBtn��56      $��Apply��6#   $��10��63   $��2��6A   $��
120,20,0,0q�6Q   $��80��6e   $��25��6p   57      58      