   M S B A M L   `   `   `  ����R  NAutomated_Entrance_Exam, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullW0clr-namespace:Automated_Entrance_Exam.Pages.Main"Automated_Entrance_Exam.Pages.Main  5   	   -    'Automated_Entrance_Exam.Pages.Main.Main   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Blocal0clr-namespace:Automated_Entrance_Exam.Pages.Main     5   	   U QMaterialDesignThemes.Wpf, Version=2.3.1.953, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   -   5           MaterialDesignBody#���   5   	     MaterialDesignPaper#���  5   	   $��Medium"�5   	   $��14(�5   	   $X��Rpack://application:,,,/MaterialDesignThemes.Wpf;component/Resources/Roboto/#Roboto)�5   	     � Title$
  Main��5   	   $	��600��6   $	��800��6#    � WindowStartupLocation$ CenterScreen=�6/    � WindowState$ 	Maximized=�6T    � WindowStyle$
 None=�6l   .��5      �  � RowDefinitions 5   
   �� 5      $
��.15* �6   �� 5      $
��.85* �6   .+�5   
   � $��0��6   
����� �.+�5      ��  �� Orientation$ 
Horizontal=�6   $��Center=�62   .+�5      �� -   5         ��Name$ btn_Overview��5       
������ $	��150��5      $
��Auto��5      $��0q�5      $��18(�5      ��5"      �� 5#      .+�5$      �� $��40��6$   $��40��5%   $   $��/Assets/overview.png��5&   $   $��5q�5'   $   �� 5(      $��Overview��6(   $��5q�5)   (   5*      5,      �� 5.      -   5        $ btn_Examinees��53      
������ $	��150��5/      $
��Auto��50      $��0q�51      $��18(�52      ��55      �� 56      .+�57      �� $��40��6$   $��40��58   $   $��/Assets/examinees.png��59   $   $��5q�5:   $   �� 5;      $��	Examinees��6(   $��5q�5<   (   5=      5?      �� 5A      -   5        $ btn_Examinations��5F      
������ $	��150��5B      $
��Auto��5C      $��0q�5D      $��18(�5E      ��5H      �� 5I      .+�5J      �� $��40��6$   $��40��5K   $   $��/Assets/examinations.png��5L   $   $��5q�5M   $   �� 5N      $��Examinations��6(   $��5q�5O   (   5P      5R      �� 5S      -   5        $ btn_Settings��5X      
������ $	��150��5T      $
��Auto��5U      $��0q�5V      $��18(�5W      ��5Z      �� 5[      .+�5\      �� $��40��6$   $��40��5]   $   $��/Assets/settings.png��5^   $   $��5q�5_   $   �� 5`      $��Settings��6(   $��5q�5a   (   5b      5d      �� 5f      -   5        $ 
btn_Logout��5k      
������ $	��150��5g      $
��Auto��5h      $��0q�5i      $��18(�5j      ��5m      �� 5n      .+�5o      �� $��40��6$   $��40��5p   $   $��/Assets/logout.png��5q   $   $��5q�5r   $   �� 5s      $��Logout��6(   $��5q�5t   (   5u      5w      5x      5y      � 5{   
   $��1��6   .+�5|       � -   5          �Name$ f_Main��5|        � NavigationUIVisibility$ Hidden=�6$   5}      5~      5      