   M S B A M L   `   `   `  ����  UserInterface    UserInterface.ProductList   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2006     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      -   5          �Name$  Window��5       � Title$ Product List��5
      $	��640��5      $	��480��6   ���#F8F8F8$��Segoe UI)�5      .��5      � -   5         �Name$ 
LayoutRoot��5       � RowDefinitions 5   
   �� 5      $��55 �6   �� 5      $��90 �6   �� 5      $��* �6   �� 5      $��35 �6   .+�5   
   �� $��0��6   $��Segoe)�6   $
��Bold"�60   $��42(�6B   ���#555$��10,2,0,2q�6b   $��Stretch=�6t   $��Stretch=�6�   $��Adventure Works��6�   �� 5   
   $��	10,8,10,0q�6   $��1��6&   $��Search Product��63   .��5      � .+�5      �� $��Product Name��6   ���	#FF555555$��109.02��6F   $
��Bold"�6U   $
��Left=�6g   $��	10,29,0,0q�6�   $	��Top=�6�   �� 5      $��Product Category��6   ���	#FF555555$��109.02��6J   $
��Bold"�6}   $
��Left=�6�   $��10,0.08,0,21q�6�   �� 5      -   5         ��Name$ CategoryComboBox��5       �� DisplayMemberPath$
 Name��6l   $��1��6�   $��153,4.08,285,31q�6�   �� 5      -   5         ��Name$ NameTextBox��5   6   $�� ��6    �� TextWrapping$
 Wrap=�6"   $��2��6K   $��153,31,285,3q�6X   �� 5      -   5        $��Search��5      $��80��6*   $��3��6N   $��Right=�6�   $��	0,0,199,5q�6�   $��Bottom=�6�   $��20��6�   5       5!      �� 5&   
   -   5         ��Name$ ProductsListView��5&      $��2��6-   $��
10,12,10,8q�6;   $
��Auto��6O   $��Stretch=�6\   $
��Auto��6z   $��Stretch=�6�   	 �� View	 5'      �� 5(      .P�5)      �� $��Product Number��6%   
 �� DisplayMemberBinding
 6=   ��  �� Path$ ProductNumber��� 5*      $
��Name��6%   
 63   �� $
 Name��� 5+      $��Category��6%   
 67   �� $ ProductCategory.Name��� 5,      $��	ListPrice��6%   
 68   �� $ 	ListPrice��� 5-      $��Color��6%   
 64   �� $ Color��� 5.      $
��Size��6%   
 63   �� $
 Size��� 5/      $��Weight��6%   
 65   �� $ Weight�50      52      �� 54   
   -   5         ��Name$ btnNewProduct��54   M   $��3��6   $��Right=�6   $��	0,0,120,8q�6:   $��Bottom=�6�   $	��100��6�   $��New Product��6�   �� 55   
   -   5        $ btnDeleteProduct��55   ?   $��Right=�6   $��0,0,10,8q�6-   $	��100��6Y   $��3��6e   $��Bottom=�6�   $��Delete Product��6�   57      58      