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
    public partial class ShowProduct : ContentPage
    {
        
        Products selproducts; 
        ProductCRUD productCRUD;

        public ShowProduct(Products selectedProducts)
        {
            InitializeComponent();
            productCRUD = new ProductCRUD();
            selproducts = selectedProducts;            
            BindingContext = selproducts;
        }

        public void OnEditClicked(object sender, EventArgs args)
        {
            Navigation.PushAsync(new EditProduct(selproducts));
        }
        public async void OnDeleteClicked(object sender, EventArgs args)
        {
            try
            {
                bool accepted = await DisplayAlert("Confirm", "Are you Sure ?", "Yes", "No");
                if (accepted)
                {
                    productCRUD.DeleteProduct(selproducts);
                }
                await DisplayAlert("Sucess", "Data is Deleted Successfully", "OK");
                await Navigation.PushAsync(new Stocks());
            }
            catch(Exception ex)
            {
                string error = ex.ToString();
                await DisplayAlert("Sorry...", "Something went wrong. Try after sometime.", "OK");
                
            }
        }
    }
}