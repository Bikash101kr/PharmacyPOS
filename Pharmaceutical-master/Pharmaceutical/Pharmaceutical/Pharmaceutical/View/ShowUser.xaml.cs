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
	public partial class ShowUser : ContentPage
	{
        Users selusers;
        UserCRUD userCRUD;

        public ShowUser (Users selectedUsers)
		{
			InitializeComponent ();
            userCRUD = new UserCRUD();
            selusers = selectedUsers;
            BindingContext = selusers;
        }
        public void OnEditClicked(object sender, EventArgs args)
        {
            Navigation.PushAsync(new EditUser(selusers));
        }
        public async void OnDeleteClicked(object sender, EventArgs args)
        {
            try
            {
                bool accepted = await DisplayAlert("Confirm", "Are you Sure ?", "Yes", "No");
                if (accepted)
                {
                    userCRUD.Delete(selusers);
                }
                await DisplayAlert("Sucess", "Data is Deleted Successfully", "OK");
                await Navigation.PushAsync(new Userlist());
            }
            catch (Exception ex)
            {
                string error = ex.ToString();
                await DisplayAlert("Sorry...", "Something went wrong. Try after sometime.", "OK");

            }
        }
    }
}