   M S B A M L   `   `   `  ����  Shop_Service    Shop_Service.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   b ^MaterialDesignThemes.Wpf, Version=4.0.0.2422, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	     � Title$   ��5   	   $	��600��6   $
��1024��6    � WindowStartupLocation$ CenterScreen=�6,    � 
ResizeMode$ NoResize=�6Q    � WindowStyle$
 None=�6g    � Icon$ MainIcon.png��6z   .��5	      � -   5        
������� � DataContext$ hello world��5	      .+�5
   
   �� .+�5      � ���#a6e6fc$
��Left=�6(   $��20��6C   $	��Top=�6O   $
��1024��6g   .+�5      �� -   5        $��0q�5      $��	999,0,0,0q�6%   $��25��5   F   ��6   Z� ��6/   Z� .��5      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ Close=�6.   
�������6;   5      �� 5      -   5        $��0q�5      $��	949,0,0,0q�6%   $��25��5   F   ��6   Z� ��6/   Z� .��5        $ WindowMinimize=�6.   
�������6D   5      5      � 5      ���#cff1fc$
��Left=�6(   $��35��6C   $	��Top=�6O   $
��1024��6g   $��0q�6t   .+�5      �� -   5        $��0q�5      $��
974,5,10,5q�6%   $��25��5   F   ��6   Z� ��6/   Z� .��5        $ Power=�6.   
�������6;   5      �� 5      $��0q�6   $��
924,5,10,5q�6%   $��25��5   F   ��6   Z� ��6/   Z� .��5        $ Settings=�6.   
�������6>   5      �� 5      $��0q�6   $��
874,5,10,5q�6%   $��25��5   F   ��6   Z� ��6/   Z� .��5         $ Notifications=�6.   
�������6C   5!      �� 5"      $��	100,0,0,0q�6   $
��50px��6+   $
��50px��68   6H   5$      5%      � 5&   
   ���#effafc$	��250��6$   $
��Left=�60   $��0,55,0,0q�6K   .+�5'      ?  9MaterialDesignThemes.Wpf.Transitions.TransitioningContent  -   5          Name$ MenuTransition��5'   2    K� ZIndex$ 1��6J   C  =MaterialDesignThemes.Wpf.Transitions.TransitioningContentBase	   OpeningEffect	 5(      D  >MaterialDesignThemes.Wpf.Transitions.TransitionEffectExtension  *SlideInFromLeft+
   Duration$
 0:0:0.2X�.��5)      � -   5         �Name$ 
GridCursor��5)   )   
����� �$��	0,100,0,0q�6=   $��10��6P   $��60��6[   $
��Left=�6g   $	��Top=�5*      5+      �� 5,       �� Orientation$ Vertical=�6   $��0, 100, 0, 0q�60   .+�5-      �� -   5        $��60��5-      $	��250��6)   $ 
Horizontal=�65   $
��Left=�6N   .+�51        $��20,0,0,0q�6.   $
 Shop=�6@   $��30��6L   $��30��6W   $��Center=�6c   �� 52      $��Center=�6    $
��Main��6;   $��26(�6G   $��10, 0, 0, 0q�6U   $��Calibri Bold)�6j   53      �� 54      -   5        $��60��54      $	��250��6)   $ 
Horizontal=�65   $
��Left=�6N   .+�58        $��20,0,0,0q�6.   $
 Home=�6@   $��30��6L   $��30��6W   $��Center=�6c   �� 59      $��Center=�6    $
��Shop��6;   $��26(�6G   $��10, 0, 0, 0q�6U   $��Calibri Bold)�6j   5:      �� 5;      -	   5        $��60��5;      $	��250��6)   $ 
Horizontal=�65   $
��Left=�6N   .+�5?        $��20,0,0,0q�6.   $ 	MapMarker=�6@   $��30��6Q   $��30��6\   $��Center=�6h   �� 5@      $��Center=�6    $��Stores��6;   $��26(�6I   $��10, 0, 0, 0q�6W   $��Calibri Bold)�6l   5A      �� 5B      -
   5        $��60��5B      $	��250��6)   $ 
Horizontal=�65   $
��Left=�6N   .+�5F        $��20,0,0,0q�6.   $
 Cart=�6@   $��30��6L   $��30��6W   $��Center=�6c   �� 5G      $��Center=�6    $
��Cart��6;   $��26(�6G   $��10, 0, 0, 0q�6U   $��Calibri Bold)�6j   5H      �� 5I      -   5        $��60��5I      $	��250��6)   $ 
Horizontal=�5J      $
��Left=�66   .+�5N        $��20,0,0,0q�6.   $ AboutCircle=�6@   $��30��6S   $��30��6^   $��Center=�6j   �� 5O      $��Center=�6    $��About��6;   $��26(�6H   $��10, 0, 0, 0q�6V   $��Calibri Bold)�6k   5P      5R      5x      � 5y   
   $	��774��6   $��250, 55, 0, 0q�6   
���**��6G   5z      5{      