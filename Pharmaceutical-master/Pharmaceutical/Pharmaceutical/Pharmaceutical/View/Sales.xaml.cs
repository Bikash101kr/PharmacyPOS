
using Pharmaceutical.Data;
using Pharmaceutical.Model;
using SQLite.Net;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Pharmaceutical.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Sales : ContentPage , INotifyPropertyChanged
	{
        public SalesCRUD salesCRUD;
        public Products products;
        public Model.Sales sales;
        public ProductCRUD productCRUD;


        //============================================= 
        // Reference A3: externally sourced algorithm 
        // Purpose: get Product list in picker in sales tab
        // Date: 22 Sep 2018 
        // Source: Microsoft docs
        // Author: unknown 
        // url: https://docs.microsoft.com/en-us/xamarin/xamarin-forms/user-interface/picker/populating-itemssource
        // Adaptation required: changed variable name //

        public Sales()
        {
			InitializeComponent ();
           
            productCRUD = new ProductCRUD();
            products = new Products();
            sales = new Model.Sales();
            salesCRUD = new SalesCRUD();           
            var productlist = productCRUD.GetProductNameList();
            picker_product.ItemsSource = productlist;         

        }


        string selectedProduct;
        public string SelectedProduct
        {
            get
            {
                return selectedProduct;
            }
            set
            {
                if (selectedProduct != value)
                {
                    selectedProduct = value;

                    // trigger some action to take such as updating other labels or fields
                    OnPropertyChanged(nameof(SelectedProduct));
                    //ProductSelected = productlist[selectedProduct];
                }
            }
        }


        private void salerecord_clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SalesRecord());
        }
        private void salesave_clicked(object sender, EventArgs e)
        {
            try
            {


                if (ent_billno.Text.ToString().Equals(""))
                {
                    DisplayAlert("Error", "Please Provide Batch Number", "ok");
                }
                else if (picker_product.SelectedItem.ToString().Equals(""))
                {
                    DisplayAlert("Error", "Please Enter Product Name", "OK");
                }
                else
                {
                    string salesdate = dp_saledate.Date.ToString("yyyy/MM/dd");


                    sales.buyrs_name = ent_buyrs.Text;
                    sales.product_name = picker_product.SelectedItem.ToString();
                    sales.bill_no = int.Parse(ent_billno.Text);
                    sales.sales_date = salesdate;
                    sales.sales_quantity = int.Parse(ent_salequantity.Text);
                    sales.rate = int.Parse(ent_salerate.Text); ;
                    sales.total_amount = int.Parse(ent_saletotal.Text); 
                    sales.amount_paid = int.Parse(ent_saleamountpaid.Text); ;
                    sales.change = int.Parse(ent_salereturn.Text); ;
                    salesCRUD.InsertDetails(sales);

                    Navigation.PushAsync(new SalesRecord());
                    UpdateData();
                    DisplayAlert("Alert", "Saved Succesfully.", "OK");

                }

            }
            catch (Exception ex)
            {
                string error = ex.ToString();
                DisplayAlert("Sorry", "Error Occured! Unable to Save", "OK");
                
            }

        }
       
        public void UpdateData()
        {
            try
            {
                string productname = picker_product.SelectedItem.ToString();
                var quantities = productCRUD.GetProductQuantity(productname);

                int totalqty = int.Parse(quantities.ToString());
                int qty = int.Parse(ent_salequantity.ToString());

                int newquantity = totalqty - qty;

                products.quantity = newquantity.ToString();

                productCRUD.UpdateDetails(products);
            }
            catch(Exception ex)
            {
                string error = ex.ToString();
                DisplayAlert("Sorry", "Canot update Quantity", "OK");

            }

        }

        private void ent_saletotal_TextChanged(object sender, TextChangedEventArgs e)
        {
            int rate = int.Parse( ent_salerate.Text);
            int qty = int.Parse(ent_salequantity.Text);

            int total = rate * qty;

            ent_saletotal.Text = total.ToString();
                 
        }

        private void ent_salereturn_TextChanged(object sender, TextChangedEventArgs e)
        {
            int amountpaid = int.Parse(ent_saleamountpaid.Text);
            int total = int.Parse(ent_saletotal.Text);

            int salesreturn = amountpaid - total;

            ent_salereturn.Text = salesreturn.ToString();

        }

        private void ent_salerate_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                string productname = picker_product.SelectedItem.ToString();
                var rate = productCRUD.GetProductRate(productname);

                ent_salerate.Text = rate.ToString();
            }
            catch(Exception ex)
            {
                string error = ex.ToString();
                DisplayAlert("Sorry", "Canot get Rate", "OK");

            }
        }

        private void picker_product_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}