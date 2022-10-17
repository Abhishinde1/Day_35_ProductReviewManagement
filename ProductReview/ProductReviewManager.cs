using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductReview
{
    public class ProductReviewManager
    {
        
        public static List<ProductRevieww> AddProductReviewToList()
        {
            List<ProductRevieww> products = new List<ProductRevieww>();
            try
            {
                //Adding 25 entries to list
                products.Add(new ProductRevieww() { ProductId = 1, UserId = 1, Review = "Bad", Rating = 1, IsLike = true });
                products.Add(new ProductRevieww() { ProductId = 2, UserId = 2, Review = "Average", Rating = 3, IsLike = true });
                products.Add(new ProductRevieww() { ProductId = 3, UserId = 3, Review = "Average", Rating = 3, IsLike = false });
                products.Add(new ProductRevieww() { ProductId = 4, UserId = 4, Review = "Good", Rating = 5, IsLike = true });
                products.Add(new ProductRevieww() { ProductId = 5, UserId = 5, Review = "Average", Rating = 2, IsLike = true });
                products.Add(new ProductRevieww() { ProductId = 6, UserId = 6, Review = "Bad", Rating = 1, IsLike = false });
                products.Add(new ProductRevieww() { ProductId = 7, UserId = 7, Review = "Very Good", Rating = 3, IsLike = true });
                products.Add(new ProductRevieww() { ProductId = 8, UserId = 15, Review = "Average", Rating = 3, IsLike = true });
                products.Add(new ProductRevieww() { ProductId = 9, UserId = 9, Review = "Very Good", Rating = 5, IsLike = true });
                products.Add(new ProductRevieww() { ProductId = 10, UserId = 10, Review = "Very Good", Rating = 4.2, IsLike = true });
                products.Add(new ProductRevieww() { ProductId = 1, UserId = 7, Review = "Average", Rating = 2, IsLike = false });
                products.Add(new ProductRevieww() { ProductId = 3, UserId = 8, Review = "Good", Rating = 4, IsLike = true });
                products.Add(new ProductRevieww() { ProductId = 2, UserId = 8, Review = "Average", Rating = 2, IsLike = false });
                products.Add(new ProductRevieww() { ProductId = 4, UserId = 9, Review = "Average", Rating = 3, IsLike = false });
                products.Add(new ProductRevieww() { ProductId = 6, UserId = 10, Review = "Good", Rating = 4, IsLike = true });
                products.Add(new ProductRevieww() { ProductId = 8, UserId = 11, Review = "Average", Rating = 3.5, IsLike = false });
                products.Add(new ProductRevieww() { ProductId = 9, UserId = 12, Review = "Good", Rating = 4, IsLike = true });
                products.Add(new ProductRevieww() { ProductId = 5, UserId = 13, Review = "Average", Rating = 3, IsLike = false });
                products.Add(new ProductRevieww() { ProductId = 10, UserId = 14, Review = "Average", Rating = 3, IsLike = false });
                products.Add(new ProductRevieww() { ProductId = 2, UserId = 1, Review = "Very Good", Rating = 5, IsLike = true });
                products.Add(new ProductRevieww() { ProductId = 3, UserId = 2, Review = "Bad", Rating = 2, IsLike = false });
                products.Add(new ProductRevieww() { ProductId = 5, UserId = 3, Review = "Good", Rating = 4, IsLike = true });
                products.Add(new ProductRevieww() { ProductId = 7, UserId = 4, Review = "Good", Rating = 4, IsLike = true });
                products.Add(new ProductRevieww() { ProductId = 9, UserId = 5, Review = "Good", Rating = 4, IsLike = true });
                products.Add(new ProductRevieww() { ProductId = 11, UserId = 6, Review = "Average", Rating = 3, IsLike = false });

                Console.WriteLine("Added The Products Review To The List Successfully !!!!!!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return products;
        }

        //Method to iterate over the list
        public static void IterateOverList(List<ProductRevieww> products)
        {
            try
            {
                if (products != null)
                {
                    foreach (ProductRevieww product in products)
                    {
                        Console.WriteLine(product);
                    }
                }
                else
                    Console.WriteLine("No Products Review Added In The List.....");
            }
            catch (Exception )
            {
                //Console.WriteLine(ex.Message);
                throw ;
            }
            
        }
    }
}
