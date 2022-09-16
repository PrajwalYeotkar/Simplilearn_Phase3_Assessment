using LaptopsOnline.Models;
using LaptopsOnline.Services;
using LaptopsOnline.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using static System.Net.Mime.MediaTypeNames;

namespace LaptopsOnline.Controllers
{  
    public class HomeController : Controller
    {
        //List<Laptop> _laptop;
        IRepository<Laptop> _laptoprepo;
        IRepository<Carousel> _carouselrepo;
        IRepository<Order> _orderrepo; 
        public HomeController(IRepository<Laptop> laptop,IRepository<Carousel> carousel, IRepository<Order> order)
        {
            //_laptop = new List<Laptop>();   
            _laptoprepo = laptop;
            _carouselrepo = carousel;
            _orderrepo = order; 
        }

        //Index Page
        public IActionResult Index()
        {
            HomeIndexViewModel model = new HomeIndexViewModel()
            {
                Laptops = _laptoprepo.GetAll(),
                Carousels = _carouselrepo.GetAll(),
            };
            return View(model);
        }

        [HttpGet]
        public IActionResult AddLaptop()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddLaptop(Laptop laptop)
        {
            if (ModelState.IsValid) 
            {
                Laptop item = new Laptop()
                {
                    Id = _laptoprepo.GetAll().Max(m => m.Id) + 1,
                    ModelName = laptop.ModelName,
                    Price = laptop.Price,
                    Image = laptop.Image,
                    Brand = laptop.Brand,
                    RamSize = laptop.RamSize,
                    CPUModel = laptop.CPUModel,
                    ScreenSize = laptop.ScreenSize,
                    Description = laptop.Description,
                };
                _laptoprepo.Add(item);
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
            
        }

        //ContactUs page
        public IActionResult ContactUs()
        {
            return View();
        }
        
        //AboutUS Page
        public IActionResult AboutUs()
        {
            return View();
        }

        public IActionResult Details(int id)
        {
            Laptop laptop = _laptoprepo.Get(id);
            return View(laptop);
        }

        [HttpGet]
        public IActionResult Order(int? id)
        {
            if(id!=null && id>=0)
            {
                OrderViewModel model = new OrderViewModel()
                {
                    LaptopToOrder = _laptoprepo.Get((int)id),
                    OrderDetails = new Order()
                    {
                        LaptopId = (int)id
                    }
                };
                return View(model);
            }
            return View();
        }

        [HttpPost]
        public IActionResult Order(int? id, Order OrderDetails)
        {
            if (ModelState.IsValid)
            {
                if (_laptoprepo.GetAll().Count(x => x.Id == id) >= 1)
                {
                    OrderDetails.LaptopId = (int)id;
                    _orderrepo.Add(OrderDetails);
                    return RedirectToAction("Thankyou");
                }
                else
                {
                    return View();
                }
            }
            else
            {
                return View(new OrderViewModel()
                {
                    OrderDetails = OrderDetails,
                    LaptopToOrder = _laptoprepo.Get((int)id)
                });
            }
        }

        public IActionResult ThankYou()
        {
            return View();
        }

        public IActionResult OrderList()
        {
            
            return View(_orderrepo.GetAll());
        }
    }
}
