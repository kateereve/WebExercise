using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProductManagementSytem
{
    public partial class Products : System.Web.UI.Page
    {
        List<Product> cart;
        protected void Page_Load(object sender, EventArgs e)
        {
            cart = new List<Product>();
            DataTable dt = new DataTable();
            dt.Columns.AddRange(new DataColumn[5] { new DataColumn("Product Name"), new DataColumn("Cost"), new DataColumn("Qty"), new DataColumn("Amount"), new DataColumn("Action") });
            ViewState["Products"] = dt;
            this.BindGrid();

        }


        protected void BindGrid()
        {
            gvProducts.DataSource = (DataTable)ViewState["Products"];
            gvProducts.DataBind();
        }

        protected void btnAddToCart_Click(object sender, EventArgs e)
        {

            var product = new Product()
            {
                productID = Convert.ToInt32(this.txtProdID.Text),
                productName = this.txtProdName.Text.ToString(),
                cost = Convert.ToDecimal(this.txtCost.Text),
                qty = Convert.ToInt32(this.txtQty.Text)
            };
            AddToCart(product);

            /*
            DataTable dt = new DataTable();
            DataRow dr = dt.NewRow();
            dr["Column1"] = product.productName;
            dt.Rows.Add(dr);

            gvProducts.DataSource = dt;
            gvProducts.DataBind();
            */
        }

        private void AddToCart(Product product)
        {

            DataTable dt = (DataTable)ViewState["Products"];
            dt.Rows.Add(product.productName, product.cost, product.qty);
            ViewState["Products"] = dt;

            this.BindGrid();
            cart.Add(product);

        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            Savecart();
        }
        private void Savecart()
        {
           
          

            foreach (Product product in cart)
            {


                if (ProductBLL.SaveProduct(product))
                {
                    //save successfully

                }
                else
                {

                }
            }
        }
    }

   

 
}
