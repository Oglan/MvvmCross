using Cirrious.FluentLayouts.Touch;
using Foundation;
using MvvmCross.Binding.BindingContext;
using MvvmCross.iOS.Support.XamarinSidebarSample.Core.ViewModels;
using MvvmCross.iOS.Views.Presenters;
using MvvmCross.iOS.Views.Presenters.Attributes;
using UIKit;

namespace MvvmCross.iOS.Support.XamarinSidebarSample.iOS.Views
{
    [Register("LoginView")]
    [MvxRootPresentation(WrapInNavigationController = false)]
    [MvxAnimatedRootTransition(ToTransition = MvxTransitionType.FlipFromLeft, FromTransition = MvxTransitionType.FlipFromRight)]
    public class LoginView : BaseViewController<LoginViewModel>
    {
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            var loginButton = new UIButton();
            loginButton.SetTitle("Login", UIControlState.Normal);

            var bindingSet = this.CreateBindingSet<LoginView, LoginViewModel>();
            bindingSet.Bind(loginButton).For("TouchDown").To(vm => vm.LoginCommand);
            bindingSet.Apply();

            Add(loginButton);
            View.SubviewsDoNotTranslateAutoresizingMaskIntoConstraints();
            View.AddConstraints(
                loginButton.WithSameCenterX(View),
                loginButton.WithSameCenterY(View)
            );
        }
    }
}
