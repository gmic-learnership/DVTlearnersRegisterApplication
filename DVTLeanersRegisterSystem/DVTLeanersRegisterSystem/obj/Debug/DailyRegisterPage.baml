   M S B A M L   `   `   `  ����S  ODVTLeanersRegisterSystem, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:DVTLeanersRegisterSystemDVTLeanersRegisterSystem  5   	   0    *DVTLeanersRegisterSystem.DailyRegisterPage   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   8local&clr-namespace:DVTLeanersRegisterSystem     5   	     � Title$  DailyRegisterPage��5   	   $��438.735��6#   $��622.529��64   .��5
      � 
����  � � ColumnDefinitions 5   
   �� 5      $
��500* �6   �� 5      $	��17* �6   �� 5      $	��98* �6   .+�5   
   � 
�������$
��Left=�6"   $��48��6=   $	��Top=�6I   $	��615��6a   $��3��6m    5      �� 5      $	��62* �6#   �� 5      $	��57* �6#   .+�5      �� $��
10,0,192,1q�6   $��logo.png��6(   $
��Fill=�6:   5      � 5   
   
��� ���$
��Left=�6#   $��48��6>   $��	0,360,0,0q�6J   $	��Top=�6]   $	��615��6u   $��3��6�    5      �� 5      $	��62* �6#   �� 5      $	��57* �6#   5      (  "System.Windows.Controls.DatePicker  5   
   -   5          Name$ dtpDate��5      
������ $
��Left=�6?   $��
10,101,0,0q�6Z   $	��Top=�6n   $��35��6�   $��18(�6�   $	��179��6�   6�   �� 5    
   $��Daily Register��6   $
��Bold"�6)   $
��Left=�6;   $��
134,10,0,0q�6V   $	��Top=�6j   $	��111��6�   �� 5!   
   $��Date *��6   $��20(�6!   $
��Bold"�6/   $
��Left=�6A   $��	10,63,0,0q�6\   $	��Top=�6o   �� 5"   
   $��Mentor *��6   $��20(�6#   $
��Bold"�61   $
��Left=�6C   $��
10,147,0,0q�6^   $	��Top=�6r   $	��125��6�   �� 5#   
   -   5         ��Name$ cmbbxMentornames��5#      $
��Left=�6Q   $��
10,189,0,0q�6m   $	��Top=�6�   $	��179��6�   $��38��6�   ��6-   �� *mentorNames+6�   �� 5$   
   -   5         ��Name$ txtTrainingOn��5$       �� TextWrapping$
 Wrap=�6)   $
��Left=�6=   $��80��6X   $��
10,278,0,0q�6d    � ToolTip$/ )Commment on the training topic or content��6y   $	��Top=�6�   $	��179��6�   �� 5%   
   $��Training On��6   $��20(�6&   $
��Bold"�64   $
��Left=�6F   $��
10,241,0,0q�6a   $	��Top=�6u   $	��135��6�   �� 5&   
   -   5         ��Name$ 	btnCancel��5&      $��Cancel��6$   
������ $��20(�6O   $
��Bold"�6]   $
��Left=�6o   $��218,366,0,0q�6�   $	��Top=�6�   $	��130��6�   $��32��6�   6�   �� 5'   
   -   5        $ btnSave��5'      $
��Save��6"   
������ $��20(�6J   $
��Bold"�6X   $
��Left=�6j   $��473,366,0,0q�6�   $	��Top=�6�   $	��115��6�   $��32��6�   $��3��6�   &   System.Windows.Controls.DataGrid  5)   
   -   5          Name$ dtgNamesAndHours��5)      $
��Left=�6-   $��
206,63,0,0q�6H   $	��Top=�6\   $	��297��6t   $	��382��6�   	   AutoGenerateColumns	 .  $��20(�6�   $��3��6�   
   Columns
 5*      4  .System.Windows.Controls.DataGridComboBoxColumn  5+      -   5        Name��,  &System.Windows.Controls.DataGridColumn   Header$
 Name��5+   7      Width5  /System.Windows.Controls.DataGridLengthConverter$	 180 5,         DisplayMemberPath 6   �� *Name+   SelectedValueBinding 6>   �� *Name+ �� Mode$ TwoWay=�0  *System.Windows.Controls.DataGridTextColumn  5-      -   5        	Hours��$ Hours��5-   4   $	 180 6j   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6C   �� *Hours+$ TwoWay=�6j   5/      51      52      