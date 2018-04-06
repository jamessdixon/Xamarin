using System;
using Foundation;
using ObjCRuntime;
using UIKit;

namespace YLProgressBarXamarin
{
	// @interface YLProgressBar : UIView
	[BaseType (typeof(UIView))]
	interface YLProgressBar
	{
		// @property (assign, atomic) CGFloat progress;
		[Export ("progress")]
		nfloat Progress { get; set; }

		// -(void)setProgress:(CGFloat)progress animated:(BOOL)animated;
		[Export ("setProgress:animated:")]
		void SetProgress (nfloat progress, bool animated);

		// @property (assign, nonatomic) YLProgressBarBehavior behavior;
		[Export ("behavior", ArgumentSemantic.Assign)]
		YLProgressBarBehavior Behavior { get; set; }

		// @property (assign, nonatomic) BOOL hideGloss;
		[Export ("hideGloss")]
		bool HideGloss { get; set; }

		// @property (assign, nonatomic) BOOL progressStretch;
		[Export ("progressStretch")]
		bool ProgressStretch { get; set; }

		// @property (assign, nonatomic) BOOL uniformTintColor;
		[Export ("uniformTintColor")]
		bool UniformTintColor { get; set; }

		// @property (nonatomic, strong) NSArray * _Nonnull progressTintColors;
		[Export ("progressTintColors", ArgumentSemantic.Strong)]
        	UIColor[] ProgressTintColors { get; set; }

		// @property (nonatomic, strong) UIColor * _Nonnull progressTintColor;
		[Export ("progressTintColor", ArgumentSemantic.Strong)]
		UIColor ProgressTintColor { get; set; }

		// @property (nonatomic, strong) UIColor * _Nonnull trackTintColor;
		[Export ("trackTintColor", ArgumentSemantic.Strong)]
		UIColor TrackTintColor { get; set; }

		// @property (assign, nonatomic) CGFloat progressBarInset;
		[Export ("progressBarInset")]
		nfloat ProgressBarInset { get; set; }

		// @property (assign, nonatomic) YLProgressBarType type;
		[Export ("type", ArgumentSemantic.Assign)]
		YLProgressBarType Type { get; set; }

		// @property (assign, nonatomic) CGFloat cornerRadius;
		[Export ("cornerRadius")]
		nfloat CornerRadius { get; set; }

		// @property (nonatomic, strong) UILabel * _Nonnull indicatorTextLabel;
		[Export ("indicatorTextLabel", ArgumentSemantic.Strong)]
		UILabel IndicatorTextLabel { get; set; }

		// @property (assign, nonatomic) YLProgressBarIndicatorTextDisplayMode indicatorTextDisplayMode;
		[Export ("indicatorTextDisplayMode", ArgumentSemantic.Assign)]
		YLProgressBarIndicatorTextDisplayMode IndicatorTextDisplayMode { get; set; }

		// @property (getter = isStripesAnimated, nonatomic) BOOL stripesAnimated;
		[Export ("stripesAnimated")]
		bool StripesAnimated { [Bind ("isStripesAnimated")] get; set; }

		// @property (assign, nonatomic) YLProgressBarStripesDirection stripesDirection;
		[Export ("stripesDirection", ArgumentSemantic.Assign)]
		YLProgressBarStripesDirection StripesDirection { get; set; }

		// @property (assign, nonatomic) double stripesAnimationVelocity;
		[Export ("stripesAnimationVelocity")]
		double StripesAnimationVelocity { get; set; }

		// @property (assign, nonatomic) YLProgressBarStripesOrientation stripesOrientation;
		[Export ("stripesOrientation", ArgumentSemantic.Assign)]
		YLProgressBarStripesOrientation StripesOrientation { get; set; }

		// @property (assign, nonatomic) NSInteger stripesWidth;
		[Export ("stripesWidth")]
		nint StripesWidth { get; set; }

		// @property (nonatomic, strong) UIColor * _Nonnull stripesColor;
		[Export ("stripesColor", ArgumentSemantic.Strong)]
		UIColor StripesColor { get; set; }

		// @property (assign, nonatomic) NSInteger stripesDelta;
		[Export ("stripesDelta")]
		nint StripesDelta { get; set; }

		// @property (assign, nonatomic) BOOL hideStripes;
		[Export ("hideStripes")]
		bool HideStripes { get; set; }

		// @property (assign, nonatomic) BOOL hideTrack;
		[Export ("hideTrack")]
		bool HideTrack { get; set; }
	}

	[Static]
	partial interface Constants
	{
		// extern double YLProgressBarVersionNumber;
		[Field ("YLProgressBarVersionNumber", "__Internal")]
		double YLProgressBarVersionNumber { get; }

		// extern const unsigned char [] YLProgressBarVersionString;
		[Field ("YLProgressBarVersionString", "__Internal")]
        NSString YLProgressBarVersionString { get; }
	}
}
