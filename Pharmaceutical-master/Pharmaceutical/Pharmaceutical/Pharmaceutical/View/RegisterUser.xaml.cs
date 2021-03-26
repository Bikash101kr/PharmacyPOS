using Pharmaceutical.Data;
using Pharmaceutical.Model;
using SQLite.Net;
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
	public partial class RegisterUser : ContentPage
	{
        public UserCRUD userCRUD;
        public Users users;

        public RegisterUser ()
		{
			InitializeComponent ();
            userCRUD = new UserCRUD();
            users = new Users();
            
        }
        protected void Add_user(object sender, EventArgs e)
        {

            try
            {
                if (ent_firstname.Text == null || ent_lastname.Text == null || ent_username.Text == null || ent_psw.Text == null || ent_conpsw.Text == null) 
                {
                    DisplayAlert("Alert", "Please Fill All the Fields", "OK");
                }             
                else
                {
                    if (ent_psw.Text == ent_conpsw.Text)
                    {    

                        InsertData(ent_firstname.Text.ToString(), ent_lastname.Text.ToString(), ent_username.Text.ToString(), ent_psw.Text.ToString(), picker_role.SelectedItem.ToString());
                        DisplayAlert("Alert", "Saved Succesfully.", "OK");
                        Navigation.PushAsync(new Userlist());
                    }
                    else
                    {
                        DisplayAlert("Alert", "Please check whether the password and the re typed password is correct", "OK");
                    }
                }
            }
            catch (Exception ex)
            {
                string error = ex.ToString();
                DisplayAlert("Sorry...", "Something went wrong. Try after sometime.", "OK");
                Navigation.PushAsync(new Login());
            }
        }

        public void InsertData(string fname, string lname, string uname, string password, string role)
        {
            users.FirstName = fname;
            users.LastName = lname;
            users.Username = uname;
            users.Password = password;            
            users.Role = role;
            userCRUD.InsertDetails(users);

        }

        void CleanForm()
        {
            ent_firstname.Text = "";
            ent_lastname.Text = "";
            ent_username.Text = "";
            ent_psw.Text = "";
            picker_role.SelectedIndex = 0;
            DisplayAlert("Success", "It was added correctly", "Ok");
        }

        private void ViewButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Userlist());
        }
    }
} 