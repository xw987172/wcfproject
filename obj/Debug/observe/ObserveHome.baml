   M S B A M L   `   `   `  ����H  DSpiderWatcher, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:SpiderWatcherSpiderWatcher  5      '    !SpiderWatcher.observe.ObserveHome   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ,baseclr-namespace:SpiderWatcher     5        N� Title$  ObserveHome��5	       � 	Resources 5       
  style1 �� 
TargetType �� Property �� Value��%V   &	        �� 5   
   " ��6   .�5      ��  � ��$ Center=�6;   5      5      .��5      �  � RowDefinitions 5   
   �� 5      $	��90* �6   �� 5      $	��10* �6   .+�5   
   �� -   5         ��Name$ 
doInfoList��5      $��0��6'   #��[  64    �� View 5      �� 5      .P�5      �� -   5        c1��$��任务��5   1    �� Width$
 auto��6=   	 �� DisplayMemberBinding	 6J   �� 
 �� Path$

 Task��� 5      -   5        c2��$��上次执行时间��5   1   $
 auto��6A   	 6N   �� $
 LastTime��� 5      -   5        c3��$��频率��5   1   $
 auto��6=   	 6J   �� $

 Freq��� 5      -   5        c4��$��是否正常执行��5   1   $
 auto��6A   	 6N   �� $
 IfGood�5       � ContextMenu 5      �� 5      .@�5       m� $��删除��6    m� Icon 5!      �� 5"      $��../static/imgs/delete.png��6$   $��20��6G   $��20��6R   5$      m� 5%      -   5        $��添加��5%      6A   5&      5(      �� 5)   
   $��1��6   $��Center=�6!   爬虫任务执行情况表6I   5*      5+      