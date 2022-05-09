using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProjetoAspNetCore.Services;

namespace ProjetoAspNetCore.Controllers
{
    public class SellersController : Controller
    {
        private readonly SellerServices _sellerServices;

        public SellersController(SellerServices sellerServices)
        {
            _sellerServices = sellerServices;
        }

        public IActionResult Index()
        {
            var list = _sellerServices.FindAll();
            return View(list);
        }
    }
}