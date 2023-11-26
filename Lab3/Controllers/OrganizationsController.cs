using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Labolatorium_3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrganizationsController : ControllerBase
    {
        private readonly AppDbContext _appDbContext;
        public IActionResult GetFilterOrganization(string q)
        {
            var result = _appDbContext.Organizations
                .Where(o => o.Name.StartsWith(q))
                .Select(o => new {Id = o.Id, Name = o.Name})
                .ToList();

            return Ok(result);
        }

        public IActionResult GetOrganizationbyId(int id)
        {
            var entity = _appDbContext.Organization.Find(id);

            if(entity == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(entity);
            }
        }
    }
}
