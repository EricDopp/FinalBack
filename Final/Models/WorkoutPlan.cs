using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Final.Models;

public class WorkoutPlan
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int WorkoutPlanId { get; set; }
    [Required]
    public string UserId { get; set; }
    [MaxLength(50)]
    public string WorkoutPlanName { get; set; }
    [MaxLength(13)]
    public string WeekDay { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
}