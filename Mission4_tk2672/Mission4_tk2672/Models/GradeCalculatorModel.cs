using System;
using System.ComponentModel.DataAnnotations;
namespace Mission4_tk2672.Models
{
	public class GradeCalculatorModel
	{
        [Required]
        [Range (0, 100, ErrorMessage = "percent must be between 0 and 100")]
		public decimal Assignments { get; set; }

        [Required]
        [Range(0, 100, ErrorMessage = "percent must be between 0 and 100")]
        public decimal Quizzes { get; set; }

        [Required]
        [Range(0, 100, ErrorMessage = "percent must be between 0 and 100")]
        public decimal Projects { get; set; }

        [Required]
        [Range(0, 100, ErrorMessage = "percent must be between 0 and 100")]
        public decimal Intex { get; set; }

        [Required]
        [Range(0, 100, ErrorMessage = "percent must be between 0 and 100")]
        public decimal Exams { get; set; }

        [Required]
        [Range(0, 100, ErrorMessage = "percent must be between 0 and 100")]
        public decimal Extra { get; set; }
    }
}