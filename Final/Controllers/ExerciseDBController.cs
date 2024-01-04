using Final.Models;
using Final.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Final.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
   
    public class ExerciseDBController : ControllerBase
    {
        private readonly IExerciseDBService _exerciseDBService;
        
        public ExerciseDBController(IExerciseDBService exerciseDBService)
        {
            _exerciseDBService = exerciseDBService; 
        }

        [HttpGet("exerciseByBodyPart/{bodyPart}")]
        public async Task<IActionResult> GetExerciseDBsByBodyPart(string bodyPart)
        {
            try
            {
                var exerciseDBs = await _exerciseDBService.GetExerciseDBsByBodyPart(bodyPart);

                if (exerciseDBs != null)
                {
                    return Ok(exerciseDBs);
                }
                else
                {
                    return NotFound(); // or return an appropriate error response
                }
            }
            catch (Exception ex)
            {
                // Log the exception
                return StatusCode(500, $"{ex.Message}"); // or return an appropriate error response

            }
        }

        [HttpGet("exercises/bodyPartList")]
        public async Task<IActionResult> GetBodyPartList()
        {
            try
            {
                var exerciseDBs = await _exerciseDBService.GetBodyPartList();

                if (exerciseDBs != null)
                {
                    return Ok(exerciseDBs);
                }
                else
                {
                    return NotFound(); // or return an appropriate error response
                }
            }
            catch (Exception ex)
            {
                // Log the exception
                return StatusCode(500, $"{ex.Message}"); // or return an appropriate error response
            }
        }
        [HttpGet("exercises/equipmentList")]
        public async Task<IActionResult> GetEquipmentList()
        {
            try
            {
                var exerciseDBs = await _exerciseDBService.GetEquipmentList();

                if (exerciseDBs != null)
                {
                    return Ok(exerciseDBs);
                }
                else
                {
                    return NotFound(); // or return an appropriate error response
                }
            }
            catch (Exception ex)
            {
                // Log the exception
                return StatusCode(500, $"{ex.Message}"); // or return an appropriate error response
            }
        }

        [HttpGet("exercises/targetList")]
        public async Task<IActionResult> GetTargetList()
        {
            try
            {
                var exerciseDBs = await _exerciseDBService.GetTargetList();

                if (exerciseDBs != null)
                {
                    return Ok(exerciseDBs);
                }
                else
                {
                    return NotFound(); // or return an appropriate error response
                }
            }
            catch (Exception ex)
            {
                // Log the exception
                return StatusCode(500, $"{ex.Message}"); // or return an appropriate error response
            }
        }

            [HttpGet("exercises/equipment/{equipment}")]
        public async Task<IActionResult> GetExercisesByEquipment(string equipment)
        {
            try
            {
                var exerciseDBs = await _exerciseDBService.GetExercisesByEquipment(equipment);

                if (exerciseDBs != null)
                {
                    return Ok(exerciseDBs);
                }
                else
                {
                    return NotFound(); // or return an appropriate error response
                }
            }
            catch (Exception ex)
            {
                // Log the exception
                return StatusCode(500, $"{ex.Message}"); // or return an appropriate error response
            }
        }
        [HttpGet("exercises/target/{target}")]
        public async Task<IActionResult> GetExercisesByTarget(string target)
        {
            try
            {
                var exerciseDBs = await _exerciseDBService.GetExercisesByTarget(target);

                if (exerciseDBs != null)
                {
                    return Ok(exerciseDBs);
                }
                else
                {
                    return NotFound(); // or return an appropriate error response
                }
            }
            catch (Exception ex)
            {
                // Log the exception
                return StatusCode(500, $"{ex.Message}"); // or return an appropriate error response
            }
        }

        [HttpGet("exercises/exercise/{id}")]
        public async Task<IActionResult> GetExerciseById(string id)
        {
            try
            {
                var exerciseDBs = await _exerciseDBService.GetExerciseById(id);

                if (exerciseDBs != null)
                {
                    return Ok(exerciseDBs);
                }
                else
                {
                    return NotFound(); // or return an appropriate error response
                }
            }
            catch (Exception ex)
            {
                // Log the exception
                return StatusCode(500, $"{ex.Message}"); // or return an appropriate error response
            }
        }



        [HttpGet("exercises/name/{name}")]
        public async Task<IActionResult> GetExerciseByName(string name)
        {
            try
            {
                var exerciseDBs = await _exerciseDBService.GetExerciseByName(name);

                if (exerciseDBs != null)
                {
                    return Ok(exerciseDBs);
                }
                else
                {
                    return NotFound(); // or return an appropriate error response
                }
            }
            catch (Exception ex)
            {
                // Log the exception
                return StatusCode(500, $"{ex.Message}"); // or return an appropriate error response
            }
        }

        [HttpGet("exercises")]
        public async Task<IActionResult> GetAllExercises()
        {
            try
            {
                var exerciseDBs = await _exerciseDBService.GetAllExercises();

                if (exerciseDBs != null)
                {
                    return Ok(exerciseDBs);
                }
                else
                {
                    return NotFound(); // or return an appropriate error response
                }
            }
            catch (Exception ex)
            {
                // Log the exception
                return StatusCode(500, $"{ex.Message}"); // or return an appropriate error response
            }
        }
        

    }

}
