using Microsoft.AspNetCore.Mvc;
using On_Demand_Car_Wash.IRepository;
using On_Demand_Car_Wash.Model;
namespace On_Demand_Car_Wash.Controllers
{
    [ApiController]
    public class WasherController:Controller
    {
        IWasherRepository repository;

        public WasherController(IWasherRepository _repository)
        {
            repository = _repository;

        }

        // For Getting all the Washer Details

        [Route("Washer/GetAll")]
        [HttpGet]
        public async Task<ActionResult<List<Washer>>> GetAll()
        {

            try
            {
                var washerList = await repository.GetAllWasher();
                return Ok(washerList);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }

        //For Updating Washer details using id

        [Route("Washer/GetById/{id}")]
        [HttpGet]
        public async Task<ActionResult<Washer>> GetById(int id)
        {
            try
            {
                var washer = await repository.WasherById(id);
                return Ok(washer);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        //For Adding new Washer details

        [Route("Washer/Put/{id}")]
        [HttpPost]
        public async Task<ActionResult<Washer>> Put(int id, [FromBody] Washer obj)
        {
            try
            {
                var washer = await repository.UpdateWasher(id, obj);
                return Ok(washer);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        //For Adding new Washer details 

        [Route("Washer/Post")]
        [HttpPost]
        public async Task<ActionResult<Washer>> Post(Washer washer)
        {
            try
            {
                var cust = await repository.AddingNewWasher(washer);
                return Ok(cust);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }



        //For Deleting the Existing data Using id

        [Route("Washer/Delete/{id}")]
        [HttpGet]
        public async Task<ActionResult<bool>> Delete(int id)
        {
            try
            {
                var washer = await repository.DeleteWasher(id);
                if (washer)
                    return Ok(true);
                else
                    return Ok(false);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


    }
}
