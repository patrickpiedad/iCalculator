﻿using System.ComponentModel.DataAnnotations;

namespace MediPal.Models
{
    public class Symptom
    {
        [Key]
        public int SymptomID { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "Symptom description cannot exceed 100 characters.")]
        public string? SymptomName { get; set; }

        [Required]
        public DateOnly Date { get; set; } = DateOnly.FromDateTime(DateTime.Now);
        //public DateTime Date { get; set; } = DateTime.Today;

        [Required]
        [Range(0, 10, ErrorMessage = "Pain level must be between 0 and 10.")]
        public int PainLevel { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "Activity description cannot exceed 100 characters.")]
        public string? Activity { get; set; }
    }
}
