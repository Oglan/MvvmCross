using System;
using CoreAnimation;
using UIKit;

namespace MvvmCross.iOS.Views.Presenters.Attributes
{
    [AttributeUsage(AttributeTargets.Class)]
    public class MvxAnimatedRootTransitionAttribute : Attribute
    {
        public const double DefaultDuration = 0.3;

        public MvxTransitionType ToTransition { get; set; }
        public double ToDuration { get; set; }

        public MvxTransitionType FromTransition { get; set; }
        public double FromDuration { get; set; }

        public MvxAnimatedRootTransitionAttribute()
        {
            FromTransition = MvxTransitionType.NotSpecified;
            FromDuration = DefaultDuration;

            ToTransition = MvxTransitionType.NotSpecified;
            ToDuration = DefaultDuration;
        }

        public MvxRootPresenter GetToPresenter()
        {
            return GetPresenter(ToTransition, ToDuration);
        }

        public MvxRootPresenter GetFromPresenter()
        {
            return GetPresenter(FromTransition, FromDuration);
        }

        private MvxRootPresenter GetPresenter(MvxTransitionType type, double duration)
        {
            switch (type)
            {
                case MvxTransitionType.None:
                    return new MvxRootPresenter();
                case MvxTransitionType.FlipFromLeft:
                    return new MvxRootViewTransitionPresenter(duration, UIViewAnimationOptions.TransitionFlipFromLeft);
                case MvxTransitionType.FlipFromRight:
                    return new MvxRootViewTransitionPresenter(duration, UIViewAnimationOptions.TransitionFlipFromRight);
                case MvxTransitionType.FlipFromTop:
                    return new MvxRootViewTransitionPresenter(duration, UIViewAnimationOptions.TransitionFlipFromTop);
                case MvxTransitionType.FlipFromBottom:
                    return new MvxRootViewTransitionPresenter(duration, UIViewAnimationOptions.TransitionFlipFromBottom);
                case MvxTransitionType.CurlUp:
                    return new MvxRootViewTransitionPresenter(duration, UIViewAnimationOptions.TransitionCurlUp);
                case MvxTransitionType.CurlDown:
                    return new MvxRootViewTransitionPresenter(duration, UIViewAnimationOptions.TransitionCurlDown);
                case MvxTransitionType.CrossDissolve:
                    return new MvxRootViewTransitionPresenter(duration, UIViewAnimationOptions.TransitionCrossDissolve);
                case MvxTransitionType.Fade:
                    return new MvxRootLayerAnimationPresenter(duration, CAAnimation.TransitionFade, null);
                case MvxTransitionType.PushFromLeft:
                    return new MvxRootLayerAnimationPresenter(duration, CAAnimation.TransitionPush, CAAnimation.TransitionFromLeft);
                case MvxTransitionType.PushFromRight:
                    return new MvxRootLayerAnimationPresenter(duration, CAAnimation.TransitionPush, CAAnimation.TransitionFromRight);
                case MvxTransitionType.PushFromTop:
                    return new MvxRootLayerAnimationPresenter(duration, CAAnimation.TransitionPush, CAAnimation.TransitionFromTop);
                case MvxTransitionType.PushFromBottom:
                    return new MvxRootLayerAnimationPresenter(duration, CAAnimation.TransitionPush, CAAnimation.TransitionFromBottom);
                case MvxTransitionType.MoveInFromLeft:
                    return new MvxRootLayerAnimationPresenter(duration, CAAnimation.TransitionMoveIn, CAAnimation.TransitionFromLeft);
                case MvxTransitionType.MoveInFromRight:
                    return new MvxRootLayerAnimationPresenter(duration, CAAnimation.TransitionMoveIn, CAAnimation.TransitionFromRight);
                case MvxTransitionType.MoveInFromTop:
                    return new MvxRootLayerAnimationPresenter(duration, CAAnimation.TransitionMoveIn, CAAnimation.TransitionFromTop);
                case MvxTransitionType.MoveInFromBottom:
                    return new MvxRootLayerAnimationPresenter(duration, CAAnimation.TransitionMoveIn, CAAnimation.TransitionFromBottom);
                case MvxTransitionType.RevealFromLeft:
                    return new MvxRootLayerAnimationPresenter(duration, CAAnimation.TransitionReveal, CAAnimation.TransitionFromLeft);
                case MvxTransitionType.RevealFromRight:
                    return new MvxRootLayerAnimationPresenter(duration, CAAnimation.TransitionReveal, CAAnimation.TransitionFromRight);
                case MvxTransitionType.RevealFromTop:
                    return new MvxRootLayerAnimationPresenter(duration, CAAnimation.TransitionReveal, CAAnimation.TransitionFromTop);
                case MvxTransitionType.RevealFromBottom:
                    return new MvxRootLayerAnimationPresenter(duration, CAAnimation.TransitionReveal, CAAnimation.TransitionFromBottom);
                default:
                    return null;
            }
        }
    }
}
