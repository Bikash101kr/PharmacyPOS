using Pharmaceutical.Data;
using Pharmaceutical.Model;
using SQLite.Net;
using System;
using System.Collections.Generic;
using System.IO;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Pharmaceutical.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Login : ContentPage
	{
        public string ShowUser { get; private set; } // To display which user is log into account 
        
        public Login ()
		{
			InitializeComponent ();
            
        }
        public UserCRUD userCRUD;
        public Users users;

        
        private async void btn_login(object sender, EventArgs e)
        {
            //============================================= 
            // Reference P3: personal assistance 
            // Purpose: Deal with proper user validation with username and password 
            // Date: 17 Sep 2018 
            // Source: fellow student Sandip Dhakal
            // Assistance: get username saved in database and validate via password for login
            //============================================= 

            try
            {
                 Users users = new Users();
                 UserCRUD userCRUD = new UserCRUD(); 

                 Users u = userCRUD.GetUsername(Username.Text);
                 if (u != null)
                 {
                     if (Password.Text == u.Password)
                     {
                         DisplayAlert("Alert", "login succesful", "OK");

                         if (u.Role == "Admin")
                         {
                            ShowUser = Username.Text;

                            //============================================= 
                            // Reference P4: personal assistance 
                            // Purpose: Deal with proper user role to navigate corresponding page
                            // Date: 17 Sep 2018 
                            // Source: fellow student Sandip Dhakal
                            // Assistance: to get Administrative View
                            //============================================= 
                            Application.Current.MainPage = new NavigationPage(new AdminView(this));
                         }
                        //============================================= 
                        // End reference p4
                        //============================================= 
                        else
                        {
                            ShowUser = Username.Text;
                            Application.Current.MainPage = new NavigationPage(new UserView(this));
                        }
                     }
                     else
                     {
                         await DisplayAlert("Alert", "login failed", "OK");
                     }
                 }
             }

             catch (Exception)
             {

                 throw;
             }
            //============================================= 
            // End reference p3
            //============================================= 
        }

    }
}