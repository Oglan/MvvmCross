using MvvmCross.Core.ViewModels;

namespace MvvmCross.iOS.Support.XamarinSidebarSample.Core.ViewModels
{
    public class LoginViewModel : BaseViewModel
	{
        private IMvxCommand _loginCommand;

        public IMvxCommand LoginCommand
        {
            get
            {
                _loginCommand = _loginCommand ?? new MvxCommand(Login);
                return _loginCommand;
            }
        }

		private void Login()
		{
			ShowViewModel<CenterPanelViewModel>();
		}
    }
}
