using UIKit;

namespace MvvmCross.iOS.Views.Presenters
{
    public class MvxRootViewTransitionPresenter : MvxRootPresenter
    {
        private readonly double _duration;
        private readonly UIViewAnimationOptions _animationOptions;

        public MvxRootViewTransitionPresenter(double duration, UIViewAnimationOptions animationOptions)
        {
            _duration = duration;
            _animationOptions = animationOptions;
        }

        public override void SetWindowRootViewController(UIWindow window, UIViewController controller)
        {
            UIView.Transition(window, _duration, _animationOptions, () =>
            {
                var oldSate = UIView.AnimationsEnabled;
                UIView.AnimationsEnabled = false;

                base.SetWindowRootViewController(window, controller);

                UIView.AnimationsEnabled = oldSate;
            }, null);
        }
    }
}
