using Final.Models;

namespace Final.Services
{
    public interface IExerciseDBService
    {
        Task<List<ExerciseDB>> GetExerciseDBsByBodyPart(string bodyPart);
        Task<List<string>> GetBodyPartList();
        Task<List<string>> GetEquipmentList();
        Task<List<string>> GetTargetList();
        Task<List<ExerciseDB>> GetExercisesByEquipment(string equipment);
        Task<List<ExerciseDB>> GetExercisesByTarget(string target);
        Task<ExerciseDB> GetExerciseById(string id);
        Task<List<ExerciseDB>> GetExerciseByName(string name);
        Task<List<ExerciseDB>> GetAllExercises();
        
    }
}
