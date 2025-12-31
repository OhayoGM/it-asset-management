using System.ComponentModel.DataAnnotations;

namespace ITAssetManagement.Models
{
  public class Employee
  {
    public int EmployeeId { get; set; }

    [Required]
    public string FullName { get; set; }

    public string Department { get; set; }
    public string Email { get; set; }
  }
}
