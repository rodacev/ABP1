   M S B A M L   `   `   `  ����G  CPresentacion, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullY1clr-namespace:Presentacion.aplicacion.controlador#Presentacion.aplicacion.controlador  5   	   >    8Presentacion.aplicacion.controlador.VentanaBuscarCliente   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Clocal1clr-namespace:Presentacion.aplicacion.controlador     5   	     � Title$  VentanaBuscarCliente��5   	   $	��450��5	   	   $	��800��5
   	    � WindowStartupLocation$ CenterScreen=�5   	    � WindowStyle$
 None=�5   	    � 
ResizeMode$ NoResize=�5   	    � 	Resources 5         FocusVisual �� Property �� Value J� SnapsToDevicePixels �� StrokeDashArray  Button.Static.Background	 �� Color  Button.Static.Border 	 close
 �� ImageSource j� Stretch  Button.MouseOver.Border  Button.Pressed.Border  Button.Disabled.Background  Button.Disabled.Border  Button.Disabled.Foreground 	 
closeStyle �� 
TargetType �� 
TargetType ��Name ��Name �� Triggers P� Property P� Value �� 
TargetName 
 guardar  guardarStyle��%r  &	        &	 �     &	 �     &	 �     &	 X    &	 {    &	 �    &	 �    &	 �    &		     7   7  7  7  7  7  7  7  7  7  &	
 �    &	 �    7   7  7  7 
 7  7 
 7  7  7  7  �� 5   
   .�5      ��  � �� 5      �� 5      .R�5      �� $��2q�6$    . #��� ��6J   $��1��6�   $	 1 2R�6�   5      5      5      �� 5   
   $	 	#FFDDDDDD��6;   �� 5   
   $	 	#FF707070��67   �� 5   
   $A
 ;/Presentacion;component/aplicacion/imagenes/close_hover.png��6#   $ Uniform=�6m   �� 5   
   $	 	#FF3C7FB1��6:   �� 5   
   $	 	#FF2C628B��68   �� 5   
   $	 	#FFF4F4F4��6=   �� 5    
   $	 	#FFADB2B5��69   �� 5!   
   $	 	#FF838383��6=   �� 5"   
   " ��6#   .�5#      ��  �@�FocusVisualStyle8   61   �� 5$       � ��8  6+   �� 5%       � ��8  6,   �� 5&       � ��# � ��6+   �� 5'       � ��$ 1q�60   �� 5(       � ��$ Center=�6;   �� 5)       � ��$ Center=�69   �� 5*       � ��$ 1q�6(   �� 5+       � �� 5,      �� 5-      " ��6&   .R�5.      �� $ border��6!   #��z��61   #��z��6]   #��z��6�    . ._�5/      �� $ contentPresenter��6/   |�.  #��z��6[   #��z��6�   ��. # z 6�   #��z��6  50       51      P� 52       �@��IsDefaulted . . �53   "   �� $ border��6@   # � ��6T    � ��54      P� 55       �@J�IsMouseOver . . �56   "   �� $ border��6?   8   � ��6S   �� 57   "   $ border��6@   8   � ��6T   58      P� 59       � �� . . �5:   "   �� $ border��6?   8   � ��6S   �� 5;   "   $ border��6@   8   � ��6T   5<      P� 5=       � {� .  . �5>   "   �� $ border��6?   8   � ��6S   �� 5?   "   $ border��6@   8   � ��6T   �� 5@   "   $ contentPresenter��6K   8 	  � ��6i   5A      5C      5E      5F      �� 5G   
   $	 #72a951��6*   �� 5H   
   " ��6%   .�5I      ��  �@�FocusVisualStyle8   61   �� 5J       � ��8  6+   �� 5K       � ��8  6,   �� 5L       � ��# � ��6+   �� 5M       � ��$ 1q�60   �� 5N       � ��$ Center=�6;   �� 5O       � ��$ Center=�69   �� 5P       � ��$ 1q�6(   �� 5Q       � �� 5R      �� 5S      " ��6&   .R�5T      �� $ border��6!   #��z��61   #��z��6]   #��z��6�    . ._�5U      �� $ contentPresenter��6/   |�.  #��z��6[   #��z��6�   ��. # z 6�   #��z��6  5V       5W      P� 5X       �@��IsDefaulted . . �5Y   "   �� $ border��6@   # � ��6T    � ��5Z      P� 5[       �@J�IsMouseOver . . �5\   "   �� $ border��6?   8   � ��6S   �� 5]   "   $ border��6@   8   � ��6T   5^      P� 5_       � �� . . �5`   "   �� $ border��6?   8   � ��6S   �� 5a   "   $ border��6@   8   � ��6T   5b      P� 5c       � {� .  . �5d   "   �� $ border��6?   8   � ��6S   �� 5e   "   $ border��6@   8   � ��6T   �� 5f   "   $ contentPresenter��6K   8 	  � ��6i   5g      5i      5k      5l      5m      .��5n      � ��5o   
   �� 5p      $K
 E/Presentacion;component/aplicacion/imagenes/logo_white_background.jpg��6   $ Uniform=�6m    �� Opacity$	 0.2Q�6   .+�5s   
   	� -   5         	�Name$ rb_rut��5s      $	��RUT��6&   $
��Left=�64   $��	22,63,0,0q�6O   $	��Top=�6b   $��14(�6z   6�   �� 5t   
   -   5         ��Name$ txt_rut��5t      $
��Left=�6#   $��23��6>   $��
127,58,0,0q�6J    �� TextWrapping$
 Wrap=�6^   $	��Top=�6r   $	��120��6�   	� 5u   
   -   5        $ rb_actividad��5u      $��	ACTIVIDAD��6,   $
��Left=�6@   $��	22,91,0,0q�6[   $	��Top=�6n   $��14(�6�   6�   �� 5v   
   -   5         ��Name$ cmb_actividad��5v      $
��Left=�6*   $��
127,86,0,0q�6E   $	��Top=�6Y   $	��120��6q    �� Text$ -- Seleccione --��6}    �� 
IsEditable .  �� 
IsReadOnly . 6�   	� 5w   
   -   5        $ rb_tipo��5w      $
��TIPO��6'   $
��Left=�66   $��
22,118,0,0q�6Q   $	��Top=�6e   $��14(�6}   6�   �� 5x   
   -   5        $ cmb_tipo��5x      $
��Left=�6%   $��127,113,0,0q�6@   $	��Top=�6U   $	��120��6m   $ -- Seleccione --��6y    .  . 6�   &   System.Windows.Controls.DataGrid  5z   
   -   5          Name$ dtg_clientes��5z      $
��Left=�6)   $	��245��6D   $��
10,150,0,0q�6Q   $	��Top=�6e   $	��380��6}   
������    AutoGenerateColumns .     
IsReadOnly . ��5{   A   �� *	Coleccion+   Columns 5}      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn    Header$	  RUT��6%   !   
Foreground
! �  ��"   
FontWeight$
" Bold"�6C   #   Width5  /System.Windows.Controls.DataGridLengthConverter$# 70 6m   1  +System.Windows.Controls.DataGridBoundColumn$   Binding$ 6U   �� *Rut+6m     5�      $  RAZÓN SOCIAL��6%   $# 95 6[   $ 6;   �� *RazonSocial+6[     5�      $  CONTACTO��6%   $	# 120 6Z   $ 67   �� *NombreContacto+6Z     5�      $
  MAIL��6%   $	# 120 6T   $ 63   �� *MailContacto+6T     5�      $  
DIRECCIÓN��6%   $	# 120 6V   $ 68   �� *	Direccion+6V     5�      $
  FONO��6%   $# 88 6P   $ 63   �� *
Telefono+6P     5�      $  	ACTIVIDAD��6%   $# 88 6]   $ 68   �� *ActividadEmpresa+6]     5�      $
  TIPO��6%   $# 88 6S   $ 63   �� *TipoEmpresa+6S   5�      �� 5�   
   -   5        % ��Name$% 	btn_close��5�      $
��Left=�6%   $��	770,0,0,0q�6@   $	��Top=�6S   $��30��6k   $��30��6v   $��0q�6�   #��� 	 6�   ��5�      �� 5�      $C
 =/Presentacion;component/aplicacion/imagenes/close_default.png��6   $ Uniform=�6i   5�      �� 5�   
   -	   5        $% 
btn_buscar��5�      $��BUSCAR��6%   $
��Left=�66   $��
290,83,0,0q�6Q   $	��Top=�6e   $	��100��6}   $��30��6�   $��0q�6�   
����������	#FF9E0FBF#���  6�   $
��Bold"�6�   6  �� 5�   
   -
   5        $% btn_contratos��5�      $��VER CONTRATOS��6(   $
��Left=�6@   $��323,410,0,0q�6[   $	��Top=�6p   $	��140��6�   $��30��6�   $��0q�6�   
����������	#FF9E0FBF#���  6�   $
��Bold"�6  6    5�   
   -   5        $ dtg_contrato��5�      $
��Left=�6)   $	��245��6D   $��395,150,0,0q�6Q   $	��Top=�6f   $	��395��6~   
������  .   . ��5�   A   �� *	Coleccion+ 5�        5�      $  ID CONTRATO��6%   
! �  ��$
" Bold"�6K   $ 6]   �� *
IdContrato+  5�      $  RUT CLIENTE��6%   $ 6:   �� *	Cliente+  5�      $  TIPO EVENTO��6%   $ 6:   �� *
TipoEvento+  5�      $  CREADO��6%   $ 65   �� *FechaCreacion+  5�      $  FECHA INICIO��6%   $ 6;   �� *FechaHoraInicio+  5�      $  FECHA TÉRMINO��6%   $ 6<   �� *FechaHoraTermino+  5�      $  
UBICACIÓN��6%   $ 68   �� *	Direccion+  5�      $
  OBS.��6%   $ 63   �� *Observaciones+  5�      $  ESTADO��6%   $
" Bold"�65   $ 6G   �� *Estado+  5�      $  FECHA CIERRE��6%   $ 6;   �� *FechaTermino+5�      �� 5�   
   $��BUSCAR CLIENTE��6   $
��Left=�6)   $��	10,10,0,0q�6D   $	��Top=�6W   $��18(�6o   
�������$
��Bold"�6�   5�      5�      