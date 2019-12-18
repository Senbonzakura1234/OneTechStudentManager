using System.ComponentModel;

namespace OneTechStudentManager.Models
{
    public class Student
    {
        [DisplayName("Student Code")]
        public int StudentId { get; set; }
        [DisplayName("First Name")]
        public string FirstName { get; set; }
        [DisplayName("Last Name")]
        public string LastName { get; set; }
        [DisplayName("Phone")]
        public string PhoneNumber { get; set; }
        [DisplayName("Email")]
        public string Email { get; set; }
    }
}