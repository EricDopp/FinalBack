using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Final.Models;

public class WorkoutSets
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int WorkoutSetId { get; set; }
    [ForeignKey("WorkoutPlan")]
    public int WorkoutPlanId { get; set; }
    [Required]
    public string UserId { get; set; }
    [Required]
    public string ExerciseDBId { get; set; }
    public int RepCount { get; set; }
    [Column(TypeName = "decimal(5,2)")]
    public decimal Weight { get; set; }
    [MaxLength(10)]
    public string WeightUnit { get; set; }
    public int WorkoutSetCount { get; set; }
    public int SortOrder { get; set; }
}