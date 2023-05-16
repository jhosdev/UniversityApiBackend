using System.ComponentModel.DataAnnotations;

namespace UniversityApiBackend.Models.DataModels
{
    public class Course:BaseEntity
    {
        //generate name required
        [Required]
        public string Name { get; set; } = string.Empty;

        //generate description required 280 characters max
        [Required, StringLength(280)]
        public string Description { get; set; } = string.Empty;

        [Required]
        //long description
        public string LongDescription { get; set; } = string.Empty;

        [Required]
        //target audience
        public string TargetAudience { get; set; } = string.Empty;

        [Required]
        //objectives
        public string Objectives { get; set; } = string.Empty;

        [Required]
        //requirements
        public string Requirements { get; set; } = string.Empty;

        public enum CourseLevel
        {
            Beginner,
            Intermediate,
            Advanced
        }

        [Required]
        //enum level
        public CourseLevel Level { get; set; } = CourseLevel.Beginner;



    }

}
