using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace nonixmart.Models
{
    public class ProductCategoryViewModel
    {
        public List<Product> Product { get; set; }
        public SelectList Category { get; set; }
        public string ProductCategory { get; set; }
        public string SearchString { get; set; }
    }
}