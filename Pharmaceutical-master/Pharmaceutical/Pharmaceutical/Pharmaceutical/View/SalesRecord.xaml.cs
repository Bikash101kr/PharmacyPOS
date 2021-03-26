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
	public partial class SalesRecord : ContentPage
	{
        public SalesCRUD salesCRUD;
        public Model.Sales sales;

        //============================================= 
        // Reference A3: externally sourced algorithm 
        // Purpose: get  bindable list in list view
        // Date: 22 Sep 2018 
        // Source: Microsoft doc
        // Author: unknown 
        // url: https://docs.microsoft.com/en-us/xamarin/xamarin-forms/user-interface/listview/data-and-databinding
        // Adaptation required: chnaged variable name //

        public SalesRecord()
        {
			InitializeComponent ();
            salesCRUD = new SalesCRUD();
            sales = new Model.Sales();

            var saleslist = salesCRUD.GetSalesList();
            SaleslistView.ItemsSource = saleslist;
        }

        void OnSelection(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
            {
                return;
                //ItemSelected is called on deselection, 
                //which results in SelectedItem being set to null
            }
            var vSelSales = (Model.Sales)e.SelectedItem;
            Navigation.PushAsync(new ShowSales(vSelSales));
        }
        public void OnNewClicked(object sender, EventArgs args)
        {
            Navigation.PushAsync(new Sales());
        }

    }
}