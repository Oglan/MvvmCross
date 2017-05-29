using UIKit;

namespace MvvmCross.iOS.Views.Presenters
{
    public class MvxRootPresenter
    {
        public virtual void SetWindowRootViewController(UIWindow window, UIViewController controller)
        {
            foreach (var v in window.Subviews)
                v.RemoveFromSuperview();
            window.AddSubview(controller.View);
            window.RootViewController = controller;
        }
    }
}
