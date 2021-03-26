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
	public partial class EditProduct : ContentPage
	{
        // 
        //
        //============================================= 
        // Reference C5: externally sourced code 
        // Purpose: get a program updated when update button is clicked
        // Date: 25 Sep 2018 
        // Source: Code Project  
        // Author: S Ravi Kumar (TechieRathore)
        // url:https://www.codeproject.com/Articles/1097179/SQLite-with-Xamarin-Forms-Step-by-Step-guide
        // Adaptation required: changed variable names, call object of product from model and data
        //============================================= 
        Products SelProduct;
        ProductCRUD productCRUD;
        public EditProduct (Products SelectedProduct)
		{
			InitializeComponent ();
            productCRUD = new ProductCRUD();
            SelProduct = SelectedProduct;
            BindingContext = SelProduct;
        }

        //update model
        public void updateclicked(object sender, EventArgs e)
        {
            try
            { 
                
                if (ent_productname.Text.ToString().Equals(""))
                {
                    DisplayAlert("Error", "Please Enter Product Name", "OK");
                }
                else
                {
                    string mfdate = dp_mfd.Date.ToString("yyyy/MM/dd");
                    string exdate = dp_expd.Date.ToString("yyyy/MM/dd");


                    SelProduct.batch_no = ent_batch.Text;
                    SelProduct.product_name = ent_productname.Text;
                    SelProduct.mfd_date = mfdate;
                    SelProduct.exp_date = exdate;
                    SelProduct.quantity = ent_quantity.Text;
                    SelProduct.rate = ent_rate.Text;
                    productCRUD.UpdateDetails(SelProduct);                     
                    DisplayAlert("Alert", "Updated Succesfully.", "OK");
                    Navigation.PushAsync(new Stocks());
                }

            }
            catch (Exception ex)
            {
                string error = ex.ToString();
                DisplayAlert("Sorry...", "Something went wrong. Try after sometime.", "OK");
                
            }
            //============================================= 
            // End reference C5 
            //============================================= 

        }

    }
}