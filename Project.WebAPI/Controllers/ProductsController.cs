using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Project.DataAccess.Repositories.Abstracts;
using Project.Entity;
using Project.WebAPI.Models;

namespace Project.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {

        private readonly IProductRepository _repository;

        public ProductsController(IProductRepository repository)
        {
            _repository = repository;
        }

        [HttpPost("addasync")]
        public async Task<IActionResult> AddAsync([FromBody]Product product)
        {
            var data = await _repository.AddAsync(product);

            return Created("", data);
        }
        [HttpPost("add")]
        public IActionResult Add([FromBody]Product product)
        {
            var data = _repository.Add(product);
            return Created("", data);
        }

        [HttpGet("getproductsasync")]
        public async Task<IActionResult> GetProductsAsync([FromQuery]PageRequest pageRequest)
        {
            var data = await _repository.GetListAsync(size:pageRequest.PageSize,index:pageRequest.Page);
            return Ok(data);
        }

        [HttpGet("getproducts")]
        public IActionResult GetProducts([FromQuery] PageRequest pageRequest)
        {
            var data = _repository.GetList(index:pageRequest.Page, size:pageRequest.PageSize);
            return Ok(data);
        }
    }
}
