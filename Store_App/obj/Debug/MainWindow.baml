   M S B A M L   `   `   `  ����D  @Store_App, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:Store_App	Store_App  5   	       Store_App.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:Store_App     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $��* �6   �� 5      $	��12* �6   �� 5      $	��12* �6   �� 5      $	��12* �6   �� 5      $	��12* �6   �� 5      $	��12* �6   �� 5      $	��12* �6   �� 5      $	��12* �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��4* �6   �� 5      $��4* �6   �� 5      $��4* �6   �� 5      $��4* �6   �� 5      $��4* �6   �� 5      $��4* �6   �� 5      $��4* �6   �� 5      $��4* �6   �� 5       $��4* �6   �� 5!      $��4* �6   �� 5"      $��4* �6   �� 5#      $��4* �6   �� 5$      $��4* �6   �� 5%      $��4* �6   �� 5&      $��4* �6   �� 5'      $��* �6   .+�5)   
   �� $��1��6   $��1��6!   $��16(�61   $��	For Sale:��6@   $��Center=�6S   $��Right=�6n   �� 5*   
   $��1��6   $��8��6!   $��16(�61   $��Shopping Cart:��6@   $��Center=�6X   $��Right=�6s   &   System.Windows.Controls.DataGrid  5+   
   -   5        $
��shop��5+      $��2��6   $��2��6/   $��3��6<   $��10��6P      AutoGenerateColumns .     Columns 5,      0  *System.Windows.Controls.DataGridTextColumn  5-      ,  &System.Windows.Controls.DataGridColumn   Header$
 Item��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$
 auto 6]   1  +System.Windows.Controls.DataGridBoundColumn   Binding 63   �� *
LastName+ �� Mode$ OneWay=�6]     5.      $ Price��6%   $
 auto 6_    64   �� *	FirstName+$ OneWay=�6_     5/      $ Serial Numbert��6%   $
 auto 6k    6=   �� *EmployeeType+$ OneWay=�6k   51        52   
   -   5        $��shop1��52      $��2��6    $��1��60   $��3��6=   $��10��6Q    .   53        54      $
 Item��6%   $
 auto 6]    63   �� *
LastName+$ OneWay=�6]     55      $ Price��6%   $
 auto 6_    64   �� *	FirstName+$ OneWay=�6_     56      $ Serial Numbert��6%   $
 auto 6k    6=   �� *EmployeeType+$ OneWay=�6k   58      5<      5=      