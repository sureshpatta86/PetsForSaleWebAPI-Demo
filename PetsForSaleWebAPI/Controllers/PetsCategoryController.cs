using Microsoft.AspNetCore.Mvc;
using PetsForSaleWebAPI.Model;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PetsForSaleWebAPI.Controllers
{
    [ApiController]
    public class PetsCategoryController : ControllerBase
    {
        private readonly DbHelper _dbHelper;
        public PetsCategoryController(EFDataContext eFDataContext)
        {
            _dbHelper = new DbHelper(eFDataContext);
        }

        // GET: api/<ValuesController>
        [HttpGet]
        [Route("api/getpetscategory")]
        public IActionResult Get()
        {
            ResponseType rsType = ResponseType.Sucess;
            try
            {
                IEnumerable<PetsCategoryModel> data = _dbHelper.GetPetsCategory();
                if (!data?.Any() ?? false)
                {
                    rsType = ResponseType.NotFound;
                }
                return Ok(ResponseHandler.GetApiRespnse(rsType, data));
            }
            catch (Exception ex)
            {
                return BadRequest(ResponseHandler.GetExceptionResponse(ex));
            }
        }        
    }
}
