   M S B A M L   `   `   `  ����V  RLibraryManagementSystemForm, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:LibraryManagementSystemFormLibraryManagementSystemForm  5   	   U QSystem.Runtime, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3aO8clr-namespace:System.Collections;assembly=System.RuntimeSystem.Collections 5   	   ,    &LibraryManagementSystemForm.MainWindow   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ;local)clr-namespace:LibraryManagementSystemForm     5   	   PCollections8clr-namespace:System.Collections;assembly=System.Runtime     5   	     � Title$  Library Management System��5	   	   $	��450��6+   $	��800��68    � WindowStartupLocation$ CenterScreen=�6D   .��5
      �  � ColumnDefinitions 5   
   �� 5      $��20 �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��* �6   �� 5      $��20 �6    � RowDefinitions 5   
   �� 5      $��10 �6   �� 5      $
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
��auto �6   �� 5      $
��auto �6   �� 5       $��* �6   �� 5!      $��20 �6   .+�5#   
   �� $��1��6   $��1��6"    �� Orientation$ 
Horizontal=�62   .+�5$      �� -   5         ��Name$ homeBtn��5$      $
��Home��6&   $��80��65   $��5,0,5,0q�6@   �� 5%      -   5        $ registrationBtn��5%      $��Sign Up��6.   $��80��6@   $��5,0,5,0q�6K   6\   �� 5&      -   5        $ loginFormBtn��5&      $��Sign In��6+   $��80��6=   $��5,0,5,0q�6H   6Y   �� 5'      -   5        $ booksPageBtn��5'      $��Books��6+   $��80��6;   $��5,0,5,0q�6F   6W   �� 5(      -   5        $ adminAreaBtn��5(      $��
Admin Area��6+   $��80��6@   $��5,0,5,0q�6K   6\   �� 5)      -   5        $ googleBooksBtn��5)      $��Google Books��6-   $��80��6D   $��5,0,5,0q�6O   6`   5*       � 5+   
   -   5          �Name$ mainFrm��5+      $��2��6!   $��1��6.   $��10,0,0,0q�6>     � NavigationUIVisibility$ Hidden=�6P   5,      5-      