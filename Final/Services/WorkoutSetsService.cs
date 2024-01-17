using Final.Data;
using Final.Models;

namespace Final.Services
{
    public class WorkoutSetsService : IWorkoutSetsService
    {
        private readonly AppDbContext _dbContext;

        public WorkoutSetsService(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public WorkoutSets CreateWorkoutSets(string userId, int workoutPlanId, string exerciseName, string exerciseDBId, decimal weight, int reps, int workoutSets, string weightUnit, int sortOrder)
        {
            var workoutSet = new WorkoutSets
            {
                UserId = userId,
                WorkoutPlanId = workoutPlanId,
                ExerciseName = exerciseName,
                ExerciseDBId = exerciseDBId,
                RepCount = reps,
                Weight = weight,
                WorkoutSetCount = workoutSets,
                WeightUnit = weightUnit,
                SortOrder = sortOrder
            };

            _dbContext.WorkoutSets.Add(workoutSet);
            _dbContext.SaveChanges();

            return workoutSet;
        }

        public List<WorkoutSets> GetWorkoutSetsByPlanId(int workoutPlanId)
        {
            return _dbContext.WorkoutSets
                .Where(ws => ws.WorkoutPlanId == workoutPlanId)
                .OrderBy(ws => ws.SortOrder)
                .ToList();
        }

        public WorkoutSets GetWorkoutSetsById(int workoutSetId)
        {
            return _dbContext.WorkoutSets.Find(workoutSetId);
        }

        public WorkoutSets UpdateWorkoutSets(int workoutSetId, decimal weight, int reps, int workoutSets, int sortOrder)
        {
            var workoutSet = _dbContext.WorkoutSets.Find(workoutSetId);

            if (workoutSet != null)
            {
                workoutSet.Weight = weight;
                workoutSet.RepCount = reps;
                workoutSet.WorkoutSetCount = workoutSets;
                workoutSet.SortOrder = sortOrder;

                _dbContext.SaveChanges();
            }

            return workoutSet;
        }

        public bool DeleteWorkoutSets(int workoutSetId)
        {
            var workoutSet = _dbContext.WorkoutSets.Find(workoutSetId);

            if (workoutSet != null)
            {
                _dbContext.WorkoutSets.Remove(workoutSet);
                _dbContext.SaveChanges();
                return true;
            }

            return false;
        }
    }
}
