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
    public partial class EditSales : ContentPage
    {
        Model.Sales SelSales;
        SalesCRUD salesCRUD;
        ProductCRUD productCRUD;

        public EditSales(Model.Sales Selectedsales)
        {
            InitializeComponent();
            salesCRUD = new SalesCRUD();
            productCRUD = new ProductCRUD();
            SelSales = Selectedsales;
            var productlist = productCRUD.GetProductNameList();
            picker_product.ItemsSource = productlist;
            BindingContext = SelSales;
        }
        public void saleupdate_clicked(object sender, EventArgs e)
        {
            try
            {
                string salesdate = dp_saledate.Date.ToString("yyyy/MM/dd");

                SelSales.bill_no = int.Parse(ent_billno.Text);
                SelSales.buyrs_name = ent_buyrs.Text;
                SelSales.product_name = picker_product.SelectedItem.ToString();                
                SelSales.sales_date = salesdate;
                SelSales.sales_quantity = int.Parse(ent_salequantity.Text);
                SelSales.rate = int.Parse(ent_salerate.Text);
                SelSales.total_amount = int.Parse(ent_saletotal.Text);
                SelSales.amount_paid = int.Parse(ent_saleamountpaid.Text);
                SelSales.change = int.Parse(ent_salereturn.Text);
                salesCRUD.InsertDetails(SelSales); 
            }
            catch (Exception ex)
            {
                string error = ex.ToString();
                DisplayAlert("Sorry...", "Something went wrong. Try after sometime.", "OK");

            }

        }
        private void ent_saletotal_TextChanged(object sender, TextChangedEventArgs e)
        {
            int rate = int.Parse(ent_salerate.Text);
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
    }
}