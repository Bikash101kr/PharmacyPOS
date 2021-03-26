using Pharmaceutical.Data;
using Pharmaceutical.Model;
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
	public partial class EditUser : ContentPage
	{
        Users SelUser;
        UserCRUD userCRUD;

        public EditUser (Users SelectedUser)
		{
			InitializeComponent ();
            userCRUD = new UserCRUD();
            SelUser = SelectedUser;
            BindingContext = SelUser;
        }

        public void updateclicked(object sender, EventArgs e)
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
                        SelUser.FirstName = ent_firstname.Text;
                        SelUser.LastName = ent_lastname.Text;
                        SelUser.Username = ent_username.Text;
                        SelUser.Password = ent_psw.Text;
                        SelUser.Role = picker_role.SelectedItem.ToString();

                        userCRUD.UpdateDetails(SelUser);
                        DisplayAlert("Alert", "Updated Succesfully.", "OK");
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


    }
}