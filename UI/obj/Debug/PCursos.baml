   M S B A M L   `   `   `  ����  UI    
UI.PCursos   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5        N� Title$  PCursos��5      .��5
      �  � ColumnDefinitions 5   
   �� 5      $
��209* �6   �� 5      $
��209* �6   �� 5      $
��209* �6   �� 5      $
��209* �6    � RowDefinitions 5   
   �� 5      $	��44* �6   �� 5      $	��44* �6   �� 5      $	��44* �6   �� 5      $	��44* �6   �� 5      $
��300* �6   .+�5   
   �� $��0��6   $��4��6   $��Mantenimiento de Alumnos��61   $��20(�6T   $��Center=�6b   $��Center=�6   6�   �� 5   
   $��1��6   $��0��6   $��Nombre:��6-   $��Right=�6?   $��Center=�6[   6x   �� 5   
   $��1��6   $��2��6   $��Número de Créditos:��6-   $��Right=�6K   $��Center=�6g   6�   �� 5   
   -   5         ��Name$ 	txtNombre��5      $��1��6%   $��1��62   $��10q�6B   6P   �� 5   
   -   5        $ txtCreditos��5      $��1��6'   $��3��64   $��10q�6D   6R   �� 5    
   -   5         ��Name$ 
btnAgregar��5    a   $��3��6   $��3��6!   $��10q�6.   $��Agregar��6:   6w   �� 5!   
   -   5        $ btnEliminar��5!   g   $��0��6   $��3��6!   $��10q�6.   $��Eliminar��6:   6~   �� 5"   
   -   5        $ btnActualizar��5"   k   $��2��6   $��3��6!   $��10q�6.   $��
Actualizar��6:   6�   &   System.Windows.Controls.DataGrid  5#   
   -   5          Name$ dtgDatos��5#      $��4��6%   $��4��62   $��15q�6F      AutoGenerateColumns . 5%      5&      5'      