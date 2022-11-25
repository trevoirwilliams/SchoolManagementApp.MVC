using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace SchoolManagementApp.MVC.Data;

public class LecturerMetadata
{
    [Display(Name="First Name")]
    public string FirstName { get; set; } = null!;

    [Display(Name="Last Name")]
    public string LastName { get; set; } = null!;
}

[ModelMetadataType(typeof(LecturerMetadata))]
public partial class Lecturer{}