using System;
using Microsoft.AspNetCore.Mvc;
using StoreFront.Models;

namespace StoreFront.Controllers
    {
    public class ProductController : Controller
        {
        private IProductRepository repository;
        public ProductController(IProductRepository repo)
            {
            repository = repo;
            }

        public ViewResult List() => View(repository.Products);

        }
    }
