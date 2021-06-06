using Patterns.Mediator.UIFramework;

namespace Patterns.Mediator.GUI.UIFramework
{
    public class SignUpDialogBox
    {
        private readonly TextBox txtUsername = new();
        private readonly TextBox txtPassword = new();
        private readonly CheckBox checkAgreeToTerms = new();
        private readonly Button btnSignUp = new();

        public SignUpDialogBox()
        {
            txtUsername.AddHandler(TryEnabledButton);
            txtPassword.AddHandler(TryEnabledButton);
            checkAgreeToTerms.AddHandler(TryEnabledButton);
            btnSignUp.Label = "Sign UP";
        }

        public void SimulateInteraction()
        {
            txtUsername.Text = "Nick";
            txtPassword.Text = "123qwe";
            checkAgreeToTerms.IsChecked = true;

            btnSignUp.Click();
        }

        private void TryEnabledButton()
        {
            var hasUsername = !string.IsNullOrEmpty(txtUsername.Text);
            var hasPassword = !string.IsNullOrEmpty(txtPassword.Text);
            var check = checkAgreeToTerms.IsChecked;

            btnSignUp.IsEnabled = (hasUsername && hasPassword && check);
        }
    }
}