using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MIS3033_LC_1206_BradenFisher.Models;

public partial class Course
{
    [Key]
    public string Id { get; set; } = null!;

    public string Name { get; set; } = null!;

    public int CreditHours { get; set; }

    public DateTime Created { get; set; }

    [InverseProperty("Course")]
    public virtual ICollection<Enrollment> Enrollments { get; set; } = new List<Enrollment>();
}
