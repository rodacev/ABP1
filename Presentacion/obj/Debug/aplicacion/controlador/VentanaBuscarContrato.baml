   M S B A M L   `   `   `  ����G  CPresentacion, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullY1clr-namespace:Presentacion.aplicacion.controlador#Presentacion.aplicacion.controlador  5   	   ?    9Presentacion.aplicacion.controlador.VentanaBuscarContrato   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Clocal1clr-namespace:Presentacion.aplicacion.controlador     5   	     � Title$  VentanaBuscarContrato��5   	   $	��450��5	   	   $	��800��5
   	    � WindowStartupLocation$ CenterOwner=�5   	    � WindowStyle$
 None=�5   	    � 
ResizeMode$ NoResize=�5   	    � 	Resources 5         FocusVisual �� Property �� Value J� SnapsToDevicePixels �� StrokeDashArray  Button.Static.Background	 �� Color  Button.Static.Border 	 close
 �� ImageSource j� Stretch  Button.MouseOver.Border  Button.Pressed.Border  Button.Disabled.Background  Button.Disabled.Border  Button.Disabled.Foreground 	 
closeStyle �� 
TargetType �� 
TargetType ��Name ��Name �� Triggers P� Property P� Value �� 
TargetName 
 guardar  guardarStyle��%�  &	        &	 �     &	 �     &	 �     &	 X    &	 {    &	 �    &	 �    &	 �    &		     7   7  7  7  7  7  7  7  7  7  &	
 �    &	      7   7  7  7 
 7  7 
 7  7  7  7  �� 5   
   .�5      ��  � �� 5      �� 5      .R�5      �� $��2q�6$    . #��� ��6J   $��1��6�   $	 1 2R�6�   5      5      5      �� 5   
   $	 	#FFDDDDDD��6;   �� 5   
   $	 	#FF707070��67   �� 5   
   $A
 ;/Presentacion;component/aplicacion/imagenes/close_hover.png��6#   $ Uniform=�6m   �� 5   
   $	 	#FF3C7FB1��6:   �� 5   
   $	 	#FF2C628B��68   �� 5   
   $	 	#FFF4F4F4��6=   �� 5   
   $	 	#FFADB2B5��69   �� 5    
   $	 	#FF838383��6=   �� 5!   
   " ��6#   .�5"      ��  �@�FocusVisualStyle8   61   �� 5#       � ��8  6+   �� 5$       � ��8  6,   �� 5%       � ��# � ��6+   �� 5&       � ��$ 1q�60   �� 5'       � ��$ Center=�6;   �� 5(       � ��$ Center=�69   �� 5)       � ��$ 1q�6(   �� 5*       � �� 5+      �� 5,      " ��6&   .R�5-      �� $ border��6!   #��z��61   #��z��6]   #��z��6�    . $��0,0,0.4,0.4q�6�   ._�5.      �� $ contentPresenter��6/   |�.  #��z��6[   #��z��6�   ��. # z 6�   #��z��6  5/       50      P� 51       �@��IsDefaulted . . �52   "   �� $ border��6@   # � ��6T    � ��53      P� 54       �@J�IsMouseOver . . �55   "   �� $ border��6?   8   � ��6S   �� 56   "   $ border��6@   8   � ��6T   57      P� 58       � �� . . �59   "   �� $ border��6?   8   � ��6S   �� 5:   "   $ border��6@   8   � ��6T   5;      P� 5<       � {� .  . �5=   "   �� $ border��6?   8   � ��6S   �� 5>   "   $ border��6@   8   � ��6T   �� 5?   "   $ contentPresenter��6K   8 	  � ��6i   5@      5B      5D      5E      �� 5F   
   $	 #72a951��6*   �� 5G   
   " ��6%   .�5H      ��  �@�FocusVisualStyle8   61   �� 5I       � ��8  6+   �� 5J       � ��8  6,   �� 5K       � ��# � ��6+   �� 5L       � ��$ 1q�60   �� 5M       � ��$ Center=�6;   �� 5N       � ��$ Center=�69   �� 5O       � ��$ 1q�6(   �� 5P       � �� 5Q      �� 5R      " ��6&   .R�5S      �� $ border��6!   #��z��61   #��z��6]   #��z��6�    . ._�5T      �� $ contentPresenter��6/   |�.  #��z��6[   #��z��6�   ��. # z 6�   #��z��6  5U       5V      P� 5W       �@��IsDefaulted . . �5X   "   �� $ border��6@   # � ��6T    � ��5Y      P� 5Z       �@J�IsMouseOver . . �5[   "   �� $ border��6?   8   � ��6S   �� 5\   "   $ border��6@   8   � ��6T   5]      P� 5^       � �� . . �5_   "   �� $ border��6?   8   � ��6S   �� 5`   "   $ border��6@   8   � ��6T   5a      P� 5b       � {� .  . �5c   "   �� $ border��6?   8   � ��6S   �� 5d   "   $ border��6@   8   � ��6T   �� 5e   "   $ contentPresenter��6K   8 	  � ��6i   5f      5h      5j      5k      5l      .��5m      � ��5n   
   �� 5o      $K
 E/Presentacion;component/aplicacion/imagenes/logo_white_background.jpg��6   $ Uniform=�6m    �� Opacity$	 0.2Q�6   .+�5s   
   �� -   5         ��Name$ 	btn_close��5s      $��770,0,0,419.6q�6$   $��0q�6;   #��� 	 6O    J� RenderTransformOrigin$ 0.333,0.733&�6�   $��30��6�   $��Bottom=�6�   $
