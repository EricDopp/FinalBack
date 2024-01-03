using Final.Models;

namespace Final.Services;

public interface IWorkoutPlanService
{
    WorkoutPlan CreateWorkoutPlan(string userId, string workoutPlanName, string weekDay);
    List<WorkoutPlan> GetWorkoutPlansByUserId(string userId);
    WorkoutPlan UpdateWorkoutPlan(int workoutPlanId, string workoutPlanName, string weekDay);
    bool DeleteWorkoutPlan(int workoutPlanId);
}