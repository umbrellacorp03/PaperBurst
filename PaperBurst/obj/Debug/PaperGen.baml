   M S B A M L   `   `   `  ����E  APaperBurst, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:PaperBurst
PaperBurst  5   	       PaperBurst.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:PaperBurst     5   	     � Title$  
PaperBurst��5   	   $��384.286��6   $��754.286��6-   ���	#FF262626
������� � 
ResizeMode$ NoResize=�6g    � Icon$ icon.ico��6}   .��5	      � -   5         �Name$ 
mainWindow��5	      ���	#FF262626.+�5
   
   �� $��Settings��6   $
��Left=�6%   $	��276��6@   $��	10,10,0,0q�6M   $	��Top=�6`   $	��729��6x   .��5      �� -   5         ��Name$ 
Passphrase��5      $
��Left=�6*   $��23��6E   $��
151,57,0,0q�6Q    �� TextWrapping$
 Wrap=�6e   $	��Top=�6y   $	��553��6�   ���	#FF262626 �� CharacterCasing$ Lower=�6�   5      �� 5   
   $��Number of words :��6   $
��Left=�6,   $��	30,40,0,0q�6G   $	��Top=�6Z   
�������6r   	� 5   
   -   5         	�Name$ RadioButton1��5      $��12 words��6,   $
��Left=�6?   $��
165,46,0,0q�6Z   $	��Top=�6n   
������� d� 	IsChecked$
 TrueY�6�   	� 5   
   -   5        $ RadioButton2��5      $��24 words��6,   $
��Left=�6?   $��
269,46,0,0q�6Z   $	��Top=�6n   
�������6�   �� 5   
   $��Passphrase :��6   $
��Left=�6'   $��	30,81,0,0q�6B   $	��Top=�6U   
�������6m   �� 5   
   -   5        $ PrivateKey1��5      $
��Left=�6'   $��23��6B   $��167,135,0,0q�6N   $
 Wrap=�6c   $	��Top=�6w   $	��553��6�   
����������	#FF262626	 �� 	MaxLength$	 1��6�   
 �� 
IsReadOnly
 .  �� 
AcceptsTab .  �� AutoWordSelection . $ Lower=�6  4  .System.Windows.Automation.AutomationProperties   HelpText$E ?This is the private key of your paper wallet. Do not share it !��6)  �� 5   
   $��Private Key :��6   $
��Left=�6(   $��
30,134,0,0q�6C   $	��Top=�6W   
�������6o   �� 5   
   $��Public Key :��6   $
��Left=�6'   $��
30,184,0,0q�6B   $	��Top=�6V   
�������6n   �� 5   
   -   5        $ 
PublicKey1��5      $
��Left=�6&   $��23��6A   $��167,188,0,0q�6M   $
 Wrap=�6b   $	��Top=�6v   $	��553��6�   
����������	#FF262626
 .  .  . $ Lower=�6  �� 5   
   $��Reed Solomon :��6   $
��Left=�6)   $��
30,240,0,0q�6D   $	��Top=�6X   
�������6p   �� 5   
   -   5        $ ReedSolomonAddress��5      $
��Left=�6.   $��23��6I   $��167,243,0,0q�6U   $
 Wrap=�6j   $	��Top=�6~   $	��553��6�   
����������	#FF262626
 .  .  . $ Upper=�6
  �� 5   
   -   5         ��Name$ generatePassphrase��5      $��Generate new passphrase��6-   $
��Left=�6O   $��203,305,0,0q�6j   $	��Top=�6   $	��157��6�   ���	#FF262626
�������$��33��6�   �� 5   
   -	   5        $ generatePaperWallet��5      $��Generate paper wallet !��6.   $
��Left=�6P   $��386,305,0,0q�6k   $	��Top=�6�   $	��157��6�   ���	#FF262626
�������$��33��6�   5      5      