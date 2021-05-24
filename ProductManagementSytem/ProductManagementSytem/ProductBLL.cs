using System;

namespace ProductManagementSytem
{
    internal class ProductBLL
    {
        internal static bool SaveProduct(Product product)
        {

           
            if (ProductsDA.SaveProduct(product))
            {
                return true;
            }
            else
            {
                return false;
            }
        }        //internal static bool SaveProduct(Product product)
        
     }
}