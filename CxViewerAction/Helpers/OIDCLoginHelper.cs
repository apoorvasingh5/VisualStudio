using System;
using System.Threading;
using System.Windows.Forms;
using CxViewerAction.ValueObjects;
using CxViewerAction.Views;

namespace CxViewerAction.Helpers
{
    public class OIDCLoginHelper
    {
        
        private readonly BrowserForm browserForm = new BrowserForm();
        private readonly AutoResetEvent _oidcLoginEvent = new AutoResetEvent(false);
        public static bool errorWasShown = false;
        private OidcLoginResult _latestResult;

        public OIDCLoginHelper()
        {
           
            browserForm.NavigationCompleted += OidcLoginCtrlOnNavigationCompleted;
            browserForm.NavigationError += OidcLoginCtrlOnNavigationError;
            
			
		}

		public void resetLatestResult()
		{
			_latestResult = new OidcLoginResult(false, string.Empty, null);
		}

        private void OnUserClosedForm(object sender, EventArgs e)
        {
            _latestResult = new OidcLoginResult(false, "Exit", null);
            _oidcLoginEvent.Set();
        }

        private void OidcLoginCtrlOnNavigationError(object sender, string errorMessage)
        {
            errorWasShown = true;
            MessageBox.Show(errorMessage,"Error", MessageBoxButtons.OK);
            _latestResult = new OidcLoginResult(false, errorMessage, null);
            _oidcLoginEvent.Set();
        }

        private void OidcLoginCtrlOnNavigationCompleted(object sender, string code)
        {
            _latestResult = new OidcLoginResult(true, string.Empty, code);
            _oidcLoginEvent.Set();
  
        }

        private void ConectAndWait(string baseServerUri)
        {
            browserForm.Show();
            browserForm.Invoke(new MethodInvoker(() =>
            {
                browserForm.Show();
                browserForm.ConnectToIdentidyProvider(baseServerUri);
                Application.Run(browserForm);

            }));
            _oidcLoginEvent.WaitOne();
        }

        public OidcLoginResult ConnectToIdentidyProvider(string baseServerUri)
        {

            ConectAndWait(baseServerUri);
            browserForm.CloseForm();
            return _latestResult;
        }

		public void CloseLoginWindow()
		{
            browserForm.CloseForm();
		}
    }
}
