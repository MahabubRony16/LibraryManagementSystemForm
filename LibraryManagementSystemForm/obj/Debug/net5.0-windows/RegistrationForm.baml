   M S B A M L   `   `   `  ����V  RLibraryManagementSystemForm, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:LibraryManagementSystemFormLibraryManagementSystemForm  5   	   2    ,LibraryManagementSystemForm.RegistrationForm   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ;local)clr-namespace:LibraryManagementSystemForm     5   	     � Title$  Library Management System��5   	   $	��450��6+   $	��380��68    � WindowStartupLocation$ CenterScreen=�6D   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $��20 �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��* �6   �� 5      $��20 �6    � RowDefinitions 5   
   �� 5      $��10 �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��* �6   �� 5       $��20 �6   .+�5"   
   �� $��1��6   $��1��6!   $��4��61   $��0,0,0,25q�6E   $��Sign Up��6W   $��25(�6f   $��Calibri)�6t    �� TextAlignment$ Center=�6�   $
��Bold"�6�   �� 5$   
   $��2��6   $��1��6!   $��0,5,0,5q�61   $��
First Name��6B   $��16(�6T   $��Centaur)�6b   �� 5%   
   -   5         ��Name$ firstNameTbx��5%      $��2��6(   $��2��65   $��0,5,0,5q�6E   $	��130��6V   $
��Left=�6b   �� 5&   
   $��3��6   $��1��6!   $��0,5,0,5q�61   $��	Last Name��6B   $��16(�6S   $��Centaur)�6a   �� 5'   
   -   5        $ lastNameTbx��5'      $��3��6'   $��2��64   $��0,5,0,5q�6D   $	��130��6U   $
��Left=�6a   �� 5(   
   $��4��6   $��1��6!   $��0,5,0,5q�61   $��Email��6B   $��16(�6O   $��Centaur)�6]   �� 5)   
   -   5        $ emailTbx��5)      $��4��6$   $��2��61   $��0,5,0,5q�6A   $	��200��6R   $
��Left=�6^   �� 5*   
   $��5��6   $��1��6!   $��0,5,0,5q�61   $��Contact��6B   $��16(�6Q   $��Centaur)�6_   �� 5+   
   -   5        $ 
contactTbx��5+      $��5��6&   $��2��63   $��0,5,0,5q�6C   $	��200��6T   $
��Left=�6`   �� 5,   
   $��6��6   $��1��6!   $��0,5,0,5q�61   $��Address��6B   $��16(�6Q   $��Centaur)�6_   �� 5-   
   -   5        $ 
addressTbx��5-      $��6��6&   $��2��63   $��0,5,0,5q�6C   $	��200��6T   $��60��6`   $
��Left=�6l   �� 5/   
   $��8��6   $��1��6!   $��2��61   $��	0,20,0,20q�6E   �� 50   
   $��9��6   $��1��6!   $��0,5,0,5q�61   $��Password��6B   $��16(�6R   $��Centaur)�6`   �� 51   
   -   5        $ passwordTbx��51      $��9��6'   $��2��64   $��0,5,0,5q�6D   $	��200��6U   $
��Left=�6a   �� 52   
   $��10��6   $��1��6"   $��0,5,10,5q�62   $��Confirm Password��6D   $��16(�6\   $��Centaur)�6j   �� 53   
   -   5        $ confirmPasswordTbx��53      $��10��6.   $��2��6<   $��0,5,0,5q�6L   $	��200��6]   $
��Left=�6i   �� 55   
   -   5         ��Name$ applyBtn��55      $��Apply��6#   $��11��63   $��2��6A   $��
120,20,0,0q�6Q   $��80��6e   $��25��6p   6|   56      57      