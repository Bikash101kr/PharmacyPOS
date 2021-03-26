using Pharmaceutical.Data;
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
	public partial class ShowSales : ContentPage
	{
        Model.Sales selsales;
        SalesCRUD salesCRUD;
        public ShowSales (Model.Sales selectedsales)
		{
			InitializeComponent ();
            salesCRUD = new SalesCRUD();
            selsales = selectedsales;
            BindingContext = selsales;
        }

        public void OnEditClicked(object sender, EventArgs args)
        {
            Navigation.PushAsync(new EditSales(selsales));
        }
        public async void OnDeleteClicked(object sender, EventArgs args)
        {
            try
            {
                bool accepted = await DisplayAlert("Confirm", "Are you Sure ?", "Yes", "No");
                if (accepted)
                {
                    salesCRUD.DeleteSales(selsales);
                }
                await DisplayAlert("Sucess", "Data is Deleted Successfully", "OK");
                await Navigation.PushAsync(new SalesRecord());
            }
            catch (Exception ex)
            {
                string error = ex.ToString();
                await DisplayAlert("Sorry...", "Something went wrong. Try after sometime.", "OK");

            }
        }

    }
}