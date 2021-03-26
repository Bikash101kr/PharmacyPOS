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
	public partial class Product : ContentPage
	{
        public ProductCRUD productCRUD;
        public Products products;
        
       

        public Product ()
		{
			InitializeComponent ();
            productCRUD = new ProductCRUD();
            products = new Products();
            
            
            

        }

        

        protected void addclicked(object sender, EventArgs e)
        {
            try
            {
                //============================================= 
                // Reference P5: personal assistance 
                // Purpose: add product in database
                // Date: 17 Sep 2018 
                // Source: fellow student Sandip Dhakal
                // Assistance: insert proper data type to database
                //============================================= 


                if (ent_batch.Text.ToString().Equals(""))
                {
                    DisplayAlert("Error", "Please Provide Batch Number", "ok");
                }
                else if (ent_productname.Text.ToString().Equals(""))
                {
                    DisplayAlert("Error", "Please Enter Product Name", "OK");
                }
                else
                {
                    string mfdate = dp_mfd.Date.ToString("yyyy/MM/dd");
                    string exdate = dp_expd.Date.ToString("yyyy/MM/dd");
                    InsertData(ent_batch.Text.ToString(), ent_productname.Text.ToString(), mfdate, exdate, ent_quantity.Text.ToString(), ent_rate.Text.ToString());
                    DisplayAlert("Alert", "Saved Succesfully.", "OK");

                }
                //============================================= 
                // End reference C5 
                //============================================= 

            }
            catch (Exception ex)
            {
                string error = ex.ToString();
                DisplayAlert("Sorry...", "Unable to add Product", "OK");
                Navigation.PushAsync(new Stocks());
            }

        }
        public void InsertData(string batchno, string productname, string mfdate, string exp, string qty, string rate)
        {
            products.batch_no = batchno;
            products.product_name = productname;
            products.mfd_date = mfdate;
            products.exp_date = exp;
            products.quantity = qty;
            products.rate = rate;              
            productCRUD.InsertDetails(products);

        }

    }
}