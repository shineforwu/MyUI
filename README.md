# MyUI
## Wpf.UI.Control
	这是 WPF的UI的Control
### PathButton
#### 背景
	做项目时总是少不了Button，但是普通的Button大家都不喜欢用，总是想要自定义的Button，形状也是根据功能不同而变化的，并且窗口程序是会放大缩小的，如果用图片形式是会出现失真的，并且切换主题时没法变色，当然你可以用多个尺寸的图片，并且每个主题配一套图片，但是很麻烦。

#### 实现
	以设置按钮为例，当然这里的颜色可能和你需要的不一样，但是没关系是可以自定义的思路是写一个Usercontrol，继承自Button，然会应用一个样式，这里不直接用样式而是用Usercontrol是因为加了几个DependencyProperty，这样就可以自定义颜色了。
#### 注意点
	<Button> 里需要添加 Style="{DynamicResource PathButtonStyle}" 用以忘记。

