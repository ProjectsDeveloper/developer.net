using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ualmeida.virtualshop.domain.repository;

namespace ualmeida.virtualshop.web.Controllers
{
    public class ProductController : Controller
    {
        private RepositoryProduct _repository;
        //
        // GET: /Product/
        public ActionResult Index()
        {
            _repository = new RepositoryProduct();
            var products = _repository.Products.Take(3);
            
            return View(products);

        }
	}
}