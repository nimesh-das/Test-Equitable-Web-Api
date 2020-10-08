using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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

          // PUT: api/product/n
          [HttpPut("{id}")]
          public IActionResult PutProduct(int id, [FromBody]Product product)
          {
               if (id != product.Id) 
               {
                    return BadRequest();
               }

               _context.Entry(product).State = EntityState.Modified;
               _context.SaveChanges();   
               
               return NoContent();
          }

          // DELETE: api/product/n
          [HttpDelete("{id}")]
          public IActionResult DeleteProduct(int id)
          {
               var product = _context.Products.Find(id);

               if (product == null) {
                    return NotFound();
               }

               _context.Products.Remove(product);
               _context.SaveChanges();

               return Ok(product);
          }


     }
}