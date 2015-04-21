using OnSaleProductsMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnSaleProductsMVC.Views.Products
{
    public class ProductIndexViewModel
    {
        public IList<Product> Products { get; set; }
    }
}