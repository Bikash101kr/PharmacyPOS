using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Pharmaceutical.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class UserView : ContentPage
	{
        public string ShowUser { get; private set; }
        Login login;
        public UserView(Login log)
        {
            InitializeComponent();
            //To display status that which user get connected
            this.login = log;
            lbluser.Text = "Hello: " + this.login.ShowUser;
        }
        private void btn_product_add_Clicked(object sender, EventArgs e)
        {
            
            Navigation.PushAsync(new Product());
        }
        private void btn_sales_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Sales());
        }

        private void btn_sales_record_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SalesRecord());
        }

        private void btn_about_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new About());
        }
        private void btn_stock_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Stocks());
        }
        private async void btn_logout_Clicked(object sender, EventArgs e)
        {
            bool accepted = await DisplayAlert("Confirm", "Are you Sure To Logout ?", "Yes", "No");
            if (accepted)
            {
                App.Current.MainPage = new Login();
            }
        }

        
    }
}