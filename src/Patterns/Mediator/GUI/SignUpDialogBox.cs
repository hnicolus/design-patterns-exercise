using Patterns.Mediator.UIFramework;

namespace Patterns.Mediator.GUI.UIFramework
{
    public class SignUpDialogBox
    {
        private TextBox txtUsername = new TextBox();
        private TextBox txtPassword = new TextBox();
        private CheckBox checkAgreeToTerms = new CheckBox();
        private Button btnSignUp = new Button();

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