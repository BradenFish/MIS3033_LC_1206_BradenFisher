using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MIS3033_LC_1206_BradenFisher.Models;

[Index("StudentId", Name = "IX_Profiles_StudentId")]
public partial class Profile
{
    [Key]
    public string Id { get; set; } = null!;

    [Column("fcolor")]
    public string Fcolor { get; set; } = null!;

    [Column("address")]
    public string Address { get; set; } = null!;

    [Column("lon")]
    public double Lon { get; set; }

    [Column("lat")]
    public double Lat { get; set; }

    [Column("height")]
    public double Height { get; set; }

    [Column("weight")]
    public double Weight { get; set; }

    [Column("created")]
    public DateTime Created { get; set; }

    public string StudentId { get; set; } = null!;

    [ForeignKey("StudentId")]
    [InverseProperty("Profiles")]
    public virtual Student Student { get; set; } = null!;
}
