namespace SchoolManagementApp.MVC.Models;

public class StudentEnrollmentViewModel
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public bool IsEnrolled { get; set; }
}