��Left=�6�   $��30��6�   ��5t      �� 5u      $C
 =/Presentacion;component/aplicacion/imagenes/close_default.png��6   $ Uniform=�6i   5w      &   System.Windows.Controls.DataGrid  5y   
   -   5          Name$ dtg_contratos��5y      $
��Left=�6*   $	��253��6E   $��
10,150,0,0q�6R   $	��Top=�6f   $	��780��6~   
������    AutoGenerateColumns .     
IsReadOnly . ��5z   A   �� *	Coleccion+   Columns 5{      0  *System.Windows.Controls.DataGridTextColumn  5|      ,  &System.Windows.Controls.DataGridColumn   Header$ ID CONTRATO��6%      
Foreground
 �  ��   
FontWeight$
 Bold"�6K   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6]   �� *
IdContrato+  5}      $ RUT CLIENTE��6%    6:   �� *	Cliente+  5~      $ TIPO EVENTO��6%    6:   �� *
TipoEvento+  5      $ CREADO��6%    65   �� *FechaCreacion+  5�      $ FECHA INICIO��6%    6;   �� *FechaHoraInicio+  5�      $ FECHA TÉRMINO��6%    6<   �� *FechaHoraTermino+  5�      $ 
UBICACIÓN��6%    68   �� *	Direccion+  5�      $
 OBS.��6%    63   �� *Observaciones+  5�      $ ESTADO��6%   $
 Bold"�65    6G   �� *Estado+  5�      $ FECHA CIERRE��6%    6;   �� *FechaTermino+  5�      $ 
ASISTENTES��6%    69   �� *	Asistente+  5�      $ TOTAL EVENTO (UF)��6%    6@   �� *
ValorTotal+5�      �� 5�   
   -   5        $ btn_finalizar��5�      $��FINALIZAR CONTRATO��6(   $
��Left=�6E   $��620,410,0,0q�6`   $	��Top=�6u   $	��170��6�   $��0q�6�   
����������	#FF9E0FBF$��30��6�   #���  6�   $
��Bold"�6
  6  	� 5�   
   -   5         	�Name$ rb_id_contrato��5�      $��NRO. CONTRATO��6.   $
��Left=�6F   $��	13,63,0,0q�6a   $	��Top=�6t   $��14(�6�   6�   �� 5�   
   -   5          ��Name$  txt_id_contrato��5�      $
��Left=�6+   $��23��6F   $��
163,60,0,0q�6R   ! �� TextWrapping$
! Wrap=�6f   $	��Top=�6z   $	��120��6�   	� 5�   
   -   5        $ rb_rut_cliente��5�      $��RUT CLIENTE��6.   $
��Left=�6D   $��	13,91,0,0q�6_   $	��Top=�6r   $��14(�6�   6�   �� 5�   
   -   5        $  txt_rut_cliente��5�      $
��Left=�6+   $��23��6F   $��
163,87,0,0q�6R   $
! Wrap=�6f   $	��Top=�6z   $	��120��6�   	� 5�   
   -   5        $ rb_tipo_evento��5�      $��TIPO EVENTO��6.   $
��Left=�6D   $��
13,118,0,0q�6_   $	��Top=�6s   $��14(�6�   6�   �� 5�   
   -	   5        " ��Name$" cmb_tipo_evento��5�      $
��Left=�6,   $��163,115,0,0q�6G   $	��Top=�6\   $	��120��6t   # �� Text$# -- Seleccione --��6�   $ �� 
IsEditable$ . % �� 
IsReadOnly% . 6�   �� 5�   
   -
   5        $ 
btn_buscar��5�      $��BUSCAR��6%   $
��Left=�66   $��
326,85,0,0q�6Q   $	��Top=�6e   $	��100��6}   $��30��6�   $��0q�6�   
����������	#FF9E0FBF#���  6�   $
��Bold"�6�   6  �� 5�   
   $��BUSCAR CONTRATO��6   $
��Left=�6*   $��	10,10,0,0q�6E   $	��Top=�6X   $��18(�6p   
�������$
��Bold"�6�   5�      5�      