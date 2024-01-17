using Final.Data;
using Final.Models;

namespace Final.Services;

public class WorkoutPlanService : IWorkoutPlanService
{
    private readonly AppDbContext _dbContext;

    public WorkoutPlanService(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public WorkoutPlan CreateWorkoutPlan(string userId, string workoutPlanName, string weekDay)
    {
        if (!IsValidWeekDay(weekDay))
        {
            throw new ArgumentException("Invalid WeekDay format");
        }

        var workoutPlan = new WorkoutPlan
        {
            UserId = userId,
            WorkoutPlanName = workoutPlanName,
            WeekDay = weekDay,
            CreatedAt = DateTime.Now,
            UpdatedAt = DateTime.Now
        };

        _dbContext.WorkoutPlans.Add(workoutPlan);
        _dbContext.SaveChanges();

        return workoutPlan;
    }

    public List<WorkoutPlan> GetWorkoutPlansByUserId(string userId)
    {
        return _dbContext.WorkoutPlans
            .Where(wp => wp.UserId == userId)
            .ToList();
    }

    public WorkoutPlan GetWorkoutPlanById(int workoutPlanId)
    {
        return _dbContext.WorkoutPlans.Find(workoutPlanId);
    }

    public WorkoutPlan UpdateWorkoutPlan(int workoutPlanId, string workoutPlanName, string weekDay)
    {
        //if (!IsValidWeekDay(weekDay))
        //{
        //    throw new ArgumentException("Invalid WeekDay format");
        //}

        var workoutPlan = _dbContext.WorkoutPlans.Find(workoutPlanId);

        if (workoutPlan != null)
        {
            workoutPlan.WorkoutPlanName = workoutPlanName;
            workoutPlan.WeekDay = weekDay;
            workoutPlan.UpdatedAt = DateTime.Now;

            _dbContext.SaveChanges();
        }

        return workoutPlan;
    }

    public bool DeleteWorkoutPlan(int workoutPlanId)
    {
        var workoutPlan = _dbContext.WorkoutPlans.Find(workoutPlanId);

        if (workoutPlan != null)
        {
            // Also deletes associated workout sets
            var associatedWorkoutSets = _dbContext.WorkoutSets
                .Where(ws => ws.WorkoutPlanId == workoutPlanId)
                .ToList();

            _dbContext.WorkoutSets.RemoveRange(associatedWorkoutSets);

            _dbContext.WorkoutPlans.Remove(workoutPlan);

            _dbContext.SaveChanges();
            return true;
        }

        return false;
    }

    //private bool IsValidWeekDay(string weekDay)
    //{
    //    // Expected format: "0,1,2,3,4,5,6"
    //    // 0 = Sunday, 6 = Saturday
    //    var parts = weekDay.Split(',');

    //    foreach (var part in parts)
    //    {
    //        if (!int.TryParse(part, out int day))
    //        {
    //            return false;
    //        }

    //        if (day < 0 || day > 6)
    //        {
    //            return false;
    //        }
    //    }

    //    return true;
    //}
}