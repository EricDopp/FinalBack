using Final.Models;
using Final.Services;
using Microsoft.AspNetCore.Mvc;

namespace Final.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WorkoutSetsController : ControllerBase
    {
        private readonly IWorkoutSetsService _workoutSetsService;

        public WorkoutSetsController(IWorkoutSetsService workoutSetsService)
        {
            _workoutSetsService = workoutSetsService;
        }

        [HttpPost]
        public IActionResult CreateWorkoutSets([FromBody] WorkoutSets workoutSets)
        {
            try
            {
                var createdWorkoutSet = _workoutSetsService.CreateWorkoutSets(
                    workoutSets.UserId,
                    workoutSets.WorkoutPlanId,
                    workoutSets.ExerciseDBId,
                    workoutSets.Weight,
                    workoutSets.RepCount,
                    workoutSets.WorkoutSetCount,
                    workoutSets.WeightUnit,
                    workoutSets.SortOrder
                );

                return Ok(createdWorkoutSet);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Outer exception: {ex.Message}");

                if (ex.InnerException != null)
                {
                    Console.WriteLine($"Inner exception: {ex.InnerException.Message}");
                }
                throw;
            }
        }

        [HttpGet("plans/{workoutPlanId}")]
        public IActionResult GetWorkoutSetsByPlanId(int workoutPlanId)
        {
            try
            {
                var workoutSets = _workoutSetsService.GetWorkoutSetsByPlanId(workoutPlanId);
                if (workoutSets != null)
                    return Ok(workoutSets);
                else
                    return NotFound();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        [HttpGet("{workoutSetId}")]
        public IActionResult GetWorkoutSetsById(int workoutSetId)
        {
            try
            {
                var workoutSets = _workoutSetsService.GetWorkoutSetsById(workoutSetId);
                if (workoutSets != null)
                    return Ok(workoutSets);
                else
                    return NotFound();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("{workoutSetId}")]
        public IActionResult UpdateWorkoutSets(int workoutSetId, [FromBody] WorkoutSets workoutSets)
        {
            try
            {
                var updatedWorkoutSet = _workoutSetsService.UpdateWorkoutSets(
                    workoutSetId,
                    workoutSets.Weight,
                    workoutSets.RepCount,
                    workoutSets.WorkoutSetCount,
                    workoutSets.SortOrder
                );

                if (updatedWorkoutSet != null)
                    return Ok(updatedWorkoutSet);
                else
                    return NotFound();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("{workoutSetId}")]
        public IActionResult DeleteWorkoutSets(int workoutSetId)
        {
            try
            {
                var result = _workoutSetsService.DeleteWorkoutSets(workoutSetId);
                if (result)
                    return Ok();
                else
                    return NotFound();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}