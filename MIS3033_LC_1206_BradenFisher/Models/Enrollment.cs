using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MIS3033_LC_1206_BradenFisher.Models;

[Index("CourseId", Name = "IX_Enrollments_CourseID")]
[Index("StudentId", Name = "IX_Enrollments_StudentID")]
public partial class Enrollment
{
    [Key]
    public int Id { get; set; }

    public double Grade { get; set; }

    [MaxLength(1)]
    public char LetterGrade { get; set; }

    public DateTime Created { get; set; }

    [Column("CourseID")]
    public string CourseId { get; set; } = null!;

    [Column("StudentID")]
    public string StudentId { get; set; } = null!;

    [ForeignKey("CourseId")]
    [InverseProperty("Enrollments")]
    public virtual Course Course { get; set; } = null!;

    [ForeignKey("StudentId")]
    [InverseProperty("Enrollments")]
    public virtual Student Student { get; set; } = null!;
}
