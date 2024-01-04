using Final.Models;

namespace Final.Services
{
    public interface IExerciseDBService
    {
        Task<List<ExerciseDB>> GetExerciseDBsByBodyPart(string bodyPart);
        Task<List<ExerciseDB>> GetBodyPartList();
        Task<List<ExerciseDB>> GetEquipmentList();
        Task<List<ExerciseDB>> GetTargetList();
        Task<List<ExerciseDB>> GetExerciseByEquipment(string equipment);
        Task<List<ExerciseDB>> GetExercisesByTarget(string target);
        Task<List<ExerciseDB>> GetExercisesById(string id);
        Task<List<ExerciseDB>> GetExercisesByName(string name);
        Task<List<ExerciseDB>> GetAllExercises();
        
    }
}
