using HomeTask.Models;
using HomeTask.Models.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace HomeTask.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            Product product1 = new Product
            {
                Id = 1,
                Name = "Delicious Pizza",
                Price = 999.99m,
                Description = "Veniam debitis quaerat officiis quasi cupiditate quo, quisquam velit, magnam voluptatem repellendus sed eaque",
                imageUrl = "https://upload.wikimedia.org/wikipedia/commons/9/91/Pizza-3007395.jpg"
            };
            Product product2=new Product
            {
                Id = 2,
                Name = "Tasty Burger",
                Price = 499.99m,
                Description = "Veniam debitis quaerat officiis quasi cupiditate quo, quisquam velit, magnam voluptatem repellendus sed eaque",
                imageUrl = "https://upload.wikimedia.org/wikipedia/commons/4/4d/Cheeseburger.jpg"
            };
            Product product3=new Product
            {
                Id = 3,
                Name = "Fresh Salad",
                Price = 299.99m,
                Description = "Veniam debitis quaerat officiis quasi cupiditate quo, quisquam velit, magnam voluptatem repellendus sed eaque",
                imageUrl = "https://upload.wikimedia.org/wikipedia/commons/4/4d/Cheeseburger.jpg"

            };
            Product product4=new Product
            {
                Id = 4,
                Name = "Spaghetti Bolognese",
                Price = 799.99m,
                Description = "Veniam debitis quaerat officiis quasi cupiditate quo, quisquam velit, magnam voluptatem repellendus sed eaque",
                imageUrl = "https://upload.wikimedia.org/wikipedia/commons/4/4d/Cheeseburger.jpg"

            };
            Product product5=new Product
            {
                Id = 5,
                Name = "Grilled Chicken",
                Price = 899.99m,
                Description = "Veniam debitis quaerat officiis quasi cupiditate quo, quisquam velit, magnam voluptatem repellendus sed eaque",
                imageUrl = "https://upload.wikimedia.org/wikipedia/commons/4/4d/Cheeseburger.jpg"



            };
            Product product6=new Product
            {
                Id = 6,
                Name = "Chocolate Cake",
                Price = 399.99m,
                Description = "Veniam debitis quaerat officiis quasi cupiditate quo, quisquam velit, magnam voluptatem repellendus sed eaque",
                imageUrl = "https://upload.wikimedia.org/wikipedia/commons/4/4d/Cheeseburger.jpg"

            };
            Product product7=new Product
            {
                Id = 7,
                Name = "Sushi Platter",
                Price = 1299.99m,
                Description = "Veniam debitis quaerat officiis quasi cupiditate quo, quisquam velit, magnam voluptatem repellendus sed eaque",
                imageUrl = "https://upload.wikimedia.org/wikipedia/commons/4/4d/Cheeseburger.jpg"


            };
            Product product8=new Product
            {
                Id = 8,
                Name = "Ice Cream Sundae",
                Price = 199.99m,
                Description = "Veniam debitis quaerat officiis quasi cupiditate quo, quisquam velit, magnam voluptatem repellendus sed eaque",
                imageUrl = "https://upload.wikimedia.org/wikipedia/commons/4/4d/Cheeseburger.jpg"

            };
            Product product9=new Product
            {
                Id = 9,
                Name = "French Fries",
                Price = 149.99m,
                Description = "Veniam debitis quaerat officiis quasi cupiditate quo, quisquam velit, magnam voluptatem repellendus sed eaque",
                imageUrl = "https://upload.wikimedia.org/wikipedia/commons/4/4d/Cheeseburger.jpg"

            };
            List<Product> products = new List<Product>
            {
                product1,product2,product3,product4,product5,product6,product7,product8,product9
            };

            Slider slider1= new Slider
            {
                Name = "Welcome to Our Restaurant",
                Description = "Experience the best dining with us. Enjoy delicious meals and exceptional service.",
                ImageUrl = "https://hips.hearstapps.com/hmg-prod/images/big-mac-lead-66574ee4f0ee4.jpg"

            };
            Slider slider2= new Slider
            {
                Name = "Fresh Ingredients",
                Description = "We use only the freshest ingredients to create mouth-watering dishes that will satisfy your cravings.",
                ImageUrl = "https://www.thespruceeats.com/thmb/1Ykz6bX3Z4NyF7N3f4b6j6gQKpE=/1500x0/filters:no_upscale():max_bytes(150000):strip_icc()/fresh-vegetables-58b5f5f53df78c353c1a8f5e.jpg"
            };
            Slider slider3 = new Slider
            {
                Name = "Cozy Ambiance",
                Description = "Enjoy your meal in a warm and inviting atmosphere that feels like home.",
                ImageUrl = "https://media.istockphoto.com/id/1302121740/photo/cozy-restaurant-interior-with-modern-furniture.jpg?s=612x612&w=0&k=20&c=YJX1Z8uGmXo3nU7nY2X1K5e5vY4b5r"
            };
            HomeVM homeVM = new HomeVM
            {
                sliders = new List<Slider> { slider1, slider2, slider3 },
                products = products
            };
            return View(homeVM);
        }
    }
}
