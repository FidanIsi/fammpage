using WebApplication1.Entities;

namespace WebApplication1.Data
{
    public class ProductDatas
    {
        public static List<Product> Products()
        {
            return new List<Product>()
            {
                new Product()
                {
                    ProductName= "Men's Shirt",
                    ProductImage="p1.png",
                    ProductPrice=75.00m
                },
                new Product()
                {
                    ProductName= "Men's Shirt",
                    ProductImage="p2.png",
                    ProductPrice=80.00m
                },
                new Product()
                {
                    ProductName= "Women's Dress",
                    ProductImage="p3.png",
                    ProductPrice=68.00m
                },
                new Product()
                {
                    ProductName= "Women's Dress",
                    ProductImage="p4.png",
                    ProductPrice=70.00m
                },
                new Product()
                {
                    ProductName= "Women's Dress",
                    ProductImage="p5.png",
                    ProductPrice=75.00m
                },
                new Product()
                {
                    ProductName= "Women's Dress",
                    ProductImage="p6.png",
                    ProductPrice=58.00m
                },
                new Product()
                {
                    ProductName= "Women's Dress",
                    ProductImage="p7.png",
                    ProductPrice=80.00m
                },
                new Product()
                {
                    ProductName= "Men's Shirt",
                    ProductImage="p8.png",
                    ProductPrice=65.00m
                },
                new Product()
                {
                    ProductName= "Men's Shirt",
                    ProductImage="p9.png",
                    ProductPrice=65.00m
                },
                new Product()
                {
                    ProductName= "Men's Shirt",
                    ProductImage="p10.png",
                    ProductPrice=65.00m
                },
                new Product()
                {
                    ProductName= "Men's Shirt",
                    ProductImage="p11.png",
                    ProductPrice=65.00m
                },
                new Product()
                {
                    ProductName= "Women's Dress",
                    ProductImage="p12.png",
                    ProductPrice=68.00m
                },
            };
        }
    }
}
