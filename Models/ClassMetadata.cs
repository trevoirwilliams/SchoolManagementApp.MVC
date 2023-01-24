using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace SchoolManagementApp.MVC.Data;

public class ClassMetadata
{
    [Display(Name="Lecturer")]
    public int LecturerId { get; set; }

    [Display(Name="Course")]
    public int CourseId { get; set; }
}

[ModelMetadataType(typeof(ClassMetadata))]
public partial class Class{}