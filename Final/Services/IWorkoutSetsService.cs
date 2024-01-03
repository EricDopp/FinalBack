using Final.Models;

namespace Final.Services;

public interface IWorkoutSetsService
{
    WorkoutSets CreateWorkoutSets(string userId, int workoutPlanId, string exerciseDBId, decimal weight, int reps, int workoutSets, string weightUnit, int sortOrder);
    List<WorkoutSets> GetWorkoutSetsByUserId(string userId);
    WorkoutSets UpdateWorkoutSets(int workoutSetId, decimal weight, int reps, int workoutSets, int sortOrder);
    bool DeleteWorkoutSets(int workoutSetId);
}