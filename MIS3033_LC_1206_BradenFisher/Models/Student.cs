using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MIS3033_LC_1206_BradenFisher.Models;

public partial class Student
{
    [Key]
    public string Id { get; set; } = null!;

    public string Name { get; set; } = null!;

    [Column("DOB")]
    public DateTime Dob { get; set; }

    [Column("favPlace")]
    public string FavPlace { get; set; } = null!;

    [Column("lon")]
    public double Lon { get; set; }

    [Column("lat")]
    public double Lat { get; set; }

    [InverseProperty("Student")]
    public virtual ICollection<Enrollment> Enrollments { get; set; } = new List<Enrollment>();

    [InverseProperty("Student")]
    public virtual ICollection<Profile> Profiles { get; set; } = new List<Profile>();
}
