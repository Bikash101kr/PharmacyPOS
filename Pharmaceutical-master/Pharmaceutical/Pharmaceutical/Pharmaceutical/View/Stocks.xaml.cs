using Pharmaceutical.Data;
using Pharmaceutical.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Pharmaceutical.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Stocks : ContentPage
    {

        public ProductCRUD productCRUD;
        public Products products;


        public Stocks()
        {
            InitializeComponent();

            productCRUD = new ProductCRUD();
            products = new Products();

            var productlist = productCRUD.GetProductList();
            ProductlistView.ItemsSource = productlist;  

        }

        void OnSelection(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
             {
                 return;
                 //ItemSelected is called on deselection, 
                 //which results in SelectedItem being set to null
             }
             var vSelProduct = (Products)e.SelectedItem;
             Navigation.PushAsync(new ShowProduct(vSelProduct));
        }
        public void OnNewClicked(object sender, EventArgs args)
        {
            Navigation.PushAsync(new Product());
        }

        
    }
}