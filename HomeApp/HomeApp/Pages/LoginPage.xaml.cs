using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HomeApp.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public const string BUTTON_TEXT = "Войти";
        
        public static int loginCouner = 0;

        public LoginPage()
        {
            InitializeComponent();
        }
                
        private void Login_Click(object sender, EventArgs e)
        {
            if (loginCouner == 0)
            {                
                loginButton.Text = $"Выполняется вход..";
            }
            else if (loginCouner > 5) 
            {                
                loginButton.IsEnabled = false;
                var infoMessage = (Label)stackLayout.Children.Last();
                infoMessage.Text = "Слишком много попыток! Попробуйте позже";
            }
            else
            {                
                loginButton.Text = $"Выполняется вход...   Попыток входа: {loginCouner}";
            }
                        
            loginCouner += 1;
        }
    }
}