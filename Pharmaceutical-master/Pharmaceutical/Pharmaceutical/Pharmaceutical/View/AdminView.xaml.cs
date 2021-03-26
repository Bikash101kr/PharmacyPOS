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
	public partial class AdminView : ContentPage
	{
        public string User { get; private set; }
        Login login;
        

        public AdminView (Login log)
		{
			InitializeComponent ();
            //============================================= 
            // Reference C2: externally sourced code 
            // Purpose: to display status that which user get connected 
            // Date: 15 Sep 2018 
            // Source: lecturer
            // Author: Vinay Sonu            
            // Adaptation required: changed variable names 
            //============================================= 

            this.login = log;
            lbluser.Text = "Hello: " + this.login.ShowUser;
        }


        //============================================= 
        // Reference C3: externally sourced code 
        // Purpose: navigate to respective page when button is pressed
        // Date: 16 Sep 2018 
        // Source: Microsoft docs 
        // Author: unknown 
        // url: https://docs.microsoft.com/en-us/dotnet/api/xamarin.forms.button?view=xamarin-forms 
        // Adaptation required: added same event handling to all buttons
        //============================================= 

        //
        private void btn_product_add_Clicked(object sender, EventArgs e)
        {
            User = lbluser.Text;
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
        private void btn_user_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new RegisterUser());
        }
    }
}