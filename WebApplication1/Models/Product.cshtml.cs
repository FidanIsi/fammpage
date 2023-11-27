using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplication1.Data;
using WebApplication1.Entities;

namespace WebApplication1.Models
{
    public class ProductModel : PageModel
    {
        public List<Product> Products { get; set; }
        public void OnGet()
        {
            Products = ProductDatas.Products();
        }
    }
}
