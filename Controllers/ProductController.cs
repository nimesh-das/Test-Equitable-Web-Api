using System;
using Microsoft.AspNetCore.Mvc;
using ProductAPI.Services;
using ProductAPI.Entities;
namespace ProductAPI.Controllers
{
     [Route("api/[controller]")]
     public class ProductController : Controller
     {
          private ProductDbContext _context;
          public ProductController(ProductDbContext context)
          {
               _context = context;
          }
          // GET: api/product
          [HttpGet]
          public IActionResult GetProduct()
          {
               return Ok(_context.Products);
          }

          // GET: api/product/{id}
          [HttpGet("{id}")]
          public IActionResult GetProduct(int id)
          {
               var productItem = _context.Products.Find(id);
               if (productItem == null) 
               {
                    return NotFound();
               }
               return Ok(productItem);
          }

          // POST: api/product
          [HttpPost]
          public IActionResult PostProduct([FromBody]Product product)
          {
               _context.Products.Add(product);
               Console.WriteLine(_context);
               _context.SaveChanges();
               return CreatedAtAction("GetProduct", new Product{Id = product.Id}, product);
          }

     }
}