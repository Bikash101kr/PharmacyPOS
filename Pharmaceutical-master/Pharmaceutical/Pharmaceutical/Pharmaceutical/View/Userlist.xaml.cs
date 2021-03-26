using Pharmaceutical.Data;
using Pharmaceutical.Model;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Pharmaceutical.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Userlist : ContentPage
    {
        public UserCRUD userCRUD;
        public Users users;

        public Userlist()
        {
            InitializeComponent();

            userCRUD = new UserCRUD();
            users = new Users();  
            

            var userlist = userCRUD.GetUserList();
            listUsers.ItemsSource = userlist;
            // BindingContext = this; 
        }
        void OnSelection(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
            {
                return;
                //ItemSelected is called on deselection, 
                //which results in SelectedItem being set to null
            }
            var vSelUser = (Users)e.SelectedItem;
            Navigation.PushAsync(new ShowUser(vSelUser));
        }
        public void OnNewClicked(object sender, EventArgs args)
        {
            Navigation.PushAsync(new RegisterUser());
        }


    }
}
