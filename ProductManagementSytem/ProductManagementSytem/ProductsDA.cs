using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ProductManagementSytem
{
    public class ProductsDA
    {
        public static bool SaveProduct(Product product)
        {
            using (DAL da = new DAL())
            {
                if (!da.IsConnected)
                {
                    return false;
                }
                else
                {
                    SqlParameter[] param =
                   {
                        new SqlParameter  ("@productID", product.productID),
                        new SqlParameter  ("@productName", product.productName),
                        new SqlParameter  ("@cost", product.cost)
                    };

                    return da.ExecuteNonQuery("Products_Insert", param);
                }


            }


        }
    }
}