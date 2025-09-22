using db_ef_task.Data;
using db_ef_task.Models;

namespace db_ef_task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ApplicationDbContext context = new ApplicationDbContext();

            var category1 = new Category() { Name = "cat1" };
            var category2 = new Category() { Name = "cat2" };
            var category3 = new Category() { Name = "cat3" };
            var category4 = new Category() { Name = "cat4" };
            var category5 = new Category() { Name = "cat5" };
            context.Categories.Add(category1);
            context.Categories.Add(category2);
            context.Categories.Add(category3);
            context.Categories.Add(category4);
            context.Categories.Add(category5);

            var product1 = new Product()
            {
                Name = "product1",
                Price = 10,
                Description = "product 1 description",
                rate = null
            };
            var product2 = new Product()
            {
                Name = "product2",
                Price = 20,
                Description = "product 2 description",
                rate = 4
            };
            var product3 = new Product()
            {
                Name = "product3",
                Price = 100,
                Description = "product 3 description",
                rate = 2
            };
            var product4 = new Product()
            {
                Name = "product4",
                Price = 90,
                Description = "product 4 description",
                rate = null
            };
            context.Products.Add(product1);
            context.Products.Add(product2);
            context.Products.Add(product3);
            context.Products.Add(product4);


            context.SaveChanges();
        }
    }
}
