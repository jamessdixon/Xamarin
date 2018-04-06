# YLProgressBar library binding for Xamarin.iOS

<p align="center">
<a href="http://preview.ibb.co/fC0nb5/ylprogressbar_header.png"><img alt="YLProgressBar" src="http://preview.ibb.co/fC0nb5/ylprogressbar_header.png"/></a>
<a href="http://preview.ibb.co/c4dtik/YLProgress_Bar.gif"><img alt="YLProgressBar" src="http://preview.ibb.co/c4dtik/YLProgress_Bar.gif"/></a>
</p>

This repository contains Xamarin.iOS library binding project for YLProgressBar project created by Yannick Loriot.
Original project is available under this link:
[YLProgressBar](https://github.com/yannickl/YLProgressBar) 

## Download
Xamarin.iOS:  [![NuGet Badge](https://buildstats.info/nuget/YLProgressBarXamarin)](https://www.nuget.org/packages/YLProgressBarXamarin/)

## Usage with Xamarin.iOS

```c#
YLProgressBar myBar = new YLProgressBar();
myBar.Type = YLProgressBarType.Flat;
myBar.ProgressTintColor = UIColor.Blue;
myBar.Progress = 20;
myBar.HideStripes = false;
myBar.StripesOrientation = YLProgressBarStripesOrientation.Left;
myBar.Frame = new CoreGraphics.CGRect(0, View.Frame.Height / 2, View.Frame.Width, 30);
```
