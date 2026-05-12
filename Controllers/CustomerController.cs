using Customer.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Customer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly AppDbContext _context;
        public CustomerController(AppDbContext _context)
        {
            this._context = _context;
        }

        [HttpGet]
        public IActionResult Get()
        {
            //CustomerDetailViewModel customer=new CustomerDetailViewModel(); 
            //customer.id = 1;
            //customer.name = "Test";

            var canConnect = _context.Customertbl.ToList();
            return Ok(canConnect);
        }
    }
}
