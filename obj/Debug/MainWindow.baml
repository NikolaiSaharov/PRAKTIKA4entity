   M S B A M L   `   `   `  ����J  FPRAKTIKA4entity, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:PRAKTIKA4entityPRAKTIKA4entity  5   	        PRAKTIKA4entity.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:PRAKTIKA4entity     5   	     � Title$  
Passengers��5   	   $	��450��6   $	��800��6)   .��5	      �  � RowDefinitions 5
   
   �� 5      $	��60* �6   �� 5      $
��271* �6   �� 5      $	��14* �6   �� 5      $	��18* �6   �� 5      $��0* �6   �� 5      $	��73* �6    � ColumnDefinitions 5   
   �� 5      �� 5      .+�5   
   �� -   5         ��Name$ SearchClick��5   !   $��
ПОИСК��6   $
��Left=�66   $��
293,10,0,0q�6Q   $	��Top=�6e   $��37��6}   $��82��6�   $��1��6�   �� 5   
   -   5        $ 
ClearClick��5   $   $��ОЧИСТИТЬ��6   $
��Left=�68   $��
293,12,0,0q�6S   $	��Top=�6g   $��40��6   $��82��6�   $��1��6�   $��1��6�   �� 5   
   -   5         ��Name$ 
SearchName��5      $
��Left=�6&   $��	55,10,0,0q�6A    �� TextWrapping$
 Wrap=�6T   $�� ��6h   $	��Top=�6p   $	��602��6�   $��37��6�   $��2��6�   �� 5   
   -   5         ��Name$ 	FiltrName��5   -    �� DisplayMemberPath$ Class��6   $
��Left=�6@   $��	55,12,0,0q�6[   $	��Top=�6n   $	��602��6�   $��40��6�   $��1��6�   $��2��6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ PassengerGrid��5      $��200,67,200,14q�6*   $��1��6A   $��2��6N   $��2��6b   �� 5   
   -   5        $ TicketClick��5   "   $��Ticket��6   $��Center=�67   $��0,32,0,0q�6T   $	��Top=�6f   $��30��6~   $	��168��6�   $��5��6�   5      5       