using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Core.InterFaces;
using Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController:ControllerBase
    {
       private readonly  IProductRepository _repo;
     //  private readonly  StoreContext _context;
        //public ProductsController(StoreContext context){
        public ProductsController(IProductRepository repo){
                // _context = context;
                _repo=repo;
        }
        [HttpGet]
        public async Task< ActionResult <List<Product>>> GetProducts(){
          //  return "this will be a list of products";
 
     // var products = await _context.Products.ToListAsync();
     var products = await  _repo.GetProductsAsync();
      return Ok(products);
        }


        // [HttpGet("{id}")]
        //  public string GetProduct(int id){
        //     return "Single Product";
        // }



   [HttpGet("{id}")]
         public   async Task<ActionResult<Product>> GetProduct(int id){
           // return "Single Product";
        //   var pro = await _context.Products.Where(x=>x.Id==id).FirstOrDefaultAsync();
        var pro = await _repo.GetProductIdAsync(id);
            return Ok(pro);

        }


        
   [HttpGet("brands")]
         public   async Task<ActionResult<List<ProductBrand>>> GetProductBrands(){
         
        var pro = await _repo.GetProductBrandsAsync();
            return Ok(pro);

        }
              
   [HttpGet("types")]
         public async Task<ActionResult<List<ProductType>>> GetProductTypes(){
         
        var pro = await _repo.GetProductTypesAsync();
            return Ok(pro);

        }

    }
}    