using CoreAnimation;
using UIKit;

namespace MvvmCross.iOS.Views.Presenters
{
    public class MvxRootLayerAnimationPresenter : MvxRootPresenter
    {
        private readonly CAAnimation _animation;

        public MvxRootLayerAnimationPresenter(CAAnimation animation)
        {
            _animation = animation;
        }

        public MvxRootLayerAnimationPresenter(double duration, string type, string subtype)
        {
            _animation = new CATransition()
            {
                Duration = duration,
                Type = type,
                Subtype = subtype
            };
        }

        public override void SetWindowRootViewController(UIKit.UIWindow window, UIKit.UIViewController controller)
        {
            UIView.BeginAnimations("transition");
            window.Layer.AddAnimation(_animation, "transition");
            UIView.CommitAnimations();

            base.SetWindowRootViewController(window, controller);
        }
    }
}
